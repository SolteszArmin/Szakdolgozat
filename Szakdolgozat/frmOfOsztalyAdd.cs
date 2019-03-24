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
    public partial class frmOfOsztalyAdd : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        MySqlConnection conn;
        string oEvfId;

        List<int> fId;

        public frmOfOsztalyAdd(MySqlConnection conn,string oEvfId)
        {
            this.conn = conn;
            this.oEvfId = oEvfId;
            InitializeComponent();
            cbFill();
        }

        private void cbFill()
        {
            cbDiakNev.Items.Clear();
            var cmd = new MySqlCommand($"SELECT Fnev,FszulDatum,Fid FROM felhasznalo WHERE Oid=1 " +
                $"AND felhasznalo.Szid=4 " +
                $"ORDER BY Fnev ASC",conn);
            conn.Open();
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                fId = new List<int>();
                while (reader.Read())
                {
                    cbDiakNev.Items.Add(reader[0]+" | "+DateTime.Parse( reader[1].ToString()).ToString("yyyy-MM-dd"));
                    fId.Add(int.Parse(reader[2].ToString()));
                }
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
            if (cbDiakNev.SelectedIndex!=-1)
            {
                var adapter = new MySqlDataAdapter();
                adapter.UpdateCommand = new MySqlCommand("UPDATE felhasznalo " +
                    $"SET Oid={oEvfId} " +
                    $"WHERE Fid={fId[cbDiakNev.SelectedIndex]}", conn);
                conn.Open();
                adapter.UpdateCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("A Diákot Sikeresen Hozzá adtuk az osztályához!",
                    "Siker!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                cbFill();

            }
            else
            {
                MessageBox.Show("Ki kell választania Egy nevet!",
                    "HIBA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
            
        }
    }
}
