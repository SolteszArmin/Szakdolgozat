namespace Szakdolgozat
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.msItems = new System.Windows.Forms.MenuStrip();
            this.tsmProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProfilModositas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMasProfilModositas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOsztalyok = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOsztalyom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTanitottOsztalyok = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTanaraink = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timerProfile = new System.Windows.Forms.Timer(this.components);
            this.panelSlide = new System.Windows.Forms.Panel();
            this.btnModositas = new System.Windows.Forms.Button();
            this.lbOsztaly = new System.Windows.Forms.Label();
            this.lbTelSzam = new System.Windows.Forms.Label();
            this.lbKor = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbRank = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbProfilom = new System.Windows.Forms.Label();
            this.pbProfilePicture = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.pbOsztalyKep = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.msItems.SuspendLayout();
            this.panelSlide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOsztalyKep)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 41);
            this.panel1.TabIndex = 10;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.Image = global::Szakdolgozat.Properties.Resources.minus_16;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.Location = new System.Drawing.Point(751, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(41, 41);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Fő Form";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = global::Szakdolgozat.Properties.Resources.account_logout_24;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(792, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(165, 41);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Kijelentkezés";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.msItems);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 506);
            this.panel2.TabIndex = 11;
            // 
            // msItems
            // 
            this.msItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.msItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.msItems.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmProfile,
            this.tsmOptions});
            this.msItems.Location = new System.Drawing.Point(0, 0);
            this.msItems.Name = "msItems";
            this.msItems.Size = new System.Drawing.Size(50, 506);
            this.msItems.TabIndex = 0;
            this.msItems.Text = "menuStrip1";
            // 
            // tsmProfile
            // 
            this.tsmProfile.ForeColor = System.Drawing.Color.White;
            this.tsmProfile.Image = global::Szakdolgozat.Properties.Resources.user_32;
            this.tsmProfile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmProfile.Name = "tsmProfile";
            this.tsmProfile.Size = new System.Drawing.Size(37, 36);
            this.tsmProfile.Click += new System.EventHandler(this.tsmProfile_Click);
            // 
            // tsmOptions
            // 
            this.tsmOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.tsmOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmProfilModositas,
            this.tsmMasProfilModositas,
            this.tsmOsztalyok,
            this.tsmOsztalyom,
            this.tsmTanitottOsztalyok,
            this.tsmTanaraink});
            this.tsmOptions.ForeColor = System.Drawing.Color.White;
            this.tsmOptions.Image = global::Szakdolgozat.Properties.Resources.menu_4_32;
            this.tsmOptions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmOptions.Name = "tsmOptions";
            this.tsmOptions.Padding = new System.Windows.Forms.Padding(4, 30, 4, 0);
            this.tsmOptions.Size = new System.Drawing.Size(37, 66);
            // 
            // tsmProfilModositas
            // 
            this.tsmProfilModositas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.tsmProfilModositas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsmProfilModositas.ForeColor = System.Drawing.Color.White;
            this.tsmProfilModositas.Name = "tsmProfilModositas";
            this.tsmProfilModositas.Size = new System.Drawing.Size(237, 26);
            this.tsmProfilModositas.Text = "Saját Profil Módosítása";
            this.tsmProfilModositas.Click += new System.EventHandler(this.tsmProfilModositas_Click);
            // 
            // tsmMasProfilModositas
            // 
            this.tsmMasProfilModositas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.tsmMasProfilModositas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsmMasProfilModositas.ForeColor = System.Drawing.Color.White;
            this.tsmMasProfilModositas.Name = "tsmMasProfilModositas";
            this.tsmMasProfilModositas.Size = new System.Drawing.Size(237, 26);
            this.tsmMasProfilModositas.Text = "Más Profilok Beállítása";
            this.tsmMasProfilModositas.Click += new System.EventHandler(this.tsmMasProfilModositas_Click);
            // 
            // tsmOsztalyok
            // 
            this.tsmOsztalyok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.tsmOsztalyok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsmOsztalyok.ForeColor = System.Drawing.Color.White;
            this.tsmOsztalyok.Name = "tsmOsztalyok";
            this.tsmOsztalyok.Size = new System.Drawing.Size(237, 26);
            this.tsmOsztalyok.Text = "Osztályok";
            this.tsmOsztalyok.Click += new System.EventHandler(this.tsmOsztalyok_Click);
            // 
            // tsmOsztalyom
            // 
            this.tsmOsztalyom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.tsmOsztalyom.ForeColor = System.Drawing.Color.White;
            this.tsmOsztalyom.Name = "tsmOsztalyom";
            this.tsmOsztalyom.Size = new System.Drawing.Size(237, 26);
            this.tsmOsztalyom.Text = "Osztályom";
            this.tsmOsztalyom.Click += new System.EventHandler(this.frmOfOsztalyom_Click);
            // 
            // tsmTanitottOsztalyok
            // 
            this.tsmTanitottOsztalyok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.tsmTanitottOsztalyok.ForeColor = System.Drawing.Color.White;
            this.tsmTanitottOsztalyok.Name = "tsmTanitottOsztalyok";
            this.tsmTanitottOsztalyok.Size = new System.Drawing.Size(237, 26);
            this.tsmTanitottOsztalyok.Text = "Tanított Osztályok";
            this.tsmTanitottOsztalyok.Click += new System.EventHandler(this.tsmTanitottOsztalyok_Click);
            // 
            // tsmTanaraink
            // 
            this.tsmTanaraink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.tsmTanaraink.ForeColor = System.Drawing.Color.White;
            this.tsmTanaraink.Name = "tsmTanaraink";
            this.tsmTanaraink.Size = new System.Drawing.Size(237, 26);
            this.tsmTanaraink.Text = "Osztály Tanárai";
            this.tsmTanaraink.Click += new System.EventHandler(this.tsmTanaraink_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(923, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(34, 506);
            this.panel4.TabIndex = 13;
            // 
            // timerProfile
            // 
            this.timerProfile.Interval = 10;
            this.timerProfile.Tick += new System.EventHandler(this.timerOptions_Tick);
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panelSlide.Controls.Add(this.btnModositas);
            this.panelSlide.Controls.Add(this.lbOsztaly);
            this.panelSlide.Controls.Add(this.lbTelSzam);
            this.panelSlide.Controls.Add(this.lbKor);
            this.panelSlide.Controls.Add(this.lbEmail);
            this.panelSlide.Controls.Add(this.lbRank);
            this.panelSlide.Controls.Add(this.lbName);
            this.panelSlide.Controls.Add(this.lbProfilom);
            this.panelSlide.Controls.Add(this.pbProfilePicture);
            this.panelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlide.Location = new System.Drawing.Point(50, 41);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(365, 506);
            this.panelSlide.TabIndex = 14;
            // 
            // btnModositas
            // 
            this.btnModositas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnModositas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModositas.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModositas.ForeColor = System.Drawing.Color.White;
            this.btnModositas.Image = global::Szakdolgozat.Properties.Resources.edit_7_24;
            this.btnModositas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModositas.Location = new System.Drawing.Point(87, 454);
            this.btnModositas.Name = "btnModositas";
            this.btnModositas.Size = new System.Drawing.Size(115, 40);
            this.btnModositas.TabIndex = 3;
            this.btnModositas.Text = "Módosítás";
            this.btnModositas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModositas.UseVisualStyleBackColor = false;
            this.btnModositas.Click += new System.EventHandler(this.btnModositas_Click);
            // 
            // lbOsztaly
            // 
            this.lbOsztaly.AutoSize = true;
            this.lbOsztaly.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbOsztaly.Location = new System.Drawing.Point(16, 422);
            this.lbOsztaly.Name = "lbOsztaly";
            this.lbOsztaly.Size = new System.Drawing.Size(58, 19);
            this.lbOsztaly.TabIndex = 2;
            this.lbOsztaly.Text = "Osztály";
            // 
            // lbTelSzam
            // 
            this.lbTelSzam.AutoSize = true;
            this.lbTelSzam.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTelSzam.Location = new System.Drawing.Point(16, 387);
            this.lbTelSzam.Name = "lbTelSzam";
            this.lbTelSzam.Size = new System.Drawing.Size(60, 19);
            this.lbTelSzam.TabIndex = 2;
            this.lbTelSzam.Text = "Telszam";
            // 
            // lbKor
            // 
            this.lbKor.AutoSize = true;
            this.lbKor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbKor.Location = new System.Drawing.Point(16, 319);
            this.lbKor.Name = "lbKor";
            this.lbKor.Size = new System.Drawing.Size(30, 19);
            this.lbKor.TabIndex = 2;
            this.lbKor.Text = "Kor";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbEmail.Location = new System.Drawing.Point(16, 355);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 19);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "Email";
            // 
            // lbRank
            // 
            this.lbRank.AutoSize = true;
            this.lbRank.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbRank.Location = new System.Drawing.Point(16, 283);
            this.lbRank.Name = "lbRank";
            this.lbRank.Size = new System.Drawing.Size(44, 19);
            this.lbRank.TabIndex = 2;
            this.lbRank.Text = "Rank";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbName.Location = new System.Drawing.Point(16, 262);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(45, 21);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Név";
            // 
            // lbProfilom
            // 
            this.lbProfilom.AutoSize = true;
            this.lbProfilom.Location = new System.Drawing.Point(139, 3);
            this.lbProfilom.Name = "lbProfilom";
            this.lbProfilom.Size = new System.Drawing.Size(87, 23);
            this.lbProfilom.TabIndex = 1;
            this.lbProfilom.Text = "Profilom";
            // 
            // pbProfilePicture
            // 
            this.pbProfilePicture.Location = new System.Drawing.Point(67, 29);
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.Size = new System.Drawing.Size(234, 215);
            this.pbProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfilePicture.TabIndex = 0;
            this.pbProfilePicture.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Controls.Add(this.btnLeft);
            this.panel3.Controls.Add(this.btnRight);
            this.panel3.Controls.Add(this.pbOsztalyKep);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(415, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(508, 506);
            this.panel3.TabIndex = 15;
            // 
            // btnLeft
            // 
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeft.Image = global::Szakdolgozat.Properties.Resources.arrow_88_32;
            this.btnLeft.Location = new System.Drawing.Point(6, 257);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(45, 45);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRight.Image = global::Szakdolgozat.Properties.Resources.arrow_24_32;
            this.btnRight.Location = new System.Drawing.Point(6, 199);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(45, 45);
            this.btnRight.TabIndex = 1;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // pbOsztalyKep
            // 
            this.pbOsztalyKep.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbOsztalyKep.Location = new System.Drawing.Point(70, 0);
            this.pbOsztalyKep.Name = "pbOsztalyKep";
            this.pbOsztalyKep.Size = new System.Drawing.Size(438, 506);
            this.pbOsztalyKep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOsztalyKep.TabIndex = 0;
            this.pbOsztalyKep.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(957, 547);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelSlide);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.msItems.ResumeLayout(false);
            this.msItems.PerformLayout();
            this.panelSlide.ResumeLayout(false);
            this.panelSlide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbOsztalyKep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timerProfile;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.MenuStrip msItems;
        private System.Windows.Forms.ToolStripMenuItem tsmProfile;
        private System.Windows.Forms.ToolStripMenuItem tsmOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmProfilModositas;
        private System.Windows.Forms.ToolStripMenuItem tsmMasProfilModositas;
        private System.Windows.Forms.ToolStripMenuItem tsmOsztalyok;
        private System.Windows.Forms.Label lbOsztaly;
        private System.Windows.Forms.Label lbTelSzam;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbRank;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbProfilom;
        private System.Windows.Forms.PictureBox pbProfilePicture;
        private System.Windows.Forms.Button btnModositas;
        private System.Windows.Forms.Label lbKor;
        private System.Windows.Forms.ToolStripMenuItem tsmOsztalyom;
        private System.Windows.Forms.ToolStripMenuItem tsmTanitottOsztalyok;
        private System.Windows.Forms.ToolStripMenuItem tsmTanaraink;
        private System.Windows.Forms.PictureBox pbOsztalyKep;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
    }
}