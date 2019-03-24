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
    public partial class frmLogin : Form
    {
        string Bid;
        MySqlConnection conn = new MySqlConnection(
                    "Server=127.0.0.1;" +
                    "Database=felhasznaloiadatok;" +
                    "Uid=root;" +
                    "Pwd=;");
        private bool mouseDown;
        private Point lastLocation;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (tbPass.Text!=""&& tbUsername.Text!="")
            {
                conn.Open();

                var cmd = new MySqlCommand("SELECT felhasznalonev,jelszo,Bid FROM belepes WHERE " +
                    $"felhasznalonev='{tbUsername.Text}'",conn);
                var reader = cmd.ExecuteReader();

                reader.Read();
                
                if (reader.HasRows && tbUsername.Text==reader[0].ToString())
                {
                    Bid = reader[2].ToString();
                    var verify = SecurePasswordHasher.Verify(tbPass.Text, reader[1].ToString());
                    if (verify)
                    {
                        reader.Close();

                        cmd.CommandText = "SELECT Fid,Szid,Oid FROM felhasznalo WHERE " +
                        $" Bid={Bid}";

                        reader = cmd.ExecuteReader();
                        reader.Read();

                        string Fid = reader[0].ToString();
                        int Frank = int.Parse(reader[1].ToString());
                        string Oid = reader[2].ToString();

                        reader.Close();
                        conn.Close();

                        var frm = new frmMain(conn, Frank, Fid,Oid);
                        this.Hide();
                        frm.ShowDialog();
                        tbPass.Text = "";
                        tbUsername.Text = "";
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Hibás felhasználónév vagy jelszó");

                        reader.Close();
                        conn.Close();
                    }
                }

                else
                {
                    MessageBox.Show("Hibás felhasználónév vagy jelszó");

                    reader.Close();
                    conn.Close();
                }
                
               
            }
            else
            {
                MessageBox.Show("Ki kell töltenie az adatokat");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var frm = new frmReg(conn);
            frm.ShowDialog();
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
