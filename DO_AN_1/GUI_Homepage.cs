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
    public partial class GUI_Homepage : Form
    {
        private int childFormNumber = 0;

        public GUI_Homepage()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Menulogin_Click(object sender, EventArgs e)
        {
            if (Menulogin.Text == "Đăng nhập") //Nhấn đăng nhập hiện form đăng nhập
            {
                GUI_Log_in lg = new GUI_Log_in();
                lg.MdiParent = this;
                lg.Show();
            }
        }

        private void MenuSignup_Click(object sender, EventArgs e)
        {
            if (MenuSignup.Text == "Đăng xuất") // Đăng xuất
            {
                Menulogin.Text = "Đăng nhập";
                MenuSignup.Text = "Đăng ký";
                Managing.Enabled = false;
                MenuSignup.Visible = false;
            }
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Managing_Click(object sender, EventArgs e)
        {
            
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            Managing.Enabled = false;
            MenuSignup.Visible = false;
        }

        private void btnqlphieunhap_Click(object sender, EventArgs e)
        {
            GUI_PhieuNhap childForm = new GUI_PhieuNhap();
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void btnqlhoadon_Click(object sender, EventArgs e)
        {
            GUI_HoaDon childForm = new GUI_HoaDon();
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void btnqlsach_Click(object sender, EventArgs e)
        {
            GUI_Sach childForm = new GUI_Sach();
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void btnqlloaisach_Click(object sender, EventArgs e)
        {
            GUI_LoaiSach childForm = new GUI_LoaiSach();
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void btnqlncc_Click(object sender, EventArgs e)
        {
            GUI_NhaCC childForm = new GUI_NhaCC();
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void btnqlkhachhang_Click(object sender, EventArgs e)
        {
            GUI_KhachHang childForm = new GUI_KhachHang();
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void btnqluser_Click(object sender, EventArgs e)
        {
            GUI_User childForm = new GUI_User();
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }
    }
}
