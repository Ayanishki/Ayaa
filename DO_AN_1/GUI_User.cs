using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace DO_AN_1
{
    public partial class GUI_User : Form
    {
        BUS_Users bususer = new BUS_Users();
        int accountid;

        public GUI_User()
        {
            InitializeComponent();
        }

        private void GUI_User_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bususer.GetUser();
            dgvHienThi.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtTendn.Text;
            string tenhienthi = txtTenhienthi.Text;
            string sdt = txtSdt.Text;
            string email = txtEmail.Text;
            string matkhau = txtmatkhau.Text;
            int role = int.Parse(txtrole.Text);
            DTO_Users user = new DTO_Users(tenhienthi,tendangnhap,matkhau,email,sdt,role);
            if (bususer.Add(user) == true)
            {
                MessageBox.Show("Thêm thành công");
                dgvHienThi.DataSource = bususer.GetUser();
            }
            else
            {
                MessageBox.Show("Tài khoản bị trùng");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtTendn.Text;
            string tenhienthi = txtTenhienthi.Text;
            string sdt = txtSdt.Text;
            string email = txtEmail.Text;
            string matkhau = txtmatkhau.Text;
            int role = int.Parse(txtrole.Text);
            DTO_Users user = new DTO_Users(accountid, tenhienthi, tendangnhap, matkhau, email, sdt, role);
            DialogResult check = MessageBox.Show("Bạn có muốn sửa tài khoản này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                if (bususer.Update(user) == true)
                {
                    MessageBox.Show("Update thành công");
                    dgvHienThi.DataSource = bususer.GetUser();
                }
            }
        }

        private void dgvHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            if (hang < 0) hang = 0;
            if (hang == dgvHienThi.RowCount - 1) hang = hang - 1;
            accountid = (int)dgvHienThi[0, hang].Value;
            txtTenhienthi.Text = dgvHienThi[1, hang].Value.ToString();
            txtTendn.Text = dgvHienThi[2, hang].Value.ToString();
            txtmatkhau.Text = dgvHienThi[3, hang].Value.ToString();
            txtEmail.Text = dgvHienThi[4, hang].Value.ToString();
            txtSdt.Text = dgvHienThi[5, hang].Value.ToString();
            txtrole.Text = dgvHienThi[6, hang].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtTendn.Text;
            string tenhienthi = txtTenhienthi.Text;
            string sdt = txtSdt.Text;
            string email = txtEmail.Text;
            string matkhau = txtmatkhau.Text;
            int role = int.Parse(txtrole.Text);
            DTO_Users user = new DTO_Users(accountid, tenhienthi, tendangnhap, matkhau, email, sdt, role);
            DialogResult check = MessageBox.Show("Bạn có muốn xoá tài khoản này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                if (bususer.Delete(user) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    dgvHienThi.DataSource = bususer.GetUser();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtmatkhau.Clear();
            txtrole.Clear();
            txtSdt.Clear();
            txtSearch.Clear();
            txtTendn.Clear();
            txtTenhienthi.Clear();
            dgvHienThi.DataSource = bususer.GetUser();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Ô tìm kiếm trống");
            }
            else
            {
                DataTable dt = new DataTable();
                dt =bususer.Timkiem(keywords);
                if (dt.Rows.Count > 0)


                {
                    MessageBox.Show("Đã xong");
                    dgvHienThi.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không có kết quả");
                }

            }
        }
    }
}
