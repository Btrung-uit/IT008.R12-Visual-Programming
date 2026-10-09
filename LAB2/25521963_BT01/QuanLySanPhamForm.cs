using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _25521963_BT01
{
	public partial class QuanLySanPhamForm : Form
	{
		// Form chỉ giữ 1 đối tượng Quản lý duy nhất
		private QuanLySanPham _qlsp;
		public QuanLySanPhamForm()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
			_qlsp = new QuanLySanPham(); // Khởi tạo 1 lần
		}

		private void QuanLySanPhamForm_Load(object sender, EventArgs e)
		{
			dgvSanPham.AutoGenerateColumns = false;
			List<string> ListDonViTinh = new List<string> { "Thùng", "Cái", "Chai", "Hộp", "Bịch", "KG" };
			cbbDonViTinh.DataSource = ListDonViTinh;

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

			string? ma = tbMaSanPham.Text.Trim();
			string? ten = tbTenSanPham.Text.Trim();
			if (string.IsNullOrEmpty(ma))
			{
				MessageBox.Show("Bảng đã đầy! Không thể thêm mới!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (string.IsNullOrEmpty(ten))
			{
				MessageBox.Show("Không được để trống Tên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (!int.TryParse(tbSoLuong.Text.Trim(), out int sl) || sl < 0)
			{
				MessageBox.Show("Số lượng không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				tbSoLuong.Focus();
				return;
			}
			if (!double.TryParse(tbDonGia.Text.Trim(), out double dg) || dg < 0)
			{
				MessageBox.Show("Đơn giá không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				tbDonGia.Focus();
				return;
			}
			string? dvt = cbbDonViTinh.SelectedItem?.ToString() ?? "";
			SanPham spMoi = new SanPham(ma, ten, sl, dg, dvt);
			try
			{
				_qlsp.ThemSanPham(spMoi);
				MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadDataGrid();
				XoaTrangForm();
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
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

		private SanPham sanPhamDangChon = null;
		private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.RowIndex < dgvSanPham.Rows.Count)
			{
				sanPhamDangChon = dgvSanPham.Rows[e.RowIndex].DataBoundItem as SanPham;

				if (sanPhamDangChon != null)
				{
					// Đổ dữ liệu từ object lên các TextBox tương ứng
					tbMaSanPham.Text = sanPhamDangChon.MaSanPham.ToString();
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
				MessageBox.Show("Vui lòng chọn một sản phẩm từ bảng trước khi sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string? ten = tbTenSanPham.Text.Trim();
			if (string.IsNullOrEmpty(ten))
			{
				MessageBox.Show("Không được để trống Tên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (!int.TryParse(tbSoLuong.Text.Trim(), out int sl) || sl < 0)
			{
				MessageBox.Show("Số lượng không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				tbSoLuong.Focus();
				return;
			}
			if (!double.TryParse(tbDonGia.Text.Trim(), out double dg) || dg < 0)
			{
				MessageBox.Show("Đơn giá không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				tbDonGia.Focus();
				return;
			}

			string? dvt = cbbDonViTinh.SelectedItem?.ToString() ?? "";

			// Kiểm tra xem user có thay đổi thông tin nào trước khi cập nhật không, nếu không có thông tin gì thay đổi thì không cập nhật
			if (ten == sanPhamDangChon.TenSanPham &&
			   sl == sanPhamDangChon.SoLuong &&
			   dg == sanPhamDangChon.DonGia &&
			   dvt == sanPhamDangChon.DonViTinh)
			{
				MessageBox.Show("Bạn chưa thay đổi thông tin nào của sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			// Tạo đối tượng đối với thông tin mới
			SanPham spCapNhat = new SanPham(sanPhamDangChon.MaSanPham, ten, sl, dg, dvt);

			try
			{
				_qlsp.CapNhatSanPham(spCapNhat);
				MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadDataGrid();
				XoaTrangForm();
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (sanPhamDangChon == null)
			{
				MessageBox.Show("Vui lòng chọn sản phẩm cần xóa trên bảng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm [{sanPhamDangChon.TenSanPham}] không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				try
				{
					_qlsp.XoaSanPham(sanPhamDangChon.MaSanPham);
					MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
