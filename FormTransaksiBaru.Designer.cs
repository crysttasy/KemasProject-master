
namespace KemasProject
{
    partial class FormTransaksiBaru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransaksiBaru));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.lblKeterangan = new System.Windows.Forms.Label();
            this.txtKeperluan = new System.Windows.Forms.TextBox();
            this.lblKeperluan = new System.Windows.Forms.Label();
            this.dtpPerkiraanKembali = new System.Windows.Forms.DateTimePicker();
            this.lblPerkiraanKembali = new System.Windows.Forms.Label();
            this.dtpWaktuIzin = new System.Windows.Forms.DateTimePicker();
            this.lblWaktuIzin = new System.Windows.Forms.Label();
            this.cmbJenisIzin = new System.Windows.Forms.ComboBox();
            this.lblJenisIzin = new System.Windows.Forms.Label();
            this.cmbSiswa = new System.Windows.Forms.ComboBox();
            this.lblSiswa = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(744, 82);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSubtitle.Location = new System.Drawing.Point(26, 47);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(208, 13);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Buat surat izin masuk atau keluar siswa";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(62)))), ((int)(((byte)(115)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(179, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tambah Transaksi";
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlContent.Controls.Add(this.pnlFooter);
            this.pnlContent.Controls.Add(this.pnlForm);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 82);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20, 18, 20, 10);
            this.pnlContent.Size = new System.Drawing.Size(744, 499);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnSimpan);
            this.pnlFooter.Controls.Add(this.btnBatal);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(20, 425);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(704, 64);
            this.pnlFooter.TabIndex = 1;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnSimpan.Location = new System.Drawing.Point(660, 15);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(85, 34);
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.White;
            this.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnBatal.Location = new System.Drawing.Point(570, 15);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(85, 34);
            this.btnBatal.TabIndex = 0;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlForm.Controls.Add(this.pictureBox1);
            this.pnlForm.Controls.Add(this.lblInfo);
            this.pnlForm.Controls.Add(this.txtKeterangan);
            this.pnlForm.Controls.Add(this.lblKeterangan);
            this.pnlForm.Controls.Add(this.txtKeperluan);
            this.pnlForm.Controls.Add(this.lblKeperluan);
            this.pnlForm.Controls.Add(this.dtpPerkiraanKembali);
            this.pnlForm.Controls.Add(this.lblPerkiraanKembali);
            this.pnlForm.Controls.Add(this.dtpWaktuIzin);
            this.pnlForm.Controls.Add(this.lblWaktuIzin);
            this.pnlForm.Controls.Add(this.cmbJenisIzin);
            this.pnlForm.Controls.Add(this.lblJenisIzin);
            this.pnlForm.Controls.Add(this.cmbSiswa);
            this.pnlForm.Controls.Add(this.lblSiswa);
            this.pnlForm.Location = new System.Drawing.Point(20, 18);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(680, 410);
            this.pnlForm.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 368);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInfo.Location = new System.Drawing.Point(42, 369);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(267, 13);
            this.lblInfo.TabIndex = 12;
            this.lblInfo.Text = "Status awal transaksi akan dibuat sebagai \"Menunggu\"";
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeterangan.Location = new System.Drawing.Point(24, 267);
            this.txtKeterangan.MaxLength = 255;
            this.txtKeterangan.Multiline = true;
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(632, 90);
            this.txtKeterangan.TabIndex = 11;
            // 
            // lblKeterangan
            // 
            this.lblKeterangan.AutoSize = true;
            this.lblKeterangan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeterangan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblKeterangan.Location = new System.Drawing.Point(24, 242);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(72, 15);
            this.lblKeterangan.TabIndex = 10;
            this.lblKeterangan.Text = "Keterangan";
            // 
            // txtKeperluan
            // 
            this.txtKeperluan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeperluan.Location = new System.Drawing.Point(350, 192);
            this.txtKeperluan.MaxLength = 255;
            this.txtKeperluan.Name = "txtKeperluan";
            this.txtKeperluan.Size = new System.Drawing.Size(306, 23);
            this.txtKeperluan.TabIndex = 9;
            // 
            // lblKeperluan
            // 
            this.lblKeperluan.AutoSize = true;
            this.lblKeperluan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeperluan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblKeperluan.Location = new System.Drawing.Point(350, 168);
            this.lblKeperluan.Name = "lblKeperluan";
            this.lblKeperluan.Size = new System.Drawing.Size(64, 15);
            this.lblKeperluan.TabIndex = 8;
            this.lblKeperluan.Text = "Keperluan";
            // 
            // dtpPerkiraanKembali
            // 
            this.dtpPerkiraanKembali.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpPerkiraanKembali.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPerkiraanKembali.Location = new System.Drawing.Point(24, 192);
            this.dtpPerkiraanKembali.Name = "dtpPerkiraanKembali";
            this.dtpPerkiraanKembali.Size = new System.Drawing.Size(306, 23);
            this.dtpPerkiraanKembali.TabIndex = 7;
            // 
            // lblPerkiraanKembali
            // 
            this.lblPerkiraanKembali.AutoSize = true;
            this.lblPerkiraanKembali.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerkiraanKembali.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblPerkiraanKembali.Location = new System.Drawing.Point(23, 168);
            this.lblPerkiraanKembali.Name = "lblPerkiraanKembali";
            this.lblPerkiraanKembali.Size = new System.Drawing.Size(108, 15);
            this.lblPerkiraanKembali.TabIndex = 6;
            this.lblPerkiraanKembali.Text = "Perkiraan Kembali";
            // 
            // dtpWaktuIzin
            // 
            this.dtpWaktuIzin.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpWaktuIzin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWaktuIzin.Location = new System.Drawing.Point(350, 119);
            this.dtpWaktuIzin.Name = "dtpWaktuIzin";
            this.dtpWaktuIzin.Size = new System.Drawing.Size(306, 23);
            this.dtpWaktuIzin.TabIndex = 5;
            // 
            // lblWaktuIzin
            // 
            this.lblWaktuIzin.AutoSize = true;
            this.lblWaktuIzin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaktuIzin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblWaktuIzin.Location = new System.Drawing.Point(350, 95);
            this.lblWaktuIzin.Name = "lblWaktuIzin";
            this.lblWaktuIzin.Size = new System.Drawing.Size(67, 15);
            this.lblWaktuIzin.TabIndex = 4;
            this.lblWaktuIzin.Text = "Waktu Izin";
            // 
            // cmbJenisIzin
            // 
            this.cmbJenisIzin.BackColor = System.Drawing.Color.White;
            this.cmbJenisIzin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cmbJenisIzin.FormattingEnabled = true;
            this.cmbJenisIzin.Location = new System.Drawing.Point(24, 119);
            this.cmbJenisIzin.Name = "cmbJenisIzin";
            this.cmbJenisIzin.Size = new System.Drawing.Size(300, 23);
            this.cmbJenisIzin.TabIndex = 3;
            // 
            // lblJenisIzin
            // 
            this.lblJenisIzin.AutoSize = true;
            this.lblJenisIzin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJenisIzin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblJenisIzin.Location = new System.Drawing.Point(24, 95);
            this.lblJenisIzin.Name = "lblJenisIzin";
            this.lblJenisIzin.Size = new System.Drawing.Size(57, 15);
            this.lblJenisIzin.TabIndex = 2;
            this.lblJenisIzin.Text = "Jenis Izin";
            // 
            // cmbSiswa
            // 
            this.cmbSiswa.BackColor = System.Drawing.Color.White;
            this.cmbSiswa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cmbSiswa.FormattingEnabled = true;
            this.cmbSiswa.Location = new System.Drawing.Point(24, 46);
            this.cmbSiswa.Name = "cmbSiswa";
            this.cmbSiswa.Size = new System.Drawing.Size(632, 23);
            this.cmbSiswa.TabIndex = 1;
            // 
            // lblSiswa
            // 
            this.lblSiswa.AutoSize = true;
            this.lblSiswa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiswa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblSiswa.Location = new System.Drawing.Point(24, 22);
            this.lblSiswa.Name = "lblSiswa";
            this.lblSiswa.Size = new System.Drawing.Size(38, 15);
            this.lblSiswa.TabIndex = 0;
            this.lblSiswa.Text = "Siswa";
            // 
            // FormTransaksiBaru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(744, 581);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTransaksiBaru";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah Transaksi";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.DateTimePicker dtpPerkiraanKembali;
        private System.Windows.Forms.Label lblPerkiraanKembali;
        private System.Windows.Forms.DateTimePicker dtpWaktuIzin;
        private System.Windows.Forms.Label lblWaktuIzin;
        private System.Windows.Forms.ComboBox cmbJenisIzin;
        private System.Windows.Forms.Label lblJenisIzin;
        private System.Windows.Forms.ComboBox cmbSiswa;
        private System.Windows.Forms.Label lblSiswa;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.Label lblKeterangan;
        private System.Windows.Forms.TextBox txtKeperluan;
        private System.Windows.Forms.Label lblKeperluan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
    }
}