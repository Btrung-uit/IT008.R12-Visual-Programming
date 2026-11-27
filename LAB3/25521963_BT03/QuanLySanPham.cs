using Microsoft.Data.SqlClient;
using System.Data;

namespace _25521963_BT03
{
	public class QuanLySanPham
	{
		public DataTable LayTatCaSanPham()
		{
			try
			{
				string strSQL = "SELECT * FROM dbo.SanPham";
				Provider p = new Provider();
				DataTable dt = p.Select(CommandType.Text, strSQL);
				return dt;

			}
			catch (Exception ex)
			{
				throw;
			}
		}

		public int ThemSanPham(SanPham sp)
		{

			try
			{
				string strSQL = "INSERT INTO dbo.SanPham VALUES(@MaSanPham, @TenSanPham, @SoLuong, @DonGia, @DonViTinh)";
				Provider p = new Provider();
				int nRow = p.ExecuteNonQuery(CommandType.Text, strSQL,
					new SqlParameter { ParameterName = "@MaSanPham", Value = sp.MaSanPham },
					new SqlParameter { ParameterName = "@TenSanPham", Value = sp.TenSanPham },
					new SqlParameter { ParameterName = "@DonGia", Value = sp.DonGia },
					new SqlParameter { ParameterName = "@SoLuong", Value = sp.SoLuong },
					new SqlParameter { ParameterName = "@DonViTinh", Value = sp.DonViTinh });
				return nRow;

			}
			catch (Exception)
			{
				throw;
			}
		}

		public int XoaSanPham(SanPham sp)
		{

			try
			{
				string strSQL = "DELETE	SanPham WHERE MaSanPham = @MaSanPham";
				Provider p = new Provider();
				int nRow = p.ExecuteNonQuery(CommandType.Text, strSQL,
					new SqlParameter { ParameterName = "@MaSanPham", Value = sp.MaSanPham }
					);
				return nRow;

			}
			catch (Exception)
			{
				throw;
			}
		}

		public int SuaSanPham(SanPham sp)
		{

			try
			{
				string strSQL = "UPDATE dbo.SanPham SET TenSanPham = @TenSanPham, SoLuong = @SoLuong, DonGia = @DonGia, DonViTinh = @DonViTinh WHERE MaSanPham = @MaSanPham";
				Provider p = new Provider();
				int nRow = p.ExecuteNonQuery(CommandType.Text, strSQL,
					new SqlParameter { ParameterName = "@MaSanPham", Value = sp.MaSanPham },
					new SqlParameter { ParameterName = "@TenSanPham", Value = sp.TenSanPham },
					new SqlParameter { ParameterName = "@DonGia", Value = sp.DonGia },
					new SqlParameter { ParameterName = "@SoLuong", Value = sp.SoLuong },
					new SqlParameter { ParameterName = "@DonViTinh", Value = sp.DonViTinh });
				return nRow;

			}
			catch (Exception)
			{
				throw;
			}
		}

		public DataTable TimKiemSanPham(string TenSP)
		{
			try
			{
				string strSQL = "SELECT * FROM dbo.SanPham WHERE TenSanPham LIKE %@TenSanPham%";
				Provider p = new Provider();
				DataTable dt = p.Select(CommandType.Text, strSQL
					new SqlParameter {ParameterName = "@TenSanPham", Value = TenSP}
					);
				return dt;

			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
