using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KemasProject
{
    public partial class FormTransaksi : Form
    {
        // =========================================================
        // VARIABLE
        // =========================================================

        private bool isLoading = false;

        // =========================================================
        // CONSTRUCTOR
        // =========================================================

        public FormTransaksi()
        {
            InitializeComponent();
            InitializeForm();
        }

        // =========================================================
        // INITIALIZE FORM
        // =========================================================

        private void InitializeForm()
        {
            // =====================================================
            // FORM
            // =====================================================

            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.FromArgb(245, 247, 250);
            this.Font = new Font("Segoe UI", 9F);

            // =====================================================
            // USER INFO
            // =====================================================

            lblUsername.Text =
                string.IsNullOrWhiteSpace(Session.Nama)
                    ? "-"
                    : Session.Nama;

            lblRole.Text =
                string.IsNullOrWhiteSpace(Session.Role)
                    ? "-"
                    : Session.Role;

            // =====================================================
            // BREADCRUMB
            // =====================================================

            lblBreadcrumb.Text =
                "Dashboard / Transaksi Perizinan";

            // =====================================================
            // JUDUL CONTENT
            // =====================================================

            lblContentTitle.Text =
                "Transaksi Perizinan";

            // =====================================================
            // SUBTITLE CONTENT
            // =====================================================

            lblContentSubtitle.Text =
                "Kelola seluruh data surat izin yang masuk dan keluar.";

            // =====================================================
            // FILTER JENIS
            // =====================================================

            cmbJenis.Items.Clear();

            cmbJenis.Items.Add("Semua Jenis");
            cmbJenis.Items.Add("Izin Masuk");
            cmbJenis.Items.Add("Izin Keluar");

            cmbJenis.SelectedIndex = 0;

            // =====================================================
            // FILTER STATUS
            // =====================================================

            cmbStatus.Items.Clear();

            cmbStatus.Items.Add("Semua Status");
            cmbStatus.Items.Add("Menunggu");
            cmbStatus.Items.Add("Disetujui");
            cmbStatus.Items.Add("Ditolak");
            cmbStatus.Items.Add("Selesai");
            cmbStatus.Items.Add("Dibatalkan");

            cmbStatus.SelectedIndex = 0;

            // =====================================================
            // DATE
            // =====================================================

            dtpTanggal.Format =
                DateTimePickerFormat.Short;

            dtpTanggal.Value =
                DateTime.Today;

            chkSemuaTanggal.Checked = true;

            dtpTanggal.Enabled = false;

            // =====================================================
            // EVENT
            // =====================================================

            txtSearch.TextChanged +=
                txtSearch_TextChanged;

            cmbJenis.SelectedIndexChanged +=
                cmbJenis_SelectedIndexChanged;

            cmbStatus.SelectedIndexChanged +=
                cmbStatus_SelectedIndexChanged;

            dtpTanggal.ValueChanged +=
                dtpTanggal_ValueChanged;

            chkSemuaTanggal.CheckedChanged +=
                chkSemuaTanggal_CheckedChanged;

            btnReset.Click +=
                btnReset_Click;

            btnTambah.Click +=
                btnTambah_Click;

            dgvTransaksi.CellContentClick +=
                dgvTransaksi_CellContentClick;

            // =====================================================
            // DATAGRIDVIEW
            // =====================================================

            ConfigureDataGridView();

            // =====================================================
            // FORM LOAD
            // =====================================================

            this.Load +=
                FormTransaksi_Load;
        }

        // =========================================================
        // FORM LOAD
        // =========================================================

        private void FormTransaksi_Load(
            object sender,
            EventArgs e)
        {
            LoadStatistics();
            LoadTransaksi();
        }

        // =========================================================
        // CONFIGURE DATAGRIDVIEW
        // =========================================================

        private void ConfigureDataGridView()
        {
            dgvTransaksi.AutoGenerateColumns = false;

            dgvTransaksi.AllowUserToAddRows = false;
            dgvTransaksi.AllowUserToDeleteRows = false;
            dgvTransaksi.AllowUserToResizeRows = false;
            dgvTransaksi.AllowUserToResizeColumns = true;

            dgvTransaksi.ReadOnly = true;

            dgvTransaksi.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvTransaksi.MultiSelect = false;

            dgvTransaksi.RowHeadersVisible = false;

            dgvTransaksi.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.None;

            dgvTransaksi.RowTemplate.Height = 42;

            dgvTransaksi.BackgroundColor =
                Color.White;

            dgvTransaksi.BorderStyle =
                BorderStyle.None;

            dgvTransaksi.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgvTransaksi.GridColor =
                Color.FromArgb(226, 232, 240);

            dgvTransaksi.EnableHeadersVisualStyles =
                false;

            // =====================================================
            // HEADER
            // =====================================================

            dgvTransaksi.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(248, 250, 252);

            dgvTransaksi.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.FromArgb(30, 41, 59);

            dgvTransaksi.ColumnHeadersDefaultCellStyle.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold
                );

            dgvTransaksi.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            dgvTransaksi.ColumnHeadersHeight = 42;

            // =====================================================
            // CELL
            // =====================================================

            dgvTransaksi.DefaultCellStyle.Font =
                new Font("Segoe UI", 9F);

            dgvTransaksi.DefaultCellStyle.ForeColor =
                Color.FromArgb(30, 41, 59);

            dgvTransaksi.DefaultCellStyle.BackColor =
                Color.White;

            dgvTransaksi.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(226, 238, 252);

            dgvTransaksi.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(30, 41, 59);

            dgvTransaksi.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            // =====================================================
            // COLUMN WIDTH
            // =====================================================

            No.Width = 45;

            NomorSurat.Width = 125;

            NamaSiswa.Width = 160;

            JenisIzin.Width = 100;

            WaktuIzin.Width = 125;

            Keperluan.AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;

            Status.Width = 100;

            Aksi.Width = 80;
        }

        // =========================================================
        // LOAD STATISTICS
        // =========================================================

        private void LoadStatistics()
        {
            try
            {
                OpenConnection();

                // =================================================
                // TOTAL
                // =================================================

                string queryTotal = @"
                    SELECT COUNT(*)
                    FROM perizinan
                ";

                using (MySqlCommand command =
                    new MySqlCommand(
                        queryTotal,
                        conn.connec))
                {
                    object result =
                        command.ExecuteScalar();

                    lblCardTotalValue.Text =
                        result == null ||
                        result == DBNull.Value
                            ? "0"
                            : Convert.ToInt32(result).ToString();
                }

                // =================================================
                // MENUNGGU
                // =================================================

                string queryMenunggu = @"
                    SELECT COUNT(*)
                    FROM perizinan
                    WHERE status = 'Menunggu'
                ";

                using (MySqlCommand command =
                    new MySqlCommand(
                        queryMenunggu,
                        conn.connec))
                {
                    object result =
                        command.ExecuteScalar();

                    lblCardMenungguValue.Text =
                        result == null ||
                        result == DBNull.Value
                            ? "0"
                            : Convert.ToInt32(result).ToString();
                }

                // =================================================
                // DISETUJUI
                // =================================================

                string queryDisetujui = @"
                    SELECT COUNT(*)
                    FROM perizinan
                    WHERE status = 'Disetujui'
                ";

                using (MySqlCommand command =
                    new MySqlCommand(
                        queryDisetujui,
                        conn.connec))
                {
                    object result =
                        command.ExecuteScalar();

                    lblCardDisetujuiValue.Text =
                        result == null ||
                        result == DBNull.Value
                            ? "0"
                            : Convert.ToInt32(result).ToString();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Gagal mengambil statistik transaksi.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Terjadi kesalahan saat mengambil statistik.\n\n" +
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

        // =========================================================
        // LOAD TRANSAKSI
        // =========================================================

        private void LoadTransaksi()
        {
            if (isLoading)
            {
                return;
            }

            isLoading = true;

            try
            {
                OpenConnection();

                string query = @"
                    SELECT
                        p.id,
                        p.nomor_surat,
                        p.jenis_izin,
                        p.waktu_izin,
                        p.keperluan,
                        p.status,
                        s.nama_siswa
                    FROM perizinan p
                    INNER JOIN siswa s
                        ON s.id = p.siswa_id
                    WHERE 1 = 1
                ";

                // =================================================
                // SEARCH
                // =================================================

                string search =
                    txtSearch.Text.Trim();

                if (!string.IsNullOrWhiteSpace(search))
                {
                    query += @"
                        AND (
                            s.nama_siswa LIKE @search
                            OR p.nomor_surat LIKE @search
                        )
                    ";
                }

                // =================================================
                // JENIS
                // =================================================

                if (cmbJenis.SelectedIndex > 0)
                {
                    query += @"
                        AND p.jenis_izin = @jenis
                    ";
                }

                // =================================================
                // STATUS
                // =================================================

                if (cmbStatus.SelectedIndex > 0)
                {
                    query += @"
                        AND p.status = @status
                    ";
                }

                // =================================================
                // TANGGAL
                // =================================================

                if (!chkSemuaTanggal.Checked)
                {
                    query += @"
                        AND DATE(p.waktu_izin) = @tanggal
                    ";
                }

                // =================================================
                // ORDER
                // =================================================

                query += @"
                    ORDER BY
                        p.created_at DESC,
                        p.id DESC
                ";

                using (MySqlCommand command =
                    new MySqlCommand(
                        query,
                        conn.connec))
                {
                    // =================================================
                    // SEARCH PARAMETER
                    // =================================================

                    if (!string.IsNullOrWhiteSpace(search))
                    {
                        command.Parameters.AddWithValue(
                            "@search",
                            "%" + search + "%"
                        );
                    }

                    // =================================================
                    // JENIS PARAMETER
                    // =================================================

                    if (cmbJenis.SelectedIndex > 0)
                    {
                        command.Parameters.AddWithValue(
                            "@jenis",
                            cmbJenis.SelectedItem.ToString()
                        );
                    }

                    // =================================================
                    // STATUS PARAMETER
                    // =================================================

                    if (cmbStatus.SelectedIndex > 0)
                    {
                        command.Parameters.AddWithValue(
                            "@status",
                            cmbStatus.SelectedItem.ToString()
                        );
                    }

                    // =================================================
                    // TANGGAL PARAMETER
                    // =================================================

                    if (!chkSemuaTanggal.Checked)
                    {
                        command.Parameters.AddWithValue(
                            "@tanggal",
                            dtpTanggal.Value.Date
                        );
                    }

                    // =================================================
                    // READ DATA
                    // =================================================

                    using (MySqlDataReader reader =
                        command.ExecuteReader())
                    {
                        dgvTransaksi.Rows.Clear();

                        int nomor = 1;

                        while (reader.Read())
                        {
                            int id =
                                Convert.ToInt32(
                                    reader["id"]
                                );

                            string nomorSurat =
                                reader["nomor_surat"]
                                    .ToString();

                            string namaSiswa =
                                reader["nama_siswa"]
                                    .ToString();

                            string jenisIzin =
                                reader["jenis_izin"]
                                    .ToString();

                            string waktuIzin = "-";

                            if (reader["waktu_izin"] !=
                                DBNull.Value)
                            {
                                DateTime waktu =
                                    Convert.ToDateTime(
                                        reader["waktu_izin"]
                                    );

                                waktuIzin =
                                    waktu.ToString(
                                        "dd/MM/yyyy HH:mm"
                                    );
                            }

                            string keperluan =
                                reader["keperluan"] ==
                                DBNull.Value
                                    ? "-"
                                    : reader["keperluan"]
                                        .ToString();

                            string status =
                                reader["status"]
                                    .ToString();

                            int rowIndex =
                                dgvTransaksi.Rows.Add(
                                    nomor,
                                    nomorSurat,
                                    namaSiswa,
                                    jenisIzin,
                                    waktuIzin,
                                    keperluan,
                                    status,
                                    "Detail"
                                );

                            dgvTransaksi.Rows[rowIndex]
                                .Tag = id;

                            SetGridStatusStyle(
                                dgvTransaksi.Rows[rowIndex],
                                status
                            );

                            nomor++;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Gagal mengambil data transaksi.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Terjadi kesalahan saat mengambil transaksi.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                CloseConnection();

                isLoading = false;
            }
        }

        // =========================================================
        // STATUS STYLE
        // =========================================================

        private void SetGridStatusStyle(
            DataGridViewRow row,
            string status)
        {
            DataGridViewCell cell =
                row.Cells["colStatus"];

            // Reset style terlebih dahulu
            cell.Style.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold
                );

            switch (status.ToLower())
            {
                case "menunggu":

                    cell.Style.ForeColor =
                        Color.FromArgb(180, 83, 9);

                    break;

                case "disetujui":

                    cell.Style.ForeColor =
                        Color.FromArgb(21, 128, 61);

                    break;

                case "ditolak":

                    cell.Style.ForeColor =
                        Color.FromArgb(220, 38, 38);

                    break;

                case "selesai":

                    cell.Style.ForeColor =
                        Color.FromArgb(22, 101, 52);

                    break;

                case "dibatalkan":

                    cell.Style.ForeColor =
                        Color.FromArgb(100, 116, 139);

                    break;

                default:

                    cell.Style.ForeColor =
                        Color.FromArgb(30, 41, 59);

                    break;
            }
        }

        // =========================================================
        // SEARCH
        // =========================================================

        private void txtSearch_TextChanged(
            object sender,
            EventArgs e)
        {
            LoadTransaksi();
        }

        // =========================================================
        // FILTER JENIS
        // =========================================================

        private void cmbJenis_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            LoadTransaksi();
        }

        // =========================================================
        // FILTER STATUS
        // =========================================================

        private void cmbStatus_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            LoadTransaksi();
        }

        // =========================================================
        // FILTER TANGGAL
        // =========================================================

        private void dtpTanggal_ValueChanged(
            object sender,
            EventArgs e)
        {
            if (!chkSemuaTanggal.Checked)
            {
                LoadTransaksi();
            }
        }

        // =========================================================
        // SEMUA TANGGAL
        // =========================================================

        private void chkSemuaTanggal_CheckedChanged(
            object sender,
            EventArgs e)
        {
            dtpTanggal.Enabled =
                !chkSemuaTanggal.Checked;

            LoadTransaksi();
        }

        // =========================================================
        // RESET FILTER
        // =========================================================

        private void btnReset_Click(
            object sender,
            EventArgs e)
        {
            // Supaya event tidak memanggil query
            // berkali-kali selama reset.
            isLoading = true;

            try
            {
                txtSearch.Clear();

                cmbJenis.SelectedIndex = 0;

                cmbStatus.SelectedIndex = 0;

                chkSemuaTanggal.Checked = true;

                dtpTanggal.Value =
                    DateTime.Today;

                dtpTanggal.Enabled = false;
            }
            finally
            {
                isLoading = false;
            }

            LoadStatistics();
            LoadTransaksi();
        }

        // =========================================================
        // TAMBAH TRANSAKSI
        // =========================================================

        private void btnTambah_Click(
            object sender,
            EventArgs e)
        {
            using (FormTransaksiBaru form =
                new FormTransaksiBaru())
            {
                form.ShowDialog();
            }

            LoadStatistics();
            LoadTransaksi();
        }

        // =========================================================
        // DETAIL TRANSAKSI
        // =========================================================

        private void dgvTransaksi_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex !=
                dgvTransaksi.Columns["colAksi"].Index)
            {
                return;
            }

            if (dgvTransaksi.Rows[e.RowIndex].Tag ==
                null)
            {
                return;
            }

            int id =
                Convert.ToInt32(
                    dgvTransaksi.Rows[e.RowIndex].Tag
                );

            using ( FormDetailTransaksi form =
                new FormDetailTransaksi(id))
            {
                form.ShowDialog();
            }

            LoadStatistics();
            LoadTransaksi();
        }

        // =========================================================
        // OPEN CONNECTION
        // =========================================================

        private void OpenConnection()
        {
            if (conn.connec.State !=
                ConnectionState.Open)
            {
                conn.connec.Open();
            }
        }

        // =========================================================
        // CLOSE CONNECTION
        // =========================================================

        private void CloseConnection()
        {
            try
            {
                if (conn.connec.State ==
                    ConnectionState.Open)
                {
                    conn.connec.Close();
                }
            }
            catch
            {
                // Tidak melakukan apa-apa.
            }
        }
    }
}