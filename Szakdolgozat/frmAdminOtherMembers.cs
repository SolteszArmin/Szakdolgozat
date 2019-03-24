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
using System.IO;

namespace Szakdolgozat
{
    public partial class frmAdminOtherMembers : Form
    {
        MySqlConnection conn;
        private bool mouseDown;
        private Point lastLocation;

        public frmAdminOtherMembers(MySqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            dgvFill();
        }

        private void dgvFill()
        {
            dgvAll.Rows.Clear();
            tbSearcher.Text = "";
            conn.Open();
            var cmd = new MySqlCommand("SELECT kep,Fid,Sznev,Fnev,FszulDatum,Femail,Ftel,Onev,evfolyamok " +
                "FROM (((((felhasznalo " +
                "INNER JOIN osztalyevfolyam ON osztalyevfolyam.id=felhasznalo.Oid) " +
                "INNER JOIN evfolyam ON osztalyevfolyam.Evfid=evfolyam.id) " +
                "INNER JOIN osztaly ON osztalyevfolyam.Oid=osztaly.Oid) " +
                "INNER JOIN profilkep ON felhasznalo.kepId=profilkep.id)" +
                "INNER JOIN szintek ON felhasznalo.Szid=szintek.Szid)" +
                "ORDER BY FiD ASC",conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                byte[] img = (byte[])reader[0];
                MemoryStream ms = new MemoryStream(img);

                dgvAll.Rows.Add
                    (
                        Image.FromStream(ms),
                        reader[1].ToString(),
                        reader[2].ToString(),
                        reader[3].ToString(),
                       DateTime.Parse( reader[4].ToString()).ToString("yyyy-MM-dd"),
                        (reader[5].ToString() == "") ? "-" : reader[5].ToString(),
                        (reader[6].ToString() == "") ? "-" : reader[6].ToString(),
                        reader[7].ToString(),
                        reader[8].ToString()
                    );
            }
            conn.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void tbSearcher_TextChanged(object sender, EventArgs e)
        {
            if (rbNev.Checked)
            {
                dgvAll.Rows.Clear();
                conn.Open();
                var cmd = new MySqlCommand("SELECT kep,Fid,Sznev,Fnev,FszulDatum,Femail,Ftel,Onev,evfolyamok " +
                    "FROM (((((felhasznalo " +
                    "INNER JOIN osztalyevfolyam ON osztalyevfolyam.id=felhasznalo.Oid) " +
                    "INNER JOIN evfolyam ON osztalyevfolyam.Evfid=evfolyam.id) " +
                    "INNER JOIN osztaly ON osztalyevfolyam.Oid=osztaly.Oid) " +
                    "INNER JOIN profilkep ON felhasznalo.kepId=profilkep.id)" +
                    "INNER JOIN szintek ON felhasznalo.Szid=szintek.Szid) " +
                    $"WHERE Fnev LIKE '{tbSearcher.Text}%' " +
                    $"ORDER BY FiD ASC", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    byte[] img = (byte[])reader[0];
                    MemoryStream ms = new MemoryStream(img);
                    dgvAll.Rows.Add
                        (
                            Image.FromStream(ms),
                            reader[1].ToString(),
                            reader[2].ToString(),
                            reader[3].ToString(),
                            DateTime.Parse(reader[4].ToString()).ToShortDateString(),
                            (reader[5].ToString() == "") ? "-" : reader[5].ToString(),
                            (reader[6].ToString() == "") ? "-" : reader[6].ToString(),
                            reader[7].ToString(),
                            reader[8].ToString()
                        );
                    
                }
                conn.Close();

            }
            else
            {
                dgvAll.Rows.Clear();
                conn.Open();
                var cmd = new MySqlCommand("SELECT kep,Fid,Sznev,Fnev,FszulDatum,Femail,Ftel,Onev,evfolyamok " +
                    "FROM (((((felhasznalo " +
                    "INNER JOIN osztalyevfolyam ON osztalyevfolyam.id=felhasznalo.Oid) " +
                    "INNER JOIN evfolyam ON osztalyevfolyam.Evfid=evfolyam.id) " +
                    "INNER JOIN osztaly ON osztalyevfolyam.Oid=osztaly.Oid) " +
                    "INNER JOIN profilkep ON felhasznalo.kepId=profilkep.id)" +
                    "INNER JOIN szintek ON felhasznalo.Szid=szintek.Szid) " +
                    $"WHERE Sznev LIKE '{tbSearcher.Text}%' " +
                    $"ORDER BY FiD ASC", conn);
                var reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    byte[] img = (byte[])reader[0];
                    MemoryStream ms = new MemoryStream(img);

                    dgvAll.Rows.Add
                        (
                            Image.FromStream(ms),
                            reader[1].ToString(),
                            reader[2].ToString(),
                            reader[3].ToString(),
                            DateTime.Parse(reader[4].ToString()).ToShortDateString(),
                            (reader[5].ToString() =="") ? "-" : reader[5].ToString(),
                            (reader[6].ToString() =="") ? "-" : reader[6].ToString(),
                            reader[7].ToString(),
                            reader[8].ToString()
                        );

                }
                conn.Close();
            }
            
        }

        private void dgvAll_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Fid = dgvAll.SelectedRows[0].Cells[1].Value.ToString();

            var frm = new frmAdminMemberUpdate(Fid, conn);
            frm.ShowDialog();
            dgvFill();
        }
    }
}
