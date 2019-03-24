namespace Szakdolgozat
{
    partial class frmProfilModosit
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pbProfilePicture = new System.Windows.Forms.PictureBox();
            this.btnModositas = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtSzulEv = new System.Windows.Forms.DateTimePicker();
            this.cbName = new System.Windows.Forms.CheckBox();
            this.cbEmail = new System.Windows.Forms.CheckBox();
            this.cbTel = new System.Windows.Forms.CheckBox();
            this.cbSzul = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ofdImgUpload = new System.Windows.Forms.OpenFileDialog();
            this.cbPicture = new System.Windows.Forms.CheckBox();
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
            this.panel1.Size = new System.Drawing.Size(833, 41);
            this.panel1.TabIndex = 4;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Profil Módosítása";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = global::Szakdolgozat.Properties.Resources.x_mark_16;
            this.btnClose.Location = new System.Drawing.Point(792, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 41);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Location = new System.Drawing.Point(508, 114);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(219, 32);
            this.tbName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Név:";
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Location = new System.Drawing.Point(508, 181);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(219, 32);
            this.tbEmail.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email:";
            // 
            // TbPhone
            // 
            this.TbPhone.Enabled = false;
            this.TbPhone.Location = new System.Drawing.Point(508, 249);
            this.TbPhone.Name = "TbPhone";
            this.TbPhone.Size = new System.Drawing.Size(219, 32);
            this.TbPhone.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefonszám:";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnUpload.Enabled = false;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Image = global::Szakdolgozat.Properties.Resources.upload_3_32;
            this.btnUpload.Location = new System.Drawing.Point(131, 471);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(55, 47);
            this.btnUpload.TabIndex = 9;
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pbProfilePicture
            // 
            this.pbProfilePicture.Location = new System.Drawing.Point(12, 47);
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.Size = new System.Drawing.Size(323, 408);
            this.pbProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfilePicture.TabIndex = 8;
            this.pbProfilePicture.TabStop = false;
            // 
            // btnModositas
            // 
            this.btnModositas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnModositas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModositas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModositas.ForeColor = System.Drawing.Color.White;
            this.btnModositas.Image = global::Szakdolgozat.Properties.Resources.edit_7_24;
            this.btnModositas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModositas.Location = new System.Drawing.Point(518, 497);
            this.btnModositas.Name = "btnModositas";
            this.btnModositas.Size = new System.Drawing.Size(147, 60);
            this.btnModositas.TabIndex = 7;
            this.btnModositas.Text = "Módosítás";
            this.btnModositas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModositas.UseVisualStyleBackColor = false;
            this.btnModositas.Click += new System.EventHandler(this.btnModositas_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Szül. év:";
            // 
            // dtSzulEv
            // 
            this.dtSzulEv.Enabled = false;
            this.dtSzulEv.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtSzulEv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSzulEv.Location = new System.Drawing.Point(508, 315);
            this.dtSzulEv.Name = "dtSzulEv";
            this.dtSzulEv.Size = new System.Drawing.Size(219, 32);
            this.dtSzulEv.TabIndex = 10;
            // 
            // cbName
            // 
            this.cbName.AutoSize = true;
            this.cbName.Location = new System.Drawing.Point(744, 121);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(18, 17);
            this.cbName.TabIndex = 11;
            this.cbName.UseVisualStyleBackColor = true;
            this.cbName.CheckedChanged += new System.EventHandler(this.cbName_CheckedChanged);
            // 
            // cbEmail
            // 
            this.cbEmail.AutoSize = true;
            this.cbEmail.Location = new System.Drawing.Point(744, 188);
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Size = new System.Drawing.Size(18, 17);
            this.cbEmail.TabIndex = 11;
            this.cbEmail.UseVisualStyleBackColor = true;
            this.cbEmail.CheckedChanged += new System.EventHandler(this.cbEmail_CheckedChanged);
            // 
            // cbTel
            // 
            this.cbTel.AutoSize = true;
            this.cbTel.Location = new System.Drawing.Point(744, 256);
            this.cbTel.Name = "cbTel";
            this.cbTel.Size = new System.Drawing.Size(18, 17);
            this.cbTel.TabIndex = 11;
            this.cbTel.UseVisualStyleBackColor = true;
            this.cbTel.CheckedChanged += new System.EventHandler(this.cbTel_CheckedChanged);
            // 
            // cbSzul
            // 
            this.cbSzul.AutoSize = true;
            this.cbSzul.Location = new System.Drawing.Point(744, 319);
            this.cbSzul.Name = "cbSzul";
            this.cbSzul.Size = new System.Drawing.Size(18, 17);
            this.cbSzul.TabIndex = 11;
            this.cbSzul.UseVisualStyleBackColor = true;
            this.cbSzul.CheckedChanged += new System.EventHandler(this.cbSzul_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(470, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kérem pipálja ki a módosítani kívánt adatokat!";
            // 
            // ofdImgUpload
            // 
            this.ofdImgUpload.FileName = "openFileDialog1";
            // 
            // cbPicture
            // 
            this.cbPicture.AutoSize = true;
            this.cbPicture.Location = new System.Drawing.Point(153, 540);
            this.cbPicture.Name = "cbPicture";
            this.cbPicture.Size = new System.Drawing.Size(18, 17);
            this.cbPicture.TabIndex = 11;
            this.cbPicture.UseVisualStyleBackColor = true;
            this.cbPicture.CheckedChanged += new System.EventHandler(this.cbPicture_CheckedChanged);
            // 
            // frmProfilModosit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(833, 569);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbSzul);
            this.Controls.Add(this.cbTel);
            this.Controls.Add(this.cbEmail);
            this.Controls.Add(this.cbPicture);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.dtSzulEv);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.pbProfilePicture);
            this.Controls.Add(this.btnModositas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProfilModosit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModositas;
        private System.Windows.Forms.PictureBox pbProfilePicture;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtSzulEv;
        private System.Windows.Forms.CheckBox cbName;
        private System.Windows.Forms.CheckBox cbEmail;
        private System.Windows.Forms.CheckBox cbTel;
        private System.Windows.Forms.CheckBox cbSzul;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog ofdImgUpload;
        private System.Windows.Forms.CheckBox cbPicture;
    }
}