using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KemasProject
{
    public partial class FormDetailTransaksi : Form
    {
        private int transaksiId = 0;
        private string currentStatus = "";

        public FormDetailTransaksi()
        {
            InitializeComponent();
            InitializeForm();
        }

        public FormDetailTransaksi(int id)
        {
            InitializeComponent();

            transaksiId = id;

            InitializeForm();
        }

        private void InitializeForm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(900, 680);
            this.BackColor = Color.FromArgb(245, 247, 250);
            this.Font = new Font("Segoe UI", 9F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            ConfigureLabels();
            ConfigureButtons();

            this.Load += FormDetailTransaksi_Load;
        }

        private void ConfigureLabels()
        {
            lblTitle.Text = "Detail Transaksi";
            lblSubtitle.Text =
                "Informasi lengkap surat izin masuk dan keluar siswa.";

            lblSectionSurat.Text = "Informasi Surat";
            lblSectionSiswa.Text = "Data Siswa";
            lblSectionIzin.Text = "Detail Perizinan";
            lblSectionProses.Text = "Informasi Proses";

            lblNomorSuratTitle.Text = "Nomor Surat";
            lblStatusTitle.Text = "Status";

            lblNamaTitle.Text = "Nama Siswa";
            lblNisTitle.Text = "NIS";
            lblKelasTitle.Text = "Kelas";

            lblJenisTitle.Text = "Jenis Izin";
            lblWaktuTitle.Text = "Waktu Izin";
            lblKembaliTitle.Text = "Perkiraan Kembali";
            lblKeperluanTitle.Text = "Keperluan";
            lblKeteranganTitle.Text = "Keterangan";

            lblPetugasTitle.Text = "Petugas";
            lblWaktuProsesTitle.Text = "Waktu Proses";
            lblAlasanTitle.Text = "Alasan Penolakan";

            lblNomorSurat.Text = "-";
            lblStatus.Text = "-";

            lblNama.Text = "-";
            lblNis.Text = "-";
            lblKelas.Text = "-";

            lblJenis.Text = "-";
            lblWaktu.Text = "-";
            lblKembali.Text = "-";
            lblKeperluan.Text = "-";
            lblKeterangan.Text = "-";

            lblPetugas.Text = "-";
            lblWaktuProses.Text = "-";
            lblAlasan.Text = "-";
        }

        private void ConfigureButtons()
        {
            btnTutup.Text = "Tutup";
            btnTolak.Text = "Tolak";
            btnSetujui.Text = "Setujui";
            btnSelesai.Text = "Selesai";

            btnTutup.Click += btnTutup_Click;
            btnTolak.Click += btnTolak_Click;
            btnSetujui.Click += btnSetujui_Click;
            btnSelesai.Click += btnSelesai_Click;
        }

        private void FormDetailTransaksi_Load(object sender, EventArgs e)
        {
            if (transaksiId <= 0)
            {
                MessageBox.Show(
                    "ID transaksi tidak valid.",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                this.Close();
                return;
            }

            LoadDetail();
        }

        private void LoadDetail()
        {
            try
            {
                OpenConnection();

                string query = @"
                    SELECT
                        p.id,
                        p.nomor_surat,
                        p.jenis_izin,
                        p.waktu_izin,
                        p.perkiraan_kembali,
                        p.keperluan,
                        p.keterangan,
                        p.status,
                        p.waktu_proses,
                        p.alasan_penolakan,

                        s.nama_siswa,
                        s.nis,
                        s.kelas,

                        u.nama AS nama_petugas

                    FROM perizinan p

                    INNER JOIN siswa s
                        ON s.id = p.siswa_id

                    LEFT JOIN users u
                        ON u.id = p.petugas_id

                    WHERE p.id = @id
                    LIMIT 1
                ";

                using (MySqlCommand command =
                    new MySqlCommand(query, conn.connec))
                {
                    command.Parameters.AddWithValue(
                        "@id",
                        transaksiId
                    );

                    using (MySqlDataReader reader =
                        command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show(
                                "Data transaksi tidak ditemukan.",
                                "Data Tidak Ditemukan",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );

                            this.Close();
                            return;
                        }

                        LoadDataToForm(reader);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Gagal mengambil detail transaksi.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Terjadi kesalahan saat mengambil detail transaksi.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                this.Close();
            }
            finally
            {
                CloseConnection();
            }
        }

        private void LoadDataToForm(MySqlDataReader reader)
        {
            lblNomorSurat.Text =
                GetString(reader, "nomor_surat");

            currentStatus =
                GetString(reader, "status");

            lblStatus.Text = currentStatus;

            lblNama.Text =
                GetString(reader, "nama_siswa");

            lblNis.Text =
                GetString(reader, "nis");

            lblKelas.Text =
                GetString(reader, "kelas");

            lblJenis.Text =
                GetString(reader, "jenis_izin");

            if (reader["waktu_izin"] != DBNull.Value)
            {
                DateTime waktu =
                    Convert.ToDateTime(reader["waktu_izin"]);

                lblWaktu.Text =
                    waktu.ToString("dd/MM/yyyy HH:mm");
            }
            else
            {
                lblWaktu.Text = "-";
            }

            if (reader["perkiraan_kembali"] != DBNull.Value)
            {
                DateTime kembali =
                    Convert.ToDateTime(
                        reader["perkiraan_kembali"]
                    );

                lblKembali.Text =
                    kembali.ToString("dd/MM/yyyy HH:mm");
            }
            else
            {
                lblKembali.Text = "-";
            }

            lblKeperluan.Text =
                GetString(reader, "keperluan");

            lblKeterangan.Text =
                GetString(reader, "keterangan");

            if (reader["nama_petugas"] != DBNull.Value)
            {
                lblPetugas.Text =
                    reader["nama_petugas"].ToString();
            }
            else
            {
                lblPetugas.Text = "-";
            }

            if (reader["waktu_proses"] != DBNull.Value)
            {
                DateTime waktuProses =
                    Convert.ToDateTime(
                        reader["waktu_proses"]
                    );

                lblWaktuProses.Text =
                    waktuProses.ToString("dd/MM/yyyy HH:mm");
            }
            else
            {
                lblWaktuProses.Text = "-";
            }

            lblAlasan.Text =
                GetString(reader, "alasan_penolakan");

            SetStatusStyle();
            SetButtonVisibility();
        }

        private string GetString(
            MySqlDataReader reader,
            string columnName)
        {
            if (reader[columnName] == DBNull.Value)
            {
                return "-";
            }

            string value =
                reader[columnName].ToString();

            if (string.IsNullOrWhiteSpace(value))
            {
                return "-";
            }

            return value;
        }

        private void SetStatusStyle()
        {
            lblStatus.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold
                );

            switch (currentStatus.ToLower())
            {
                case "menunggu":
                    lblStatus.ForeColor =
                        Color.FromArgb(180, 83, 9);
                    break;

                case "disetujui":
                    lblStatus.ForeColor =
                        Color.FromArgb(21, 128, 61);
                    break;

                case "ditolak":
                    lblStatus.ForeColor =
                        Color.FromArgb(220, 38, 38);
                    break;

                case "selesai":
                    lblStatus.ForeColor =
                        Color.FromArgb(22, 101, 52);
                    break;

                case "dibatalkan":
                    lblStatus.ForeColor =
                        Color.FromArgb(100, 116, 139);
                    break;

                default:
                    lblStatus.ForeColor =
                        Color.FromArgb(30, 41, 59);
                    break;
            }
        }

        private void SetButtonVisibility()
        {
            btnTolak.Visible = false;
            btnSetujui.Visible = false;
            btnSelesai.Visible = false;

            /*
             * Kepala Sekolah hanya dapat melihat detail.
             */
            if (Session.Role == "Kepala Sekolah")
            {
                return;
            }

            /*
             * Admin dan Guru Piket dapat memproses transaksi.
             */
            if (
                Session.Role != "Admin" &&
                Session.Role != "Guru Piket"
            )
            {
                return;
            }

            switch (currentStatus)
            {
                case "Menunggu":

                    btnTolak.Visible = true;
                    btnSetujui.Visible = true;

                    break;

                case "Disetujui":

                    btnSelesai.Visible = true;

                    break;

                case "Ditolak":
                case "Selesai":
                case "Dibatalkan":

                    break;
            }
        }

        private void btnSetujui_Click(
            object sender,
            EventArgs e)
        {
            if (currentStatus != "Menunggu")
            {
                MessageBox.Show(
                    "Transaksi ini sudah tidak berada dalam status Menunggu.",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadDetail();
                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Apakah kamu yakin ingin menyetujui transaksi ini?",
                    "Konfirmasi Persetujuan",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (result != DialogResult.Yes)
            {
                return;
            }

            ProcessTransaction(
                "Disetujui",
                null
            );
        }

        private void btnTolak_Click(
            object sender,
            EventArgs e)
        {
            if (currentStatus != "Menunggu")
            {
                MessageBox.Show(
                    "Transaksi ini sudah tidak berada dalam status Menunggu.",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadDetail();
                return;
            }

            string alasan =
                ShowReasonDialog(
                    "Masukkan alasan penolakan:"
                );

            if (alasan == null)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(alasan))
            {
                MessageBox.Show(
                    "Alasan penolakan wajib diisi.",
                    "Validasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Apakah kamu yakin ingin menolak transaksi ini?",
                    "Konfirmasi Penolakan",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

            if (result != DialogResult.Yes)
            {
                return;
            }

            ProcessTransaction(
                "Ditolak",
                alasan.Trim()
            );
        }

        private void btnSelesai_Click(
            object sender,
            EventArgs e)
        {
            if (currentStatus != "Disetujui")
            {
                MessageBox.Show(
                    "Hanya transaksi dengan status Disetujui yang dapat diselesaikan.",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadDetail();
                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Apakah transaksi ini sudah selesai diproses?",
                    "Konfirmasi Penyelesaian",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (result != DialogResult.Yes)
            {
                return;
            }

            ProcessTransaction(
                "Selesai",
                null
            );
        }

        private void ProcessTransaction(
            string newStatus,
            string alasan)
        {
            if (!Session.IsLoggedIn)
            {
                MessageBox.Show(
                    "Sesi pengguna tidak ditemukan. Silakan login kembali.",
                    "Session Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            MySqlTransaction transaction = null;

            try
            {
                OpenConnection();

                transaction =
                    conn.connec.BeginTransaction();

                /*
                 * Cek kembali status transaksi
                 * sebelum melakukan UPDATE.
                 */
                string checkQuery = @"
                    SELECT status
                    FROM perizinan
                    WHERE id = @id
                    LIMIT 1
                ";

                string databaseStatus = "";

                using (MySqlCommand checkCommand =
                    new MySqlCommand(
                        checkQuery,
                        conn.connec,
                        transaction))
                {
                    checkCommand.Parameters.AddWithValue(
                        "@id",
                        transaksiId
                    );

                    object result =
                        checkCommand.ExecuteScalar();

                    if (
                        result == null ||
                        result == DBNull.Value
                    )
                    {
                        throw new Exception(
                            "Data transaksi tidak ditemukan."
                        );
                    }

                    databaseStatus =
                        result.ToString();
                }

                /*
                 * Validasi status di database.
                 */
                if (
                    newStatus == "Disetujui" &&
                    databaseStatus != "Menunggu"
                )
                {
                    throw new Exception(
                        "Transaksi sudah diproses oleh pengguna lain."
                    );
                }

                if (
                    newStatus == "Ditolak" &&
                    databaseStatus != "Menunggu"
                )
                {
                    throw new Exception(
                        "Transaksi sudah diproses oleh pengguna lain."
                    );
                }

                if (
                    newStatus == "Selesai" &&
                    databaseStatus != "Disetujui"
                )
                {
                    throw new Exception(
                        "Transaksi belum dapat diselesaikan."
                    );
                }

                /*
                 * Update transaksi.
                 */
                string updateQuery = @"
                    UPDATE perizinan
                    SET
                        status = @status,
                        petugas_id = @petugas_id,
                        waktu_proses = NOW(),
                        alasan_penolakan = @alasan,
                        updated_at = NOW()
                    WHERE id = @id
                ";

                using (MySqlCommand updateCommand =
                    new MySqlCommand(
                        updateQuery,
                        conn.connec,
                        transaction))
                {
                    updateCommand.Parameters.AddWithValue(
                        "@status",
                        newStatus
                    );

                    updateCommand.Parameters.AddWithValue(
                        "@petugas_id",
                        Session.UserId
                    );

                    if (string.IsNullOrWhiteSpace(alasan))
                    {
                        updateCommand.Parameters.AddWithValue(
                            "@alasan",
                            DBNull.Value
                        );
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue(
                            "@alasan",
                            alasan
                        );
                    }

                    updateCommand.Parameters.AddWithValue(
                        "@id",
                        transaksiId
                    );

                    int affected =
                        updateCommand.ExecuteNonQuery();

                    if (affected <= 0)
                    {
                        throw new Exception(
                            "Data transaksi gagal diperbarui."
                        );
                    }
                }

                /*
                 * Catat aktivitas pengguna.
                 */
                string aktivitas =
                    "Mengubah status transaksi #" +
                    transaksiId +
                    " menjadi " +
                    newStatus;

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

                using (MySqlCommand logCommand =
                    new MySqlCommand(
                        logQuery,
                        conn.connec,
                        transaction))
                {
                    logCommand.Parameters.AddWithValue(
                        "@user_id",
                        Session.UserId
                    );

                    logCommand.Parameters.AddWithValue(
                        "@aktivitas",
                        aktivitas
                    );

                    logCommand.ExecuteNonQuery();
                }

                /*
                 * Semua operasi berhasil.
                 */
                transaction.Commit();

                MessageBox.Show(
                    "Status transaksi berhasil diubah menjadi \"" +
                    newStatus +
                    "\".",
                    "Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadDetail();
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
                    "Gagal memproses transaksi.\n\n" +
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
                    "Gagal memproses transaksi.\n\n" +
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

        private string ShowReasonDialog(string title)
        {
            using (Form form = new Form())
            {
                form.Text = "Alasan Penolakan";
                form.StartPosition =
                    FormStartPosition.CenterParent;
                form.FormBorderStyle =
                    FormBorderStyle.FixedDialog;
                form.ClientSize =
                    new Size(460, 220);
                form.MinimizeBox = false;
                form.MaximizeBox = false;
                form.ShowInTaskbar = false;
                form.Font =
                    new Font("Segoe UI", 9F);

                Label lbl =
                    new Label();

                lbl.Text = title;
                lbl.Location =
                    new Point(20, 20);
                lbl.Size =
                    new Size(410, 25);
                lbl.Font =
                    new Font(
                        "Segoe UI",
                        9F,
                        FontStyle.Bold
                    );

                TextBox txt =
                    new TextBox();

                txt.Multiline = true;
                txt.ScrollBars =
                    ScrollBars.Vertical;
                txt.Location =
                    new Point(20, 50);
                txt.Size =
                    new Size(410, 90);

                Button btnOk =
                    new Button();

                btnOk.Text = "Simpan";
                btnOk.DialogResult =
                    DialogResult.OK;
                btnOk.Location =
                    new Point(270, 160);
                btnOk.Size =
                    new Size(75, 32);

                Button btnCancel =
                    new Button();

                btnCancel.Text = "Batal";
                btnCancel.DialogResult =
                    DialogResult.Cancel;
                btnCancel.Location =
                    new Point(355, 160);
                btnCancel.Size =
                    new Size(75, 32);

                form.Controls.Add(lbl);
                form.Controls.Add(txt);
                form.Controls.Add(btnOk);
                form.Controls.Add(btnCancel);

                form.AcceptButton = btnOk;
                form.CancelButton = btnCancel;

                DialogResult result =
                    form.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    return txt.Text;
                }

                return null;
            }
        }

        private void btnTutup_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }

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

        private void FormDetailTransaksi_Load_1(object sender, EventArgs e)
        {

        }
    }
}