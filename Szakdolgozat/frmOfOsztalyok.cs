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
    public partial class frmOfOsztalyok : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        string fRank;
        string fId;
        string oEvfId;
        bool tanitott;

        MySqlConnection conn;
        public frmOfOsztalyok(MySqlConnection conn,string fRank,string fId,bool tanitott)
        {
            this.conn = conn;
            this.fRank = fRank;
            this.fId = fId;
            this.tanitott = tanitott;
            InitializeComponent();
            dgvFill();
        }

        private void dgvFill()
        {
            dgvOsztalyok.Rows.Clear();

            if (fRank == "2" && tanitott == false)
            {
                var cmd = new MySqlCommand("SELECT osztalyevfolyam.id,Onev,evfolyamok FROM (((felhasznalo " +
                    "INNER JOIN osztalyevfolyam ON osztalyevfolyam.OfoId=Fid) " +
                    "INNER JOIN osztaly ON osztalyevfolyam.Oid=osztaly.Oid) " +
                    "INNER JOIN evfolyam ON evfolyam.id=Evfid) " +
                    $"WHERE OfoId={fId} " +
                    $"ORDER BY evfolyamok DESC", conn);
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dgvOsztalyok.Rows.Add
                        (
                            reader[0].ToString(),
                            reader[1].ToString(),
                            reader[2].ToString()
                        );
                }
                conn.Close();
            }
            else
            {
                label3.Text = "Tanított osztályok";
                var cmd = new MySqlCommand("SELECT osztalyevfolyam.id,osztaly.Onev,evfolyam.evfolyamok FROM (((osztalyevfolyam  " +
                    "INNER JOIN tanit ON tanit.Oid=osztalyevfolyam.id) " +
                    "INNER JOIN evfolyam ON evfolyam.id=osztalyevfolyam.Evfid) " +
                    "INNER JOIN osztaly ON osztaly.Oid=osztalyevfolyam.Oid) " +
                    $"WHERE tanit.Fid={fId} " +
                    "ORDER BY evfolyam.evfolyamok DESC", conn);
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dgvOsztalyok.Rows.Add
                        (
                            reader[0].ToString(),
                            reader[1].ToString(),
                            reader[2].ToString()
                        );
                }
                conn.Close();
            }
            
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

        private void tbKereses_TextChanged(object sender, EventArgs e)
        {

            dgvOsztalyok.Rows.Clear();

            if (fRank == "2" && tanitott == false)
            {
                var cmd = new MySqlCommand("SELECT osztalyevfolyam.id,Onev,evfolyamok FROM (((felhasznalo " +
                    "INNER JOIN osztalyevfolyam ON osztalyevfolyam.OfoId=Fid) " +
                    "INNER JOIN osztaly ON osztalyevfolyam.Oid=osztaly.Oid) " +
                    "INNER JOIN evfolyam ON evfolyam.id=Evfid) " +
                    $"WHERE OfoId={fId} AND Onev LIKE '{tbKereses.Text}%'" +
                    $"ORDER BY evfolyamok DESC", conn);
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dgvOsztalyok.Rows.Add
                        (
                            reader[0].ToString(),
                            reader[1].ToString(),
                            reader[2].ToString()
                        );
                }
                conn.Close();
            }
            else
            {
                label3.Text = "Tanított osztályok";
                var cmd = new MySqlCommand("SELECT osztalyevfolyam.id,osztaly.Onev,evfolyam.evfolyamok FROM (((osztalyevfolyam  " +
                    "INNER JOIN tanit ON tanit.Oid=osztalyevfolyam.id) " +
                    "INNER JOIN evfolyam ON evfolyam.id=osztalyevfolyam.Evfid) " +
                    "INNER JOIN osztaly ON osztaly.Oid=osztalyevfolyam.Oid) " +
                    $"WHERE tanit.Fid={fId} " +
                    $"AND Onev LIKE '{tbKereses.Text}%' " +
                    "ORDER BY evfolyam.evfolyamok DESC", conn);
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dgvOsztalyok.Rows.Add
                        (
                            reader[0].ToString(),
                            reader[1].ToString(),
                            reader[2].ToString()
                        );
                }
                conn.Close();
            }
            
        }

        private void dgvOsztalyok_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            oEvfId = dgvOsztalyok.SelectedRows[0].Cells[0].Value.ToString();
            var frm = new frmOfOsztaly(conn, oEvfId,fRank);
            frm.ShowDialog();
            dgvFill();
        }
    }
}
