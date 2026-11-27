using System.Data;
using DAO;
using DTO;

namespace BUS;

public class QuanLySanPhamBUS
{
	private readonly QuanLySanPhamDAO dao = new();

	public DataTable LayTatCaSanPham()
	{
		return dao.LayTatCaSanPham();
	}

	public int ThemSanPham(SanPhamDTO sp)
	{
		return dao.ThemSanPham(sp);
	}

	public int XoaSanPham(SanPhamDTO sp)
	{
		return dao.XoaSanPham(sp);
	}

	public int SuaSanPham(SanPhamDTO sp)
	{
		return dao.SuaSanPham(sp);
	}

	public DataTable TimKiemSanPham(string tuKhoa)
	{
		return dao.TimKiemSanPham(tuKhoa);
	}
}