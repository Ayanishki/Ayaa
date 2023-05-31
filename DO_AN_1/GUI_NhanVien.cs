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
    public partial class GUI_NhanVien : Form
    {
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        private int MaNhanVien;
        public GUI_NhanVien()
        {
            InitializeComponent();
        }
        private void GUI_NhanVien_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = busNhanVien.GetNhanVien();
            dgvHienThi.DataSource = dt;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenNhanVien = txtTennv.Text;
            string diachi = txtDiachi.Text;
            string sdtNhanVien = txtSdt.Text;
            string email = txtEmail.Text;
            DateTime ngayvao = Datengayvao.Value;
            DTO_NhanVien NhanVien = new DTO_NhanVien(tenNhanVien, sdtNhanVien, email, diachi, ngayvao);

            if (busNhanVien.themNhanVien(NhanVien) == true)
            {
                MessageBox.Show("Thêm thành công");
                dgvHienThi.DataSource = busNhanVien.GetNhanVien();
            }
        }

        private void dgvHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            if (hang < 0) hang = 0;
            if (hang == dgvHienThi.RowCount - 1) hang = hang - 1;
            MaNhanVien = (int)dgvHienThi[0, hang].Value;
            txtTennv.Text = dgvHienThi[1, hang].Value.ToString();
            txtDiachi.Text = dgvHienThi[2, hang].Value.ToString();
            txtSdt.Text = dgvHienThi[3, hang].Value.ToString();
            txtEmail.Text = dgvHienThi[4, hang].Value.ToString();
            Datengayvao.Value = DateTime.Parse(dgvHienThi[5, hang].Value.ToString());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maNhanVien = MaNhanVien;
            string tenNhanVien = txtTennv.Text;
            string diachi = txtDiachi.Text;
            string sdtNhanVien = txtSdt.Text;
            string email = txtEmail.Text;
            DateTime ngayvao = Datengayvao.Value;
            DTO_NhanVien NhanVien = new DTO_NhanVien(maNhanVien, tenNhanVien, sdtNhanVien, email, diachi, ngayvao);

            if (busNhanVien.SuaNhanVien(NhanVien) == true)
            {
                MessageBox.Show("Cập nhật thành công");
                dgvHienThi.DataSource = busNhanVien.GetNhanVien();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maNhanVien = MaNhanVien;
            string tenNhanVien = txtTennv.Text;
            string diachi = txtDiachi.Text;
            string sdtNhanVien = txtSdt.Text;
            string email = txtEmail.Text;
            DateTime ngayvao = Datengayvao.Value;
            DTO_NhanVien NhanVien = new DTO_NhanVien(maNhanVien, tenNhanVien, sdtNhanVien, email, diachi, ngayvao);

            DialogResult check = MessageBox.Show("Bạn có muốn xoá đầu sách này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                if (busNhanVien.XoaNhanVien(NhanVien) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    dgvHienThi.DataSource = busNhanVien.GetNhanVien();
                }
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTennv.Clear();
            txtSdt.Clear();
            txtEmail.Clear();
            txtDiachi.Clear();
            txtSearch.Clear();
            Datengayvao.Value.ToLocalTime();
            dgvHienThi.DataSource = busNhanVien.GetNhanVien();
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
                dt = busNhanVien.TimNhanVien(keywords);
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
