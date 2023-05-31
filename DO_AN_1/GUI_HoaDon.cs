using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using BUS;
using DTO;

namespace DO_AN_1
{
    public partial class GUI_HoaDon : Form
    {
        BUS_HoaDon bushoadon = new BUS_HoaDon();
        BUS_KhachHang buskhachhang = new BUS_KhachHang();
        int MaHD;
        public GUI_HoaDon()
        {
            InitializeComponent();
        }

        private void GUI_HoaDon_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bushoadon.GetHoaDon();
            dgvHienThi.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DateTime ngaylaphd = Datelaphoadon.Value;
            string tenkh = txtTenkhachang.Text;
            string sdtkh = txtSDTKH.Text;
            string diachi = txtDiachi.Text;
            string email = txtEmail.Text;
            DTO_HoaDon hoadon = new DTO_HoaDon(ngaylaphd, tenkh, sdtkh, email, diachi);
            DTO_KhachHang khachhang = new DTO_KhachHang(tenkh, sdtkh, email, diachi);
            if (bushoadon.themHoaDon(hoadon) == true)
            {
                if(buskhachhang.themKhachHang(khachhang)==true)
                {
                    buskhachhang.themKhachHang(khachhang);
                    MessageBox.Show("Thêm thành công");
                    dgvHienThi.DataSource = bushoadon.GetHoaDon();
                } 
            }

        }

        private void Inputpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            if (hang < 0) hang = 0;
            if (hang == dgvHienThi.RowCount - 1) hang = hang - 1;
            MaHD = (int)dgvHienThi[0, hang].Value;
            Datelaphoadon.Value = DateTime.Parse(dgvHienThi[1, hang].Value.ToString());
            txtTenkhachang.Text = dgvHienThi[2, hang].Value.ToString();
            txtSDTKH.Text = dgvHienThi[3, hang].Value.ToString();
            txtEmail.Text = dgvHienThi[4, hang].Value.ToString();
            txtDiachi.Text = dgvHienThi[5, hang].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string tenkhachhang = txtTenkhachang.Text;
            string sdtkh = txtSDTKH.Text;
            DateTime datelap = Datelaphoadon.Value;
            string email = txtEmail.Text;
            string diachi = txtDiachi.Text;
            DTO_HoaDon hoadon = new DTO_HoaDon(MaHD, datelap, tenkhachhang, sdtkh, email, diachi);
            DTO_KhachHang khachhang = new DTO_KhachHang(tenkhachhang, sdtkh, email, diachi);
            if (bushoadon.suaHoaDon(hoadon) == true && buskhachhang.SuaKhachHang(khachhang) == true)
            {
                MessageBox.Show("Cập nhật thành công");
                dgvHienThi.DataSource = bushoadon.GetHoaDon();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tenkhachhang = txtTenkhachang.Text;
            string sdtkh = txtSDTKH.Text;
            DateTime datelap = Datelaphoadon.Value;
            string email = txtEmail.Text;
            string diachi = txtDiachi.Text;
            DTO_HoaDon hoadon = new DTO_HoaDon(MaHD, datelap, tenkhachhang, sdtkh, email, diachi);
            DialogResult check = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {
                if (bushoadon.xoaHoaDon(hoadon) == true)
                {
                    MessageBox.Show("Xoá thành công");
                    dgvHienThi.DataSource = bushoadon.GetHoaDon();
                }
            }

        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            txtTenkhachang.Clear();
            txtSDTKH.Clear();
            txtEmail.Clear();
            txtDiachi.Clear();
            txtSearch.Clear();
            Datelaphoadon.Value.ToLocalTime();
            dgvHienThi.DataSource = bushoadon.GetHoaDon();
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
                dt = bushoadon.TimHoaDon(keywords);
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

        private void btnChitiet_Click(object sender, EventArgs e)
        {
            GUI_Chitiethoadon form = new GUI_Chitiethoadon(MaHD);
            form.ShowDialog();
        }
    }
}
