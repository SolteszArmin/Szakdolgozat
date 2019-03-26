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
    public partial class frmAdminMemberUpdate : Form
    {

        private bool mouseDown;
        private Point lastLocation;

        string Fid;
        MySqlConnection conn;
        string fOsztaly;
        string fevfolyam;
        
        public frmAdminMemberUpdate(string Fid,MySqlConnection conn)
        {
            this.conn = conn;
            this.Fid = Fid;
            InitializeComponent();
            profileLoad();
            cbEvfolyam.Enabled = false;
        }

        private void profileLoad()
        {
            cbEvfolyam.Items.Clear();
            cbOsztaly.Items.Clear();
            cbRank.Items.Clear();
            string cmdStr = "SELECT Onev FROM osztaly";
            var cmd = new MySqlCommand(cmdStr, conn);
            conn.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbOsztaly.Items.Add(reader[0]);
            }
            conn.Close();

             cmdStr = "SELECT Sznev FROM szintek";
             cmd = new MySqlCommand(cmdStr, conn);
            conn.Open();
             reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbRank.Items.Add(reader[0]);
            }
            conn.Close();

            cmdStr = "SELECT evfolyamok FROM evfolyam";
            cmd = new MySqlCommand(cmdStr, conn);
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbEvfolyam.Items.Add(reader[0]);
            }
            conn.Close();


            cmdStr = "SELECT Fnev,FszulDatum,Femail,Ftel,Onev,evfolyamok,Sznev FROM ((((felhasznalo " +
                "INNER JOIN osztalyevfolyam ON osztalyevfolyam.id=felhasznalo.Oid) " +
                "INNER JOIN evfolyam ON osztalyevfolyam.Evfid=evfolyam.id) " +
                "INNER JOIN osztaly ON osztalyevfolyam.Oid=osztaly.Oid) " +
                "INNER JOIN szintek ON felhasznalo.Szid=szintek.Szid) " +
                $"WHERE Fid={Fid}";
             cmd = new MySqlCommand(cmdStr, conn);
            conn.Open();

            reader = cmd.ExecuteReader();
            reader.Read();
            tbNev.Text = reader[0].ToString();
            dtpSzul.Value =DateTime.Parse(reader[1].ToString());
            tbEmail.Text = (reader[2].ToString() == "") ? "-" : reader[2].ToString();
            tbTel.Text = (reader[3].ToString() == "") ? "-" : reader[3].ToString();
            cbOsztaly.SelectedItem = reader[4].ToString();
            fOsztaly = reader[4].ToString();
            cbEvfolyam.SelectedItem = reader[5].ToString();
            fevfolyam = reader[5].ToString();
            cbRank.SelectedItem= reader[6].ToString();

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

        private void btnProfileReset_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztos hogy alap helyzetbe akarod állítani a profilképet?",
                "Profilkép alaphelyzetbe állítása",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                string profilkepId;
                var adapter = new MySqlDataAdapter();
                var cmd = new MySqlCommand($"SELECT kepId FROM felhasznalo WHERE Fid={Fid}",conn);
                adapter.UpdateCommand = new MySqlCommand("UPDATE felhasznalo " +
                    "SET kepId=1 " +
                    $"WHERE Fid={Fid}", conn);

                conn.Open();

                var reader = cmd.ExecuteReader();
                reader.Read();
                profilkepId = reader[0].ToString();
                conn.Close();
                
                conn.Open();
                adapter.UpdateCommand.ExecuteNonQuery();
                conn.Close();
                if (profilkepId != "1")
                {
                    conn.Open();
                    adapter.DeleteCommand = new MySqlCommand($"DELETE FROM profilkep WHERE profilkep.id={profilkepId}", conn);
                    adapter.DeleteCommand.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Sikeres visszaállítás", "Sikeres", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbEvfolyam.SelectedIndex!=-1)
            {
                string osztalyEvfolyamId;
                string ujRank;
                var cmd = new MySqlCommand("SELECT osztalyevfolyam.id " +
                    "FROM ((osztalyevfolyam " +
                    "INNER JOIN osztaly ON osztalyevfolyam.Oid=osztaly.Oid) " +
                    "INNER JOIN evfolyam ON osztalyevfolyam.Evfid=evfolyam.id) " +
                    $"WHERE osztalyevfolyam.Oid=(SELECT osztaly.Oid FROM osztaly WHERE osztaly.Onev LIKE '{cbOsztaly.SelectedItem.ToString()}') " +
                    $"AND osztalyevfolyam.Evfid=(SELECT evfolyam.id FROM evfolyam WHERE evfolyam.evfolyamok LIKE '{cbEvfolyam.SelectedItem.ToString()}')", conn);

                conn.Open();
                var reader = cmd.ExecuteReader();
                reader.Read();
                osztalyEvfolyamId = reader[0].ToString();

                conn.Close();
                cmd = new MySqlCommand($"SELECT szintek.Szid FROM szintek WHERE szintek.Sznev = '{cbRank.SelectedItem.ToString()}'", conn);

                conn.Open();

                reader = cmd.ExecuteReader();

                reader.Read();
                ujRank = reader[0].ToString();

                conn.Close();

                var adapter = new MySqlDataAdapter();
                adapter.UpdateCommand = new MySqlCommand("UPDATE felhasznalo " +
                    $"SET Fnev='{tbNev.Text}',Femail='{tbEmail.Text}',Ftel='{tbTel.Text}'," +
                    $"FszulDatum='{dtpSzul.Value.ToString("yyyy-MM-dd")}',Szid={ujRank},felhasznalo.Oid={osztalyEvfolyamId} " +
                    $"WHERE Fid={Fid}", conn);

                conn.Open();
                adapter.UpdateCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Frissítettük a felhasználó adatait!", "Siker!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nincs semmi kijelölve az évfolyamba", "hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void cbOsztaly_SelectionChangeCommitted(object sender, EventArgs e)
        {

            cbEvfolyam.Items.Clear();
            var cmd = new MySqlCommand("SELECT evfolyam.evfolyamok " +
                "FROM ((evfolyam " +
                "INNER JOIN osztalyevfolyam ON osztalyevfolyam.Evfid=evfolyam.id) " +
                "INNER JOIN osztaly ON osztalyevfolyam.Oid=osztaly.Oid) " +
               $"WHERE osztalyevfolyam.Oid=(SELECT osztaly.Oid FROM osztaly WHERE osztaly.Onev = '{cbOsztaly.SelectedItem}')", conn);
            conn.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbEvfolyam.Items.Add(reader[0]);
            }
            conn.Close();
            if (cbOsztaly.SelectedItem.ToString()=="nincs")
            {
                cbEvfolyam.SelectedItem = "nincs";
            }
            cbEvfolyam.Enabled = true;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            profileLoad();
        }
    }
}
