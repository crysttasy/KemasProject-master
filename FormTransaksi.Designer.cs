
namespace KemasProject
{
    partial class FormTransaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.flpSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSidebarHeader = new System.Windows.Forms.Panel();
            this.lblText = new System.Windows.Forms.Label();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlTopbar = new System.Windows.Forms.Panel();
            this.pnlUserInfo = new System.Windows.Forms.Panel();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPageSubtitle = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlData = new System.Windows.Forms.Panel();
            this.dgvTransaksi = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomorSurat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaSiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JenisIzin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaktuIzin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Keperluan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aksi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblDataDubtitle = new System.Windows.Forms.Label();
            this.lblDataTitle = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.chkSemuaTanggal = new System.Windows.Forms.CheckBox();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbJenis = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFilterTitle = new System.Windows.Forms.Label();
            this.pnlCardDisetujui = new System.Windows.Forms.Panel();
            this.lblCardDisetujuiValue = new System.Windows.Forms.Label();
            this.lblCardDisetujuiTitle = new System.Windows.Forms.Label();
            this.pnlCardMenunggu = new System.Windows.Forms.Panel();
            this.lblCardMenungguValue = new System.Windows.Forms.Label();
            this.lblCardMenungguTitle = new System.Windows.Forms.Label();
            this.pnlCardTotal = new System.Windows.Forms.Panel();
            this.lblCardTotalValue = new System.Windows.Forms.Label();
            this.lblCardTotalTitle = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.lblContentSubtitle = new System.Windows.Forms.Label();
            this.lblContentTitle = new System.Windows.Forms.Label();
            this.lblBreadcrumb = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlSidebarHeader.SuspendLayout();
            this.pnlTopbar.SuspendLayout();
            this.pnlUserInfo.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).BeginInit();
            this.pnlFilter.SuspendLayout();
            this.pnlCardDisetujui.SuspendLayout();
            this.pnlCardMenunggu.SuspendLayout();
            this.pnlCardTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(62)))), ((int)(((byte)(115)))));
            this.pnlSidebar.Controls.Add(this.flpSidebar);
            this.pnlSidebar.Controls.Add(this.pnlSidebarHeader);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 720);
            this.pnlSidebar.TabIndex = 0;
            // 
            // flpSidebar
            // 
            this.flpSidebar.AutoScroll = true;
            this.flpSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSidebar.Location = new System.Drawing.Point(0, 80);
            this.flpSidebar.Name = "flpSidebar";
            this.flpSidebar.Padding = new System.Windows.Forms.Padding(10);
            this.flpSidebar.Size = new System.Drawing.Size(220, 640);
            this.flpSidebar.TabIndex = 3;
            this.flpSidebar.WrapContents = false;
            // 
            // pnlSidebarHeader
            // 
            this.pnlSidebarHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(62)))), ((int)(((byte)(115)))));
            this.pnlSidebarHeader.Controls.Add(this.lblText);
            this.pnlSidebarHeader.Controls.Add(this.lblSystemName);
            this.pnlSidebarHeader.Controls.Add(this.lblLogo);
            this.pnlSidebarHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSidebarHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebarHeader.Name = "pnlSidebarHeader";
            this.pnlSidebarHeader.Size = new System.Drawing.Size(220, 80);
            this.pnlSidebarHeader.TabIndex = 2;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(215)))), ((int)(((byte)(235)))));
            this.lblText.Location = new System.Drawing.Point(70, 42);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(103, 12);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Sistem Perizinan Sekolah";
            // 
            // lblSystemName
            // 
            this.lblSystemName.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName.ForeColor = System.Drawing.Color.White;
            this.lblSystemName.Location = new System.Drawing.Point(70, 17);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(120, 25);
            this.lblSystemName.TabIndex = 1;
            this.lblSystemName.Text = "KEMAS";
            this.lblSystemName.UseMnemonic = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(20, 15);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(31, 32);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "K";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTopbar
            // 
            this.pnlTopbar.BackColor = System.Drawing.Color.White;
            this.pnlTopbar.Controls.Add(this.pnlUserInfo);
            this.pnlTopbar.Controls.Add(this.lblPageSubtitle);
            this.pnlTopbar.Controls.Add(this.lblPageTitle);
            this.pnlTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopbar.Location = new System.Drawing.Point(220, 0);
            this.pnlTopbar.Name = "pnlTopbar";
            this.pnlTopbar.Size = new System.Drawing.Size(1060, 75);
            this.pnlTopbar.TabIndex = 1;
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.Controls.Add(this.lblRole);
            this.pnlUserInfo.Controls.Add(this.lblUsername);
            this.pnlUserInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlUserInfo.Location = new System.Drawing.Point(860, 0);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(200, 75);
            this.pnlUserInfo.TabIndex = 2;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblRole.Location = new System.Drawing.Point(40, 42);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(77, 13);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Administrator";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblUsername.Location = new System.Drawing.Point(40, 20);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(68, 15);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Nama User";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPageSubtitle
            // 
            this.lblPageSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPageSubtitle.Location = new System.Drawing.Point(25, 42);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.Size = new System.Drawing.Size(500, 20);
            this.lblPageSubtitle.TabIndex = 1;
            this.lblPageSubtitle.Text = "Kelola data surat izin masuk dan keluar sekolah";
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblPageTitle.Location = new System.Drawing.Point(25, 15);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(400, 25);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Transaksi Perizinan";
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlData);
            this.pnlContent.Controls.Add(this.pnlFilter);
            this.pnlContent.Controls.Add(this.pnlCardDisetujui);
            this.pnlContent.Controls.Add(this.pnlCardMenunggu);
            this.pnlContent.Controls.Add(this.pnlCardTotal);
            this.pnlContent.Controls.Add(this.btnTambah);
            this.pnlContent.Controls.Add(this.lblContentSubtitle);
            this.pnlContent.Controls.Add(this.lblContentTitle);
            this.pnlContent.Controls.Add(this.lblBreadcrumb);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(220, 75);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(25);
            this.pnlContent.Size = new System.Drawing.Size(1060, 645);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlData
            // 
            this.pnlData.BackColor = System.Drawing.Color.White;
            this.pnlData.Controls.Add(this.dgvTransaksi);
            this.pnlData.Controls.Add(this.lblDataDubtitle);
            this.pnlData.Controls.Add(this.lblDataTitle);
            this.pnlData.Location = new System.Drawing.Point(25, 340);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(1130, 300);
            this.pnlData.TabIndex = 8;
            // 
            // dgvTransaksi
            // 
            this.dgvTransaksi.AllowUserToAddRows = false;
            this.dgvTransaksi.AllowUserToDeleteRows = false;
            this.dgvTransaksi.AllowUserToResizeColumns = false;
            this.dgvTransaksi.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.NomorSurat,
            this.NamaSiswa,
            this.JenisIzin,
            this.WaktuIzin,
            this.Keperluan,
            this.Status,
            this.Aksi});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(238)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransaksi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransaksi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvTransaksi.Location = new System.Drawing.Point(20, 70);
            this.dgvTransaksi.MultiSelect = false;
            this.dgvTransaksi.Name = "dgvTransaksi";
            this.dgvTransaksi.ReadOnly = true;
            this.dgvTransaksi.RowHeadersVisible = false;
            this.dgvTransaksi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransaksi.Size = new System.Drawing.Size(1090, 210);
            this.dgvTransaksi.TabIndex = 2;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Visible = false;
            this.No.Width = 45;
            // 
            // NomorSurat
            // 
            this.NomorSurat.HeaderText = "Nomor Surat";
            this.NomorSurat.Name = "NomorSurat";
            this.NomorSurat.ReadOnly = true;
            this.NomorSurat.Visible = false;
            this.NomorSurat.Width = 125;
            // 
            // NamaSiswa
            // 
            this.NamaSiswa.HeaderText = "Nama Siswa";
            this.NamaSiswa.Name = "NamaSiswa";
            this.NamaSiswa.ReadOnly = true;
            this.NamaSiswa.Visible = false;
            this.NamaSiswa.Width = 160;
            // 
            // JenisIzin
            // 
            this.JenisIzin.HeaderText = "Jenis Izin";
            this.JenisIzin.Name = "JenisIzin";
            this.JenisIzin.ReadOnly = true;
            this.JenisIzin.Visible = false;
            // 
            // WaktuIzin
            // 
            this.WaktuIzin.HeaderText = "Waktu";
            this.WaktuIzin.Name = "WaktuIzin";
            this.WaktuIzin.ReadOnly = true;
            this.WaktuIzin.Visible = false;
            this.WaktuIzin.Width = 125;
            // 
            // Keperluan
            // 
            this.Keperluan.HeaderText = "Keperluan";
            this.Keperluan.Name = "Keperluan";
            this.Keperluan.ReadOnly = true;
            this.Keperluan.Visible = false;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // Aksi
            // 
            this.Aksi.HeaderText = "Aksi";
            this.Aksi.Name = "Aksi";
            this.Aksi.ReadOnly = true;
            this.Aksi.Text = "Detail";
            this.Aksi.UseColumnTextForButtonValue = true;
            this.Aksi.Visible = false;
            this.Aksi.Width = 80;
            // 
            // lblDataDubtitle
            // 
            this.lblDataDubtitle.AutoSize = true;
            this.lblDataDubtitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblDataDubtitle.Location = new System.Drawing.Point(20, 38);
            this.lblDataDubtitle.Name = "lblDataDubtitle";
            this.lblDataDubtitle.Size = new System.Drawing.Size(165, 13);
            this.lblDataDubtitle.TabIndex = 1;
            this.lblDataDubtitle.Text = "Daftar Seluruh Surat Izin Siswa";
            // 
            // lblDataTitle
            // 
            this.lblDataTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblDataTitle.Location = new System.Drawing.Point(20, 15);
            this.lblDataTitle.Name = "lblDataTitle";
            this.lblDataTitle.Size = new System.Drawing.Size(400, 18);
            this.lblDataTitle.TabIndex = 0;
            this.lblDataTitle.Text = "Data Perizinan";
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.Controls.Add(this.btnReset);
            this.pnlFilter.Controls.Add(this.chkSemuaTanggal);
            this.pnlFilter.Controls.Add(this.dtpTanggal);
            this.pnlFilter.Controls.Add(this.cmbStatus);
            this.pnlFilter.Controls.Add(this.cmbJenis);
            this.pnlFilter.Controls.Add(this.txtSearch);
            this.pnlFilter.Controls.Add(this.lblFilterTitle);
            this.pnlFilter.Location = new System.Drawing.Point(25, 220);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1130, 105);
            this.pnlFilter.TabIndex = 7;
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnReset.Location = new System.Drawing.Point(940, 45);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // chkSemuaTanggal
            // 
            this.chkSemuaTanggal.AutoSize = true;
            this.chkSemuaTanggal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.chkSemuaTanggal.Location = new System.Drawing.Point(810, 52);
            this.chkSemuaTanggal.Name = "chkSemuaTanggal";
            this.chkSemuaTanggal.Size = new System.Drawing.Size(106, 19);
            this.chkSemuaTanggal.TabIndex = 6;
            this.chkSemuaTanggal.Text = "Semua Tanggal";
            this.chkSemuaTanggal.UseVisualStyleBackColor = true;
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Location = new System.Drawing.Point(665, 45);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(120, 23);
            this.dtpTanggal.TabIndex = 5;
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.White;
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cmbStatus.ItemHeight = 30;
            this.cmbStatus.Location = new System.Drawing.Point(500, 45);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(150, 36);
            this.cmbStatus.TabIndex = 4;
            // 
            // cmbJenis
            // 
            this.cmbJenis.BackColor = System.Drawing.Color.White;
            this.cmbJenis.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJenis.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbJenis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbJenis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJenis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cmbJenis.ItemHeight = 30;
            this.cmbJenis.Location = new System.Drawing.Point(335, 45);
            this.cmbJenis.Name = "cmbJenis";
            this.cmbJenis.Size = new System.Drawing.Size(150, 36);
            this.cmbJenis.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(20, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Cari nama siswa atau nomor surat...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(300, 34);
            this.txtSearch.TabIndex = 2;
            // 
            // lblFilterTitle
            // 
            this.lblFilterTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblFilterTitle.Location = new System.Drawing.Point(20, 12);
            this.lblFilterTitle.Name = "lblFilterTitle";
            this.lblFilterTitle.Size = new System.Drawing.Size(200, 20);
            this.lblFilterTitle.TabIndex = 0;
            this.lblFilterTitle.Text = "Filter Transaksi";
            // 
            // pnlCardDisetujui
            // 
            this.pnlCardDisetujui.BackColor = System.Drawing.Color.White;
            this.pnlCardDisetujui.Controls.Add(this.lblCardDisetujuiValue);
            this.pnlCardDisetujui.Controls.Add(this.lblCardDisetujuiTitle);
            this.pnlCardDisetujui.Location = new System.Drawing.Point(561, 115);
            this.pnlCardDisetujui.Name = "pnlCardDisetujui";
            this.pnlCardDisetujui.Size = new System.Drawing.Size(250, 90);
            this.pnlCardDisetujui.TabIndex = 6;
            // 
            // lblCardDisetujuiValue
            // 
            this.lblCardDisetujuiValue.AutoSize = true;
            this.lblCardDisetujuiValue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardDisetujuiValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.lblCardDisetujuiValue.Location = new System.Drawing.Point(20, 38);
            this.lblCardDisetujuiValue.Name = "lblCardDisetujuiValue";
            this.lblCardDisetujuiValue.Size = new System.Drawing.Size(33, 37);
            this.lblCardDisetujuiValue.TabIndex = 1;
            this.lblCardDisetujuiValue.Text = "0";
            // 
            // lblCardDisetujuiTitle
            // 
            this.lblCardDisetujuiTitle.AutoSize = true;
            this.lblCardDisetujuiTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardDisetujuiTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCardDisetujuiTitle.Location = new System.Drawing.Point(20, 15);
            this.lblCardDisetujuiTitle.Name = "lblCardDisetujuiTitle";
            this.lblCardDisetujuiTitle.Size = new System.Drawing.Size(53, 13);
            this.lblCardDisetujuiTitle.TabIndex = 0;
            this.lblCardDisetujuiTitle.Text = "Disetujui";
            // 
            // pnlCardMenunggu
            // 
            this.pnlCardMenunggu.BackColor = System.Drawing.Color.White;
            this.pnlCardMenunggu.Controls.Add(this.lblCardMenungguValue);
            this.pnlCardMenunggu.Controls.Add(this.lblCardMenungguTitle);
            this.pnlCardMenunggu.Location = new System.Drawing.Point(295, 115);
            this.pnlCardMenunggu.Name = "pnlCardMenunggu";
            this.pnlCardMenunggu.Size = new System.Drawing.Size(250, 90);
            this.pnlCardMenunggu.TabIndex = 5;
            // 
            // lblCardMenungguValue
            // 
            this.lblCardMenungguValue.AutoSize = true;
            this.lblCardMenungguValue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardMenungguValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblCardMenungguValue.Location = new System.Drawing.Point(20, 38);
            this.lblCardMenungguValue.Name = "lblCardMenungguValue";
            this.lblCardMenungguValue.Size = new System.Drawing.Size(33, 37);
            this.lblCardMenungguValue.TabIndex = 1;
            this.lblCardMenungguValue.Text = "0";
            // 
            // lblCardMenungguTitle
            // 
            this.lblCardMenungguTitle.AutoSize = true;
            this.lblCardMenungguTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardMenungguTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCardMenungguTitle.Location = new System.Drawing.Point(20, 15);
            this.lblCardMenungguTitle.Name = "lblCardMenungguTitle";
            this.lblCardMenungguTitle.Size = new System.Drawing.Size(65, 13);
            this.lblCardMenungguTitle.TabIndex = 0;
            this.lblCardMenungguTitle.Text = "Menunggu";
            // 
            // pnlCardTotal
            // 
            this.pnlCardTotal.BackColor = System.Drawing.Color.White;
            this.pnlCardTotal.Controls.Add(this.lblCardTotalValue);
            this.pnlCardTotal.Controls.Add(this.lblCardTotalTitle);
            this.pnlCardTotal.Location = new System.Drawing.Point(25, 115);
            this.pnlCardTotal.Name = "pnlCardTotal";
            this.pnlCardTotal.Size = new System.Drawing.Size(250, 90);
            this.pnlCardTotal.TabIndex = 4;
            // 
            // lblCardTotalValue
            // 
            this.lblCardTotalValue.AutoSize = true;
            this.lblCardTotalValue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblCardTotalValue.Location = new System.Drawing.Point(20, 38);
            this.lblCardTotalValue.Name = "lblCardTotalValue";
            this.lblCardTotalValue.Size = new System.Drawing.Size(33, 37);
            this.lblCardTotalValue.TabIndex = 1;
            this.lblCardTotalValue.Text = "0";
            // 
            // lblCardTotalTitle
            // 
            this.lblCardTotalTitle.AutoSize = true;
            this.lblCardTotalTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardTotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCardTotalTitle.Location = new System.Drawing.Point(20, 15);
            this.lblCardTotalTitle.Name = "lblCardTotalTitle";
            this.lblCardTotalTitle.Size = new System.Drawing.Size(82, 13);
            this.lblCardTotalTitle.TabIndex = 0;
            this.lblCardTotalTitle.Text = "Total Perizinan";
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.White;
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Location = new System.Drawing.Point(970, 48);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(180, 38);
            this.btnTambah.TabIndex = 3;
            this.btnTambah.Text = "+ Tambah Perizinan";
            this.btnTambah.UseVisualStyleBackColor = false;
            // 
            // lblContentSubtitle
            // 
            this.lblContentSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContentSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblContentSubtitle.Location = new System.Drawing.Point(25, 78);
            this.lblContentSubtitle.Name = "lblContentSubtitle";
            this.lblContentSubtitle.Size = new System.Drawing.Size(500, 30);
            this.lblContentSubtitle.TabIndex = 2;
            this.lblContentSubtitle.Text = "Kelola seluruh data surat izin yang masuk dan keluar.";
            // 
            // lblContentTitle
            // 
            this.lblContentTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblContentTitle.Location = new System.Drawing.Point(25, 48);
            this.lblContentTitle.Name = "lblContentTitle";
            this.lblContentTitle.Size = new System.Drawing.Size(500, 30);
            this.lblContentTitle.TabIndex = 1;
            this.lblContentTitle.Text = "Transaksi Perizinan ";
            // 
            // lblBreadcrumb
            // 
            this.lblBreadcrumb.AutoSize = true;
            this.lblBreadcrumb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadcrumb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblBreadcrumb.Location = new System.Drawing.Point(25, 15);
            this.lblBreadcrumb.Name = "lblBreadcrumb";
            this.lblBreadcrumb.Size = new System.Drawing.Size(121, 13);
            this.lblBreadcrumb.TabIndex = 0;
            this.lblBreadcrumb.Text = "Dashboard / Transaksi";
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTopbar);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTransaksi";
            this.Text = "FormTransaksi";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebarHeader.ResumeLayout(false);
            this.pnlSidebarHeader.PerformLayout();
            this.pnlTopbar.ResumeLayout(false);
            this.pnlUserInfo.ResumeLayout(false);
            this.pnlUserInfo.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlCardDisetujui.ResumeLayout(false);
            this.pnlCardDisetujui.PerformLayout();
            this.pnlCardMenunggu.ResumeLayout(false);
            this.pnlCardMenunggu.PerformLayout();
            this.pnlCardTotal.ResumeLayout(false);
            this.pnlCardTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.FlowLayoutPanel flpSidebar;
        private System.Windows.Forms.Panel pnlSidebarHeader;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel pnlTopbar;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPageSubtitle;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblContentTitle;
        private System.Windows.Forms.Label lblBreadcrumb;
        private System.Windows.Forms.Panel pnlCardTotal;
        private System.Windows.Forms.Label lblCardTotalTitle;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label lblContentSubtitle;
        private System.Windows.Forms.Panel pnlCardMenunggu;
        private System.Windows.Forms.Label lblCardMenungguValue;
        private System.Windows.Forms.Label lblCardMenungguTitle;
        private System.Windows.Forms.Label lblCardTotalValue;
        private System.Windows.Forms.Panel pnlCardDisetujui;
        private System.Windows.Forms.Label lblCardDisetujuiValue;
        private System.Windows.Forms.Label lblCardDisetujuiTitle;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblFilterTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cmbJenis;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView dgvTransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomorSurat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn JenisIzin;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaktuIzin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keperluan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn Aksi;
        private System.Windows.Forms.Label lblDataDubtitle;
        private System.Windows.Forms.Label lblDataTitle;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox chkSemuaTanggal;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStatus;
    }
}