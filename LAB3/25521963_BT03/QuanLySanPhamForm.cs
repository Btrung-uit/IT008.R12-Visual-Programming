using System.Data;
using System.Diagnostics;
using Microsoft.Data.SqlClient;

namespace _25521963_BT03
{
	public partial class QuanLySanPhamForm : Form
	{
		List<string> lstDonViTinh = new List<string>() { "Thùng", "Cái", "Chai", "Hộp", "Bịch" };
		SanPham spChon;
		public QuanLySanPhamForm()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}

		public SanPham LayDuLieuTuManHinh()
		{
			SanPham sp = new SanPham();
			sp.MaSanPham = tbMaSanPham.Text;
			sp.TenSanPham = tbTenSanPham.Text;
			sp.SoLuong = Convert.ToInt32(tbSoLuong.Text);
			sp.DonGia = Convert.ToDouble(tbDonGia.Text);
			sp.DonViTinh = (string)cbbDonViTinh.SelectedItem;
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
			QuanLySanPham QLSP = new QuanLySanPham();
			DataTable dt = QLSP.LayTatCaSanPham();
			dgvSanPham.DataSource = dt;
			int maSPMoi = 1;
			if (dt.Rows.Count > 0)
			{
				string maLonNhat = (string)dt.Compute("MAX(MaSanPham)", "");
				maSPMoi = int.Parse(maLonNhat.Substring(2)) + 1;

			}
			tbMaSanPham.Text = "SP" + maSPMoi.ToString("D3");

			GanDuLieuManHinh(null);
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

		public SanPham LayDuLieuManHinh()
		{
			SanPham sp = new SanPham();
			sp.MaSanPham = tbMaSanPham.Text;
			sp.TenSanPham = tbTenSanPham.Text;
			sp.SoLuong = Convert.ToInt32(tbSoLuong.Text);
			sp.DonGia = Convert.ToDouble(tbDonGia.Text);
			sp.DonViTinh = (string)cbbDonViTinh.SelectedItem;
			return sp;
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				SanPham sp = LayDuLieuManHinh();
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

		private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
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

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if(spChon == null)
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
	}
}
