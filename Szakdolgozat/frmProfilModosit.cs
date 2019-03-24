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
    public partial class frmProfilModosit : Form
    {
        string Fid;
        MySqlConnection conn;
        private bool mouseDown;
        private Point lastLocation;
        string regiProfilkepId;

        bool ujkep = false;

        public frmProfilModosit(string Fid, MySqlConnection conn)
        {
            this.Fid = Fid;
            this.conn = conn;

            InitializeComponent();

            ProfilUpload();
        }

        private void ProfilUpload()
        {
            var cmd = new MySqlCommand("SELECT kep,Fnev,Femail,Ftel,FszulDatum,profilkep.id FROM felhasznalo " +
                "INNER JOIN profilkep ON felhasznalo.kepId=profilkep.id " +
                $"WHERE Fid={Fid}", conn);
            
            conn.Open();

            var reader = cmd.ExecuteReader();
            reader.Read();

            byte[] img = (byte[])reader[0];
            MemoryStream ms = new MemoryStream(img);
            pbProfilePicture.Image = Image.FromStream(ms);

            tbName.Text = reader[1].ToString();
            tbEmail.Text = (reader[2].ToString() == "") ? "-" : reader[2].ToString();
            TbPhone.Text = (reader[3].ToString() == "") ? "-" : reader[3].ToString();
            dtSzulEv.Value =DateTime.Parse(reader[4].ToString());
            regiProfilkepId = reader[5].ToString();
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

        private void cbName_CheckedChanged(object sender, EventArgs e)
        {
            tbName.Enabled = (cbName.Checked) ? true : false;
        }

        private void cbEmail_CheckedChanged(object sender, EventArgs e)
        {
            tbEmail.Enabled = (cbEmail.Checked) ? true : false;
        }

        private void cbTel_CheckedChanged(object sender, EventArgs e)
        {
            TbPhone.Enabled = (cbTel.Checked) ? true : false;
        }

        private void cbSzul_CheckedChanged(object sender, EventArgs e)
        {
            dtSzulEv.Enabled = (cbSzul.Checked) ? true : false;
        }

        private void btnModositas_Click(object sender, EventArgs e)
        {
            if (cbEmail.Checked == false
                && cbName.Checked == false
                && cbSzul.Checked == false
                && cbTel.Checked == false
                && cbPicture.Checked == false)
            {
                MessageBox.Show("Nincs semmi kijelölve!");
            }
            else
            {


                int ujKepId;

                string cmd = "UPDATE felhasznalo " +
                     $"SET Fnev='{tbName.Text}',FszulDatum='{dtSzulEv.Value.ToString("yyyy-MM-dd")}',Femail='{tbEmail.Text}',Ftel='{TbPhone.Text}'" +
                     $" WHERE felhasznalo.Fid={Fid}";

                var adapter = new MySqlDataAdapter();

                conn.Open();
                if (ujkep)
                {
                    MemoryStream ms = new MemoryStream();
                    pbProfilePicture.Image.Save(ms, pbProfilePicture.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    adapter.InsertCommand = new MySqlCommand("INSERT INTO profilkep(kep) " +
                    "VALUES (@img)", conn);
                    adapter.InsertCommand.Parameters.Add("@img", MySqlDbType.LongBlob);
                    adapter.InsertCommand.Parameters["@img"].Value = img;
                    adapter.InsertCommand.ExecuteNonQuery();

                    var reader = new MySqlCommand("SELECT id FROM profilkep ORDER BY id DESC Limit 1", conn).ExecuteReader();

                    
                    reader.Read();

                    ujKepId = int.Parse(reader[0].ToString());

                    conn.Close();

                    conn.Open();

                    cmd = "UPDATE felhasznalo " +
                    $"SET Fnev='{tbName.Text}',FszulDatum='{dtSzulEv.Value.ToString("yyyy-MM-dd")}',Femail='{tbEmail.Text}',Ftel='{TbPhone.Text}',kepID={ujKepId}" +
                    $" WHERE felhasznalo.Fid={Fid}";
                }



                adapter.UpdateCommand = new MySqlCommand(cmd, conn);

                adapter.UpdateCommand.ExecuteNonQuery();


                if (regiProfilkepId != "1"&&ujkep)
                {
                    adapter.DeleteCommand = new MySqlCommand($"DELETE FROM profilkep WHERE profilkep.id={regiProfilkepId}", conn);
                    adapter.DeleteCommand.ExecuteNonQuery();
                }



                conn.Close();

                cbEmail.Checked = false;
                cbName.Checked = false;
                cbSzul.Checked = false;
                cbTel.Checked = false;
                cbPicture.Checked = false;

                ujkep = false;
                ProfilUpload();
                MessageBox.Show("A módosítás megtörtént!");
                this.Dispose();
            }

            }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            ujkep = true;
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pbProfilePicture.Image = Image.FromFile(opf.FileName);
            }
        }

        private void cbPicture_CheckedChanged(object sender, EventArgs e)
        {
            btnUpload.Enabled = (cbPicture.Checked) ? true : false;
        }
    }
}
