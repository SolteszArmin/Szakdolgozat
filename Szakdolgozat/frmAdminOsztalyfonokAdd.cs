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
    public partial class frmAdminOsztalyfonokAdd : Form
    {

        private bool mouseDown;
        private Point lastLocation;

        MySqlConnection conn;

        string oszEvfId;

        public frmAdminOsztalyfonokAdd(MySqlConnection conn, string oszEvfId)
        {
            this.conn = conn;
            this.oszEvfId = oszEvfId;
            InitializeComponent();

            osztalyLoad();

        }

        private void osztalyLoad()
        {

            var cmd = new MySqlCommand("SELECT Fnev FROM felhasznalo WHERE Szid=2 ORDER BY Fnev DESC",conn);
            conn.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbOfo.Items.Add(reader[0]);
            }
            conn.Close();
            conn.Open();
             cmd = new MySqlCommand("SELECT Onev,evfolyamok,Fnev FROM (((felhasznalo " +
                "INNER JOIN osztalyevfolyam ON osztalyevfolyam.OfoId=felhasznalo.Fid) " +
                "INNER JOIN evfolyam ON evfolyam.id=osztalyevfolyam.Evfid) " +
                "INNER JOIN osztaly ON osztaly.Oid=osztalyevfolyam.Oid) " +
                $"WHERE osztalyevfolyam.id={oszEvfId}",conn);
            
             reader = cmd.ExecuteReader();
            reader.Read();
            tbOsztaly.Text = reader[0].ToString() + " | " + reader[1].ToString();
            cbOfo.SelectedItem = reader[2].ToString();
            
            

            

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

        private void btnModositas_Click(object sender, EventArgs e)
        {
            var adapter = new MySqlDataAdapter();
            adapter.UpdateCommand = new MySqlCommand("UPDATE osztalyevfolyam " +
                $"SET osztalyevfolyam.OfoId=(SELECT Fid FROM felhasznalo WHERE Fnev='{cbOfo.SelectedItem}') " +
                $"WHERE osztalyevfolyam.id={oszEvfId} ",conn);
            conn.Open();
            adapter.UpdateCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sikeres Módosítás",
                "Siker!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Dispose();
        }
    }
}
