namespace _25521963_BT03
{
	// internal chỉ hiểu trong packet thôi nên hải đổi qua public
	public class SanPham
	{
		string _maSanPham;
		string _tenSanPham;
		int _soLuong;
		double _donGia;
		string _donViTinh;
		public string MaSanPham { get => _maSanPham; set => _maSanPham = value; }
		public string TenSanPham { get => _tenSanPham; set => _tenSanPham = value; }
		public int SoLuong { get => _soLuong; set => _soLuong = value; }
		public double DonGia { get => _donGia; set => _donGia = value; }
		public string DonViTinh { get => _donViTinh; set => _donViTinh = value; }

		public SanPham()
		{
		}
		public SanPham(
			string maSanPham,
			string tenSanPham,
			int soLuong,
			double donGia,
			string donViTinh)
		{
			if (string.IsNullOrWhiteSpace(maSanPham))
			{
				throw new ArgumentException("Mã sản phẩm không được để trống.");
			}

			MaSanPham = maSanPham.Trim();

			CapNhatThongTin(
				tenSanPham,
				soLuong,
				donGia,
				donViTinh);
		}

		public void CapNhatThongTin(
			string tenSanPham,
			int soLuong,
			double donGia,
			string donViTinh)
		{
			if (string.IsNullOrWhiteSpace(tenSanPham))
				throw new ArgumentException("Tên sản phẩm không được để trống.");

			if (soLuong < 0)
				throw new ArgumentException("Số lượng không được âm.");

			if (donGia < 0)
				throw new ArgumentException("Đơn giá không được âm.");

			if (string.IsNullOrWhiteSpace(donViTinh))
				throw new ArgumentException("Đơn vị tính không được để trống.");

			TenSanPham = tenSanPham.Trim();
			SoLuong = soLuong;
			DonGia = donGia;
			DonViTinh = donViTinh.Trim();
		}
	}
}
