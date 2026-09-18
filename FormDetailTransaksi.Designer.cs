
namespace KemasProject
{
    partial class FormDetailTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetailTransaksi));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlDataSurat = new System.Windows.Forms.Panel();
            this.lblSectionSurat = new System.Windows.Forms.Label();
            this.lblNomorSuratTitle = new System.Windows.Forms.Label();
            this.lblNomorSurat = new System.Windows.Forms.Label();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlDataSiswa = new System.Windows.Forms.Panel();
            this.lblNis = new System.Windows.Forms.Label();
            this.lblNisStyle = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblNamaTitle = new System.Windows.Forms.Label();
            this.lblSectionSiswa = new System.Windows.Forms.Label();
            this.lblKelasTitle = new System.Windows.Forms.Label();
            this.lblKelas = new System.Windows.Forms.Label();
            this.pnlDataIzin = new System.Windows.Forms.Panel();
            this.lblSectionIIzin = new System.Windows.Forms.Label();
            this.lblKembali = new System.Windows.Forms.Label();
            this.lblKembaliTitle = new System.Windows.Forms.Label();
            this.lblWaktu = new System.Windows.Forms.Label();
            this.lblWaktuTitle = new System.Windows.Forms.Label();
            this.lblJenis = new System.Windows.Forms.Label();
            this.lblJenisTitle = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlDataSurat.SuspendLayout();
            this.pnlDataSiswa.SuspendLayout();
            this.pnlDataIzin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1031, 82);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(62)))), ((int)(((byte)(115)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(162, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Detail Transaksi";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSubtitle.Location = new System.Drawing.Point(26, 47);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(275, 13);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Informasi lengkap surat izin masuk dan keluar siswa";
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.Controls.Add(this.pnlDataIzin);
            this.pnlContent.Controls.Add(this.pnlDataSiswa);
            this.pnlContent.Controls.Add(this.pnlDataSurat);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 82);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20, 18, 20, 10);
            this.pnlContent.Size = new System.Drawing.Size(1031, 658);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlDataSurat
            // 
            this.pnlDataSurat.BackColor = System.Drawing.Color.White;
            this.pnlDataSurat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDataSurat.Controls.Add(this.lblStatus);
            this.pnlDataSurat.Controls.Add(this.lblStatusTitle);
            this.pnlDataSurat.Controls.Add(this.lblNomorSurat);
            this.pnlDataSurat.Controls.Add(this.lblNomorSuratTitle);
            this.pnlDataSurat.Controls.Add(this.lblSectionSurat);
            this.pnlDataSurat.Location = new System.Drawing.Point(20, 18);
            this.pnlDataSurat.Name = "pnlDataSurat";
            this.pnlDataSurat.Size = new System.Drawing.Size(840, 105);
            this.pnlDataSurat.TabIndex = 0;
            // 
            // lblSectionSurat
            // 
            this.lblSectionSurat.AutoSize = true;
            this.lblSectionSurat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectionSurat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblSectionSurat.Location = new System.Drawing.Point(18, 12);
            this.lblSectionSurat.Name = "lblSectionSurat";
            this.lblSectionSurat.Size = new System.Drawing.Size(103, 17);
            this.lblSectionSurat.TabIndex = 0;
            this.lblSectionSurat.Text = "Informasi Surat";
            // 
            // lblNomorSuratTitle
            // 
            this.lblNomorSuratTitle.AutoSize = true;
            this.lblNomorSuratTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomorSuratTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblNomorSuratTitle.Location = new System.Drawing.Point(18, 43);
            this.lblNomorSuratTitle.Name = "lblNomorSuratTitle";
            this.lblNomorSuratTitle.Size = new System.Drawing.Size(72, 13);
            this.lblNomorSuratTitle.TabIndex = 1;
            this.lblNomorSuratTitle.Text = "Nomor Surat";
            // 
            // lblNomorSurat
            // 
            this.lblNomorSurat.AutoSize = true;
            this.lblNomorSurat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomorSurat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(62)))), ((int)(((byte)(115)))));
            this.lblNomorSurat.Location = new System.Drawing.Point(18, 64);
            this.lblNomorSurat.Name = "lblNomorSurat";
            this.lblNomorSurat.Size = new System.Drawing.Size(12, 15);
            this.lblNomorSurat.TabIndex = 2;
            this.lblNomorSurat.Text = "-";
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.AutoSize = true;
            this.lblStatusTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblStatusTitle.Location = new System.Drawing.Point(450, 43);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(39, 13);
            this.lblStatusTitle.TabIndex = 3;
            this.lblStatusTitle.Text = "Status";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.lblStatus.Location = new System.Drawing.Point(450, 64);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(12, 15);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "-";
            // 
            // pnlDataSiswa
            // 
            this.pnlDataSiswa.BackColor = System.Drawing.Color.White;
            this.pnlDataSiswa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDataSiswa.Controls.Add(this.lblKelas);
            this.pnlDataSiswa.Controls.Add(this.lblKelasTitle);
            this.pnlDataSiswa.Controls.Add(this.lblNis);
            this.pnlDataSiswa.Controls.Add(this.lblNisStyle);
            this.pnlDataSiswa.Controls.Add(this.lblNama);
            this.pnlDataSiswa.Controls.Add(this.lblNamaTitle);
            this.pnlDataSiswa.Controls.Add(this.lblSectionSiswa);
            this.pnlDataSiswa.Location = new System.Drawing.Point(20, 133);
            this.pnlDataSiswa.Name = "pnlDataSiswa";
            this.pnlDataSiswa.Size = new System.Drawing.Size(840, 105);
            this.pnlDataSiswa.TabIndex = 1;
            // 
            // lblNis
            // 
            this.lblNis.AutoSize = true;
            this.lblNis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblNis.Location = new System.Drawing.Point(300, 65);
            this.lblNis.Name = "lblNis";
            this.lblNis.Size = new System.Drawing.Size(12, 15);
            this.lblNis.TabIndex = 4;
            this.lblNis.Text = "-";
            // 
            // lblNisStyle
            // 
            this.lblNisStyle.AutoSize = true;
            this.lblNisStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNisStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblNisStyle.Location = new System.Drawing.Point(300, 43);
            this.lblNisStyle.Name = "lblNisStyle";
            this.lblNisStyle.Size = new System.Drawing.Size(24, 13);
            this.lblNisStyle.TabIndex = 3;
            this.lblNisStyle.Text = "NIS";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(62)))), ((int)(((byte)(115)))));
            this.lblNama.Location = new System.Drawing.Point(18, 65);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(12, 15);
            this.lblNama.TabIndex = 2;
            this.lblNama.Text = "-";
            // 
            // lblNamaTitle
            // 
            this.lblNamaTitle.AutoSize = true;
            this.lblNamaTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblNamaTitle.Location = new System.Drawing.Point(18, 43);
            this.lblNamaTitle.Name = "lblNamaTitle";
            this.lblNamaTitle.Size = new System.Drawing.Size(68, 13);
            this.lblNamaTitle.TabIndex = 1;
            this.lblNamaTitle.Text = "Nama Siswa";
            // 
            // lblSectionSiswa
            // 
            this.lblSectionSiswa.AutoSize = true;
            this.lblSectionSiswa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectionSiswa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblSectionSiswa.Location = new System.Drawing.Point(18, 12);
            this.lblSectionSiswa.Name = "lblSectionSiswa";
            this.lblSectionSiswa.Size = new System.Drawing.Size(75, 17);
            this.lblSectionSiswa.TabIndex = 0;
            this.lblSectionSiswa.Text = "Data Siswa";
            // 
            // lblKelasTitle
            // 
            this.lblKelasTitle.AutoSize = true;
            this.lblKelasTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelasTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblKelasTitle.Location = new System.Drawing.Point(560, 43);
            this.lblKelasTitle.Name = "lblKelasTitle";
            this.lblKelasTitle.Size = new System.Drawing.Size(33, 13);
            this.lblKelasTitle.TabIndex = 5;
            this.lblKelasTitle.Text = "Kelas";
            // 
            // lblKelas
            // 
            this.lblKelas.AutoSize = true;
            this.lblKelas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblKelas.Location = new System.Drawing.Point(560, 65);
            this.lblKelas.Name = "lblKelas";
            this.lblKelas.Size = new System.Drawing.Size(12, 15);
            this.lblKelas.TabIndex = 6;
            this.lblKelas.Text = "-";
            // 
            // pnlDataIzin
            // 
            this.pnlDataIzin.BackColor = System.Drawing.Color.White;
            this.pnlDataIzin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDataIzin.Controls.Add(this.lblKembali);
            this.pnlDataIzin.Controls.Add(this.lblKembaliTitle);
            this.pnlDataIzin.Controls.Add(this.lblWaktu);
            this.pnlDataIzin.Controls.Add(this.lblWaktuTitle);
            this.pnlDataIzin.Controls.Add(this.lblJenis);
            this.pnlDataIzin.Controls.Add(this.lblJenisTitle);
            this.pnlDataIzin.Controls.Add(this.lblSectionIIzin);
            this.pnlDataIzin.Location = new System.Drawing.Point(20, 263);
            this.pnlDataIzin.Name = "pnlDataIzin";
            this.pnlDataIzin.Size = new System.Drawing.Size(840, 190);
            this.pnlDataIzin.TabIndex = 2;
            // 
            // lblSectionIIzin
            // 
            this.lblSectionIIzin.AutoSize = true;
            this.lblSectionIIzin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectionIIzin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblSectionIIzin.Location = new System.Drawing.Point(18, 12);
            this.lblSectionIIzin.Name = "lblSectionIIzin";
            this.lblSectionIIzin.Size = new System.Drawing.Size(106, 17);
            this.lblSectionIIzin.TabIndex = 0;
            this.lblSectionIIzin.Text = "Detail Perizinan";
            // 
            // lblKembali
            // 
            this.lblKembali.AutoSize = true;
            this.lblKembali.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKembali.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblKembali.Location = new System.Drawing.Point(560, 64);
            this.lblKembali.Name = "lblKembali";
            this.lblKembali.Size = new System.Drawing.Size(12, 15);
            this.lblKembali.TabIndex = 12;
            this.lblKembali.Text = "-";
            // 
            // lblKembaliTitle
            // 
            this.lblKembaliTitle.AutoSize = true;
            this.lblKembaliTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKembaliTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblKembaliTitle.Location = new System.Drawing.Point(560, 43);
            this.lblKembaliTitle.Name = "lblKembaliTitle";
            this.lblKembaliTitle.Size = new System.Drawing.Size(98, 13);
            this.lblKembaliTitle.TabIndex = 11;
            this.lblKembaliTitle.Text = "Perkiraan Kembali";
            // 
            // lblWaktu
            // 
            this.lblWaktu.AutoSize = true;
            this.lblWaktu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaktu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblWaktu.Location = new System.Drawing.Point(300, 64);
            this.lblWaktu.Name = "lblWaktu";
            this.lblWaktu.Size = new System.Drawing.Size(12, 15);
            this.lblWaktu.TabIndex = 10;
            this.lblWaktu.Text = "-";
            // 
            // lblWaktuTitle
            // 
            this.lblWaktuTitle.AutoSize = true;
            this.lblWaktuTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaktuTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblWaktuTitle.Location = new System.Drawing.Point(300, 43);
            this.lblWaktuTitle.Name = "lblWaktuTitle";
            this.lblWaktuTitle.Size = new System.Drawing.Size(62, 13);
            this.lblWaktuTitle.TabIndex = 9;
            this.lblWaktuTitle.Text = "Waktu Izin";
            // 
            // lblJenis
            // 
            this.lblJenis.AutoSize = true;
            this.lblJenis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJenis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(62)))), ((int)(((byte)(115)))));
            this.lblJenis.Location = new System.Drawing.Point(18, 64);
            this.lblJenis.Name = "lblJenis";
            this.lblJenis.Size = new System.Drawing.Size(12, 15);
            this.lblJenis.TabIndex = 8;
            this.lblJenis.Text = "-";
            // 
            // lblJenisTitle
            // 
            this.lblJenisTitle.AutoSize = true;
            this.lblJenisTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJenisTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblJenisTitle.Location = new System.Drawing.Point(18, 43);
            this.lblJenisTitle.Name = "lblJenisTitle";
            this.lblJenisTitle.Size = new System.Drawing.Size(53, 13);
            this.lblJenisTitle.TabIndex = 7;
            this.lblJenisTitle.Text = "Jenis Izin";
            // 
            // FormDetailTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1031, 740);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDetailTransaksi";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail Transaksi";
            this.Load += new System.EventHandler(this.FormDetailTransaksi_Load_1);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlDataSurat.ResumeLayout(false);
            this.pnlDataSurat.PerformLayout();
            this.pnlDataSiswa.ResumeLayout(false);
            this.pnlDataSiswa.PerformLayout();
            this.pnlDataIzin.ResumeLayout(false);
            this.pnlDataIzin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlDataIzin;
        private System.Windows.Forms.Label lblKembali;
        private System.Windows.Forms.Label lblKembaliTitle;
        private System.Windows.Forms.Label lblWaktu;
        private System.Windows.Forms.Label lblWaktuTitle;
        private System.Windows.Forms.Label lblJenis;
        private System.Windows.Forms.Label lblJenisTitle;
        private System.Windows.Forms.Label lblSectionIIzin;
        private System.Windows.Forms.Panel pnlDataSiswa;
        private System.Windows.Forms.Label lblKelas;
        private System.Windows.Forms.Label lblKelasTitle;
        private System.Windows.Forms.Label lblNis;
        private System.Windows.Forms.Label lblNisStyle;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblNamaTitle;
        private System.Windows.Forms.Label lblSectionSiswa;
        private System.Windows.Forms.Panel pnlDataSurat;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.Label lblNomorSurat;
        private System.Windows.Forms.Label lblNomorSuratTitle;
        private System.Windows.Forms.Label lblSectionSurat;
    }
}