using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.AccessControl;
using DTO;
using System.Text.RegularExpressions;

namespace DO_AN_1
{
    public partial class GUI_Chitiethoadon : Form
    {
        BUS_ChiTietHoaDon chitiethoadon = new BUS_ChiTietHoaDon();
        int MaSach;
        int MaHoaDon;
        public GUI_Chitiethoadon(int Mahoadon)
        {
            InitializeComponent();
            this.MaHoaDon = Mahoadon;
            LoadcboTenSach();
            LoadTongTien();

        }
        private void LoadTongTien()
        {
            object result = chitiethoadon.SqlScalar("SELECT SUM(SLban * Giaban) FROM Chitiethoadon WHERE MaHoaDon = " + MaHoaDon);
            double tongtien = Convert.ToDouble(result);
            lbTongtien.Text = "Tổng tiền: " + tongtien;
        }

        private void GUI_Chitiethoadon_Load(object sender, EventArgs e)
        {
            Title.Text = "Chi Tiết Hoá Đơn " + MaHoaDon;
            DataTable dt = new DataTable();
            //dt = chitiethoadon.GetChiTietHoaDon(MaHoaDon);
            dt = chitiethoadon.GetChiTietHoaDon("select TenSach as [Tên sách], Slban as [Số lượng], Giaban as [Giá bán],Chitiethoadon.Slban * Chitiethoadon.Giaban as [Thành tiền] from ChiTietHoaDon inner join Sach on Chitiethoadon.MaSach = Sach.MaSach inner join HoaDon on Chitiethoadon.MaHoaDon = HoaDon.MaHoaDon and Chitiethoadon.MaHoaDon = " + MaHoaDon);
            dgvHienThi.DataSource = dt;
        }
        private void LoadcboTenSach()
        {
            DataTable dt = new DataTable();
            dt = chitiethoadon.GetChiTietHoaDon("select * from Sach");
            cboTensach.DisplayMember = "TenSach";
            cboTensach.ValueMember = "MaSach";
            cboTensach.DataSource = dt;
        }
        private void cboTensach_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combobox = sender as ComboBox;
            MaSach = (int)combobox.SelectedValue;
        }

        private void dgvHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            if (hang < 0) hang = 0;
            if (hang == dgvHienThi.RowCount - 1) hang = hang-1;
            cboTensach.Text = dgvHienThi[0,hang].Value.ToString();
            numSoluong.Value =(int)dgvHienThi[1,hang].Value;
            numGia.Value = (int)dgvHienThi[2, hang].Value;
        }

        private void btnThem_Click(object sender, EventArgs e)
        { 
            int Slban = (int)numSoluong.Value;
            int gia = (int)numGia.Value ;
            DTO_ChiTietHoaDon chitiethd = new DTO_ChiTietHoaDon(MaHoaDon,MaSach,Slban, gia);

            try
            {
                if (Slban == 0 || gia == 0)
                {

                    MessageBox.Show("Số lượng sách và giá sách phải lớn hơn 0\nVui lòng chọn sách khác");
                }
                else
                {
                    if (chitiethoadon.themChiTietHoaDon(chitiethd) == true)
                    {
                        MessageBox.Show("Thêm thành công");
                        dgvHienThi.DataSource = chitiethoadon.GetChiTietHoaDon(MaHoaDon);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Đã tồn tại sách này\nVui lòng chọn sách khác");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int Slban = (int)numSoluong.Value;
            int gia = (int)numGia.Value;
            DTO_ChiTietHoaDon chitiethd = new DTO_ChiTietHoaDon(MaHoaDon, MaSach, Slban , gia);
            if (chitiethoadon.suaChiTietHoaDon(chitiethd) == true)
            {
                MessageBox.Show("Cập nhật thành công");
                dgvHienThi.DataSource = chitiethoadon.GetChiTietHoaDon(MaHoaDon);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            numSoluong.Value = 0;
            numGia.Value = 0;
            cboTensach.SelectedIndex = 0;
            dgvHienThi.DataSource = chitiethoadon.GetChiTietHoaDon(MaHoaDon);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int Slban = (int)numSoluong.Value;
            int gia = (int)numGia.Value;
            DTO_ChiTietHoaDon chitiethd = new DTO_ChiTietHoaDon(MaHoaDon, MaSach, Slban, gia);
            DialogResult check = MessageBox.Show("Bạn có muốn xoá đầu sách này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                if (chitiethoadon.xoaChiTietHoaDon(chitiethd) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    dgvHienThi.DataSource = chitiethoadon.GetChiTietHoaDon(MaHoaDon);
                }
            }

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            if (keyword == "")
            {
                MessageBox.Show("Ô tìm kiếm đang trống\nVui lòng nhập lại");
            }
            else
            {
                DataTable dt = new DataTable();
                dt = chitiethoadon.TimChiTietHoaDon(keyword,MaHoaDon);
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

        private void btnInhoadon_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = chitiethoadon.GetChiTietHoaDon("exec proc_inchitiethoadon @mahoadon = " + MaHoaDon);
            ReportHoaDon report = new ReportHoaDon();
            report.SetDataSource(dt);

            ReportPrinting form = new ReportPrinting(report);
            form.ShowDialog();
        }
    }
}
