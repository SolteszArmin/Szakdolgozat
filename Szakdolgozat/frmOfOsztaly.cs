using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Szakdolgozat
{
    public partial class frmOfOsztaly : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        MySqlConnection conn;
        string oEvfId;
        string fRank;
        bool tanarNezes = false;

        public frmOfOsztaly(MySqlConnection conn, string oEvfId,string Frank)
        {
            this.conn = conn;
            this.oEvfId = oEvfId;
            this.fRank = Frank;
            InitializeComponent();
            meretezes();
            dgvFill();
        }
        public frmOfOsztaly(MySqlConnection conn, string oEvfId, string Frank,bool tanarNezes)
        {
            this.conn = conn;
            this.oEvfId = oEvfId;
            this.fRank = Frank;
            this.tanarNezes = true;
            InitializeComponent();
            meretezes();
            dgvFillTanarok();
        }

        private void dgvFillTanarok()
        {
            label3.Text = "Osztály tanárai";
            dgvOsztaly.Rows.Clear();
            var cmd = new MySqlCommand("SELECT felhasznalo.Fid,Fnev FROM ((tanit " +
                "INNER JOIN felhasznalo ON felhasznalo.Fid=tanit.Fid) " +
                "INNER JOIN osztalyevfolyam ON osztalyevfolyam.id=tanit.Oid) " +
                $"WHERE osztalyevfolyam.Oid={oEvfId} " +
                $"ORDER BY Fnev ASC", conn);
            conn.Open();

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dgvOsztaly.Rows.Add
                    (
                        reader[0].ToString(),
                        reader[1].ToString()
                    );
            }

            conn.Close();
        }

        private void meretezes()
        {
            if (fRank == "4" || fRank == "3"||tanarNezes)
            {
                this.Height = 596;
            }
            else
            {
                this.Height = 691;
            }
        }

        private void dgvFill()
        {
            dgvOsztaly.Rows.Clear();

            var cmd = new MySqlCommand($"SELECT Fid,Fnev FROM felhasznalo WHERE Oid={oEvfId} " +
                $"ORDER BY Fnev ASC", conn);
            conn.Open();

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dgvOsztaly.Rows.Add
                    (
                        reader[0].ToString(),
                        reader[1].ToString()
                    );
            }

            conn.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

        }

        private void tbKeres_TextChanged(object sender, EventArgs e)
        {
            dgvOsztaly.Rows.Clear();

            var cmd = new MySqlCommand($"SELECT Fid,Fnev FROM felhasznalo " +
                $"WHERE Oid={oEvfId} AND Fnev LIKE '{tbKeres.Text}%' " +
                $"ORDER BY Fnev ASC", conn);
            conn.Open();

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dgvOsztaly.Rows.Add
                    (
                        reader[0].ToString(),
                        reader[1].ToString()
                    );
            }

            conn.Close();
        }

        private void dgvOsztaly_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string fId = dgvOsztaly.SelectedRows[0].Cells[0].Value.ToString();
            var frm = new frmProfil(conn, fId);
            frm.Show();

        }

        private void btnAddToOsztaly_Click(object sender, EventArgs e)
        {
            var frm = new frmOfOsztalyAdd(conn,oEvfId);
            frm.ShowDialog();
            dgvFill();
        }

        private void btnOsztalykepModositas_Click(object sender, EventArgs e)
        {
            var frm = new frmOfOsztalykep(conn, oEvfId);
            frm.ShowDialog();
        }
    }
}
