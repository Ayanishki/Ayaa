namespace DO_AN_1
{
    partial class GUI_LoaiSach
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
            this.dgvHienThi = new System.Windows.Forms.DataGridView();
            this.Exepnl = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.Inputpnl = new System.Windows.Forms.Panel();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.MoTalbl = new System.Windows.Forms.Label();
            this.TenLoailbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
            this.Exepnl.SuspendLayout();
            this.Inputpnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHienThi
            // 
            this.dgvHienThi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHienThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHienThi.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvHienThi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThi.Location = new System.Drawing.Point(31, 191);
            this.dgvHienThi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHienThi.Name = "dgvHienThi";
            this.dgvHienThi.RowHeadersWidth = 51;
            this.dgvHienThi.Size = new System.Drawing.Size(743, 355);
            this.dgvHienThi.TabIndex = 81;
            this.dgvHienThi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHienThi_CellClick);
            // 
            // Exepnl
            // 
            this.Exepnl.BackColor = System.Drawing.Color.LightSlateGray;
            this.Exepnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Exepnl.Controls.Add(this.btnThem);
            this.Exepnl.Controls.Add(this.Clearbtn);
            this.Exepnl.Controls.Add(this.btnSua);
            this.Exepnl.Controls.Add(this.btnXoa);
            this.Exepnl.Controls.Add(this.btnThoat);
            this.Exepnl.Location = new System.Drawing.Point(778, 191);
            this.Exepnl.Margin = new System.Windows.Forms.Padding(2);
            this.Exepnl.Name = "Exepnl";
            this.Exepnl.Size = new System.Drawing.Size(159, 355);
            this.Exepnl.TabIndex = 83;
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
            this.Clearbtn.Location = new System.Drawing.Point(24, 219);
            this.Clearbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(113, 35);
            this.Clearbtn.TabIndex = 76;
            this.Clearbtn.Text = "&Làm mới";
            this.Clearbtn.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Image = global::DO_AN_1.Properties.Resources.settings_sliders;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(24, 88);
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
            this.btnXoa.Location = new System.Drawing.Point(24, 150);
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
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Image = global::DO_AN_1.Properties.Resources.exit;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(24, 285);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnThoat.Size = new System.Drawing.Size(113, 35);
            this.btnThoat.TabIndex = 75;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Inputpnl
            // 
            this.Inputpnl.BackColor = System.Drawing.Color.LightSlateGray;
            this.Inputpnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Inputpnl.Controls.Add(this.txtTenLoai);
            this.Inputpnl.Controls.Add(this.txtMota);
            this.Inputpnl.Controls.Add(this.MoTalbl);
            this.Inputpnl.Controls.Add(this.TenLoailbl);
            this.Inputpnl.Location = new System.Drawing.Point(31, 28);
            this.Inputpnl.Margin = new System.Windows.Forms.Padding(2);
            this.Inputpnl.Name = "Inputpnl";
            this.Inputpnl.Size = new System.Drawing.Size(906, 109);
            this.Inputpnl.TabIndex = 82;
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoai.Location = new System.Drawing.Point(106, 12);
            this.txtTenLoai.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(355, 25);
            this.txtTenLoai.TabIndex = 67;
            // 
            // txtMota
            // 
            this.txtMota.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMota.Location = new System.Drawing.Point(106, 53);
            this.txtMota.Margin = new System.Windows.Forms.Padding(2);
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(355, 25);
            this.txtMota.TabIndex = 63;
            // 
            // MoTalbl
            // 
            this.MoTalbl.AutoSize = true;
            this.MoTalbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoTalbl.Location = new System.Drawing.Point(24, 56);
            this.MoTalbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MoTalbl.Name = "MoTalbl";
            this.MoTalbl.Size = new System.Drawing.Size(43, 17);
            this.MoTalbl.TabIndex = 60;
            this.MoTalbl.Text = "Mô tả";
            // 
            // TenLoailbl
            // 
            this.TenLoailbl.AutoSize = true;
            this.TenLoailbl.BackColor = System.Drawing.Color.Transparent;
            this.TenLoailbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenLoailbl.Location = new System.Drawing.Point(24, 15);
            this.TenLoailbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TenLoailbl.Name = "TenLoailbl";
            this.TenLoailbl.Size = new System.Drawing.Size(61, 17);
            this.TenLoailbl.TabIndex = 58;
            this.TenLoailbl.Text = "Tên Loại";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(31, 141);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 46);
            this.panel1.TabIndex = 88;
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
            // GUI_LoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(972, 578);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvHienThi);
            this.Controls.Add(this.Exepnl);
            this.Controls.Add(this.Inputpnl);
            this.Name = "GUI_LoaiSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GUI_LoaiSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).EndInit();
            this.Exepnl.ResumeLayout(false);
            this.Inputpnl.ResumeLayout(false);
            this.Inputpnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHienThi;
        private System.Windows.Forms.Panel Exepnl;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel Inputpnl;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.Label MoTalbl;
        private System.Windows.Forms.Label TenLoailbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
    }
}

