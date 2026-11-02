using Microsoft.Data.SqlClient;
using System.Data;

namespace _25521963_BT03
{
    public class QuanLySanPham
    {
        private const string ChuoiKetNoi =
            @"Server=localhost\SQL2025DEV;Database=QuanLySanPham;Integrated Security=True;TrustServerCertificate=True;";

        public List<SanPham> LayDanhSach()
        {
            const string sql = "SELECT MaSanPham, TenSanPham, SoLuong, DonGia, DonViTinh FROM SanPham ORDER BY MaSanPham";
            return DocDanhSach(sql);
        }

        public bool KiemTraTonTai(string maSP)
        {
            const string sql = "SELECT COUNT(1) FROM SanPham WHERE MaSanPham = @MaSanPham";
            using SqlConnection ketNoi = new(ChuoiKetNoi);
            using SqlCommand lenh = new(sql, ketNoi);
            lenh.Parameters.Add("@MaSanPham", SqlDbType.VarChar, 5).Value = maSP;
            ketNoi.Open();
            return (int)lenh.ExecuteScalar()! > 0;
        }

        public string PhatSinhMaTuDong()
        {
            const string sql = """
                WITH So AS
                (
                    SELECT 1 AS GiaTri
                    UNION ALL
                    SELECT GiaTri + 1 FROM So WHERE GiaTri < 999
                )
                SELECT TOP 1 CONCAT('SP', RIGHT('000' + CAST(GiaTri AS varchar(3)), 3))
                FROM So
                WHERE NOT EXISTS
                (
                    SELECT 1
                    FROM SanPham
                    WHERE MaSanPham = CONCAT('SP', RIGHT('000' + CAST(GiaTri AS varchar(3)), 3))
                )
                ORDER BY GiaTri
                OPTION (MAXRECURSION 999)
                """;

            using SqlConnection ketNoi = new(ChuoiKetNoi);
            using SqlCommand lenh = new(sql, ketNoi);
            ketNoi.Open();
            return lenh.ExecuteScalar()?.ToString() ?? string.Empty;
        }

        public bool ThemSanPham(SanPham sp)
        {
            if (KiemTraTonTai(sp.MaSanPham))
                return false;

            const string sql = """
                INSERT INTO SanPham (MaSanPham, TenSanPham, SoLuong, DonGia, DonViTinh)
                VALUES (@MaSanPham, @TenSanPham, @SoLuong, @DonGia, @DonViTinh)
                """;

            using SqlConnection ketNoi = new(ChuoiKetNoi);
            using SqlCommand lenh = TaoLenhSanPham(sql, ketNoi, sp);
            ketNoi.Open();
            return lenh.ExecuteNonQuery() == 1;
        }

        public bool XoaSanPham(string maSP)
        {
            const string sql = "DELETE FROM SanPham WHERE MaSanPham = @MaSanPham";
            using SqlConnection ketNoi = new(ChuoiKetNoi);
            using SqlCommand lenh = new(sql, ketNoi);
            lenh.Parameters.Add("@MaSanPham", SqlDbType.VarChar, 5).Value = maSP;
            ketNoi.Open();
            return lenh.ExecuteNonQuery() == 1;
        }

        public bool CapNhatSanPham(SanPham spMoi)
        {
            const string sql = """
                UPDATE SanPham
                SET TenSanPham = @TenSanPham,
                    SoLuong = @SoLuong,
                    DonGia = @DonGia,
                    DonViTinh = @DonViTinh
                WHERE MaSanPham = @MaSanPham
                """;

            using SqlConnection ketNoi = new(ChuoiKetNoi);
            using SqlCommand lenh = TaoLenhSanPham(sql, ketNoi, spMoi);
            ketNoi.Open();
            return lenh.ExecuteNonQuery() == 1;
        }

        public List<SanPham> TimKiem(string tuKhoa)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa))
                return LayDanhSach();

            const string sql = """
                SELECT MaSanPham, TenSanPham, SoLuong, DonGia, DonViTinh
                FROM SanPham
                WHERE MaSanPham LIKE '%' + @TuKhoa + '%'
                   OR TenSanPham LIKE N'%' + @TuKhoa + N'%'
                ORDER BY MaSanPham
                """;

            return DocDanhSach(sql, tuKhoa);
        }

        private static List<SanPham> DocDanhSach(string sql, string? tuKhoa = null)
        {
            List<SanPham> danhSach = [];
            using SqlConnection ketNoi = new(ChuoiKetNoi);
            using SqlCommand lenh = new(sql, ketNoi);

            if (tuKhoa != null)
                lenh.Parameters.Add("@TuKhoa", SqlDbType.NVarChar, 100).Value = tuKhoa;

            ketNoi.Open();
            using SqlDataReader boDoc = lenh.ExecuteReader();
            while (boDoc.Read())
            {
                danhSach.Add(new SanPham(
                    boDoc.GetString(0),
                    boDoc.GetString(1),
                    boDoc.GetInt32(2),
                    Convert.ToDouble(boDoc.GetDecimal(3)),
                    boDoc.GetString(4)));
            }

            return danhSach;
        }

        private static SqlCommand TaoLenhSanPham(string sql, SqlConnection ketNoi, SanPham sp)
        {
            SqlCommand lenh = new(sql, ketNoi);
            lenh.Parameters.Add("@MaSanPham", SqlDbType.VarChar, 5).Value = sp.MaSanPham;
            lenh.Parameters.Add("@TenSanPham", SqlDbType.NVarChar, 100).Value = sp.TenSanPham;
            lenh.Parameters.Add("@SoLuong", SqlDbType.Int).Value = sp.SoLuong;
            SqlParameter donGia = lenh.Parameters.Add("@DonGia", SqlDbType.Decimal);
            donGia.Precision = 18;
            donGia.Scale = 2;
            donGia.Value = Convert.ToDecimal(sp.DonGia);
            lenh.Parameters.Add("@DonViTinh", SqlDbType.NVarChar, 20).Value = sp.DonViTinh;
            return lenh;
        }
    }
}
