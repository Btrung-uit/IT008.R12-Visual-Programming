using System;
using System.Collections.Generic;
using System.Text;

namespace _25521963_BT03
{
    // internal chỉ hiểu trong packet thôi nên hải đổi qua public
    public class SanPham
    {
        public string MaSanPham { get; private set; }
        public string TenSanPham { get; private set; } = string.Empty;
        public int SoLuong { get; private set; }
        public double DonGia { get; private set; }
        public string DonViTinh { get; private set; } = string.Empty;

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
