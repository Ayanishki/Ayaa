namespace DO_AN_1
{
    partial class GUI_HoaDon
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
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Inputpnl = new System.Windows.Forms.Panel();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Datelaphoadon = new System.Windows.Forms.DateTimePicker();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.MoTalbl = new System.Windows.Forms.Label();
            this.txtTenkhachang = new System.Windows.Forms.TextBox();
            this.MaLoailbl = new System.Windows.Forms.Label();
            this.TenLoailbl = new System.Windows.Forms.Label();
            this.Exepnl = new System.Windows.Forms.Panel();
            this.btnChitiet = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvHienThi = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.Inputpnl.SuspendLayout();
            this.Exepnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 19);
            this.label7.TabIndex = 81;
            this.label7.Text = "Tìm kiếm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(63, 163);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 46);
            this.panel1.TabIndex = 92;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Image = global::DO_AN_1.Properties.Resources.search;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(771, 6);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnFind.Size = new System.Drawing.Size(113, 35);
            this.btnFind.TabIndex = 83;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(106, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(636, 26);
            this.txtSearch.TabIndex = 82;
            // 
            // Inputpnl
            // 
            this.Inputpnl.BackColor = System.Drawing.Color.LightSlateGray;
            this.Inputpnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Inputpnl.Controls.Add(this.txtDiachi);
            this.Inputpnl.Controls.Add(this.label2);
            this.Inputpnl.Controls.Add(this.txtEmail);
            this.Inputpnl.Controls.Add(this.label1);
            this.Inputpnl.Controls.Add(this.Datelaphoadon);
            this.Inputpnl.Controls.Add(this.txtSDTKH);
            this.Inputpnl.Controls.Add(this.MoTalbl);
            this.Inputpnl.Controls.Add(this.txtTenkhachang);
            this.Inputpnl.Controls.Add(this.MaLoailbl);
            this.Inputpnl.Controls.Add(this.TenLoailbl);
            this.Inputpnl.Location = new System.Drawing.Point(63, 39);
            this.Inputpnl.Margin = new System.Windows.Forms.Padding(2);
            this.Inputpnl.Name = "Inputpnl";
            this.Inputpnl.Size = new System.Drawing.Size(906, 120);
            this.Inputpnl.TabIndex = 90;
            this.Inputpnl.Paint += new System.Windows.Forms.PaintEventHandler(this.Inputpnl_Paint);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.Location = new System.Drawing.Point(556, 64);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(328, 25);
            this.txtDiachi.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(486, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 71;
            this.label2.Text = "Đia chỉ :";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(556, 26);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(328, 25);
            this.txtEmail.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 69;
            this.label1.Text = "Email :";
            // 
            // Datelaphoadon
            // 
            this.Datelaphoadon.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelaphoadon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datelaphoadon.Location = new System.Drawing.Point(158, 79);
            this.Datelaphoadon.Name = "Datelaphoadon";
            this.Datelaphoadon.Size = new System.Drawing.Size(227, 25);
            this.Datelaphoadon.TabIndex = 68;
            this.Datelaphoadon.Value = new System.DateTime(2023, 5, 27, 0, 0, 0, 0);
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTKH.Location = new System.Drawing.Point(158, 44);
            this.txtSDTKH.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(227, 25);
            this.txtSDTKH.TabIndex = 67;
            // 
            // MoTalbl
            // 
            this.MoTalbl.AutoSize = true;
            this.MoTalbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoTalbl.Location = new System.Drawing.Point(32, 82);
            this.MoTalbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MoTalbl.Name = "MoTalbl";
            this.MoTalbl.Size = new System.Drawing.Size(120, 17);
            this.MoTalbl.TabIndex = 60;
            this.MoTalbl.Text = "Ngày lập hoá đơn :";
            // 
            // txtTenkhachang
            // 
            this.txtTenkhachang.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenkhachang.Location = new System.Drawing.Point(158, 8);
            this.txtTenkhachang.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenkhachang.Name = "txtTenkhachang";
            this.txtTenkhachang.Size = new System.Drawing.Size(227, 25);
            this.txtTenkhachang.TabIndex = 62;
            // 
            // MaLoailbl
            // 
            this.MaLoailbl.AutoSize = true;
            this.MaLoailbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaLoailbl.Location = new System.Drawing.Point(32, 11);
            this.MaLoailbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaLoailbl.Name = "MaLoailbl";
            this.MaLoailbl.Size = new System.Drawing.Size(117, 17);
            this.MaLoailbl.TabIndex = 59;
            this.MaLoailbl.Text = "Tên Khách Hàng :";
            // 
            // TenLoailbl
            // 
            this.TenLoailbl.AutoSize = true;
            this.TenLoailbl.BackColor = System.Drawing.Color.Transparent;
            this.TenLoailbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenLoailbl.Location = new System.Drawing.Point(32, 47);
            this.TenLoailbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TenLoailbl.Name = "TenLoailbl";
            this.TenLoailbl.Size = new System.Drawing.Size(122, 17);
            this.TenLoailbl.TabIndex = 58;
            this.TenLoailbl.Text = "SDT Khách Hàng :";
            // 
            // Exepnl
            // 
            this.Exepnl.BackColor = System.Drawing.Color.LightSlateGray;
            this.Exepnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Exepnl.Controls.Add(this.btnChitiet);
            this.Exepnl.Controls.Add(this.btnThem);
            this.Exepnl.Controls.Add(this.Clearbtn);
            this.Exepnl.Controls.Add(this.btnSua);
            this.Exepnl.Controls.Add(this.btnXoa);
            this.Exepnl.Controls.Add(this.btnThoat);
            this.Exepnl.Location = new System.Drawing.Point(810, 213);
            this.Exepnl.Margin = new System.Windows.Forms.Padding(2);
            this.Exepnl.Name = "Exepnl";
            this.Exepnl.Size = new System.Drawing.Size(159, 355);
            this.Exepnl.TabIndex = 91;
            // 
            // btnChitiet
            // 
            this.btnChitiet.Image = global::DO_AN_1.Properties.Resources.refresh;
            this.btnChitiet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChitiet.Location = new System.Drawing.Point(24, 183);
            this.btnChitiet.Margin = new System.Windows.Forms.Padding(2);
            this.btnChitiet.Name = "btnChitiet";
            this.btnChitiet.Size = new System.Drawing.Size(113, 35);
            this.btnChitiet.TabIndex = 93;
            this.btnChitiet.Text = "Chi tiết";
            this.btnChitiet.UseVisualStyleBackColor = true;
            this.btnChitiet.Click += new System.EventHandler(this.btnChitiet_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::DO_AN_1.Properties.Resources.add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(24, 28);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 35);
            this.btnThem.TabIndex = 78;
            this.btnThem.Text = "&Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.Image = global::DO_AN_1.Properties.Resources.refresh;
            this.Clearbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clearbtn.Location = new System.Drawing.Point(24, 233);
            this.Clearbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(113, 35);
            this.Clearbtn.TabIndex = 76;
            this.Clearbtn.Text = "&Làm mới";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::DO_AN_1.Properties.Resources.settings_sliders;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(24, 78);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(113, 35);
            this.btnSua.TabIndex = 73;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::DO_AN_1.Properties.Resources.trash;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(24, 131);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnXoa.Size = new System.Drawing.Size(113, 35);
            this.btnXoa.TabIndex = 74;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::DO_AN_1.Properties.Resources.exit;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(24, 285);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 35);
            this.btnThoat.TabIndex = 75;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvHienThi
            // 
            this.dgvHienThi.AllowUserToResizeColumns = false;
            this.dgvHienThi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHienThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHienThi.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvHienThi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThi.Location = new System.Drawing.Point(63, 213);
            this.dgvHienThi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHienThi.Name = "dgvHienThi";
            this.dgvHienThi.RowHeadersWidth = 51;
            this.dgvHienThi.Size = new System.Drawing.Size(743, 355);
            this.dgvHienThi.TabIndex = 89;
            this.dgvHienThi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHienThi_CellClick);
            // 
            // GUI_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1032, 618);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Inputpnl);
            this.Controls.Add(this.Exepnl);
            this.Controls.Add(this.dgvHienThi);
            this.Name = "GUI_HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_HoaDon";
            this.Load += new System.EventHandler(this.GUI_HoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Inputpnl.ResumeLayout(false);
            this.Inputpnl.PerformLayout();
            this.Exepnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel Inputpnl;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.Label MoTalbl;
        private System.Windows.Forms.Label MaLoailbl;
        private System.Windows.Forms.Label TenLoailbl;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel Exepnl;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvHienThi;
        private System.Windows.Forms.TextBox txtTenkhachang;
        private System.Windows.Forms.DateTimePicker Datelaphoadon;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChitiet;
    }
}