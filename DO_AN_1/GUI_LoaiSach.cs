using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN_1
{
   
    public partial class GUI_LoaiSach : Form
    {
        private int MaLoai;
        BUS_LoaiSach busLoaisach = new BUS_LoaiSach();
        public GUI_LoaiSach()
        {
            InitializeComponent();
        }

        private void GUI_LoaiSach_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("select MaLoai as [Mã Loại sach],");
            query.Append("TenLoai as [Tên Loại Sách],");
            query.Append("Mota as [Mô tả] ");
            query.Append("from LoaiSach ");
            dt = busLoaisach.GetLoaiSach(query.ToString());
            dgvHienThi.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int maloai = MaLoai;
            string tenloai = txtTenLoai.Text;
            string mota = txtMota.Text; 
            DTO_LoaiSach LoaiSach = new DTO_LoaiSach(tenloai,mota);

            if (busLoaisach.themLoaiSach(LoaiSach) == true)
            {
                MessageBox.Show("Thêm thành công");
                dgvHienThi.DataSource = busLoaisach.GetLoaiSach();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maloai = MaLoai;
            string tenloai = txtTenLoai.Text;
            string mota = txtMota.Text;
            DTO_LoaiSach LoaiSach = new DTO_LoaiSach(maloai, tenloai, mota);

            
            if (busLoaisach.XoaLoaiSach(LoaiSach) == true)
            {
                MessageBox.Show("Xóa thành công");
                dgvHienThi.DataSource = busLoaisach.GetLoaiSach();
            } 
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maloai = MaLoai;
            string tenloai = txtTenLoai.Text;
            string mota = txtMota.Text;
            DTO_LoaiSach LoaiSach = new DTO_LoaiSach(maloai, tenloai, mota);


            if (busLoaisach.SuaLoaiSach(LoaiSach) == true)
            {
                MessageBox.Show("Cập nhật thành công");
                dgvHienThi.DataSource = busLoaisach.GetLoaiSach();
            }
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
                //StringBuilder query = new StringBuilder("select MaLoai as [Mã Loại sách], TenLoai as [Tên Loại Sách],Mota as [Mô tả] from LoaiSach where MaLoai like '%" + keywords + "%' or TenLoai like N'%" + keywords + "%' or Mota like N'%" + keywords + "%'");
                //dt = busLoaisach.GetLoaiSach(query.ToString());
                dt = busLoaisach.TimKiemLoaiSach(keywords);
                if ( dt.Rows.Count > 0)
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

        private void dgvHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            if (hang < 0) hang = 0;
            if (hang == dgvHienThi.RowCount - 1) hang = hang - 1;
            MaLoai = (int)dgvHienThi[0, hang].Value;
            txtTenLoai.Text = dgvHienThi[1, hang].Value.ToString();
            txtMota.Text = dgvHienThi[2, hang].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
