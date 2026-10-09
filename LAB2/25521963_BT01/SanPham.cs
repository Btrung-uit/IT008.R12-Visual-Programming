using System;
using System.Collections.Generic;
using System.Text;

namespace _25521963_BT01
{
	// internal chỉ hiểu trong packet thôi nên hải đổi qua public
	public class SanPham
	{
		// Chú ý _
		string _maSanPham;
		string _tenSanPham;
		int _soLuong;
		double _donGia;
		string _donViTinh;

		// Chú ý cahcs tạo property: Tô đen -> edit -> Refactor -> Encapsulate Field -> Done (Ctrl R E)
		public string MaSanPham { get => _maSanPham; set => _maSanPham = value; }
		public string TenSanPham { get => _tenSanPham; set => _tenSanPham = value; }
		public int SoLuong { get => _soLuong; set => _soLuong = value; }
		public double DonGia { get => _donGia; set => _donGia = value; }
		public string DonViTinh { get => _donViTinh; set => _donViTinh = value; }
		public SanPham() { }
		public SanPham(string MaSP, string TenSP, int SL, double Gia, string DVT)
		{
			MaSanPham = MaSP;
			TenSanPham = TenSP;
			SoLuong = SL;
			DonGia = Gia;
			DonViTinh = DVT;
		}
	}
}
