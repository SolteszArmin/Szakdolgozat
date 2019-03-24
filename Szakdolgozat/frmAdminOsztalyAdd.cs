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
    public partial class frmAdminOsztalyAdd : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        MySqlConnection conn;

        public frmAdminOsztalyAdd(MySqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            cbFeltolt();
        }

        private void cbFeltolt()
        {
            var cmd = new MySqlCommand("SELECT Onev FROM osztaly WHERE osztaly.Oid NOT LIKE 3",conn);
            conn.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbOsztaly.Items.Add(reader[0]);
            }
            conn.Close();

            cmd = new MySqlCommand("SELECT evfolyamok FROM evfolyam WHERE evfolyam.id NOT LIKE 3", conn);

            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbEvfolyam.Items.Add(reader[0]);
            }
            conn.Close();

            cmd = new MySqlCommand("SELECT Fnev FROM felhasznalo WHERE Szid=2",conn);
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbOsztalyfonok.Items.Add(reader[0]);
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

        private void btnHozzaad_Click(object sender, EventArgs e)
        {
            
            if (cbOsztalyfonok.SelectedIndex != -1
                && cbOsztaly.SelectedIndex != -1
                && cbEvfolyam.SelectedIndex != -1)
            {
                string osztEvfId;

                var cmd = new MySqlCommand("SELECT osztalyevfolyam.id " +
                "FROM ((evfolyam " +
                "INNER JOIN osztalyevfolyam ON osztalyevfolyam.Evfid=evfolyam.id) " +
                "INNER JOIN osztaly ON osztalyevfolyam.Oid=osztaly.Oid) " +
               $"WHERE osztalyevfolyam.Oid=(SELECT osztaly.Oid FROM osztaly WHERE osztaly.Onev = '{cbOsztaly.SelectedItem}') " +
               $"AND osztalyevfolyam.Evfid=(SELECT evfolyam.id FROM evfolyam WHERE evfolyam.evfolyamok='{cbEvfolyam.SelectedItem}') ", conn);

                
                conn.Open();
                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    osztEvfId = reader[0].ToString();
                }
                else
                {
                    osztEvfId = "";
                }
                 
                conn.Close();

                if (osztEvfId=="")
                {
                    var adapter = new MySqlDataAdapter();
                    adapter.InsertCommand = new MySqlCommand("INSERT INTO osztalyevfolyam(Oid,Evfid,OfoId) " +
                        $"VALUE ((SELECT osztaly.Oid FROM osztaly WHERE Onev='{cbOsztaly.SelectedItem}')," +
                        $"(SELECT evfolyam.id FROM evfolyam WHERE evfolyamok='{cbEvfolyam.SelectedItem}')," +
                        $"(SELECT Fid FROM felhasznalo WHERE Fnev='{cbOsztalyfonok.SelectedItem}'))",conn);
                    conn.Open();
                    adapter.InsertCommand.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sikeres osztály felvétel!", "Siker!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Nem lehet 2 ugyan olyan osztályt létrehozni!",
                        "Hiba!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Minden adatot ki kell választani!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
