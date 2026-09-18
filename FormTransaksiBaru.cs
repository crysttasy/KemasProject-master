using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KemasProject
{
    public partial class FormTransaksiBaru : Form
    {
        private bool isSaving = false;

        public FormTransaksiBaru()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(760, 620);
            this.BackColor = Color.FromArgb(245, 247, 250);
            this.Font = new Font("Segoe UI", 9F);

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            ConfigureForm();
            ConfigureEvents();
        }

        private void ConfigureForm()
        {
            lblTitle.Text = "Tambah Transaksi";
            lblSubtitle.Text =
                "Buat surat izin masuk atau keluar siswa.";

            lblSiswa.Text = "Siswa";
            lblJenisIzin.Text = "Jenis Izin";
            lblWaktuIzin.Text = "Waktu Izin";
            lblPerkiraanKembali.Text = "Perkiraan Kembali";
            lblKeperluan.Text = "Keperluan";
            lblKeterangan.Text = "Keterangan";

            btnSimpan.Text = "Simpan";
            btnBatal.Text = "Batal";

            /*
             * Jenis izin
             */
            cmbJenisIzin.Items.Clear();

            cmbJenisIzin.Items.Add("Izin Masuk");
            cmbJenisIzin.Items.Add("Izin Keluar");

            cmbJenisIzin.SelectedIndex = 0;

            /*
             * Waktu izin
             */
            dtpWaktuIzin.Format =
                DateTimePickerFormat.Custom;

            dtpWaktuIzin.CustomFormat =
                "dd/MM/yyyy HH:mm";

            dtpWaktuIzin.Value =
                DateTime.Now;

            /*
             * Perkiraan kembali
             */
            dtpPerkiraanKembali.Format =
                DateTimePickerFormat.Custom;

            dtpPerkiraanKembali.CustomFormat =
                "dd/MM/yyyy HH:mm";

            dtpPerkiraanKembali.Value =
                DateTime.Now.AddHours(1);

            /*
             * Text input
             */
            txtKeperluan.MaxLength = 255;

            txtKeterangan.Multiline = true;
            txtKeterangan.ScrollBars =
                ScrollBars.Vertical;

            /*
             * Combo siswa
             */
            cmbSiswa.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbJenisIzin.DropDownStyle =
                ComboBoxStyle.DropDownList;
        }

        private void ConfigureEvents()
        {
            this.Load +=
                FormTransaksiBaru_Load;

            btnSimpan.Click +=
                btnSimpan_Click;

            btnBatal.Click +=
                btnBatal_Click;

            cmbJenisIzin.SelectedIndexChanged +=
                cmbJenisIzin_SelectedIndexChanged;
        }

        private void FormTransaksiBaru_Load(
            object sender,
            EventArgs e)
        {
            LoadSiswa();
            UpdateReturnDateState();
        }

        /*
         * =========================================================
         * LOAD DATA SISWA
         * =========================================================
         */

        private void LoadSiswa()
        {
            try
            {
                OpenConnection();

                string query = @"
                    SELECT
                        id,
                        nama_siswa,
                        nis,
                        kelas
                    FROM siswa
                    ORDER BY
                        nama_siswa ASC
                ";

                using (MySqlCommand command =
                    new MySqlCommand(
                        query,
                        conn.connec))
                {
                    using (MySqlDataReader reader =
                        command.ExecuteReader())
                    {
                        DataTable table =
                            new DataTable();

                        table.Load(reader);

                        cmbSiswa.DataSource = null;

                        cmbSiswa.DataSource = table;

                        cmbSiswa.DisplayMember =
                            "nama_siswa";

                        cmbSiswa.ValueMember =
                            "id";

                        if (table.Rows.Count > 0)
                        {
                            cmbSiswa.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Gagal mengambil data siswa.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Terjadi kesalahan saat mengambil data siswa.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                CloseConnection();
            }
        }

        /*
         * =========================================================
         * JENIS IZIN
         * =========================================================
         */

        private void cmbJenisIzin_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            UpdateReturnDateState();
        }

        private void UpdateReturnDateState()
        {
            /*
             * Untuk Izin Keluar,
             * perkiraan kembali digunakan.
             *
             * Untuk Izin Masuk,
             * field tetap tersedia tetapi tidak wajib.
             */
            if (cmbJenisIzin.SelectedItem == null)
            {
                return;
            }

            string jenis =
                cmbJenisIzin.SelectedItem.ToString();

            if (jenis == "Izin Keluar")
            {
                dtpPerkiraanKembali.Enabled = true;
            }
            else
            {
                dtpPerkiraanKembali.Enabled = false;
            }
        }

        /*
         * =========================================================
         * VALIDASI
         * =========================================================
         */

        private bool ValidateInput()
        {
            if (cmbSiswa.SelectedValue == null)
            {
                MessageBox.Show(
                    "Silakan pilih siswa.",
                    "Validasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbSiswa.Focus();

                return false;
            }

            if (cmbJenisIzin.SelectedItem == null)
            {
                MessageBox.Show(
                    "Silakan pilih jenis izin.",
                    "Validasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbJenisIzin.Focus();

                return false;
            }

            if (string.IsNullOrWhiteSpace(
                txtKeperluan.Text))
            {
                MessageBox.Show(
                    "Keperluan wajib diisi.",
                    "Validasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtKeperluan.Focus();

                return false;
            }

            DateTime waktuIzin =
                dtpWaktuIzin.Value;

            if (waktuIzin > DateTime.Now.AddMinutes(5))
            {
                DialogResult result =
                    MessageBox.Show(
                        "Waktu izin lebih dari waktu sekarang.\n\n" +
                        "Apakah kamu tetap ingin melanjutkan?",
                        "Konfirmasi Waktu",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                if (result != DialogResult.Yes)
                {
                    dtpWaktuIzin.Focus();

                    return false;
                }
            }

            string jenis =
                cmbJenisIzin.SelectedItem.ToString();

            if (jenis == "Izin Keluar")
            {
                if (
                    dtpPerkiraanKembali.Value <=
                    dtpWaktuIzin.Value
                )
                {
                    MessageBox.Show(
                        "Perkiraan kembali harus lebih besar " +
                        "dari waktu izin.",
                        "Validasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    dtpPerkiraanKembali.Focus();

                    return false;
                }
            }

            return true;
        }

        /*
         * =========================================================
         * SIMPAN TRANSAKSI
         * =========================================================
         */

        private void btnSimpan_Click(
            object sender,
            EventArgs e)
        {
            if (isSaving)
            {
                return;
            }

            if (!ValidateInput())
            {
                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Apakah data transaksi sudah benar?\n\n" +
                    "Transaksi akan dibuat dengan status \"Menunggu\".",
                    "Konfirmasi Simpan",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (result != DialogResult.Yes)
            {
                return;
            }

            SaveTransaction();
        }

        private void SaveTransaction()
        {
            isSaving = true;

            MySqlTransaction transaction = null;

            try
            {
                OpenConnection();

                transaction =
                    conn.connec.BeginTransaction();

                /*
                 * =================================================
                 * 1. GENERATE NOMOR SURAT
                 * =================================================
                 */

                string nomorSurat =
                    GenerateNomorSurat(
                        transaction
                    );

                /*
                 * =================================================
                 * 2. AMBIL SISWA ID
                 * =================================================
                 */

                int siswaId =
                    Convert.ToInt32(
                        cmbSiswa.SelectedValue
                    );

                string jenisIzin =
                    cmbJenisIzin.SelectedItem.ToString();

                DateTime waktuIzin =
                    dtpWaktuIzin.Value;

                string keperluan =
                    txtKeperluan.Text.Trim();

                string keterangan =
                    txtKeterangan.Text.Trim();

                /*
                 * =================================================
                 * 3. PERKIRAAN KEMBALI
                 * =================================================
                 */

                object perkiraanKembali =
                    DBNull.Value;

                if (jenisIzin == "Izin Keluar")
                {
                    perkiraanKembali =
                        dtpPerkiraanKembali.Value;
                }

                /*
                 * =================================================
                 * 4. INSERT PERIZINAN
                 * =================================================
                 */

                string insertQuery = @"
                    INSERT INTO perizinan
                    (
                        nomor_surat,
                        siswa_id,
                        jenis_izin,
                        waktu_izin,
                        perkiraan_kembali,
                        keperluan,
                        keterangan,
                        status,
                        petugas_id,
                        waktu_proses,
                        alasan_penolakan,
                        created_at,
                        updated_at
                    )
                    VALUES
                    (
                        @nomor_surat,
                        @siswa_id,
                        @jenis_izin,
                        @waktu_izin,
                        @perkiraan_kembali,
                        @keperluan,
                        @keterangan,
                        'Menunggu',
                        NULL,
                        NULL,
                        NULL,
                        NOW(),
                        NOW()
                    )
                ";

                long newId;

                using (MySqlCommand command =
                    new MySqlCommand(
                        insertQuery,
                        conn.connec,
                        transaction))
                {
                    command.Parameters.AddWithValue(
                        "@nomor_surat",
                        nomorSurat
                    );

                    command.Parameters.AddWithValue(
                        "@siswa_id",
                        siswaId
                    );

                    command.Parameters.AddWithValue(
                        "@jenis_izin",
                        jenisIzin
                    );

                    command.Parameters.AddWithValue(
                        "@waktu_izin",
                        waktuIzin
                    );

                    command.Parameters.AddWithValue(
                        "@perkiraan_kembali",
                        perkiraanKembali
                    );

                    command.Parameters.AddWithValue(
                        "@keperluan",
                        keperluan
                    );

                    if (string.IsNullOrWhiteSpace(keterangan))
                    {
                        command.Parameters.AddWithValue(
                            "@keterangan",
                            DBNull.Value
                        );
                    }
                    else
                    {
                        command.Parameters.AddWithValue(
                            "@keterangan",
                            keterangan
                        );
                    }

                    command.ExecuteNonQuery();

                    newId =
                        command.LastInsertedId;
                }

                /*
                 * =================================================
                 * 5. LOG AKTIVITAS
                 * =================================================
                 */

                string aktivitas =
                    "Membuat transaksi perizinan " +
                    nomorSurat +
                    " dengan status Menunggu";

                string logQuery = @"
                    INSERT INTO log_activities
                    (
                        user_id,
                        aktivitas,
                        created_at
                    )
                    VALUES
                    (
                        @user_id,
                        @aktivitas,
                        NOW()
                    )
                ";

                using (MySqlCommand command =
                    new MySqlCommand(
                        logQuery,
                        conn.connec,
                        transaction))
                {
                    command.Parameters.AddWithValue(
                        "@user_id",
                        Session.UserId
                    );

                    command.Parameters.AddWithValue(
                        "@aktivitas",
                        aktivitas
                    );

                    command.ExecuteNonQuery();
                }

                /*
                 * =================================================
                 * 6. COMMIT
                 * =================================================
                 */

                transaction.Commit();

                MessageBox.Show(
                    "Transaksi berhasil dibuat.\n\n" +
                    "Nomor Surat : " +
                    nomorSurat +
                    "\nStatus      : Menunggu",
                    "Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.DialogResult =
                    DialogResult.OK;

                this.Close();
            }
            catch (MySqlException ex)
            {
                try
                {
                    if (transaction != null)
                    {
                        transaction.Rollback();
                    }
                }
                catch
                {
                }

                MessageBox.Show(
                    "Gagal menyimpan transaksi.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                try
                {
                    if (transaction != null)
                    {
                        transaction.Rollback();
                    }
                }
                catch
                {
                }

                MessageBox.Show(
                    "Gagal menyimpan transaksi.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                CloseConnection();

                isSaving = false;
            }
        }

        /*
         * =========================================================
         * GENERATE NOMOR SURAT
         * =========================================================
         *
         * Contoh:
         *
         * KEMAS/IZM/20260918/001
         *
         * KEMAS/IZK/20260918/002
         *
         * IZM = Izin Masuk
         * IZK = Izin Keluar
         */

        private string GenerateNomorSurat(
            MySqlTransaction transaction)
        {
            string kodeJenis =
                cmbJenisIzin.SelectedItem.ToString()
                == "Izin Masuk"
                    ? "IZM"
                    : "IZK";

            string tanggal =
                DateTime.Now.ToString("yyyyMMdd");

            string prefix =
                "KEMAS/" +
                kodeJenis +
                "/" +
                tanggal +
                "/";

            string query = @"
                SELECT
                    nomor_surat
                FROM perizinan
                WHERE nomor_surat LIKE @prefix
                ORDER BY id DESC
                LIMIT 1
            ";

            int nomorUrut = 1;

            using (MySqlCommand command =
                new MySqlCommand(
                    query,
                    conn.connec,
                    transaction))
            {
                command.Parameters.AddWithValue(
                    "@prefix",
                    prefix + "%"
                );

                object result =
                    command.ExecuteScalar();

                if (
                    result != null &&
                    result != DBNull.Value
                )
                {
                    string nomorTerakhir =
                        result.ToString();

                    string[] parts =
                        nomorTerakhir.Split('/');

                    if (parts.Length >= 4)
                    {
                        int nomor;

                        if (
                            int.TryParse(
                                parts[3],
                                out nomor
                            )
                        )
                        {
                            nomorUrut =
                                nomor + 1;
                        }
                    }
                }
            }

            return prefix +
                   nomorUrut.ToString("D3");
        }

        /*
         * =========================================================
         * BATAL
         * =========================================================
         */

        private void btnBatal_Click(
            object sender,
            EventArgs e)
        {
            if (isSaving)
            {
                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Batalkan pembuatan transaksi?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                this.DialogResult =
                    DialogResult.Cancel;

                this.Close();
            }
        }

        /*
         * =========================================================
         * CONNECTION
         * =========================================================
         */

        private void OpenConnection()
        {
            if (
                conn.connec.State !=
                ConnectionState.Open
            )
            {
                conn.connec.Open();
            }
        }

        private void CloseConnection()
        {
            try
            {
                if (
                    conn.connec.State ==
                    ConnectionState.Open
                )
                {
                    conn.connec.Close();
                }
            }
            catch
            {
            }
        }
    }
}