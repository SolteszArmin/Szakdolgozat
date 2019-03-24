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
    public partial class frmAdminTanit : Form
    {

        private bool mouseDown;
        private Point lastLocation;

        MySqlConnection conn;
        string oEvfId, evfolyam, osztaly;
        List<string> Fid;

        public frmAdminTanit(MySqlConnection conn,string oEvfId,string evfolyam, string osztaly)
        {
            this.conn = conn;
            this.oEvfId = oEvfId;
            this.evfolyam = evfolyam;
            this.osztaly = osztaly;
            InitializeComponent();
            adatokFill();
        }

        private void adatokFill()
        {
            MessageBox.Show(oEvfId);
            var cmd = new MySqlCommand("SELECT Fnev,Fid FROM felhasznalo " +
                "WHERE Szid=2 OR Szid=3 " +
                "ORDER BY Fnev ASC", conn);
            conn.Open();

            var reader = cmd.ExecuteReader();
            Fid = new List<string>();
            while (reader.Read())
            {
                cbTanar.Items.Add(reader[0]);
                Fid.Add(reader[1].ToString());
            }
            conn.Close();

            tbOsztaly.Text = osztaly + " | " + evfolyam;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbTanar.SelectedIndex!=-1)
            {
                var cmd = new MySqlCommand("SELECT Fid,Oid FROM tanit " +
                    $"WHERE Fid={Fid[cbTanar.SelectedIndex]} and Oid={oEvfId}", conn);
                conn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    conn.Close();
                    MessageBox.Show("Ezt az osztály már tanítja "+cbTanar.SelectedItem.ToString()+" !",
                        "Hiba!",MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    conn.Close();

                    var adapter = new MySqlDataAdapter();
                    adapter.InsertCommand = new MySqlCommand("INSERT INTO tanit(Fid,Oid) " +
                        $"VALUES ({Fid[cbTanar.SelectedIndex]},{oEvfId})",conn);
                    conn.Open();
                    adapter.InsertCommand.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("A tanárt sikeresen osztályhoz rendeltük!",
                        "Siker!", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
        }
    }
}
