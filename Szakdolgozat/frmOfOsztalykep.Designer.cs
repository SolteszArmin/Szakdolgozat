namespace Szakdolgozat
{
    partial class frmOfOsztalykep
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
            this.pbOsztalyKep = new System.Windows.Forms.PictureBox();
            this.btnOsztalykepPlus = new System.Windows.Forms.Button();
            this.btnOsztalykepTorles = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.ofdImgUpload = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOsztalyKep)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1030, 41);
            this.panel1.TabIndex = 7;
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
            this.btnMinimize.Location = new System.Drawing.Point(948, 0);
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
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Osztálykép";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = global::Szakdolgozat.Properties.Resources.x_mark_16;
            this.btnClose.Location = new System.Drawing.Point(989, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 41);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbOsztalyKep
            // 
            this.pbOsztalyKep.Location = new System.Drawing.Point(12, 62);
            this.pbOsztalyKep.Name = "pbOsztalyKep";
            this.pbOsztalyKep.Size = new System.Drawing.Size(767, 490);
            this.pbOsztalyKep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOsztalyKep.TabIndex = 8;
            this.pbOsztalyKep.TabStop = false;
            // 
            // btnOsztalykepPlus
            // 
            this.btnOsztalykepPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOsztalykepPlus.Location = new System.Drawing.Point(790, 121);
            this.btnOsztalykepPlus.Name = "btnOsztalykepPlus";
            this.btnOsztalykepPlus.Size = new System.Drawing.Size(228, 47);
            this.btnOsztalykepPlus.TabIndex = 9;
            this.btnOsztalykepPlus.Text = "Kép hozzáadása";
            this.btnOsztalykepPlus.UseVisualStyleBackColor = true;
            this.btnOsztalykepPlus.Click += new System.EventHandler(this.btnOsztalykepPlus_Click);
            // 
            // btnOsztalykepTorles
            // 
            this.btnOsztalykepTorles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOsztalykepTorles.Location = new System.Drawing.Point(790, 206);
            this.btnOsztalykepTorles.Name = "btnOsztalykepTorles";
            this.btnOsztalykepTorles.Size = new System.Drawing.Size(228, 47);
            this.btnOsztalykepTorles.TabIndex = 9;
            this.btnOsztalykepTorles.Text = "Kép törlése";
            this.btnOsztalykepTorles.UseVisualStyleBackColor = true;
            this.btnOsztalykepTorles.Click += new System.EventHandler(this.btnOsztalykepTorles_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeft.Image = global::Szakdolgozat.Properties.Resources.arrow_88_32;
            this.btnLeft.Location = new System.Drawing.Point(790, 364);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(45, 45);
            this.btnLeft.TabIndex = 10;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRight.Image = global::Szakdolgozat.Properties.Resources.arrow_24_32;
            this.btnRight.Location = new System.Drawing.Point(790, 301);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(45, 45);
            this.btnRight.TabIndex = 11;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // ofdImgUpload
            // 
            this.ofdImgUpload.FileName = "openFileDialog1";
            // 
            // frmOfOsztalykep
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1030, 589);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnOsztalykepTorles);
            this.Controls.Add(this.btnOsztalykepPlus);
            this.Controls.Add(this.pbOsztalyKep);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOfOsztalykep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOfOsztalykep";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOsztalyKep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbOsztalyKep;
        private System.Windows.Forms.Button btnOsztalykepPlus;
        private System.Windows.Forms.Button btnOsztalykepTorles;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.OpenFileDialog ofdImgUpload;
    }
}