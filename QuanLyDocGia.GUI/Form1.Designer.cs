namespace QuanLyDocGia.GUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblLoaiDocGia = new System.Windows.Forms.Label();
            this.cboLoaiDocGia = new System.Windows.Forms.ComboBox();
            this.lblMaDG = new System.Windows.Forms.Label();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblPhiThuongNien = new System.Windows.Forms.Label();
            this.txtPhiThuongNien = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvDocGia = new System.Windows.Forms.DataGridView();
            this.colMaDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhiThuongNien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpThongTin.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.SuspendLayout();

            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTieuDe.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTieuDe.Location = new System.Drawing.Point(20, 10);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(920, 35);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "QUẢN LÝ ĐỘC GIẢ THƯ VIỆN";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.lblLoaiDocGia);
            this.grpThongTin.Controls.Add(this.cboLoaiDocGia);
            this.grpThongTin.Controls.Add(this.lblMaDG);
            this.grpThongTin.Controls.Add(this.txtMaDG);
            this.grpThongTin.Controls.Add(this.lblHoTen);
            this.grpThongTin.Controls.Add(this.txtHoTen);
            this.grpThongTin.Controls.Add(this.lblGioiTinh);
            this.grpThongTin.Controls.Add(this.cboGioiTinh);
            this.grpThongTin.Controls.Add(this.lblNgaySinh);
            this.grpThongTin.Controls.Add(this.dtpNgaySinh);
            this.grpThongTin.Controls.Add(this.lblPhiThuongNien);
            this.grpThongTin.Controls.Add(this.txtPhiThuongNien);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpThongTin.Location = new System.Drawing.Point(20, 50);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(760, 185);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin độc giả";

            // 
            // lblLoaiDocGia
            // 
            this.lblLoaiDocGia.AutoSize = true;
            this.lblLoaiDocGia.Location = new System.Drawing.Point(20, 35);
            this.lblLoaiDocGia.Name = "lblLoaiDocGia";
            this.lblLoaiDocGia.Size = new System.Drawing.Size(83, 17);
            this.lblLoaiDocGia.TabIndex = 0;
            this.lblLoaiDocGia.Text = "Loại độc giả:";

            // 
            // cboLoaiDocGia
            // 
            this.cboLoaiDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiDocGia.FormattingEnabled = true;
            this.cboLoaiDocGia.Location = new System.Drawing.Point(125, 32);
            this.cboLoaiDocGia.Name = "cboLoaiDocGia";
            this.cboLoaiDocGia.Size = new System.Drawing.Size(230, 25);
            this.cboLoaiDocGia.TabIndex = 1;

            // 
            // lblMaDG
            // 
            this.lblMaDG.AutoSize = true;
            this.lblMaDG.Location = new System.Drawing.Point(20, 80);
            this.lblMaDG.Name = "lblMaDG";
            this.lblMaDG.Size = new System.Drawing.Size(77, 17);
            this.lblMaDG.TabIndex = 2;
            this.lblMaDG.Text = "Mã độc giả:";

            // 
            // txtMaDG
            // 
            this.txtMaDG.Location = new System.Drawing.Point(125, 77);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(230, 24);
            this.txtMaDG.TabIndex = 3;

            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(20, 125);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(67, 17);
            this.lblHoTen.TabIndex = 4;
            this.lblHoTen.Text = "Họ và tên:";

            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(125, 122);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(230, 24);
            this.txtHoTen.TabIndex = 5;

            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(395, 35);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(59, 17);
            this.lblGioiTinh.TabIndex = 6;
            this.lblGioiTinh.Text = "Giới tính:";

            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            this.cboGioiTinh.Location = new System.Drawing.Point(510, 32);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(230, 25);
            this.cboGioiTinh.TabIndex = 7;

            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(395, 80);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(69, 17);
            this.lblNgaySinh.TabIndex = 8;
            this.lblNgaySinh.Text = "Ngày sinh:";

            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(510, 77);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(230, 24);
            this.dtpNgaySinh.TabIndex = 9;

            // 
            // lblPhiThuongNien
            // 
            this.lblPhiThuongNien.AutoSize = true;
            this.lblPhiThuongNien.Location = new System.Drawing.Point(395, 125);
            this.lblPhiThuongNien.Name = "lblPhiThuongNien";
            this.lblPhiThuongNien.Size = new System.Drawing.Size(102, 17);
            this.lblPhiThuongNien.TabIndex = 10;
            this.lblPhiThuongNien.Text = "Phí thường niên:";

            // 
            // txtPhiThuongNien
            // 
            this.txtPhiThuongNien.Location = new System.Drawing.Point(510, 122);
            this.txtPhiThuongNien.Name = "txtPhiThuongNien";
            this.txtPhiThuongNien.Size = new System.Drawing.Size(230, 24);
            this.txtPhiThuongNien.TabIndex = 11;

            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(800, 55);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(140, 32);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.Text = "Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(800, 93);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(140, 32);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(800, 131);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(140, 32);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Crimson;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(800, 169);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(140, 32);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DimGray;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(800, 207);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(140, 32);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dgvDocGia);
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpDanhSach.Location = new System.Drawing.Point(20, 245);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(920, 340);
            this.grpDanhSach.TabIndex = 7;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách độc giả";

            // 
            // dgvDocGia
            // 
            this.dgvDocGia.AllowUserToAddRows = false;
            this.dgvDocGia.AllowUserToDeleteRows = false;
            this.dgvDocGia.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDG,
            this.colHoTen,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colPhiThuongNien,
            this.colLoaiDocGia});
            this.dgvDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocGia.Location = new System.Drawing.Point(3, 20);
            this.dgvDocGia.MultiSelect = false;
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.ReadOnly = true;
            this.dgvDocGia.RowHeadersVisible = false;
            this.dgvDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocGia.Size = new System.Drawing.Size(914, 317);
            this.dgvDocGia.TabIndex = 0;
            this.dgvDocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocGia_CellClick);
            this.dgvDocGia.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDocGia_CellFormatting);

            // 
            // colMaDG
            // 
            this.colMaDG.DataPropertyName = "MaDG";
            this.colMaDG.HeaderText = "Mã ĐG";
            this.colMaDG.Name = "colMaDG";
            this.colMaDG.ReadOnly = true;
            this.colMaDG.Width = 110;

            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ và tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            this.colHoTen.Width = 200;

            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DataPropertyName = "GioiTinh";
            this.colGioiTinh.HeaderText = "Giới tính";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.ReadOnly = true;
            this.colGioiTinh.Width = 100;

            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "NgaySinh";
            this.colNgaySinh.DefaultCellStyle.Format = "dd/MM/yyyy";
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.ReadOnly = true;
            this.colNgaySinh.Width = 120;

            // 
            // colPhiThuongNien
            // 
            this.colPhiThuongNien.DataPropertyName = "PhiThuongNien";
            this.colPhiThuongNien.DefaultCellStyle.Format = "N0";
            this.colPhiThuongNien.HeaderText = "Phí năm";
            this.colPhiThuongNien.Name = "colPhiThuongNien";
            this.colPhiThuongNien.ReadOnly = true;
            this.colPhiThuongNien.Width = 130;

            // 
            // colLoaiDocGia
            // 
            this.colLoaiDocGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLoaiDocGia.DataPropertyName = "MaLoai";
            this.colLoaiDocGia.HeaderText = "Loại độc giả";
            this.colLoaiDocGia.Name = "colLoaiDocGia";
            this.colLoaiDocGia.ReadOnly = true;

            // 
            // Form1
            // 
            this.AcceptButton = this.btnThem;
            this.CancelButton = this.btnThoat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý độc giả – 24110359 – Nguyễn Đăng Khoa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblLoaiDocGia;
        private System.Windows.Forms.ComboBox cboLoaiDocGia;
        private System.Windows.Forms.Label lblMaDG;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblPhiThuongNien;
        private System.Windows.Forms.TextBox txtPhiThuongNien;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhiThuongNien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiDocGia;
    }
}
