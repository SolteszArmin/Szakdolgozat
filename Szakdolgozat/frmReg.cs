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
    public partial class frmReg : Form
    {
        MySqlConnection conn;
        private bool mouseDown;
        private Point lastLocation;

        public frmReg(MySqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void tbReg_Click(object sender, EventArgs e)
        {
            try
            {
                string email;
                string phone;
                string loginID;

                if (tbUsername.Text == "" &&
                    tbPw.Text == "" &&
                    tbPwRe.Text == "" &&
                    tbName.Text == "")
                {
                    MessageBox.Show("Nem Töltöttél ki egy kötelező mezőt!");
                }
                else if (tbPw.Text!=tbPwRe.Text)
                {
                    MessageBox.Show("A jelszó nem egyezik!");
                    tbPwRe.Text = "";
                    tbPw.Text = "";
                }
                else if (13>DateTime.Today.Year-dtpDate.Value.Year)
                {
                    MessageBox.Show("Biztos ebben az évben születtél: " + dtpDate.Value.Year + " ?");
                }
                else
                {
                    email = (tbEmail.Text == "") ? null : $"'{tbEmail.Text}'";
                    phone = (tbPhone.Text == "") ? null : $"'{tbPhone.Text}'";

                    var hash = SecurePasswordHasher.Hash(tbPw.Text);
                    conn.Open();
                    //Bejelentkezési tábla feltöltése
                    var adapter = new MySqlDataAdapter();
                    adapter.InsertCommand = new MySqlCommand("INSERT INTO belepes(felhasznalonev,jelszo)" +
                        $" VALUES ('{tbUsername.Text}','{hash}')", conn);
                    adapter.InsertCommand.ExecuteNonQuery();

                    conn.Close();


                    //Bejelentkezési id lekérése

                    conn.Open();
                    var cmd = new MySqlCommand("SELECT Bid FROM belepes WHERE" +
                        $" felhasznalonev='{tbUsername.Text}'", conn);

                    var reader = cmd.ExecuteReader();
                    reader.Read();
                    loginID = reader[0].ToString();
                    
                    reader.Close();
                    conn.Close();

                    conn.Open();
                    //felhasználó hozzáadása
                    
                    if (email == null && phone == null)
                    {
                        adapter.InsertCommand = new MySqlCommand("INSERT INTO felhasznalo(Fnev,FszulDatum,Szid,Bid) VALUES " +
                        $"('{tbName.Text}','{dtpDate.Value.ToString("yyyy-MM-dd")}',4,{loginID})", conn);
                        adapter.InsertCommand.ExecuteNonQuery();
                    }
                    else if (email == null && phone != null)
                    {
                        adapter.InsertCommand = new MySqlCommand("INSERT INTO felhasznalo(Fnev,FszulDatum,Ftel,Szid,Bid) VALUES " +
                        $"('{tbName.Text}','{dtpDate.Value.ToString("yyyy-MM-dd")}',{phone},4,{loginID})", conn);
                        adapter.InsertCommand.ExecuteNonQuery();
                    }
                    else if (email != null && phone == null)
                    {
                        adapter.InsertCommand = new MySqlCommand("INSERT INTO felhasznalo(Fnev,FszulDatum,Femail,Szid,Bid) VALUES " +
                        $"('{tbName.Text}','{dtpDate.Value.ToString("yyyy-MM-dd")}',{email},4,{loginID})", conn);
                        adapter.InsertCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        adapter.InsertCommand = new MySqlCommand("INSERT INTO felhasznalo(Fnev,FszulDatum,Femail,Ftel,Szid,Bid) VALUES " +
                        $"('{tbName.Text}','{dtpDate.Value.ToString("yyyy-MM-dd")}',{email},{phone},4,{loginID})", conn);
                        adapter.InsertCommand.ExecuteNonQuery();
                    }

                    conn.Close();
                    loginID = null;
                    MessageBox.Show("A regisztráció sikeres!");
                    this.Dispose();
                }
                
            }
            catch
            {
                MessageBox.Show("Ilyen felhasználónév már létezik");
            }
            finally
            {
                conn.Close();
                tbPwRe.Text = "";
                tbPw.Text = "";
            }
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
    }
}
