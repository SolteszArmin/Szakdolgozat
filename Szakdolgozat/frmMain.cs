using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Szakdolgozat
{
    public partial class frmMain : Form
    {
        MySqlConnection conn;

        int Frank;
        string Fid;
        string Oid;

        private bool mouseDown;
        private Point lastLocation;

        int panelWidth;
        bool hidden;
        int pbWidth;
        int pNum;

        List<Image> imgList;

        public frmMain(MySqlConnection conn, int Frank, string Fid,string Oid)
        {

            this.conn = conn;
            this.Frank = Frank;
            this.Fid = Fid;
            this.Oid = Oid;

            InitializeComponent();
            
            
            ProfilUpload();
            profilRanking();
            pbFill();
            panelWidth = panelSlide.Width;
            pbWidth = pbOsztalyKep.Width;
            hidden = false;

            
            
        }

        private void pbFill()
        {
            imgList = new List<Image>();

            imgList.Clear();
            var cmd = new MySqlCommand("SELECT osztalyKep FROM osztalykep " +
                "INNER JOIN osztalyevfolyam  ON osztalykep.Oid=osztalyevfolyam.id " +
                $"WHERE osztalykep.Oid={Oid} " +
                $"ORDER BY osztalykep.id DESC", conn);
            conn.Open();
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    byte[] img = (byte[])reader[0];

                    MemoryStream ms = new MemoryStream(img);
                    imgList.Add(Image.FromStream(ms));

                }

                pbOsztalyKep.Image = imgList[0];
            }
            else
            {
                btnLeft.Visible = false;
                btnRight.Visible = false;
                pbOsztalyKep.Visible = false;
            }
            conn.Close();
            pNum = 0;
        }

        private void profilRanking()
        {

            if (Frank==4)
            {
                
                tsmMasProfilModositas.Visible = false;
                tsmOsztalyok.Visible = false;
                tsmTanitottOsztalyok.Visible = false;
            }
            else if (Frank==3)
            {
                tsmMasProfilModositas.Visible = false;
                tsmOsztalyok.Visible = false;
                tsmTanaraink.Visible = false;
                tsmOsztalyom.Visible = false;
                btnLeft.Visible = false;
                btnRight.Visible = false;
            }
            else if (Frank==2)
            {
                tsmMasProfilModositas.Visible = false;
                tsmOsztalyok.Visible = false;
                tsmTanaraink.Visible = false;
            }
            else
            {
                    btnLeft.Visible = false;
                    btnRight.Visible = false;
                    tsmOsztalyom.Visible = false;
                    tsmTanaraink.Visible = false;
                    tsmTanitottOsztalyok.Visible = false;
            }
        }

        private void ProfilUpload()
        {
            if (Oid!="1")
            {
                var cmd = new MySqlCommand("SELECT kep,Fnev,Femail,Ftel,Onev,evfolyamok,FszulDatum " +
                    "FROM ((((felhasznalo " +
                    "INNER JOIN profilkep ON felhasznalo.kepId=profilkep.id) " +
                    "INNER JOIN osztalyevfolyam ON osztalyevfolyam.id=felhasznalo.Oid) " +
                    "INNER JOIN evfolyam ON osztalyevfolyam.Evfid=evfolyam.id) " +
                    "INNER JOIN osztaly ON osztalyevfolyam.Oid=osztaly.Oid) " +
                    $"WHERE felhasznalo.Fid = {Fid}", conn);
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
                lbOsztaly.Text = "Osztály: "+reader[4].ToString() + "   " + reader[5].ToString();
                lbKor.Text = DateTime.Parse(reader[6].ToString()).ToString("yyyy-MM-dd");

                conn.Close();
            }
            else
            {
                var cmd = new MySqlCommand("SELECT kep,Fnev,Femail,Ftel,FszulDatum " +
                "FROM felhasznalo " +
                "INNER JOIN profilkep ON felhasznalo.kepId=profilkep.id "+
                $"WHERE felhasznalo.Fid = {Fid}", conn);
                conn.Open();
                var reader = cmd.ExecuteReader();

                reader.Read();
                byte[] img = (byte[])reader[0];

                MemoryStream ms = new MemoryStream(img);

                pbProfilePicture.Image = Image.FromStream(ms);

                string email = (reader[2].ToString() == "") ? "-" : reader[2].ToString();
                string telszam = (reader[3].ToString() == "") ? "-" : reader[3].ToString();

                lbName.Text = reader[1].ToString();
                lbEmail.Text = "Email: "+email;
                lbTelSzam.Text = "Telszam: "+telszam;
                lbOsztaly.Text = "Osztály: -";
                lbKor.Text ="Szül. év: "+DateTime.Parse(reader[4].ToString()).ToString("yyyy-MM-dd");

                conn.Close();
            }

            
            if (Frank==1)
            {
                lbRank.Text = "Admin";
            }
            else if (Frank==2)
            {
                lbRank.Text = "Osztályfőnök";
            }
            else if (Frank==3)
            {
                lbRank.Text = "Tanár";
            }
            else
            {
                lbRank.Text = "Diák";
            }

            if (Oid!="1")
            {
                pbFill();
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

        private void timerOptions_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                panelSlide.Width = panelSlide.Width + 10;
                pbOsztalyKep.Width = pbOsztalyKep.Width - 10;
                if (panelSlide.Width>=panelWidth)
                {
                    timerProfile.Stop();
                    hidden = false;
                    this.Refresh();
                }
            }
            else
            {

                pbOsztalyKep.Width = pbOsztalyKep.Width  +10;
                panelSlide.Width = panelSlide.Width - 10;
                if (panelSlide.Width<=0)
                {
                    timerProfile.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
        }

        private void tsmProfile_Click(object sender, EventArgs e)
        {
            timerProfile.Start();
        }

        private void btnModositas_Click(object sender, EventArgs e)
        {
            var frm = new frmProfilModosit(Fid,conn);
            frm.ShowDialog();
            ProfilUpload();

        }

        private void tsmProfilModositas_Click(object sender, EventArgs e)
        {
            var frm = new frmProfilModosit(Fid, conn);
            frm.ShowDialog();
            ProfilUpload();
        }

        private void tsmMasProfilModositas_Click(object sender, EventArgs e)
        {
            var frm = new frmAdminOtherMembers(conn);
            frm.ShowDialog();
            ProfilUpload();
        }

        private void tsmOsztalyok_Click(object sender, EventArgs e)
        {
            var frm = new frmAdminOsztalyok(conn);
            frm.ShowDialog();
            ProfilUpload();
        }

        private void frmOfOsztalyom_Click(object sender, EventArgs e)
        {
            if (Frank==4||Frank==1)
            {
                if (Oid!="1")
                {

                    var frm = new frmOfOsztaly(conn, Oid, Frank.ToString());
                    frm.ShowDialog();
                    ProfilUpload();
                }
                else
                {
                    MessageBox.Show("Még nem vagy osztályhoz rendelve!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                var frm = new frmOfOsztalyok(conn, Frank.ToString(), Fid,false);
                frm.ShowDialog();
                ProfilUpload();
            }
            pbFill();
             
        }

        private void tsmTanitottOsztalyok_Click(object sender, EventArgs e)
        {
            var frm = new frmOfOsztalyok(conn, Frank.ToString(), Fid,true);
            frm.ShowDialog();
        }

        private void tsmTanaraink_Click(object sender, EventArgs e)
        {
            var frm = new frmOfOsztaly(conn, Oid, Frank.ToString(), true);
            frm.ShowDialog();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            
            if (pNum+1<imgList.Count())
            {
                pNum++;
                pbOsztalyKep.Image = imgList[pNum];
            }
            else
            {
                pNum = 0;
                pbOsztalyKep.Image = imgList[pNum];
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (pNum>0)
            {
                pNum--;
                pbOsztalyKep.Image = imgList[pNum];
            }
            else
            {
                pNum = imgList.Count()-1;
                pbOsztalyKep.Image = imgList[pNum];
            }
        }
    }
}
