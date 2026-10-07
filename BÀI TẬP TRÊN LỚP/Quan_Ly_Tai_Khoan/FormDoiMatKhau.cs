using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
	public partial class FormDoiMatKhau : Form
	{
		public FormDoiMatKhau()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Đổi Mật Khẩu";
		}
		private void btnLuu_Click(object sender, EventArgs e)
		{
			string ?username = tbUsername.Text.Trim();
			string ?matKhauCu = tbMatKhauCu.Text.Trim();
			string ?matKhauMoi = tbMatKhauMoi.Text.Trim();
			string ?xacNhanMatKhau = tbXacNhanMatKhau.Text.Trim();
			
			// ngăn chặn người dùng để ô trống
			if(string.IsNullOrEmpty(username))
			{
				MessageBox.Show("Vui lòng nhập Username!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				tbUsername.Focus();
				return;
			}

			// Nếu user không nhập mật khẩu cũ thì báo lỗi
			if (string.IsNullOrEmpty(matKhauCu))
			{
				MessageBox.Show("Vui lòng nhập Mật khẩu cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				tbMatKhauCu.Focus();
				return;
			}

			// Nếu user không nhập mật khẩu mới thì báo lỗi
			if (string.IsNullOrEmpty(matKhauMoi))
			{
				MessageBox.Show("Vui lòng nhập Mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				tbMatKhauMoi.Focus();
				return;
			}

			// Nếu mật khẩu mới ít hơn 6 ký tự thì báo lỗi
			if (matKhauMoi.Length < 6)
			{
				MessageBox.Show("Mật khẩu mới phải có ít nhất 6 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				tbMatKhauMoi.Focus();
				return;
			}

			// Nếu user không nhập xác nhận mật khẩu thì báo lỗi
			if (string.IsNullOrEmpty(xacNhanMatKhau))
			{
				MessageBox.Show("Vui lòng Xác nhận mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				tbXacNhanMatKhau.Focus();
				return;
			}

			// kiểm tra xem mật khẩu xác nhận có giống mật khẩu mới không
			if (matKhauMoi != xacNhanMatKhau)
			{
				MessageBox.Show("Mật khẩu xác nhận không khớp với mật khẩu mới! Vui lòng kiểm tra lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				tbXacNhanMatKhau.Focus();
				return;
			}

			// Kiểm tra mật khẩu mới không được trùng với mật khẩu cũ
			if (matKhauMoi == matKhauCu)
			{
				MessageBox.Show("Mật khẩu mới không được trùng với Mật khẩu cũ! Vui lòng thay đổi mật khẩu mới khác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				tbMatKhauMoi.Focus();
				return;
			}
			// Đọc dữ liệu mới nhất từ file trước khi kiểm tra
			DuLieu.DocDuLieuTuFile();

			TaiKhoan ?tkTimThay = null;
			// Kiểm tra tài khoản mật khẩu cũ trong danh sách
			foreach(TaiKhoan tk in DuLieu.DanhSachTaiKhoan)
			{
				if(username == tk.Username)
				{
					tkTimThay = tk;
					break;
				}
			}

			// Tài khoản không tồn tại trên hệ thống thì báo lỗi
			if (tkTimThay == null)
			{
				MessageBox.Show("Tài khoản không tồn tại trên hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				tbUsername.Focus();
				return;
			}

			// Nếu mật khẩu cũ không giống mật khẩu của tìa khoản thì báo mật khẩu không chính xác
			if(tkTimThay.Password != matKhauCu)
			{
				MessageBox.Show("Mật khẩu cũ không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				tbMatKhauCu.Focus();
				return;
			}

			// Đưa tất cả các dòng trong file vào mảng string
			string[] cacDong = File.ReadAllLines(DuLieu.duongLinkFile);

			// Đọc qua tất cả các dòng
			for(int i = 0; i < cacDong.Length; i++)
			{
				if(string.IsNullOrWhiteSpace(cacDong[i])) continue;

				string[] thongTin = cacDong[i].Split('|');
				if(thongTin[0] == username)
				{
					// trong string cấu trúc sẽ là: username|password|DiaChi|Tên -> Thay thongTin[1]
					cacDong[i] = $"{thongTin[0]}|{matKhauMoi}|{thongTin[2]}|{thongTin[3]}";
					break;
				}
			}
			
			// Ghi lại vào file
			File.WriteAllLines(DuLieu.duongLinkFile, cacDong);

			// Cập nhật lại dữ liệu
			DuLieu.DocDuLieuTuFile();

			MessageBox.Show("Thay đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();

		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}
