namespace Szakdolgozat
{
    partial class frmProfil
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbOsztaly = new System.Windows.Forms.Label();
            this.lbTelSzam = new System.Windows.Forms.Label();
            this.lbKor = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbRank = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbProfilom = new System.Windows.Forms.Label();
            this.pbProfilePicture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 41);
            this.panel1.TabIndex = 5;
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
            this.btnMinimize.Location = new System.Drawing.Point(677, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(41, 41);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Profil";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = global::Szakdolgozat.Properties.Resources.x_mark_16;
            this.btnClose.Location = new System.Drawing.Point(718, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 41);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbOsztaly
            // 
            this.lbOsztaly.AutoSize = true;
            this.lbOsztaly.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbOsztaly.Location = new System.Drawing.Point(447, 298);
            this.lbOsztaly.Name = "lbOsztaly";
            this.lbOsztaly.Size = new System.Drawing.Size(69, 21);
            this.lbOsztaly.TabIndex = 8;
            this.lbOsztaly.Text = "Osztály";
            // 
            // lbTelSzam
            // 
            this.lbTelSzam.AutoSize = true;
            this.lbTelSzam.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTelSzam.Location = new System.Drawing.Point(447, 263);
            this.lbTelSzam.Name = "lbTelSzam";
            this.lbTelSzam.Size = new System.Drawing.Size(73, 21);
            this.lbTelSzam.TabIndex = 9;
            this.lbTelSzam.Text = "Telszam";
            // 
            // lbKor
            // 
            this.lbKor.AutoSize = true;
            this.lbKor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbKor.Location = new System.Drawing.Point(447, 195);
            this.lbKor.Name = "lbKor";
            this.lbKor.Size = new System.Drawing.Size(36, 21);
            this.lbKor.TabIndex = 10;
            this.lbKor.Text = "Kor";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbEmail.Location = new System.Drawing.Point(447, 231);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(52, 21);
            this.lbEmail.TabIndex = 11;
            this.lbEmail.Text = "Email";
            // 
            // lbRank
            // 
            this.lbRank.AutoSize = true;
            this.lbRank.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbRank.Location = new System.Drawing.Point(447, 144);
            this.lbRank.Name = "lbRank";
            this.lbRank.Size = new System.Drawing.Size(51, 21);
            this.lbRank.TabIndex = 12;
            this.lbRank.Text = "Rank";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbName.Location = new System.Drawing.Point(447, 111);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(51, 23);
            this.lbName.TabIndex = 13;
            this.lbName.Text = "Név";
            // 
            // lbProfilom
            // 
            this.lbProfilom.AutoSize = true;
            this.lbProfilom.Location = new System.Drawing.Point(358, -20);
            this.lbProfilom.Name = "lbProfilom";
            this.lbProfilom.Size = new System.Drawing.Size(87, 23);
            this.lbProfilom.TabIndex = 7;
            this.lbProfilom.Text = "Profilom";
            // 
            // pbProfilePicture
            // 
            this.pbProfilePicture.Location = new System.Drawing.Point(16, 57);
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.Size = new System.Drawing.Size(397, 335);
            this.pbProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfilePicture.TabIndex = 6;
            this.pbProfilePicture.TabStop = false;
            // 
            // frmProfil
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(759, 413);
            this.Controls.Add(this.lbOsztaly);
            this.Controls.Add(this.lbTelSzam);
            this.Controls.Add(this.lbKor);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbRank);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbProfilom);
            this.Controls.Add(this.pbProfilePicture);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProfil";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbOsztaly;
        private System.Windows.Forms.Label lbTelSzam;
        private System.Windows.Forms.Label lbKor;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbRank;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbProfilom;
        private System.Windows.Forms.PictureBox pbProfilePicture;
    }
}