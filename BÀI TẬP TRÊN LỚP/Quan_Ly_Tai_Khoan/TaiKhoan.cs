using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace WinFormsApp2
{
	public class TaiKhoan
	{
		public string Username { get; set; } = "";
		public string Password { get; set; } = "";
		public string Ten { get; set; } = "";
		public string DiaChi { get; set; } = "";

		//Construct
		public TaiKhoan(string username, string password, string diaChi, string ten)
		{
			Username = username;
			Password = password;
			DiaChi = diaChi;
			Ten = ten;
		}
	}
	public static class DuLieu
	{
		public static string duongLinkFile = "users.txt";
		public static List<TaiKhoan> DanhSachTaiKhoan = new List<TaiKhoan>();
		public static void DocDuLieuTuFile()
		{
			DanhSachTaiKhoan.Clear();
			if(!File.Exists(duongLinkFile))
			{
				File.Create(duongLinkFile).Close();
				return;
			}
			string []cacDong = File.ReadAllLines(duongLinkFile);
			foreach (string dong in cacDong)
			{
				if(string.IsNullOrWhiteSpace(dong))
				{
					continue;
				}
				string []thongTin = dong.Split('|');
				if(thongTin.Length >= 4)
				{
					string username = thongTin[0];
					string password = thongTin[1];
					string diaChi = thongTin[2];
					string ten = thongTin[3];
					TaiKhoan tk = new TaiKhoan(username, password, diaChi, ten);
					DanhSachTaiKhoan.Add(tk);
				}
			}
		}

		public static void GhiTaiKhoanVaoFile(TaiKhoan tk)
		{
			string dongMoi = $"{tk.Username}|{tk.Password}|{tk.DiaChi}|{tk.Ten}" + Environment.NewLine;
			File.AppendAllText(duongLinkFile, dongMoi);
		}

		/*
		 * Mở rộng
		 * Thiết kế thêm form đổi mật khẩu, bạn phải lưu mật khẩu mới vào file, tức thay đổi mật khẩu trong file đó, chính xác dòng đó hoặc xóa dòng đó thêm vào cuối.
		 * Khi đăng nhập thành công thiết kế home form (profile), cho nút update thay đổi thông tin hoặc điền thông tin mới, ngày tháng năm sinh, số điện thoại, thông tin về sở thích, thêm 1 số điều như vậy, thêm 1 file thông tin mới (profile user) hoặc thêm vào file user đó luôn (chưa dùng database).
		 */
	}
}
