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
    public partial class frmProfil : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        MySqlConnection conn;
        string fId;

        public frmProfil(MySqlConnection conn,string fId)
        {
            this.conn = conn;
            this.fId = fId;
            InitializeComponent();
            profilFill();
        }

        private void profilFill()
        {
            var cmd = new MySqlCommand("SELECT kep,Fnev,Femail,Ftel,Onev,evfolyamok,FszulDatum,Sznev " +
                   "FROM (((((felhasznalo " +
                   "INNER JOIN profilkep ON felhasznalo.kepId=profilkep.id) " +
                   "INNER JOIN osztalyevfolyam ON osztalyevfolyam.id=felhasznalo.Oid) " +
                   "INNER JOIN evfolyam ON osztalyevfolyam.Evfid=evfolyam.id) " +
                   "INNER JOIN osztaly ON osztalyevfolyam.Oid=osztaly.Oid) " +
                   "INNER JOIN szintek ON felhasznalo.Szid=szintek.Szid) " +
                   $"WHERE felhasznalo.Fid = {fId}", conn);
            conn.Open();
            var reader = cmd.ExecuteReader();

            reader.Read();
            byte[] img = (byte[])reader[0];

            MemoryStream ms = new MemoryStream(img);

            pbProfilePicture.Image = Image.FromStream(ms);

            string email = (reader[2].ToString() == "") ? "-" : reader[2].ToString();
            string telszam = (reader[3].ToString() == "") ? "-" : reader[3].ToString();

            lbName.Text = reader[1].ToString();
            lbEmail.Text = "Email: " + email;
            lbTelSzam.Text = "Telszam: " + telszam;
            lbOsztaly.Text = "Osztály: " + reader[4].ToString() + "   " + reader[5].ToString();
            lbKor.Text = DateTime.Parse(reader[6].ToString()).ToString("yyyy-MM-dd");
            lbRank.Text = reader[7].ToString();

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
    }
}
