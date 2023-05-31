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
    public partial class GUI_ChiTietPhieuNhap : Form
    {
        BUS_ChiTietPhieuNhap chitietPhieuNhap = new BUS_ChiTietPhieuNhap();
        int MaSach;
        int MaPhieuNhap;
        public GUI_ChiTietPhieuNhap(int MaPhieuNhap)
        {
            InitializeComponent();
            this.MaPhieuNhap = MaPhieuNhap;
            LoadcboTenSach();
            LoadTongTien();

        }
        private void LoadTongTien()
        {
            object result = chitietPhieuNhap.SqlScalar("SELECT SUM(SLnhap * Gianhap) FROM ChitietPhieuNhap WHERE MaPhieuNhap = " + MaPhieuNhap);
            double tongtien = Convert.ToDouble(result);
            lbTongtien.Text = "Tổng tiền: " + tongtien;
        }

        private void GUI_ChitietPhieuNhap_Load(object sender, EventArgs e)
        {
            Title.Text = "Chi Tiết Phiếu nhập " + MaPhieuNhap;
            DataTable dt = new DataTable();
            dt = chitietPhieuNhap.GetChiTietPhieuNhap("select TenSach as [Tên sách], SLnhap as [Số lượng], Gianhap as [Giá bán],ChitietPhieuNhap.SLnhap * ChitietPhieuNhap.Gianhap as [Thành tiền] from ChiTietPhieuNhap inner join Sach on ChitietPhieuNhap.MaSach = Sach.MaSach inner join PhieuNhap on ChitietPhieuNhap.MaPhieuNhap = PhieuNhap.MaPhieuNhap and ChitietPhieuNhap.MaPhieuNhap = " + MaPhieuNhap);
            dgvHienThi.DataSource = dt;
        }
        private void LoadcboTenSach()
        {
            DataTable dt = new DataTable();
            dt = chitietPhieuNhap.GetChiTietPhieuNhap("select * from Sach");
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
            if (hang == dgvHienThi.RowCount - 1) hang = hang - 1;
            cboTensach.Text = dgvHienThi[0, hang].Value.ToString();
            numSoluong.Value = (int)dgvHienThi[1, hang].Value;
            numGia.Value = (int)dgvHienThi[2, hang].Value;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int SLnhap = (int)numSoluong.Value;
            int gia = (int)numGia.Value;
            DTO_ChiTietPhieuNhap chitietpn = new DTO_ChiTietPhieuNhap(MaPhieuNhap, MaSach, SLnhap, gia);
            if (SLnhap == 0 || gia == 0)
            {

                MessageBox.Show("Số lượng sách và giá sách phải lớn hơn 0\nVui lòng chọn sách khác");
            }
            else
            {
                if (chitietPhieuNhap.themChiTietPhieuNhap(chitietpn) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    dgvHienThi.DataSource = chitietPhieuNhap.GetChiTietPhieuNhap(MaPhieuNhap);
                }
            }
            try
            {
                
            }
            catch
            {
                MessageBox.Show("Đã tồn tại sách này\nVui lòng chọn sách khác");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int SLnhap = (int)numSoluong.Value;
            int gia = (int)numGia.Value;
            DTO_ChiTietPhieuNhap chitiethd = new DTO_ChiTietPhieuNhap(MaPhieuNhap, MaSach, SLnhap, gia);
            if (chitietPhieuNhap.suaChiTietPhieuNhap(chitiethd) == true)
            {
                MessageBox.Show("Cập nhật thành công");
                dgvHienThi.DataSource = chitietPhieuNhap.GetChiTietPhieuNhap(MaPhieuNhap);
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
            dgvHienThi.DataSource = chitietPhieuNhap.GetChiTietPhieuNhap(MaPhieuNhap);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int SLnhap = (int)numSoluong.Value;
            int gia = (int)numGia.Value;
            DTO_ChiTietPhieuNhap chitiethd = new DTO_ChiTietPhieuNhap(MaPhieuNhap, MaSach, SLnhap, gia);
            DialogResult check = MessageBox.Show("Bạn có muốn xoá đầu sách này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                if (chitietPhieuNhap.xoaChiTietPhieuNhap(chitiethd) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    dgvHienThi.DataSource = chitietPhieuNhap.GetChiTietPhieuNhap(MaPhieuNhap);
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
                dt = chitietPhieuNhap.TimChiTietPhieuNhap(keyword, MaPhieuNhap);
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

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = chitietPhieuNhap.GetChiTietPhieuNhap("exec proc_inchitiethoadon @mahoadon = " + MaPhieuNhap);
            ReportPhieuNhap report = new ReportPhieuNhap();
            report.SetDataSource(dt);

            ReportPrinting form = new ReportPrinting(report);
            form.ShowDialog();
        }
    }
}
