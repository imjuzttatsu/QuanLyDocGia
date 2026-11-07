using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLyDocGia.BUS;
using QuanLyDocGia.Entity;

namespace QuanLyDocGia.GUI
{
    public partial class Form1 : Form
    {
        private readonly DocGiaBLL _docGiaBLL = new DocGiaBLL();
        private readonly LoaiDocGiaBLL _loaiDocGiaBLL = new LoaiDocGiaBLL();

        public Form1()
        {
            InitializeComponent();
            dgvDocGia.AutoGenerateColumns = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                LoadLoaiDocGiaComboBox();
                LoadDataGrid();
                ResetFormState();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadLoaiDocGiaComboBox()
        {
            var dsLoai = _loaiDocGiaBLL.GetAll();

            var comboItems = new List<LoaiDocGia>
            {
                new LoaiDocGia { MaLoai = "", TenLoai = "-- Chọn loại độc giả --" }
            };
            comboItems.AddRange(dsLoai);

            cboLoaiDocGia.DisplayMember = "TenLoai";
            cboLoaiDocGia.ValueMember = "MaLoai";
            cboLoaiDocGia.DataSource = comboItems;
        }

        private void LoadDataGrid()
        {
            dgvDocGia.DataSource = null;
            dgvDocGia.DataSource = _docGiaBLL.GetAll();
        }

        private void dgvDocGia_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dg = dgvDocGia.Rows[e.RowIndex].DataBoundItem as DocGia;
            if (dg == null) return;

            if (dgvDocGia.Columns[e.ColumnIndex].Name == "colGioiTinh")
            {
                e.Value = dg.GioiTinh ? "Nam" : "Nữ";
                e.FormattingApplied = true;
            }
            else if (dgvDocGia.Columns[e.ColumnIndex].Name == "colLoaiDocGia")
            {
                e.Value = dg.LoaiDocGia?.TenLoai;
                e.FormattingApplied = true;
            }
        }

        private void ResetFormState()
        {
            txtMaDG.Clear();
            txtHoTen.Clear();
            txtPhiThuongNien.Clear();

            if (cboLoaiDocGia.Items.Count > 0)
            {
                cboLoaiDocGia.SelectedIndex = 0;
            }
            cboGioiTinh.SelectedIndex = 0;
            dtpNgaySinh.Value = DateTime.Today;

            dgvDocGia.ClearSelection();

            txtMaDG.ReadOnly = false;
            txtMaDG.Focus();

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dg = dgvDocGia.Rows[e.RowIndex].DataBoundItem as DocGia;
            if (dg == null) return;

            txtMaDG.Text = dg.MaDG;
            txtHoTen.Text = dg.HoTen;
            cboGioiTinh.SelectedItem = dg.GioiTinh ? "Nam" : "Nữ";

            if (dg.NgaySinh >= dtpNgaySinh.MinDate && dg.NgaySinh <= dtpNgaySinh.MaxDate)
            {
                dtpNgaySinh.Value = dg.NgaySinh;
            }

            txtPhiThuongNien.Text = dg.PhiThuongNien.ToString("0.##");
            cboLoaiDocGia.SelectedValue = dg.MaLoai;

            txtMaDG.ReadOnly = true;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetFormState();
        }

        private DocGia LayDuLieuTuForm(decimal phi)
        {
            return new DocGia
            {
                MaDG = txtMaDG.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                GioiTinh = cboGioiTinh.SelectedItem?.ToString() == "Nam",
                NgaySinh = dtpNgaySinh.Value,
                PhiThuongNien = phi,
                MaLoai = cboLoaiDocGia.SelectedValue?.ToString() ?? ""
            };
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtPhiThuongNien.Text.Trim(), out decimal phi))
                {
                    MessageBox.Show("Phí thường niên phải là số!", "Lỗi");
                    txtPhiThuongNien.Focus();
                    return;
                }

                var dg = LayDuLieuTuForm(phi);
                _docGiaBLL.Add(dg);
                MessageBox.Show("Thêm độc giả thành công");

                LoadDataGrid();
                ResetFormState();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtPhiThuongNien.Text.Trim(), out decimal phi))
                {
                    MessageBox.Show("Phí thường niên phải là số!", "Lỗi");
                    txtPhiThuongNien.Focus();
                    return;
                }

                var dg = LayDuLieuTuForm(phi);
                _docGiaBLL.Update(dg);
                MessageBox.Show("Cập nhật độc giả thành công");

                LoadDataGrid();
                ResetFormState();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maDG = txtMaDG.Text.Trim();
                if (string.IsNullOrEmpty(maDG))
                {
                    MessageBox.Show("Chưa chọn độc giả để xóa!", "Lỗi");
                    return;
                }

                var xacNhan = MessageBox.Show(
                    "Bạn có muốn xóa độc giả " + maDG + " không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo);

                if (xacNhan == DialogResult.Yes)
                {
                    _docGiaBLL.Delete(maDG);
                    MessageBox.Show("Xóa độc giả thành công");

                    LoadDataGrid();
                    ResetFormState();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var xacNhan = MessageBox.Show(
                "Bạn có chắc muốn thoát chương trình?",
                "Xác nhận",
                MessageBoxButtons.YesNo);

            if (xacNhan != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
