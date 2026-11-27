using BUS;
using DTO;
using System.Data;
using System.Diagnostics;
using System.Drawing.Text;
using System.Security.Cryptography;

namespace QuanLySanPham
{
	public partial class QuanLySanPhamForm : Form
	{
		List<string> lstDonViTinh = new List<string>() { "Thùng", "Cái", "Chai", "Hộp", "Bịch" };
		SanPhamDTO spChon;
		public QuanLySanPhamForm()
		{
			InitializeComponent();
		}

		public SanPhamDTO LayDuLieuTuManHinh()
		{
			if (!int.TryParse(tbSoLuong.Text, out int soLuong) || soLuong <= 0)
				throw new FormatException("Số lượng phải là số nguyên dương.");

			if (!double.TryParse(tbDonGia.Text, out double donGia) ||
				!double.IsFinite(donGia) || donGia > float.MaxValue)
				throw new FormatException("Đơn giá phải là số hợp lệ.");

			return new SanPhamDTO(
				tbMaSanPham.Text,
				tbTenSanPham.Text,
				soLuong,
				donGia,
				cbbDonViTinh.SelectedItem as string ?? "");
		}
		public void GanDuLieuManHinh(SanPhamDTO? sp)
		{
			if (sp != null)
			{
				tbMaSanPham.Text = sp.MaSanPham;
				tbTenSanPham.Text = sp.TenSanPham;
				tbSoLuong.Text = sp.SoLuong.ToString();
				tbDonGia.Text = sp.DonGia.ToString();
				cbbDonViTinh.SelectedItem = sp.DonViTinh.ToString();
			}
			else
			{
				tbTenSanPham.Text = "";
				tbSoLuong.Text = "";
				tbDonGia.Text = "";
				cbbDonViTinh.SelectedIndex = 0;
			}
		}

		public void HienThiDuLieuManHinh()
		{
			cbbDonViTinh.DataSource = lstDonViTinh;
			var bus  = new QuanLySanPhamBUS();
			DataTable dt = bus.LayTatCaSanPham();
			string tuKhoa = tbTimKiem.Text.Trim();
			dgvSanPham.DataSource = tuKhoa.Length == 0 ? dt : bus.TimKiemSanPham(tuKhoa);
			int maSPMoi = 1;
			if (dt.Rows.Count > 0)
			{
				string maLonNhat = (string)dt.Compute("MAX(MaSanPham)", "");
				maSPMoi = int.Parse(maLonNhat.Substring(2)) + 1;

			}
			tbMaSanPham.Text = "SP" + maSPMoi.ToString("D3");

			GanDuLieuManHinh(null);
			spChon = null;
			dgvSanPham.ClearSelection();
		}
		private void QuanLySanPhamForm_Load(object sender, EventArgs e)
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

		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				SanPhamDTO sp = LayDuLieuTuManHinh();
				var bus = new QuanLySanPhamBUS();

				if (bus.ThemSanPham(sp) <= 0)
				{
					MessageBox.Show("Không thêm được sản phẩm.");
					return;
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.ToString());
				MessageBox.Show(ex is FormatException or ArgumentException
					? ex.Message
					: "Không thêm được sản phẩm.");
				return;
			}

			try
			{
				HienThiDuLieuManHinh();
				MessageBox.Show("Thêm thành công!");
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.ToString());
			}
		}
		private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int row = e.RowIndex;
			if (row >= 0)
			{
				spChon = new SanPhamDTO();
				spChon.MaSanPham = dgvSanPham.Rows[row].Cells["MaSanPham"].Value.ToString();
				spChon.TenSanPham = dgvSanPham.Rows[row].Cells["TenSanPham"].Value.ToString();
				spChon.SoLuong = Convert.ToInt32(dgvSanPham.Rows[row].Cells["SoLuong"].Value.ToString());
				spChon.DonGia = Convert.ToDouble(dgvSanPham.Rows[row].Cells["DonGia"].Value.ToString());
				spChon.DonViTinh = dgvSanPham.Rows[row].Cells["DonViTinh"].Value.ToString();
			}
			GanDuLieuManHinh(spChon);
		}
		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				SanPhamDTO sp = LayDuLieuTuManHinh();
				var bus = new QuanLySanPhamBUS();

				if (bus.XoaSanPham(sp) <= 0)
				{
					MessageBox.Show("Không thêm được sản phẩm.");
					return;
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.ToString());
			}

			try
			{
				HienThiDuLieuManHinh();
				MessageBox.Show("Xoa thành công!");
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.ToString());
			}
		}
		
		private void btnSua_Click(object sender, EventArgs e)
		{
			if (spChon == null)
			{
				MessageBox.Show("Hãy chọn sản phẩm.");
				return;
			}

			try
			{
				SanPhamDTO sp = LayDuLieuTuManHinh();
				sp.MaSanPham = spChon.MaSanPham;

				var bus = new QuanLySanPhamBUS();
				if (bus.SuaSanPham(sp) > 0)
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

		private void btnTimKiem_Click(object sender, EventArgs e)
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
	}
}
