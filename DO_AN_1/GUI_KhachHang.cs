using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN_1
{
    public partial class GUI_KhachHang : Form
    {
        BUS_KhachHang busKhachHang = new BUS_KhachHang();
        private int MaKhachHang;
        public GUI_KhachHang()
        {
            InitializeComponent();
        }
        private void GUI_KhachHang_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = busKhachHang.GetKhachhang();
            dgvHienThi.DataSource = dt;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenKhachHang = txtTenkh.Text;
            string diachi = txtDiachi.Text;
            string sdtKhachHang = txtSdt.Text;
            string email = txtEmail.Text;
            DTO_KhachHang KhachHang = new DTO_KhachHang(tenKhachHang, sdtKhachHang, email, diachi);

            if (busKhachHang.themKhachHang(KhachHang) == true)
            {
                MessageBox.Show("Thêm thành công");
                dgvHienThi.DataSource = busKhachHang.GetKhachhang();
            }
        }

        private void dgvHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            if (hang < 0) hang = 0;
            if (hang == dgvHienThi.RowCount - 1) hang = hang - 1;
            MaKhachHang = (int)dgvHienThi[0, hang].Value;
            txtTenkh.Text = dgvHienThi[1, hang].Value.ToString();
            txtDiachi.Text = dgvHienThi[4, hang].Value.ToString();
            txtSdt.Text = dgvHienThi[2, hang].Value.ToString();
            txtEmail.Text = dgvHienThi[3, hang].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maKhachHang = MaKhachHang;
            string tenKhachHang = txtTenkh.Text;
            string diachi = txtDiachi.Text;
            string sdtKhachHang = txtSdt.Text;
            string email = txtEmail.Text;
            DTO_KhachHang KhachHang = new DTO_KhachHang(maKhachHang, tenKhachHang, sdtKhachHang, email, diachi);

            if (busKhachHang.SuaKhachHang(KhachHang) == true)
            {
                MessageBox.Show("Cập nhật thành công");
                dgvHienThi.DataSource = busKhachHang.GetKhachhang();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maKhachHang = MaKhachHang;
            string tenKhachHang = txtTenkh.Text;
            string diachi = txtDiachi.Text;
            string sdtKhachHang = txtSdt.Text;
            string email = txtEmail.Text;
            DTO_KhachHang KhachHang = new DTO_KhachHang(maKhachHang, tenKhachHang, sdtKhachHang, email, diachi);

            DialogResult check = MessageBox.Show("Bạn có muốn xoá đầu sách này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                if (busKhachHang.XoaKhachHang(KhachHang) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    dgvHienThi.DataSource = busKhachHang.GetKhachhang();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenkh.Clear();
            txtSdt.Clear();
            txtEmail.Clear();
            txtDiachi.Clear();
            txtSearch.Clear();
            dgvHienThi.DataSource = busKhachHang.GetKhachhang();
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
                dt = busKhachHang.TimKhachHang(keywords);
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
