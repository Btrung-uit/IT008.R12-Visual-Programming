using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace _25521963_BT01
{
	public class QuanLySanPham
	{
		// Dữ liệu được đóng gói private bên trong lớp quản lý
		private List<SanPham> _dsSanPham;

		public QuanLySanPham()
		{
			_dsSanPham = new List<SanPham>();
			KhoiTaoDuLieuMau();
		}

		// Cung cấp danh sách
		public List<SanPham> LayDanhSach()
		{
			return _dsSanPham.OrderBy(sp =>sp.MaSanPham).ToList();
		}

		private void KhoiTaoDuLieuMau()
		{
			_dsSanPham.Add(new SanPham("SP001", "Bột giặt OMO", 800, 50000, "Bịch"));
			_dsSanPham.Add(new SanPham("SP002", "Pesi", 500, 200000, "Thùng"));
			_dsSanPham.Add(new SanPham("SP003", "Dầu ăn Trường An", 200, 120000, "Thùng"));
		}

		// Kiểm tra tồn tại
		public bool KiemTraTonTai(string maSP)
		{
			return _dsSanPham.Any(sp => sp.MaSanPham.Equals(maSP, StringComparison.OrdinalIgnoreCase));
		}

		// Phát sinh mã tự động
		public string PhatSinhMaTuDong()
		{
			// Tại sao phải chạy for cho phức tạp? Vì ta có nút xóa, ta không biết user xóa mã nào, nên ta chạy lại tìm mã nhỏ nhất
			for (int i = 1; i <= 999; i++)
			{
				string? maKiemTra = $"SP{i:D3}";
				if (!KiemTraTonTai(maKiemTra))
				{
					return maKiemTra;
				}
			}
			return "";
		}

		// Thêm sản phẩm có kiểm tra nghiệp vụ
		public bool ThemSanPham(SanPham sp)
		{
			if (sp == null || KiemTraTonTai(sp.MaSanPham))
			{
				return false;
			}
			_dsSanPham.Add(sp);
			return true;
		}

		// Xóa sản phẩm
		public bool XoaSanPham(string maSP)
		{
			var sp = _dsSanPham.FirstOrDefault(s => s.MaSanPham.Equals(maSP, StringComparison.OrdinalIgnoreCase));
			if (sp == null)
			{
				return false;
			}
			return _dsSanPham.Remove(sp);
		}

		// Sửa sản phẩm
		public bool CapNhatSanPham(SanPham spMoi)
		{
			var sp = _dsSanPham.FirstOrDefault(s => s.MaSanPham.Equals(spMoi.MaSanPham, StringComparison.OrdinalIgnoreCase));
			if (sp == null)
			{
				return false;
			}

			sp.TenSanPham = spMoi.TenSanPham;
			sp.SoLuong = spMoi.SoLuong;
			sp.DonGia = spMoi.DonGia;
			sp.DonViTinh = spMoi.DonViTinh;
			return true;
		}

		// Tìm kiếm
		public List<SanPham> TimKiem(string tuKhoa)
		{
			if (string.IsNullOrWhiteSpace(tuKhoa))
			{
				return LayDanhSach();
			}
			return _dsSanPham.Where(sp => sp.MaSanPham.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase) || sp.TenSanPham.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase)).OrderBy(sp => sp.MaSanPham).ToList();
		}
	}
}
