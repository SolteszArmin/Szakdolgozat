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
    public partial class frmOfOsztalykep : Form
    {

        private bool mouseDown;
        private Point lastLocation;

        MySqlConnection conn;
        string oEvfId;

        List<Image> imgList;
        List<string> oKepIdList;

        int pNum;
        bool vanKep;


        public frmOfOsztalykep(MySqlConnection conn, string oEvfId)
        {
            this.conn = conn;
            this.oEvfId = oEvfId;
            InitializeComponent();
            pbFill();
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

        private void pbFill()
        {
            imgList = new List<Image>();
            oKepIdList = new List<string>();

            imgList.Clear();
            var cmd = new MySqlCommand("SELECT osztalyKep,osztalykep.id FROM osztalykep " +
                "INNER JOIN osztalyevfolyam  ON osztalykep.Oid=osztalyevfolyam.id " +
                $"WHERE osztalykep.Oid={oEvfId} " +
                $"ORDER BY osztalykep.id DESC", conn);
            conn.Open();
            var reader = cmd.ExecuteReader();
            vanKep = (reader.HasRows) ? true : false;
            if (reader.HasRows)
            {
                pbOsztalyKep.Visible = true;
                btnLeft.Visible = true;
                btnRight.Visible = true;
                while (reader.Read())
                {
                    byte[] img = (byte[])reader[0];

                    MemoryStream ms = new MemoryStream(img);
                    imgList.Add(Image.FromStream(ms));
                    oKepIdList.Add(reader[1].ToString());

                }

                pbOsztalyKep.Image = imgList[0];
                pNum = 0;
            }
            else
            {
                pbOsztalyKep.Visible = false;
                btnLeft.Visible = false;
                btnRight.Visible = false;
            }

            conn.Close();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (vanKep)
            {
                if (pNum + 1 < imgList.Count())
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
            
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (vanKep)
            {
                if (pNum > 0)
                {
                    pNum--;
                    pbOsztalyKep.Image = imgList[pNum];
                }
                else
                {
                    pNum = imgList.Count() - 1;
                    pbOsztalyKep.Image = imgList[pNum];
                }
            }
            
        }

        private void btnOsztalykepPlus_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                var adapter = new MySqlDataAdapter();
                MemoryStream ms = new MemoryStream();
                Image.FromFile(opf.FileName).Save(ms, Image.FromFile(opf.FileName).RawFormat);
                byte[] img = ms.ToArray();

                adapter.InsertCommand = new MySqlCommand("INSERT INTO osztalykep(osztalyKep,Oid) " +
                "VALUES (@img,@Oid)", conn);

                adapter.InsertCommand.Parameters.Add("@img", MySqlDbType.LongBlob);
                adapter.InsertCommand.Parameters.Add("@Oid", MySqlDbType.Int32);

                adapter.InsertCommand.Parameters["@img"].Value = img;
                adapter.InsertCommand.Parameters["@Oid"].Value = oEvfId;
                conn.Open();
                adapter.InsertCommand.ExecuteNonQuery();
                conn.Close();
                pbFill();
                
            }
        }

        private void btnOsztalykepTorles_Click(object sender, EventArgs e)
        {
            if (vanKep)
            {
                DialogResult dialogResult = MessageBox.Show("Biztos törölni akarja a kiválasztott képet?",
                "Törlés",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var adapter = new MySqlDataAdapter();
                    adapter.DeleteCommand = new MySqlCommand("DELETE FROM osztalykep " +
                        $"WHERE osztalykep.id={oKepIdList[pNum]}", conn);
                    conn.Open();
                    adapter.DeleteCommand.ExecuteNonQuery();
                    conn.Close();
                    pbFill();
                }
            }
            else
            {
                MessageBox.Show("Még nincs osztálykép amit törölni lehetne!",
                    "Hiba!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
            
        }
    }
}
