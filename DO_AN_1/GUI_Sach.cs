using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DTO;
using BUS;
using System.Data.SqlClient;

namespace DO_AN_1
{
    public partial class GUI_Sach : Form
    {
        BUS_Sach busSach = new BUS_Sach();
        private int maLoaiSach;
        private int Masach;
        public GUI_Sach()
        {
            InitializeComponent();
        }

        private void GUI_Sach_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            
            LoadcbSachLoaiSach();
            dt = busSach.GetSach();
            dgvHienThi.DataSource = dt;
        }
        private void LoadcbSachLoaiSach()
        {
            DataTable dt = new DataTable();
            dt = busSach.GetSach("select * from LoaiSach");
            cboLoaiSach.DisplayMember = "TenLoai";
            cboLoaiSach.ValueMember = "MaLoai";
            cboLoaiSach.DataSource = dt; 
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            int maloai = maLoaiSach;
            string tensach = txtTieuDe.Text;
            int Gia = int.Parse(txtGia.Text);
            int Soluong = int.Parse(txtSoLuong.Text);
            string tacgia = txtTacgia.Text;
            DTO_Sach sach = new DTO_Sach(maloai, tensach, Gia, Soluong,tacgia);

            if (busSach.themSach(sach) == true)
            {
                MessageBox.Show("Thêm thành công");
                dgvHienThi.DataSource = busSach.GetSach();
            }
        }

        private void dgvHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            if (hang < 0) hang = 0;
            if (hang == dgvHienThi.RowCount - 1) hang = hang - 1;
            Masach = (int)dgvHienThi[0, hang].Value;
            cboLoaiSach.Text = dgvHienThi[1, hang].Value.ToString();
            txtTieuDe.Text = dgvHienThi[2, hang].Value.ToString();
            txtGia.Text = dgvHienThi[3, hang].Value.ToString();
            txtSoLuong.Text = dgvHienThi[4, hang].Value.ToString();
            txtTacgia.Text = dgvHienThi[5, hang].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int masach = Masach;
            int maloai = maLoaiSach;
            string tensach = txtTieuDe.Text;
            int Gia = int.Parse(txtGia.Text);
            int Soluong = int.Parse(txtSoLuong.Text);
            string tacgia = txtTacgia.Text;
            DTO_Sach sach = new DTO_Sach(masach, maloai, tensach, Gia, Soluong,tacgia);

            if (busSach.SuaSach(sach) == true)
            {
                MessageBox.Show("Cập nhật thành công");
                dgvHienThi.DataSource = busSach.GetSach();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int masach = Masach;
            int maloai = maLoaiSach;
            string tensach = txtTieuDe.Text;
            int Gia = int.Parse(txtGia.Text);
            int Soluong = int.Parse(txtSoLuong.Text);
            string tacgia = txtTacgia.Text;
            DTO_Sach sach = new DTO_Sach(masach,maloai, tensach, Gia, Soluong,tacgia);

            DialogResult check = MessageBox.Show("Bạn có muốn xoá đầu sách này không?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(check == DialogResult.Yes)
            {
                if (busSach.XoaSach(sach) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    dgvHienThi.DataSource = busSach.GetSach();
                }
            }
            
   
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboLoaiSach.Refresh();
            txtGia.Clear();
            txtSoLuong.Clear();
            txtTieuDe.Clear();
            txtTacgia.Clear();
            txtSearch.Clear();
            dgvHienThi.DataSource= busSach.GetSach();   
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
                dt = busSach.TimSach(keywords);
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

        private void Inputpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            maLoaiSach = (int)comboBox.SelectedValue;
        }

        private void txtMaSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtTieuDe_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTacgia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Exepnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvHienThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}