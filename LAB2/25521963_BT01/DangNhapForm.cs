using System.Diagnostics;

namespace _25521963_BT01
{
	public partial class DangNhapForm : Form
	{
		public DangNhapForm()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
		}

		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			try
			{
				string? tenDangNhap = tbTenDangNhap.Text.Trim();
				string? matKhau = tbMatKhau.Text.Trim();
				if (string.IsNullOrEmpty(tenDangNhap))
				{
					MessageBox.Show("Vui lòng nhập Tên đăng nhập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					tbTenDangNhap.Focus();
					return;
				}
				if (string.IsNullOrEmpty(matKhau))
				{
					MessageBox.Show("Vui lòng nhập Mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					tbMatKhau.Focus();
					return;
				}
				if (tenDangNhap.Equals("Admin") && matKhau.Equals("123456"))
				{
					MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Hide();
					QuanLySanPhamForm formQuanLySanPham = new QuanLySanPhamForm();
					formQuanLySanPham.ShowDialog();
					this.Show();
				}
				else
				{
					MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
			}
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
