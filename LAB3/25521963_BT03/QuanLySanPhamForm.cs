using System.Data;
using System.Diagnostics;

namespace _25521963_BT03
{
	public partial class QuanLySanPhamForm : Form
	{
		private readonly List<string> lstDonViTinh = new List<string>() { "Thùng", "Cái", "Chai", "Hộp", "Bịch" };
		private SanPham? spChon = null;
		public QuanLySanPhamForm()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}

		public SanPham? LayDuLieuManHinh()
		{
			SanPham sp = new SanPham();
			string MaSanPham = tbMaSanPham.Text.Trim();
			if (string.IsNullOrWhiteSpace(MaSanPham))
			{
				MessageBox.Show("Mã Sản Phẩm không hợp lệ!");
				return null;
			}
			string TenSanPham = tbTenSanPham.Text.Trim();
			if (string.IsNullOrWhiteSpace(TenSanPham))
			{
				MessageBox.Show("Tên Sản Phẩm không được để trống!");
				tbTenSanPham.Focus();
				return null;
			}
			string strSoLuong = tbSoLuong.Text.Trim();
			if (string.IsNullOrWhiteSpace(strSoLuong))
			{
				MessageBox.Show("Số Lượng không được để trống!");
				tbSoLuong.Focus();
				return null;
			}
			string strDonGia = tbDonGia.Text.Trim();
			if (string.IsNullOrWhiteSpace(strDonGia))
			{
				MessageBox.Show("Đơn Giá không được để trống!");
				tbDonGia.Focus();
				return null;
			}
			if (!int.TryParse(strSoLuong, out int SoLuong) || SoLuong <= 0)
			{
				MessageBox.Show("Số Lượng phải là số nguyên dương!");
				tbSoLuong.Focus();
				return null;
			}
			if (!double.TryParse(strDonGia, out double DonGia) || DonGia <= 0)
			{
				MessageBox.Show("Đơn giá phải là số thực dương!");
				tbDonGia.Focus();
				return null;
			}
			if (cbbDonViTinh.SelectedItem is not string DonViTinh)
			{
				MessageBox.Show("Vui lòng chọn đơn vị tính!");
				cbbDonViTinh.Focus();
				return null;
			}
			sp.MaSanPham = MaSanPham;
			sp.TenSanPham = TenSanPham;
			sp.SoLuong = SoLuong;
			sp.DonGia = DonGia;
			sp.DonViTinh = DonViTinh;
			return sp;
		}
		public void GanDuLieuManHinh(SanPham? sp)
		{
			if (sp != null)
			{
				tbMaSanPham.Text = sp.MaSanPham;
				tbTenSanPham.Text = sp.TenSanPham;
				tbSoLuong.Text = sp.SoLuong.ToString();
				tbDonGia.Text = sp.DonGia.ToString();
				cbbDonViTinh.SelectedItem = sp.DonViTinh;
			}
			else
			{
				tbTenSanPham.Clear();
				tbSoLuong.Clear();
				tbDonGia.Clear();
				cbbDonViTinh.SelectedIndex = 0;
				tbTimKiem.Clear();
			}
		}

		// Hàm tạo mã sản phẩm
		private static string TaoMaSanPham(DataTable dt)
		{
			int max = 0;
			// Tìm mã lớn nhất
			foreach (DataRow row in dt.Rows)
			{
				if (row["MaSanPham"] is string ma
					&& ma.StartsWith("SP", StringComparison.OrdinalIgnoreCase)
					&& int.TryParse(ma.Substring(2), out int so)
					&& so > max)
				{
					max = so;
				}
			}

			return "SP" + checked(max + 1).ToString("D3");
		}
		/*
		 * Đoạn code cũ:
		 * ----------------------------------------------------------------
		 * int maSPMoi = 1;
		 * if (dt.Rows.Count > 0)
		 * {
		 *		string maLonNhat = (string)dt.Compute("MAX(MaSanPham)", "");
		 *		maSPMoi = int.Parse(maLonNhat.Substring(2)) + 1;
		 * }
		 * tbMaSanPham.Text = "SP" + maSPMoi.ToString("D3");
		 * ----------------------------------------------------------------
		 * Em tách đoạn này ra thành hàm trên là vì nó có những vấn đề sau:
		 * + MAX() trên cột kiểu chuỗi không so sánh theo giá trị số của phần mã.
		 * + Substring(2) có thể phát sinh ngoại lệ nếu mã quá ngắn.
		 * + int.Parse() có thể phát sinh FormatException nếu mã không đúng định dạng.
		 * + Kết quả của Compute() có thể là DBNull.Value.
		 * + Ví dụ có 2 mã SP999 và SP1000. Khi so sánh theo chuỗi, SP999 có thể được xác định lớn hơn SP1000. Từ đó chương trình có thể sinh ra mã bị trùng.
		 * => Do đó em tách riêng ra thành 1 hàm sinh mã sản phẩm.
		 */
		public void HienThiDuLieuManHinh()
		{
			cbbDonViTinh.DataSource = lstDonViTinh;
			QuanLySanPham QLSP = new QuanLySanPham();
			DataTable dt = QLSP.LayTatCaSanPham();
			dgvSanPham.DataSource = dt;
			// Tách đoạn code cũ ở đây
			tbMaSanPham.Text = TaoMaSanPham(dt);

			GanDuLieuManHinh(null);
			spChon = null;
			dgvSanPham.ClearSelection();
		}
		private void QuanLySanPhamForm_Load(object? sender, EventArgs e)
		{
			try
			{
				HienThiDuLieuManHinh();
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.ToString());
			}
		}

		private void btnThem_Click(object? sender, EventArgs e)
		{
			try
			{
				SanPham? sp = LayDuLieuManHinh();
				if (sp == null)
				{
					return;
				}
				QuanLySanPham QLSP = new QuanLySanPham();
				int kq = QLSP.ThemSanPham(sp);
				if (kq > 0)
				{
					MessageBox.Show("Thêm thành công!");
					HienThiDuLieuManHinh();
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.ToString());
			}
		}

		private void dgvSanPham_CellClick(object? sender, DataGridViewCellEventArgs e)
		{
			int row = e.RowIndex;
			if (row >= 0)
			{
				spChon = new SanPham();
				spChon.MaSanPham = dgvSanPham.Rows[row].Cells["MaSanPham"].Value.ToString();
				spChon.TenSanPham = dgvSanPham.Rows[row].Cells["TenSanPham"].Value.ToString();
				spChon.SoLuong = Convert.ToInt32(dgvSanPham.Rows[row].Cells["SoLuong"].Value.ToString());
				spChon.DonGia = Convert.ToDouble(dgvSanPham.Rows[row].Cells["DonGia"].Value.ToString());
				spChon.DonViTinh = dgvSanPham.Rows[row].Cells["DonViTinh"].Value.ToString();
			}
			GanDuLieuManHinh(spChon);
		}

		private void btnXoa_Click(object? sender, EventArgs e)
		{
			if (spChon == null)
				return;
			try
			{
				QuanLySanPham QLSP = new QuanLySanPham();
				int kq = QLSP.XoaSanPham(spChon);
				if (kq > 0)
				{
					MessageBox.Show("Xóa thành công!");
					HienThiDuLieuManHinh();
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.ToString());
			}
		}

		private void btnSua_Click(object? sender, EventArgs e)
		{
			if (spChon == null)
			{
				MessageBox.Show("Hãy chọn sản phẩm.");
				return;
			}

			try
			{
				SanPham? sp = LayDuLieuManHinh();
				if (sp == null)
				{
					return;
				}
				QuanLySanPham QLSP = new QuanLySanPham();
				int kq = QLSP.SuaSanPham(sp);
				if (kq > 0)
				{
					MessageBox.Show("Sửa thành công!");
					HienThiDuLieuManHinh();
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.ToString());
			}
		}

		private void btnTimKiem_Click(object? sender, EventArgs e)
		{
			try
			{
				string TenSP = tbTimKiem.Text.Trim();
				QuanLySanPham QLSP = new QuanLySanPham();
				DataTable dt = QLSP.TimKiemSanPham(TenSP);
				dgvSanPham.DataSource = dt;
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.ToString());
			}
		}
	}
}
