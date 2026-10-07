using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
	public partial class FormDangKy : Form
	{
		public FormDangKy()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Đăng Ký";
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(
				"Bạn có chắc chắn muốn hủy đăng ký và quay lại màn hình đăng nhập?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				this.Close(); // đóng form 2
			}
		}

		// nút đăng ký
		private void btnDangKy_Click(object sender, EventArgs e)
		{
			string username = tbUsername.Text.Trim();
			string password = tbPassword.Text.Trim();
			string rePass = tbRePass.Text.Trim();
			string diaChi = tbDiaChi.Text.Trim();
			string hoTen = tbTen.Text.Trim();
			if (string.IsNullOrEmpty(username))
			{
				MessageBox.Show("Vui lòng nhập Username!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				tbUsername.Focus();
				return;
			}
			// 2. Kiểm tra bỏ trống Mật khẩu
			if (string.IsNullOrEmpty(password))
			{
				MessageBox.Show("Vui lòng nhập Mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				tbPassword.Focus();
				return;
			}
			// 3. Kiểm tra độ dài mật khẩu (ví dụ tối thiểu 6 ký tự)
			if (password.Length < 6)
			{
				MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				tbPassword.Focus();
				return;
			}
			// 4. Kiểm tra xác nhận mật khẩu có trùng khớp không
			if (password != rePass)
			{
				MessageBox.Show("Mật khẩu xác nhận không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				tbRePass.Clear();
				tbRePass.Focus();
				return;
			}
			// 5. Kiểm tra Họ tên
			if (string.IsNullOrEmpty(hoTen))
			{
				MessageBox.Show("Vui lòng nhập Tên của bạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				tbTen.Focus();
				return;
			}

			// Kiểm tra xem username đã tồn tại hay chưa
			foreach (TaiKhoan tk in DuLieu.DanhSachTaiKhoan)
			{
				if (tk.Username == username)
				{
					MessageBox.Show("Username đã tồn tại! Vui lòng lòng nhập username khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					tbUsername.Focus();
					return;
				}
			}

			// Thêm tài khoản vào danh sách
			TaiKhoan tkMoi = new TaiKhoan(username, password, diaChi, hoTen);
			DuLieu.DanhSachTaiKhoan.Add(tkMoi);

			// Ghi vào file text	
			DuLieu.GhiTaiKhoanVaoFile(tkMoi);
			MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}

		private void Form2_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Close();
		}

	}
}
