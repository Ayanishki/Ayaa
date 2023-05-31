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
    public partial class GUI_Log_in : Form
    {
        BUS_Users bususer = new BUS_Users();
        public GUI_Log_in()
        {
            InitializeComponent();
        }
        private bool utb = true;
        private bool ptb = true;
        private void LoadDisplayname()
        {
            string username = Usertb.Text;
            string password = Pwtb.Text;
            DTO_Users user = new DTO_Users(username, password);
            object displayname = bususer.SqlScalar("select Displayname from Users where Username = '" + user.UserName + "'" + " and Passwords ='" + user.Passwords + "'");
        }
        private void Signinbtn_Click(object sender, EventArgs e)
        {
            string username = Usertb.Text;
            string password = Pwtb.Text;
            DTO_Users user = new DTO_Users(username,password);
            DataTable dt = new DataTable();
            if (bususer.Login(user) == true) {
                MenuStrip menu = this.MdiParent.Controls["HomeStrip"] as MenuStrip;
                object displayname = bususer.SqlScalar("select Displayname from Users where Username = '" + user.UserName + "'" + " and Passwords ='" + user.Passwords + "'");
                menu.Items["Menulogin"].Text = "Hello " + displayname + "!!!";
                menu.Items["MenuSignup"].Text = "Đăng xuất";
                menu.Items["MenuSignup"].Visible = true;
                ToolStripMenuItem tsmi = menu.Items["Managing"] as ToolStripMenuItem;
                if (bususer.Loginadmin(user) == true)//đăng nhập quyền admin
                {
                    menu.Items["Managing"].Enabled= true;
                    tsmi.DropDownItems["btnqlhoadon"].Enabled = true;
                    tsmi.DropDownItems["btnqlphieunhap"].Enabled = true;
                    tsmi.DropDownItems["btnqlsach"].Enabled = true;
                    tsmi.DropDownItems["btnqlloaisach"].Enabled = true;
                    tsmi.DropDownItems["btnqlncc"].Enabled = true;
                    tsmi.DropDownItems["btnqlkhachhang"].Enabled = true;
                    tsmi.DropDownItems["btnqlsach"].Enabled = true;
                    tsmi.DropDownItems["btnqluser"].Enabled = true;
                }
                else //Quyền đăng nhập nhân viên
                {
                    menu.Items["Managing"].Enabled= true;
                    tsmi.DropDownItems["btnqlhoadon"].Enabled = true;
                    tsmi.DropDownItems["btnqlphieunhap"].Enabled = true;
                    tsmi.DropDownItems["btnqlsach"].Enabled = true;
                    tsmi.DropDownItems["btnqlloaisach"].Enabled = true;
                    tsmi.DropDownItems["btnqlncc"].Enabled = true;
                    tsmi.DropDownItems["btnqlkhachhang"].Enabled = true;
                    tsmi.DropDownItems["btnqlsach"].Enabled = true;
                    tsmi.DropDownItems["btnqluser"].Enabled = true;

                }  
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản không đúng, Vui lòng đăng nhập lại");
            } 
                
        }

        private void Usertb_Click(object sender, EventArgs e)
        {
            if(utb)
            {
                Usertb.Text = null;
                utb = false;
            }
        }

        private void Pwtb_Click(object sender, EventArgs e)
        {
            if (ptb)
            {
                Pwtb.Text = null;
                ptb = false;
            }
        }

        private void GUI_Log_in_Load(object sender, EventArgs e)
        {
            Usertb.SelectionStart = Usertb.Text.Length;
            Usertb.SelectionLength = 0;
        }

        private void Usertb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    Signinbtn_Click(sender, e);
                }
            }
        }

        private void Pwtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Signinbtn_Click(sender, e);
            }
        }
    }
}
