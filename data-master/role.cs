using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KemasProject.data_master
{
    public partial class role : Form
    {
        public role()
        {
            InitializeComponent();
        }

        public void bersih()
        {
            txtId.Text = "";
            txtRole.Text = "";
            cmbStatus.Text = "";
            cmbStatus.SelectedIndex = -1;
        }

        public void tampildata()
        {
            dgvRole.Rows.Clear();
            conn.crud("SELECT * FROM tb_roles");
            foreach (DataRow baris in conn.ds.Tables[0].Rows)
            {
                string id = "" + baris["id_role"];
                string role = "" + baris["role_name"];
                string status = "" + baris["status"];
                dgvRole.Rows.Add(id, role, status);
            }
        }

        private void cmbStatus_DropDown(object sender, EventArgs e)
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Aktif");
            cmbStatus.Items.Add("Nonaktif");
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (txtRole.Text == "" || cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Lengkapi Data");
            }
            else
            {
                string Role = txtRole.Text;
                string Status = "" + cmbStatus.SelectedItem;
                conn.crud($"INSERT INTO tb_roles VALUES (null,'{Role}','{Status}');");
                bersih();
                tampildata();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            tampildata();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvRole.Rows.Clear();
            conn.crud($"SELECT * FROM tb_roles WHERE role_name LIKE '%{txtSearch.Text}%';");
            foreach (DataRow baris in conn.ds.Tables[0].Rows)
            {
                string id = "" + baris["id_role"];
                string role = "" + baris["role_name"];
                string status = "" + baris["status"];
                dgvRole.Rows.Add(id, role, status);
            }
        }

        private void dgvRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;
            if (kolom == 3)
            {
                string id = dgvRole.Rows[baris].Cells[0].Value.ToString();
                conn.crud($"SELECT * FROM tb_roles WHERE id_role ='{id}'");
                foreach (DataRow brs in conn.ds.Tables[0].Rows)
                {
                    string idr = "" + brs["id_role"];
                    string role = "" + brs["role_name"];
                    string status = "" + brs["status"];
                    txtId.Text = idr;
                    txtRole.Text = role;
                    cmbStatus.Text = status;

                }
            }


            if (kolom == 4)
            {
                string id = dgvRole.Rows[baris].Cells[0].Value.ToString();
                DialogResult setuju = MessageBox.Show($"Apakah '{id}' mau dihapus?", "Pemberitahuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (setuju == DialogResult.Yes)
                {
                    conn.crud($"DELETE FROM tb_roles WHERE id_role = '{id}'");
                    tampildata();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string name = txtRole.Text;
            string status = "" + cmbStatus.Text;
            conn.crud($"UPDATE tb_roles SET role_name = '{name}', status = '{status}' WHERE id_role = '{id}';");
            bersih();
            tampildata();
        }
    }
}
