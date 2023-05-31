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
    public partial class GUI_PhieuNhap : Form
    {
        BUS_PhieuNhap busphieunhap = new BUS_PhieuNhap();
        int Mancc;
        int Manv;
        int Maphieunhap;
        public GUI_PhieuNhap()
        {
            InitializeComponent();
        }

        private void GUI_PhieuNhap_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            LoadCboxNCC();
            LoadCboxNV();
            dt = busphieunhap.GetPhieuNhap();
            dgvHienThi.DataSource = dt;
        }

        private void cboNhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            Manv = (int)comboBox.SelectedValue;
        }
        private void LoadCboxNCC()
        {
            DataTable dt = new DataTable();
            dt = busphieunhap.GetPhieuNhap("select * from NhaCC");
            cboNhaCC.DisplayMember = "TenNCC";
            cboNhaCC.ValueMember = "MaNCC";
            cboNhaCC.DataSource = dt;
        }
        private void LoadCboxNV()
        {
            DataTable dt = new DataTable();
            dt = busphieunhap.GetPhieuNhap("select * from NhanVien");
            cboNhanvien.DisplayMember = "TenNV";
            cboNhanvien.ValueMember = "MaNV";
            cboNhanvien.DataSource = dt;
        }
        private void cboNhaCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            Mancc = (int)comboBox.SelectedValue;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DateTime ngaylappn = Datelapphieunhap.Value;
            float trieukhaunhap = float.Parse(txtChieukhaunhap.Text);
            DTO_PhieuNhap phieunhap = new DTO_PhieuNhap(Manv, ngaylappn, Mancc, trieukhaunhap);
            if (busphieunhap.themPhieuNhap(phieunhap) == true)
            {
                MessageBox.Show("Thêm thành công");
                dgvHienThi.DataSource = busphieunhap.GetPhieuNhap();
            }
        }

        private void dgvHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            if (hang < 0) hang = 0;
            if (hang == dgvHienThi.RowCount - 1) hang = hang - 1;
            Maphieunhap = (int)dgvHienThi[0, hang].Value;
            cboNhanvien.Text = dgvHienThi[2, hang].Value.ToString();
            Datelapphieunhap.Value = DateTime.Parse(dgvHienThi[1, hang].Value.ToString());
            cboNhaCC.Text = dgvHienThi[3, hang].Value.ToString();
            txtChieukhaunhap.Text = dgvHienThi[4, hang].Value.ToString();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DateTime ngaylappn = Datelapphieunhap.Value;
            float chieukhaunhap = float.Parse(txtChieukhaunhap.Text);
            DTO_PhieuNhap phieunhap = new DTO_PhieuNhap();
            DialogResult check = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {
                if (busphieunhap.xoaPhieuNhap(phieunhap) == true)
                {
                    MessageBox.Show("Xoá thành công");
                    dgvHienThi.DataSource = busphieunhap.GetPhieuNhap();
                }
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            cboNhaCC.Refresh();
            txtChieukhaunhap.Clear();
            txtSearch.Clear();
            cboNhanvien.Refresh();
            Datelapphieunhap.Value.ToLocalTime();
            dgvHienThi.DataSource = busphieunhap.GetPhieuNhap();
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
                dt = busphieunhap.TimPhieuNhap(keywords);
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
            GUI_ChiTietPhieuNhap form = new GUI_ChiTietPhieuNhap(Maphieunhap);
            form.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DateTime ngaylappn = Datelapphieunhap.Value;
            float trieukhaunhap = float.Parse(txtChieukhaunhap.Text);
            DTO_PhieuNhap phieunhap = new DTO_PhieuNhap(Maphieunhap,Manv, ngaylappn, Mancc, trieukhaunhap);
            if (busphieunhap.suaPhieuNhap(phieunhap) == true)
            {
                MessageBox.Show("Cập nhật thành công");
                dgvHienThi.DataSource = busphieunhap.GetPhieuNhap();
            }
        }
    }
}
