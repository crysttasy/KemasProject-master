using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace KemasProject
{
    public partial class FormLogin : Form
    {
        // =========================================================
        // VARIABLE
        // =========================================================

        private bool isLoggingIn = false;
        private bool isPasswordVisible = false;

        // =========================================================
        // CONSTRUCTOR
        // =========================================================

        public FormLogin()
        {
            InitializeComponent();

            InitializeLoginForm();
        }

        // =========================================================
        // INITIALIZE FORM
        // =========================================================

        private void InitializeLoginForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;

            // Event
            this.Load += FormLogin_Load;
            this.FormClosing += FormLogin_FormClosing;

            btnLogin.Click += btnLogin_Click;
            btnShowPassword.Click += btnShowPassword_Click;

            txtUsername.KeyDown += txtUsername_KeyDown;
            txtPassword.KeyDown += txtPassword_KeyDown;

            chkRemember.CheckedChanged += chkRemember_CheckedChanged;
        }

        // =========================================================
        // FORM LOAD
        // =========================================================

        private void FormLogin_Load(object sender, EventArgs e)
        {
            LoadRememberedUsername();

            txtPassword.UseSystemPasswordChar = true;
            isPasswordVisible = false;

            btnShowPassword.Text = "●";

            txtUsername.Focus();

            TestDatabaseConnection();
        }

        // =========================================================
        // TEST DATABASE
        // =========================================================

        private void TestDatabaseConnection()
        {
            try
            {
                // Menggunakan koneksi dari class conn
                if (conn.connec.State != ConnectionState.Open)
                {
                    conn.connec.Open();
                }

                MessageBox.Show(
                    "Koneksi database berhasil.",
                    "Koneksi Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Koneksi database gagal.\n\n" +
                    "Pastikan MySQL/XAMPP sedang berjalan.\n\n" +
                    "Database: db_kemas\n\n" +
                    "Detail:\n" +
                    ex.Message,
                    "Koneksi Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Terjadi kesalahan saat mengecek database.\n\n" +
                    ex.Message,
                    "Koneksi Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                if (conn.connec.State == ConnectionState.Open)
                {
                    conn.connec.Close();
                }
            }
        }

        // =========================================================
        // ENTER USERNAME
        // =========================================================

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                txtPassword.Focus();
            }
        }

        // =========================================================
        // ENTER PASSWORD
        // =========================================================

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                PerformLogin();
            }
        }

        // =========================================================
        // LOGIN BUTTON
        // =========================================================

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PerformLogin();
        }

        // =========================================================
        // PROSES LOGIN
        // =========================================================

        private void PerformLogin()
        {
            if (isLoggingIn)
            {
                return;
            }

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // =====================================================
            // VALIDASI INPUT
            // =====================================================

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show(
                    "Username wajib diisi.",
                    "Validasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtUsername.Focus();

                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Password wajib diisi.",
                    "Validasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtPassword.Focus();

                return;
            }

            // =====================================================
            // SET LOGIN STATE
            // =====================================================

            isLoggingIn = true;

            btnLogin.Enabled = false;
            btnLogin.Text = "MEMPROSES...";

            try
            {
                // =================================================
                // GUNAKAN KONEKSI DARI CLASS conn
                // =================================================

                if (conn.connec.State != ConnectionState.Open)
                {
                    conn.connec.Open();
                }

                // =================================================
                // QUERY USER
                // =================================================

                string query = @"
                    SELECT
                        id,
                        nama,
                        username,
                        password,
                        role,
                        status
                    FROM users
                    WHERE username = @username
                    LIMIT 1
                ";

                using (MySqlCommand command =
                    new MySqlCommand(query, conn.connec))
                {
                    command.Parameters.AddWithValue(
                        "@username",
                        username
                    );

                    using (MySqlDataReader reader =
                        command.ExecuteReader())
                    {
                        // =========================================
                        // USER TIDAK DITEMUKAN
                        // =========================================

                        if (!reader.Read())
                        {
                            ShowLoginFailed(
                                "Username atau password salah."
                            );

                            return;
                        }

                        // =========================================
                        // AMBIL DATA USER
                        // =========================================

                        int userId =
                            Convert.ToInt32(reader["id"]);

                        string nama =
                            reader["nama"].ToString();

                        string dbUsername =
                            reader["username"].ToString();

                        string dbPasswordHash =
                            reader["password"].ToString();

                        string role =
                            reader["role"].ToString();

                        string status =
                            reader["status"].ToString();

                        // =========================================
                        // CEK PASSWORD
                        // =========================================

                        bool passwordValid =
                            VerifyPassword(
                                password,
                                dbPasswordHash
                            );

                        if (!passwordValid)
                        {
                            ShowLoginFailed(
                                "Username atau password salah."
                            );

                            return;
                        }

                        // =========================================
                        // CEK STATUS AKUN
                        // =========================================

                        if (!status.Equals(
                            "Aktif",
                            StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show(
                                "Akun Anda tidak aktif.\n" +
                                "Silakan hubungi administrator.",
                                "Login Ditolak",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );

                            return;
                        }

                        // =========================================
                        // CEK ROLE
                        // =========================================

                        if (!IsValidRole(role))
                        {
                            MessageBox.Show(
                                "Role akun tidak dikenali.\n\n" +
                                "Role: " + role,
                                "Login Gagal",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );

                            return;
                        }

                        // =========================================
                        // SIMPAN SESSION
                        // =========================================

                        Session.StartSession(
                            userId,
                            nama,
                            dbUsername,
                            role,
                            status
                        );

                        // =========================================
                        // REMEMBER USERNAME
                        // =========================================

                        SaveRememberedUsername(
                            dbUsername
                        );

                        // =========================================
                        // READER AKAN OTOMATIS DITUTUP
                        // =========================================

                    }
                }

                // =================================================
                // TUTUP KONEKSI
                // =================================================

                if (conn.connec.State == ConnectionState.Open)
                {
                    conn.connec.Close();
                }

                // =================================================
                // BUKA DASHBOARD
                // =================================================

                OpenDashboardByRole();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Terjadi masalah pada database.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Terjadi kesalahan saat login.\n\n" +
                    ex.Message,
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                if (conn.connec.State == ConnectionState.Open)
                {
                    conn.connec.Close();
                }

                isLoggingIn = false;

                btnLogin.Enabled = true;
                btnLogin.Text = "MASUK";
            }
        }

        // =========================================================
        // HASH PASSWORD - SHA256
        // =========================================================

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes =
                    Encoding.UTF8.GetBytes(password);

                byte[] hash =
                    sha256.ComputeHash(bytes);

                StringBuilder result =
                    new StringBuilder();

                foreach (byte b in hash)
                {
                    result.Append(
                        b.ToString("x2")
                    );
                }

                return result.ToString();
            }
        }

        // =========================================================
        // VERIFY PASSWORD
        // =========================================================

        private bool VerifyPassword(
            string password,
            string hashFromDatabase)
        {
            string inputHash =
                HashPassword(password);

            return inputHash.Equals(
                hashFromDatabase,
                StringComparison.OrdinalIgnoreCase
            );
        }

        // =========================================================
        // VALIDASI ROLE
        // =========================================================

        private bool IsValidRole(string role)
        {
            return
                role.Equals(
                    "Admin",
                    StringComparison.OrdinalIgnoreCase
                )
                ||
                role.Equals(
                    "Guru Piket",
                    StringComparison.OrdinalIgnoreCase
                )
                ||
                role.Equals(
                    "Kepala Sekolah",
                    StringComparison.OrdinalIgnoreCase
                );
        }

        // =========================================================
        // BUKA DASHBOARD SESUAI ROLE
        // =========================================================

        private void OpenDashboardByRole()
        {
            Form dashboard = null;

            switch (Session.Role)
            {
                case "Admin":

                    dashboard =
                        new FormTransaksi();

                    break;

                case "Guru Piket":

                    dashboard =
                        new FormDashboardGuruPiket();

                    break;

                case "Kepala Sekolah":

                    dashboard =
                        new FormDashboardKepalaSekolah();

                    break;

                default:

                    MessageBox.Show(
                        "Role tidak memiliki dashboard.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    Session.ClearSession();

                    return;
            }

            // =====================================================
            // SEMBUNYIKAN LOGIN
            // =====================================================

            this.Hide();

            // =====================================================
            // TAMPILKAN DASHBOARD
            // =====================================================

            dashboard.ShowDialog();

            // =====================================================
            // SETELAH DASHBOARD DITUTUP
            // =====================================================

            dashboard.Dispose();

            // =====================================================
            // CLEAR SESSION
            // =====================================================

            Session.ClearSession();

            // =====================================================
            // BERSIHKAN PASSWORD
            // =====================================================

            txtPassword.Clear();

            // =====================================================
            // TAMPILKAN LOGIN KEMBALI
            // =====================================================

            this.Show();

            txtPassword.Focus();
        }

        // =========================================================
        // LOGIN GAGAL
        // =========================================================

        private void ShowLoginFailed(string message)
        {
            MessageBox.Show(
                message,
                "Login Gagal",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            txtPassword.Clear();

            txtPassword.Focus();
        }

        // =========================================================
        // SHOW / HIDE PASSWORD
        // =========================================================

        private void btnShowPassword_Click(
            object sender,
            EventArgs e)
        {
            isPasswordVisible =
                !isPasswordVisible;

            txtPassword.UseSystemPasswordChar =
                !isPasswordVisible;

            if (isPasswordVisible)
            {
                btnShowPassword.Text = "○";
            }
            else
            {
                btnShowPassword.Text = "●";
            }

            txtPassword.Focus();

            txtPassword.SelectionStart =
                txtPassword.Text.Length;
        }

        // =========================================================
        // REMEMBER USERNAME
        // =========================================================

        private void chkRemember_CheckedChanged(
            object sender,
            EventArgs e)
        {
            if (!chkRemember.Checked)
            {
                ClearRememberedUsername();
            }
        }

        // =========================================================
        // LOAD REMEMBERED USERNAME
        // =========================================================

        private void LoadRememberedUsername()
        {
            try
            {
                string rememberedUsername =
                    Properties.Settings.Default.RememberedUsername;

                if (!string.IsNullOrWhiteSpace(
                    rememberedUsername))
                {
                    txtUsername.Text =
                        rememberedUsername;

                    chkRemember.Checked = true;

                    txtPassword.Focus();
                }
            }
            catch
            {
            }
        }

        // =========================================================
        // SAVE REMEMBERED USERNAME
        // =========================================================

        private void SaveRememberedUsername(
            string username)
        {
            try
            {
                if (chkRemember.Checked)
                {
                    Properties.Settings.Default.RememberedUsername =
                        username;

                    Properties.Settings.Default.Save();
                }
                else
                {
                    ClearRememberedUsername();
                }
            }
            catch
            {
                // Tidak mengganggu proses login.
            }
        }

        // =========================================================
        // CLEAR REMEMBERED USERNAME
        // =========================================================

        private void ClearRememberedUsername()
        {
            try
            {
                Properties.Settings.Default.RememberedUsername =
                    string.Empty;

                Properties.Settings.Default.Save();
            }
            catch
            {
                // Tidak mengganggu proses login.
            }
        }

        // =========================================================
        // FORM CLOSING
        // =========================================================

        private void FormLogin_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            if (isLoggingIn)
            {
                e.Cancel = true;
                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Apakah Anda yakin ingin keluar dari aplikasi?",
                    "Konfirmasi Keluar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}