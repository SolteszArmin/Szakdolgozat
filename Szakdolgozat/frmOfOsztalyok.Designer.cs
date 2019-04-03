namespace Szakdolgozat
{
    partial class frmOfOsztalyok
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKereses = new System.Windows.Forms.TextBox();
            this.dgvOsztalyok = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsztalyok)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(475, 41);
            this.panel1.TabIndex = 8;
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
            this.btnMinimize.Location = new System.Drawing.Point(393, 0);
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
            this.label3.Size = new System.Drawing.Size(255, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Volt/Jelenelegi osztályok";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = global::Szakdolgozat.Properties.Resources.x_mark_16;
            this.btnClose.Location = new System.Drawing.Point(434, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 41);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Keresés:";
            // 
            // tbKereses
            // 
            this.tbKereses.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbKereses.Location = new System.Drawing.Point(108, 102);
            this.tbKereses.Name = "tbKereses";
            this.tbKereses.Size = new System.Drawing.Size(159, 26);
            this.tbKereses.TabIndex = 11;
            this.tbKereses.TextChanged += new System.EventHandler(this.tbKereses_TextChanged);
            // 
            // dgvOsztalyok
            // 
            this.dgvOsztalyok.AllowUserToAddRows = false;
            this.dgvOsztalyok.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.dgvOsztalyok.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOsztalyok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOsztalyok.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvOsztalyok.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dgvOsztalyok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOsztalyok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOsztalyok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOsztalyok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOsztalyok.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOsztalyok.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.dgvOsztalyok.Location = new System.Drawing.Point(16, 175);
            this.dgvOsztalyok.Name = "dgvOsztalyok";
            this.dgvOsztalyok.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOsztalyok.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOsztalyok.RowHeadersVisible = false;
            this.dgvOsztalyok.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dgvOsztalyok.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dgvOsztalyok.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOsztalyok.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.dgvOsztalyok.RowTemplate.Height = 24;
            this.dgvOsztalyok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOsztalyok.Size = new System.Drawing.Size(444, 263);
            this.dgvOsztalyok.TabIndex = 12;
            this.dgvOsztalyok.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOsztalyok_CellDoubleClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "oEvfId";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Osztály";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Évfolyam";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(60, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Dupla kattintással nézheti meg az osztályt.";
            // 
            // frmOfOsztalyok
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvOsztalyok);
            this.Controls.Add(this.tbKereses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOfOsztalyok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOsztalyom";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsztalyok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKereses;
        private System.Windows.Forms.DataGridView dgvOsztalyok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label2;
    }
}