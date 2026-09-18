
namespace KemasProject
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lblJudul = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pnlFeature1 = new System.Windows.Forms.Panel();
            this.lblFeature1 = new System.Windows.Forms.Label();
            this.lblFeatureDesc1 = new System.Windows.Forms.Label();
            this.pnlFeature2 = new System.Windows.Forms.Panel();
            this.lblFeature2 = new System.Windows.Forms.Label();
            this.lblFeatureDesk2 = new System.Windows.Forms.Label();
            this.pnlFeature3 = new System.Windows.Forms.Panel();
            this.lblFeature3 = new System.Windows.Forms.Label();
            this.lblFeatureDesk3 = new System.Windows.Forms.Label();
            this.pnlLoginCard = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblFooterLogin = new System.Windows.Forms.Label();
            this.pnlFooter.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlFeature1.SuspendLayout();
            this.pnlFeature2.SuspendLayout();
            this.pnlFeature3.SuspendLayout();
            this.pnlLoginCard.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Location = new System.Drawing.Point(304, 124);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(254, 13);
            this.lblJudul.TabIndex = 1;
            this.lblJudul.Text = "SISTEM SURAT IZIN MASUK & KELUAR SEKOLAH";
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lblVersion);
            this.pnlFooter.Controls.Add(this.lblCopyright);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 616);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1184, 45);
            this.pnlFooter.TabIndex = 1;
            // 
            // lblVersion
            // 
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(1070, 13);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(100, 20);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Versi 1.0.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(25, 13);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(260, 13);
            this.lblCopyright.TabIndex = 0;
            this.lblCopyright.Text = "© 2026 SMK TI Pembangunan. All rights reserved.";
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlLoginCard);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(520, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(664, 616);
            this.pnlRight.TabIndex = 2;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlLeft.Controls.Add(this.pnlFeature3);
            this.pnlLeft.Controls.Add(this.pnlFeature2);
            this.pnlLeft.Controls.Add(this.pnlFeature1);
            this.pnlLeft.Controls.Add(this.lblDescription);
            this.pnlLeft.Controls.Add(this.lblTitle2);
            this.pnlLeft.Controls.Add(this.lblTitle);
            this.pnlLeft.Controls.Add(this.picLogo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.ForeColor = System.Drawing.Color.White;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(520, 616);
            this.pnlLeft.TabIndex = 0;
            // 
            // lblTitle2
            // 
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.Location = new System.Drawing.Point(70, 253);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(400, 38);
            this.lblTitle2.TabIndex = 2;
            this.lblTitle2.Text = "KELUAR MASUK SEKOLAH";
            this.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(70, 215);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "SISTEM SURAT IZIN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::KemasProject.Properties.Resources.LOGO_KEMAS;
            this.picLogo.Location = new System.Drawing.Point(70, 75);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(110, 110);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(70, 315);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(380, 55);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Kelola perizinan siswa secara mudah, terstruktur, dan terintegrasi dengan sistem " +
    "sekolah.";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFeature1
            // 
            this.pnlFeature1.Controls.Add(this.lblFeatureDesc1);
            this.pnlFeature1.Controls.Add(this.lblFeature1);
            this.pnlFeature1.Location = new System.Drawing.Point(70, 405);
            this.pnlFeature1.Name = "pnlFeature1";
            this.pnlFeature1.Size = new System.Drawing.Size(380, 55);
            this.pnlFeature1.TabIndex = 4;
            // 
            // lblFeature1
            // 
            this.lblFeature1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeature1.Location = new System.Drawing.Point(0, 0);
            this.lblFeature1.Name = "lblFeature1";
            this.lblFeature1.Size = new System.Drawing.Size(380, 23);
            this.lblFeature1.TabIndex = 0;
            this.lblFeature1.Text = "✔ DATA TERSTRUKTUR";
            // 
            // lblFeatureDesc1
            // 
            this.lblFeatureDesc1.BackColor = System.Drawing.Color.Transparent;
            this.lblFeatureDesc1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeatureDesc1.Location = new System.Drawing.Point(0, 24);
            this.lblFeatureDesc1.Name = "lblFeatureDesc1";
            this.lblFeatureDesc1.Size = new System.Drawing.Size(380, 25);
            this.lblFeatureDesc1.TabIndex = 1;
            this.lblFeatureDesc1.Text = "Data izin tersimpan dengan rapih";
            // 
            // pnlFeature2
            // 
            this.pnlFeature2.BackColor = System.Drawing.Color.Transparent;
            this.pnlFeature2.Controls.Add(this.lblFeatureDesk2);
            this.pnlFeature2.Controls.Add(this.lblFeature2);
            this.pnlFeature2.Location = new System.Drawing.Point(70, 470);
            this.pnlFeature2.Name = "pnlFeature2";
            this.pnlFeature2.Size = new System.Drawing.Size(380, 55);
            this.pnlFeature2.TabIndex = 5;
            // 
            // lblFeature2
            // 
            this.lblFeature2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeature2.Location = new System.Drawing.Point(0, 0);
            this.lblFeature2.Name = "lblFeature2";
            this.lblFeature2.Size = new System.Drawing.Size(380, 23);
            this.lblFeature2.TabIndex = 0;
            this.lblFeature2.Text = "✔ PROSES TERINTEGRASI";
            // 
            // lblFeatureDesk2
            // 
            this.lblFeatureDesk2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeatureDesk2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFeatureDesk2.Location = new System.Drawing.Point(0, 24);
            this.lblFeatureDesk2.Name = "lblFeatureDesk2";
            this.lblFeatureDesk2.Size = new System.Drawing.Size(380, 25);
            this.lblFeatureDesk2.TabIndex = 1;
            this.lblFeatureDesk2.Text = "Pengelolaan izin menjadi lebih mudah";
            // 
            // pnlFeature3
            // 
            this.pnlFeature3.Controls.Add(this.lblFeatureDesk3);
            this.pnlFeature3.Controls.Add(this.lblFeature3);
            this.pnlFeature3.Location = new System.Drawing.Point(70, 535);
            this.pnlFeature3.Name = "pnlFeature3";
            this.pnlFeature3.Size = new System.Drawing.Size(380, 55);
            this.pnlFeature3.TabIndex = 6;
            // 
            // lblFeature3
            // 
            this.lblFeature3.AutoSize = true;
            this.lblFeature3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeature3.Location = new System.Drawing.Point(0, 0);
            this.lblFeature3.Name = "lblFeature3";
            this.lblFeature3.Size = new System.Drawing.Size(87, 15);
            this.lblFeature3.TabIndex = 7;
            this.lblFeature3.Text = "✔ HAK AKSES";
            // 
            // lblFeatureDesk3
            // 
            this.lblFeatureDesk3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeatureDesk3.Location = new System.Drawing.Point(0, 24);
            this.lblFeatureDesk3.Name = "lblFeatureDesk3";
            this.lblFeatureDesk3.Size = new System.Drawing.Size(380, 25);
            this.lblFeatureDesk3.TabIndex = 8;
            this.lblFeatureDesk3.Text = "Akses sistem sesuai peran pengguna";
            // 
            // pnlLoginCard
            // 
            this.pnlLoginCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLoginCard.Controls.Add(this.lblFooterLogin);
            this.pnlLoginCard.Controls.Add(this.btnLogin);
            this.pnlLoginCard.Controls.Add(this.chkRemember);
            this.pnlLoginCard.Controls.Add(this.pnlPassword);
            this.pnlLoginCard.Controls.Add(this.lblPassword);
            this.pnlLoginCard.Controls.Add(this.txtUsername);
            this.pnlLoginCard.Controls.Add(this.lblUsername);
            this.pnlLoginCard.Controls.Add(this.lblSubtitle);
            this.pnlLoginCard.Controls.Add(this.lblWelcome);
            this.pnlLoginCard.Location = new System.Drawing.Point(125, 75);
            this.pnlLoginCard.Name = "pnlLoginCard";
            this.pnlLoginCard.Size = new System.Drawing.Size(430, 500);
            this.pnlLoginCard.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(35, 40);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(360, 35);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Selamat Datang";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Location = new System.Drawing.Point(35, 78);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(360, 25);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Silahkan login untuk melanjutkan";
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(35, 125);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(360, 23);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(35, 150);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(360, 25);
            this.txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(35, 200);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(360, 23);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // pnlPassword
            // 
            this.pnlPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPassword.Controls.Add(this.btnShowPassword);
            this.pnlPassword.Controls.Add(this.txtPassword);
            this.pnlPassword.Location = new System.Drawing.Point(35, 225);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(360, 35);
            this.pnlPassword.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(5, 2);
            this.txtPassword.MaxLength = 100;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(315, 18);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPassword.FlatAppearance.BorderSize = 0;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPassword.Location = new System.Drawing.Point(322, 2);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(32, 29);
            this.btnShowPassword.TabIndex = 7;
            this.btnShowPassword.TabStop = false;
            this.btnShowPassword.Text = "●";
            this.btnShowPassword.UseVisualStyleBackColor = true;
            // 
            // chkRemember
            // 
            this.chkRemember.AutoSize = true;
            this.chkRemember.Location = new System.Drawing.Point(35, 280);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(80, 19);
            this.chkRemember.TabIndex = 6;
            this.chkRemember.Text = "Ingat Saya";
            this.chkRemember.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(35, 325);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(360, 44);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "MASUK";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblFooterLogin
            // 
            this.lblFooterLogin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooterLogin.Location = new System.Drawing.Point(35, 405);
            this.lblFooterLogin.Name = "lblFooterLogin";
            this.lblFooterLogin.Size = new System.Drawing.Size(360, 25);
            this.lblFooterLogin.TabIndex = 8;
            this.lblFooterLogin.Text = "KEMAS - Sistem Perizinan Sekolah";
            this.lblFooterLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlFooter);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem Surat Izin Masuk & Keluar Sekolah";
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlFeature1.ResumeLayout(false);
            this.pnlFeature2.ResumeLayout(false);
            this.pnlFeature3.ResumeLayout(false);
            this.pnlFeature3.PerformLayout();
            this.pnlLoginCard.ResumeLayout(false);
            this.pnlLoginCard.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlFeature1;
        private System.Windows.Forms.Label lblFeature1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel pnlLoginCard;
        private System.Windows.Forms.Label lblFooterLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlFeature3;
        private System.Windows.Forms.Label lblFeatureDesk3;
        private System.Windows.Forms.Label lblFeature3;
        private System.Windows.Forms.Panel pnlFeature2;
        private System.Windows.Forms.Label lblFeatureDesk2;
        private System.Windows.Forms.Label lblFeature2;
        private System.Windows.Forms.Label lblFeatureDesc1;
    }
}