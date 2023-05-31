
namespace DO_AN_1
{
    partial class GUI_Homepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Homepage));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.HomeStrip = new System.Windows.Forms.MenuStrip();
            this.Managing = new System.Windows.Forms.ToolStripMenuItem();
            this.btnqlhoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.btnqlphieunhap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnqlsach = new System.Windows.Forms.ToolStripMenuItem();
            this.btnqlloaisach = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnqlncc = new System.Windows.Forms.ToolStripMenuItem();
            this.btnqlkhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnqluser = new System.Windows.Forms.ToolStripMenuItem();
            this.Menulogin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSignup = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.HomeStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 643);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1138, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // HomeStrip
            // 
            this.HomeStrip.BackColor = System.Drawing.Color.White;
            this.HomeStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Managing,
            this.Menulogin,
            this.MenuSignup,
            this.MenuExit});
            this.HomeStrip.Location = new System.Drawing.Point(0, 0);
            this.HomeStrip.MdiWindowListItem = this.MenuExit;
            this.HomeStrip.Name = "HomeStrip";
            this.HomeStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.HomeStrip.Size = new System.Drawing.Size(1138, 26);
            this.HomeStrip.TabIndex = 4;
            this.HomeStrip.Text = "MenuStrip";
            // 
            // Managing
            // 
            this.Managing.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnqlhoadon,
            this.btnqlphieunhap,
            this.toolStripSeparator3,
            this.btnqlsach,
            this.btnqlloaisach,
            this.toolStripSeparator4,
            this.btnqlncc,
            this.btnqlkhachhang,
            this.toolStripSeparator5,
            this.btnqluser});
            this.Managing.Image = global::DO_AN_1.Properties.Resources.settings;
            this.Managing.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.Managing.Name = "Managing";
            this.Managing.Size = new System.Drawing.Size(76, 20);
            this.Managing.Text = "Quản lý";
            this.Managing.Click += new System.EventHandler(this.Managing_Click);
            // 
            // btnqlhoadon
            // 
            this.btnqlhoadon.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnqlhoadon.Name = "btnqlhoadon";
            this.btnqlhoadon.Size = new System.Drawing.Size(231, 22);
            this.btnqlhoadon.Text = "Quản lý hoá đơn";
            this.btnqlhoadon.Click += new System.EventHandler(this.btnqlhoadon_Click);
            // 
            // btnqlphieunhap
            // 
            this.btnqlphieunhap.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnqlphieunhap.Name = "btnqlphieunhap";
            this.btnqlphieunhap.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.btnqlphieunhap.Size = new System.Drawing.Size(231, 22);
            this.btnqlphieunhap.Text = "Quản lý phiếu nhập";
            this.btnqlphieunhap.Click += new System.EventHandler(this.btnqlphieunhap_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(228, 6);
            // 
            // btnqlsach
            // 
            this.btnqlsach.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnqlsach.Name = "btnqlsach";
            this.btnqlsach.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btnqlsach.Size = new System.Drawing.Size(231, 22);
            this.btnqlsach.Text = "Quản lý Sách";
            this.btnqlsach.Click += new System.EventHandler(this.btnqlsach_Click);
            // 
            // btnqlloaisach
            // 
            this.btnqlloaisach.Name = "btnqlloaisach";
            this.btnqlloaisach.Size = new System.Drawing.Size(231, 22);
            this.btnqlloaisach.Text = "Quản lý loại sách";
            this.btnqlloaisach.Click += new System.EventHandler(this.btnqlloaisach_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(228, 6);
            // 
            // btnqlncc
            // 
            this.btnqlncc.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnqlncc.Name = "btnqlncc";
            this.btnqlncc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.btnqlncc.Size = new System.Drawing.Size(231, 22);
            this.btnqlncc.Text = "Quản lý nhà cung cấp";
            this.btnqlncc.Click += new System.EventHandler(this.btnqlncc_Click);
            // 
            // btnqlkhachhang
            // 
            this.btnqlkhachhang.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnqlkhachhang.Name = "btnqlkhachhang";
            this.btnqlkhachhang.Size = new System.Drawing.Size(231, 22);
            this.btnqlkhachhang.Text = "Quản lý khách hàng";
            this.btnqlkhachhang.Click += new System.EventHandler(this.btnqlkhachhang_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(228, 6);
            // 
            // btnqluser
            // 
            this.btnqluser.Image = global::DO_AN_1.Properties.Resources.user;
            this.btnqluser.Name = "btnqluser";
            this.btnqluser.Size = new System.Drawing.Size(231, 22);
            this.btnqluser.Text = "Quản lý tài khoản";
            this.btnqluser.Click += new System.EventHandler(this.btnqluser_Click);
            // 
            // Menulogin
            // 
            this.Menulogin.Image = global::DO_AN_1.Properties.Resources.user;
            this.Menulogin.Name = "Menulogin";
            this.Menulogin.Size = new System.Drawing.Size(93, 20);
            this.Menulogin.Text = "Đăng nhập";
            this.Menulogin.Click += new System.EventHandler(this.Menulogin_Click);
            // 
            // MenuSignup
            // 
            this.MenuSignup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MenuSignup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.MenuSignup.Name = "MenuSignup";
            this.MenuSignup.Size = new System.Drawing.Size(62, 20);
            this.MenuSignup.Text = "Đăng ký";
            this.MenuSignup.Click += new System.EventHandler(this.MenuSignup_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // MenuExit
            // 
            this.MenuExit.Image = global::DO_AN_1.Properties.Resources.exit;
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(65, 20);
            this.MenuExit.Text = "Thoát";
            this.MenuExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // GUI_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::DO_AN_1.Properties.Resources.AppBG;
            this.ClientSize = new System.Drawing.Size(1138, 665);
            this.Controls.Add(this.HomeStrip);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "GUI_Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.HomeStrip.ResumeLayout(false);
            this.HomeStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip HomeStrip;
        private System.Windows.Forms.ToolStripMenuItem Managing;
        private System.Windows.Forms.ToolStripMenuItem btnqlhoadon;
        private System.Windows.Forms.ToolStripMenuItem btnqlphieunhap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem btnqlsach;
        private System.Windows.Forms.ToolStripMenuItem btnqlloaisach;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem btnqlncc;
        private System.Windows.Forms.ToolStripMenuItem btnqlkhachhang;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem btnqluser;
        private System.Windows.Forms.ToolStripMenuItem Menulogin;
        private System.Windows.Forms.ToolStripMenuItem MenuSignup;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
    }
}



