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
    public partial class frmAdminOsztalyok : Form
    {
        MySqlConnection conn;
        
        private bool mouseDown;
        private Point lastLocation;

        public frmAdminOsztalyok(MySqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            dgvFeltolt();
        }

        private void dgvFeltolt()
        {
            dgvOsztaly.Rows.Clear();
            var cmd = new MySqlCommand("SELECT osztalyevfolyam.id,Onev,evfolyamok,Fnev,osztaly.Oid,evfolyam.id FROM (((evfolyam " +
                "INNER JOIN osztalyevfolyam ON evfolyam.id=osztalyevfolyam.Evfid) " +
                "INNER JOIN osztaly ON osztalyevfolyam.oid=osztaly.Oid) " +
                "INNER JOIN felhasznalo ON osztalyevfolyam.OfoId=felhasznalo.Fid) " +
                "WHERE osztalyevfolyam.id > 1 " +
                "ORDER BY evfolyamok DESC" ,conn);
            conn.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dgvOsztaly.Rows.Add
                    (
                        reader[0].ToString(),
                        reader[1].ToString(),
                        reader[2].ToString(),
                        reader[3].ToString(),
                        reader[4].ToString(),
                        reader[5].ToString()
                
                    );
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

        private void tbKereses_TextChanged(object sender, EventArgs e)
        {
            dgvOsztaly.Rows.Clear();
            var cmd = new MySqlCommand("SELECT osztalyevfolyam.id,Onev,evfolyamok,Fnev,osztaly.Oid,evfolyam.id FROM (((evfolyam " +
                "INNER JOIN osztalyevfolyam ON evfolyam.id=osztalyevfolyam.Evfid) " +
                "INNER JOIN osztaly ON osztalyevfolyam.oid=osztaly.Oid) " +
                "INNER JOIN felhasznalo ON osztalyevfolyam.OfoId=felhasznalo.Fid) " +
                $"WHERE osztalyevfolyam.id>1 AND osztaly.Onev LIKE '{tbKereses.Text}%'" +
                "ORDER BY evfolyamok DESC", conn);
            conn.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dgvOsztaly.Rows.Add
                    (
                        reader[0].ToString(),
                        reader[1].ToString(),
                        reader[2].ToString(),
                        reader[3].ToString(),
                        reader[4].ToString(),
                        reader[5].ToString()

                    );
            }
            conn.Close();
        }

        private void dgvOsztaly_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            string oszEvfId=dgvOsztaly.SelectedRows[0].Cells[0].Value.ToString();
            var frm = new frmAdminOsztalyfonokAdd(conn, oszEvfId);
            frm.ShowDialog();
            dgvFeltolt();
            
        }

        private void btnOsztalyAdd_Click(object sender, EventArgs e)
        {
            var frm = new frmAdminOsztalyAdd(conn);
            frm.ShowDialog();
            dgvFeltolt();
        }

        private void btnTanarAdd_Click(object sender, EventArgs e)
        {
            string oszEvfId = dgvOsztaly.SelectedRows[0].Cells[0].Value.ToString();
            string osztaly= dgvOsztaly.SelectedRows[0].Cells[2].Value.ToString();
            string evfolyam = dgvOsztaly.SelectedRows[0].Cells[1].Value.ToString();
            var frm = new frmAdminTanit(conn, oszEvfId,osztaly,evfolyam);
            frm.ShowDialog();
        }
    }
}
