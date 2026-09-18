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
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
            loadRole();
            loadGuru();
        }

        private void loadRole()
        {
            conn.crud("SELECT id_role, role_name FROM tb_roles WHERE status = 'Aktif'");

            cmbRole.DataSource = conn.ds.Tables[0];
            cmbRole.DisplayMember = "role_name";
            cmbRole.ValueMember = "id_role";
            cmbRole.SelectedIndex = -1;
        }

        private void loadGuru()
        {
            conn.crud("SELECT id_guru, nama FROM tb_guru WHERE status = 'Aktif'");

            cmbGuru.DataSource = conn.ds.Tables[0];
            cmbGuru.DisplayMember = "nama";
            cmbGuru.ValueMember = "id_guru";
            cmbGuru.SelectedIndex = -1;
        }

        public void bersih()
        {
            txtId.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";
            cmbGuru.Text = "";
            cmbRole.Text = "";
            cmbStatus.Text = "";
            cmbGuru.SelectedIndex = -1;
            cmbRole.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
        }

        public void tampildata()
        {
            dgvUser.Rows.Clear();

            conn.crud(@"
        SELECT 
            tb_users.id_user,
            tb_users.username,
            tb_users.password,
            tb_roles.role_name,
            tb_guru.nama,
            tb_users.status
        FROM tb_users
        LEFT JOIN tb_roles 
            ON tb_users.id_role = tb_roles.id_role
        LEFT JOIN tb_guru 
            ON tb_users.id_guru = tb_guru.id_guru
    ");

            foreach (DataRow baris in conn.ds.Tables[0].Rows)
            {
                dgvUser.Rows.Add(
                    baris["id_user"].ToString(),
                    baris["username"].ToString(),
                    baris["password"].ToString(),
                    baris["role_name"].ToString(),
                    baris["nama"].ToString(),
                    baris["status"].ToString()
                );
            }
        }


        private void cmbGuru_DropDown(object sender, EventArgs e)
        {
            cmbGuru.DataSource = null;

            conn.crud("SELECT id_guru, nama FROM tb_guru WHERE status = 'Aktif'");

            cmbGuru.DataSource = conn.ds.Tables[0];
            cmbGuru.DisplayMember = "nama";
            cmbGuru.ValueMember = "id_guru";
            cmbGuru.SelectedIndex = -1;
        }

        private void cmbRole_DropDown(object sender, EventArgs e)
        {
            cmbRole.DataSource = null;

            conn.crud("SELECT id_role, role_name FROM tb_roles WHERE status = 'Aktif'");

            cmbRole.DataSource = conn.ds.Tables[0];
            cmbRole.DisplayMember = "role_name";
            cmbRole.ValueMember = "id_role";
            cmbRole.SelectedIndex = -1;
        }

        private void cmbStatus_DropDown(object sender, EventArgs e)
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Aktif");
            cmbStatus.Items.Add("Nonaktif");
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == ""  || txtUser.Text == "" || cmbGuru.SelectedIndex == -1 || cmbRole.SelectedIndex == -1 || cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Lengkapi Data");
            }
            else
            {
                string User = txtUser.Text;
                string Pass = txtPass.Text;
                string Guru = cmbGuru.SelectedValue.ToString();
                string Role = cmbRole.SelectedValue.ToString();
                string Status = "" + cmbStatus.SelectedItem;
                conn.crud($"INSERT INTO tb_users VALUES (null,'{User}','{Pass}','{Guru}','{Role}','{Status}');");
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
            dgvUser.Rows.Clear();
            conn.crud($"SELECT * FROM tb_users INNER JOIN tb_guru INNER JOIN tb_roles WHERE tb_users.username OR tb_guru.nama OR tb_roles.role_name LIKE '%{txtSearch.Text}%';");
            foreach (DataRow baris in conn.ds.Tables[0].Rows)
            {
                string id = "" + baris["id_user"];
                string username = "" + baris["username"];
                string password = "" + baris["password"];
                string idRole = "" + baris["id_role"];
                string idGuru = "" + baris["id_guru"];
                string status = "" + baris["status"];
                dgvUser.Rows.Add(id, username, password, idRole, idGuru, status);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string Id = txtId.Text;
            string User = txtUser.Text;
            string Pass = txtPass.Text;
            string Guru = cmbGuru.SelectedValue.ToString();
            string Role = cmbRole.SelectedValue.ToString();
            string Status = cmbStatus.SelectedItem.ToString();

            conn.crud($"UPDATE tb_users SET username = '{User}', password = '{Pass}', id_guru = '{Guru}', id_role = '{Role}', status = '{Status}' WHERE id_user = '{Id}'");
            bersih();
            tampildata();
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;

            string id = dgvUser.Rows[baris].Cells[0].Value.ToString();

            if (kolom == 6)
            {
                conn.crud($"SELECT * FROM tb_users WHERE id_user = '{id}'");

                foreach (DataRow row in conn.ds.Tables[0].Rows)
                {
                    txtId.Text = row["id_user"].ToString();
                    txtUser.Text = row["username"].ToString();
                    txtPass.Text = row["password"].ToString();
                    cmbGuru.SelectedValue = row["id_guru"];
                    cmbRole.SelectedValue = row["id_role"];
                    cmbStatus.Text = row["status"].ToString();

                    bersih();
                    tampildata();
                }

                return;
            }

            if (kolom == 7)
            {
                DialogResult setuju = MessageBox.Show(
                    $"Apakah data user '{id}' mau dihapus?",
                    "Pemberitahuan",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (setuju == DialogResult.Yes)
                {
                    conn.crud($"DELETE FROM tb_users WHERE id_user = '{id}'");

                    MessageBox.Show("Data berhasil dihapus");

                    bersih();
                    tampildata();
                }

                return;
            }
        }
    }
}
