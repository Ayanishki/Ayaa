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
    public partial class GUI_NhaCC : Form
    {
        BUS_NhaCC busNCC = new BUS_NhaCC();
        private int Mancc;
        public GUI_NhaCC()
        {
            InitializeComponent();
        }
        private void GUI_NCC_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = busNCC.GetNCC();
            dgvHienThi.DataSource = dt;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenNCC = txtTenncc.Text;
            string diachi = txtDiachi.Text;
            string sdtncc =txtSdt.Text;
            string email = txtEmail.Text;
            DTO_NhaCC NCC = new DTO_NhaCC(tenNCC, diachi, sdtncc, email);

            if (busNCC.themNCC(NCC) == true)
            {
                MessageBox.Show("Thêm thành công");
                dgvHienThi.DataSource = busNCC.GetNCC();
            }
        }

        private void dgvHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            if (hang < 0) hang = 0;
            if (hang == dgvHienThi.RowCount - 1) hang = hang - 1;
            Mancc = (int)dgvHienThi[0, hang].Value;
            txtTenncc.Text = dgvHienThi[1, hang].Value.ToString();
            txtDiachi.Text = dgvHienThi[2, hang].Value.ToString();
            txtSdt.Text = dgvHienThi[3, hang].Value.ToString();
            txtEmail.Text = dgvHienThi[4, hang].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maNCC = Mancc;
            string tenNCC = txtTenncc.Text;
            string diachi = txtDiachi.Text;
            string sdtncc = txtSdt.Text;
            string email = txtEmail.Text;
            DTO_NhaCC NCC = new DTO_NhaCC(maNCC,tenNCC, diachi, sdtncc, email);

            if (busNCC.SuaNCC(NCC) == true)
            {
                MessageBox.Show("Cập nhật thành công");
                dgvHienThi.DataSource = busNCC.GetNCC();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maNCC = Mancc;
            string tenNCC = txtTenncc.Text;
            string diachi = txtDiachi.Text;
            string sdtncc = txtSdt.Text;
            string email = txtEmail.Text;
            DTO_NhaCC NCC = new DTO_NhaCC(maNCC, tenNCC, diachi, sdtncc, email);

            DialogResult check = MessageBox.Show("Bạn có muốn xoá đầu sách này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                if (busNCC.XoaNCC(NCC) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    dgvHienThi.DataSource = busNCC.GetNCC();
                }
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenncc.Clear();
            txtSdt.Clear();
            txtEmail.Clear();
            txtDiachi.Clear();
            txtSearch.Clear();
            dgvHienThi.DataSource = busNCC.GetNCC();
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
                dt = busNCC.TimNCC(keywords);
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
