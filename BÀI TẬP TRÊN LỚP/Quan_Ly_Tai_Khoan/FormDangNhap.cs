namespace WinFormsApp2
{
	public partial class FormDangNhap : Form
	{
		public FormDangNhap()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Đăng Nhập";
		}
		// Đọc dữ liệu từ file
		private void Form1_Load(object sender, EventArgs e)
		{
			DuLieu.DocDuLieuTuFile();
		}
		private void lbTaoTaiKhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			FormDangKy f2 = new FormDangKy();
			f2.ShowDialog();
			this.Show();
		}

		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			string username = tbUsername.Text.Trim();
			string password = tbPassword.Text.Trim();
			
			// Lưu Địa chỉ và Tên để cho form Profile
			string diaChi = "";
			string ten = "";

			// Kiểm tra username và password có đúng không
			foreach (TaiKhoan tk in DuLieu.DanhSachTaiKhoan)
			{
				if (username == tk.Username)
				{
					if (password == tk.Password)
					{
						MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						diaChi = tk.DiaChi;
						ten = tk.Ten;
						this.Hide();
						FormHome home = new FormHome(username, diaChi, ten);
						home.ShowDialog();
						tbPassword.Clear();
						// Khi tắt form home thì hiển thị form DangNhap
						this.Show();
						return;
					}
				}
			}
			MessageBox.Show("Username hoặc Password không đúng! Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return;

		}

		private void llbDoiMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// Khi user nhấn đổi mật khẩu thì ẩn Form đăng nhập, hiện form đổi mật khẩu
			this.Hide();
			FormDoiMatKhau FormDoiMatKhau = new FormDoiMatKhau();
			FormDoiMatKhau.ShowDialog();
			this.Show();
		}
	}
}
