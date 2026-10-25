using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _25521963_BT02
{
    public partial class QuanLySanPhamForm : Form
    {
        // Form chỉ giữ 1 đối tượng Quản lý duy nhất
        private readonly QuanLySanPham _qlsp;
        public QuanLySanPhamForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _qlsp = new QuanLySanPham(); // Khởi tạo 1 lần
        }

        private void QuanLySanPhamForm_Load(object sender, EventArgs e)
        {
            dgvSanPham.AutoGenerateColumns = false;
            List<string> listDonViTinh = new List<string> { "Thùng", "Cái", "Chai", "Hộp", "Bịch", "KG" };
            cbbDonViTinh.DataSource = listDonViTinh;

            LoadDataGrid();
            XoaTrangForm();
        }

        private void LoadDataGrid()
        {
            dgvSanPham.DataSource = null;
            dgvSanPham.DataSource = _qlsp.LayDanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = tbMaSanPham.Text.Trim();
            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show(
                    "Bảng đã đầy! " +
                    "Không thể thêm mới!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!ThuLayDuLieuNhap(out string ten, out int sl, out double dg, out string dvt))
                return;

            try
            {
                SanPham spMoi = new SanPham(ma, ten, sl, dg, dvt);
                bool themThanhCong = _qlsp.ThemSanPham(spMoi);

                if (!themThanhCong)
                {
                    MessageBox.Show(
                        "Không thể thêm sản phẩm. Mã sản phẩm có thể đã tồn tại!",
                        "Cảnh báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                MessageBox.Show(
                    "Thêm sản phẩm thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadDataGrid();
                XoaTrangForm();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Dữ liệu không hợp lệ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void XoaTrangForm()
        {
            tbMaSanPham.Text = _qlsp.PhatSinhMaTuDong();
            tbTenSanPham.Clear();
            tbSoLuong.Clear();
            tbDonGia.Clear();
            sanPhamDangChon = null;
            tbTenSanPham.Focus();
        }

        private SanPham? sanPhamDangChon;
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSanPham.Rows.Count)
            {
                sanPhamDangChon = dgvSanPham.Rows[e.RowIndex].DataBoundItem as SanPham;

                if (sanPhamDangChon != null)
                {
                    // Đổ dữ liệu từ object lên các TextBox tương ứng
                    tbMaSanPham.Text = sanPhamDangChon.MaSanPham;
                    tbTenSanPham.Text = sanPhamDangChon.TenSanPham;
                    tbSoLuong.Text = sanPhamDangChon.SoLuong.ToString();
                    tbDonGia.Text = sanPhamDangChon.DonGia.ToString();
                    cbbDonViTinh.Text = sanPhamDangChon.DonViTinh;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (sanPhamDangChon == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn một sản phẩm từ bảng trước khi sửa!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!ThuLayDuLieuNhap(out string ten, out int sl, out double dg, out string dvt))
                return;

            // Kiểm tra xem user có thay đổi thông tin nào trước khi cập nhật không, nếu không có thông tin gì thay đổi thì không cập nhật
            if (ten == sanPhamDangChon.TenSanPham &&
               sl == sanPhamDangChon.SoLuong &&
               dg == sanPhamDangChon.DonGia &&
               dvt == sanPhamDangChon.DonViTinh)
            {
                MessageBox.Show(
                    "Bạn chưa thay đổi thông tin nào của sản phẩm!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            try
            {
                SanPham spCapNhat = new SanPham(sanPhamDangChon.MaSanPham, ten, sl, dg, dvt);
                bool suaThanhCong = _qlsp.CapNhatSanPham(spCapNhat);

                if (!suaThanhCong)
                {
                    MessageBox.Show(
                        "Không tìm thấy sản phẩm cần cập nhật!",
                        "Cảnh báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                MessageBox.Show(
                    "Cập nhật thông tin thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadDataGrid();
                XoaTrangForm();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Dữ liệu không hợp lệ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private bool ThuLayDuLieuNhap(out string ten, out int soLuong, out double donGia, out string donViTinh)
        {
            ten = tbTenSanPham.Text.Trim();
            donViTinh = cbbDonViTinh.SelectedItem?.ToString() ?? string.Empty;
            soLuong = 0;
            donGia = 0;

            if (!int.TryParse(tbSoLuong.Text.Trim(), out soLuong))
            {
                MessageBox.Show(
                    "Số lượng phải là số nguyên!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                tbSoLuong.Focus();
                return false;
            }

            if (!double.TryParse(tbDonGia.Text.Trim(), out donGia))
            {
                MessageBox.Show(
                    "Đơn giá phải là một số!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                tbDonGia.Focus();
                return false;
            }

            return true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (sanPhamDangChon == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn sản phẩm cần xóa trên bảng!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa sản phẩm [{sanPhamDangChon.TenSanPham}] không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    bool xoaThanhCong = _qlsp.XoaSanPham(sanPhamDangChon.MaSanPham);

                    if (!xoaThanhCong)
                    {
                        MessageBox.Show(
                            "Không tìm thấy sản phẩm cần xóa!",
                            "Cảnh báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    MessageBox.Show(
                        "Xóa sản phẩm thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadDataGrid();
                    XoaTrangForm();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string? tuKhoa = tbTimKiem.Text.Trim();
            var ketQua = _qlsp.TimKiem(tuKhoa);
            dgvSanPham.DataSource = null;
            dgvSanPham.DataSource = ketQua;
            if (ketQua.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
