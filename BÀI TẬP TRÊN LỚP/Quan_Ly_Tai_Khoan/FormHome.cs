using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
	public partial class FormHome : Form
	{
		// Biến lưu username người đăng nhập
		private string tenDangNhap = "";
		private string diaChi = "";
		private string ten = "";
		public FormHome()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Profile";
		}

		// Lấy tên người đăng nhập từ form DangNhap
		public FormHome(string username, string diaChi, string ten)
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
			this.tenDangNhap = username;
			this.diaChi = diaChi;
			this.ten = ten;
		}

		private string fileProfile = "profiles.txt";
		private void FormHome_Load(object sender, EventArgs e)
		{
			// Mặc định dateTimePicker sẽ hiển thị ngày hôm nay do đó em dùng định dạng custom để làm cho nó trống
			dtpNgaySinh.Format = DateTimePickerFormat.Custom;
			dtpNgaySinh.CustomFormat = " ";

			tbUsername.Text = tenDangNhap;
			tbDiaChi.Text = diaChi;
			tbTen.Text = ten;

			// Kiểm tra xem file tồn tại chưa
			if (!File.Exists(fileProfile))
			{
				File.Create(fileProfile).Close();
				return;
			}

			// đọc tất cả các dòng trong profile.txt để tìm user này
			string[] cacDong = File.ReadAllLines(fileProfile);
			foreach (string dong in cacDong)
			{
				string[] thongTin = dong.Split('|');
				if (thongTin[0] == tenDangNhap)
				{
					// Chặn những trường hợp lỗi
					if (thongTin.Length >= 4)
					{
						if (DateTime.TryParseExact(thongTin[1], "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime ns))
						{
							dtpNgaySinh.CustomFormat = "dd/MM/yyyy"; // Tránh lỗi không hiển thị ngày sinh khi ngày sinh = ngày hiện tại
							dtpNgaySinh.Value = ns;
						}
						tbSDT.Text = thongTin[2];
						tbSoThich.Text = thongTin[3];
					}
					break;
				}
			}
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			string ?diaChiMoi = tbDiaChi.Text.Trim();
			string ?tenMoi = tbTen.Text.Trim();

			// Nếu user để trống tên mới thì báo lỗi
			if (string.IsNullOrEmpty(tenMoi))
			{
				MessageBox.Show("Vui lòng nhập Tên của bạn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				tbTen.Focus();
				return;
			}

			// Nếu user để trống địa chỉ mới thì báo lỗi
			if (string.IsNullOrEmpty(diaChiMoi))
			{
				MessageBox.Show("Vui lòng nhập Địa chỉ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				tbDiaChi.Focus();
				return;
			}

			// Nếu user thay đổi tên và địa chỉ thì lưu lại
			if (diaChiMoi != this.diaChi || tenMoi != this.ten)
			{
				if (File.Exists(DuLieu.duongLinkFile))
				{
					string[] cacDongUsers = File.ReadAllLines(DuLieu.duongLinkFile);
					for (int i = 0; i < cacDongUsers.Length; i++)
					{
						if (string.IsNullOrWhiteSpace(cacDongUsers[i])) continue;
						string[] thongTin = cacDongUsers[i].Split('|');
						if (thongTin[0] == tenDangNhap)
						{
							cacDongUsers[i] = $"{thongTin[0]}|{thongTin[1]}|{diaChiMoi}|{tenMoi}";
							break;
						}
					}
					File.WriteAllLines(DuLieu.duongLinkFile, cacDongUsers);
					// Cập nhật lại
					DuLieu.DocDuLieuTuFile();
					// Cập nhật lại giá trị gốc hiện tại của Form
					this.diaChi = diaChiMoi;
					this.ten = tenMoi;
				}
			}

			// Lấy ngày sinh
			string? ngaySinh = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
			string sdt = tbSDT.Text;
			string soThich = tbSoThich.Text;

			// Nếu user không nhập ngày sinh thì báo lỗi
			if (dtpNgaySinh.CustomFormat == " ")
			{
				MessageBox.Show("Vui lòng chọn ngày sinh!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				dtpNgaySinh.Focus();
				return;
			}

			// Nếu user không nhập số điện thoại thì báo lỗi
			if (string.IsNullOrEmpty(sdt))
			{
				MessageBox.Show("Vui lòng nhập Số điện thoại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				tbSDT.Focus();
				return;
			}

			// Số điện thoại chỉ được 10 số hoặc 11 số
			if (sdt.Length < 10 || sdt.Length > 11)
			{
				MessageBox.Show("Số điện thoại có độ dài tối thiểu 10 số và tối đa 11 số!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				tbSDT.Focus();
				return;
			}

			// Nếu user nhập những kí tự khác ngoài chữ số thì báo lỗi
			if (long.TryParse(sdt, out _))
			{
				MessageBox.Show("Số điện thoại chỉ được chứa các chữ số!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				tbSDT.Focus();
				return;
			}

			// Nếu user không nhập sở thích thì báo lỗi
			if (string.IsNullOrEmpty(soThich))
			{
				MessageBox.Show("Vui lòng nhập Sở thích!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				tbSoThich.Focus();
				return;
			}

			// tạo dòng để lưu
			string? dongMoi = $"{tenDangNhap}|{ngaySinh}|{sdt}|{soThich}";

			if (!File.Exists(fileProfile))
			{
				File.Create(fileProfile).Close();
			}

			List<string> danhSachDong = File.ReadAllLines(fileProfile).ToList();
			bool daCoThongTin = false;

			// Tìm user đó trong danh sách
			for (int i = 0; i < danhSachDong.Count; i++)
			{
				if (string.IsNullOrWhiteSpace(danhSachDong[i])) continue;
				string[] thongTin = danhSachDong[i].Split('|');
				if (thongTin[0] == tenDangNhap)
				{
					// Ghi đè thông tin lên dòng hiện tại
					danhSachDong[i] = dongMoi;
					daCoThongTin = true;
					break;
				}
			}

			// Nếu lần đầu user nhập thì thêm dòng mới
			if (!daCoThongTin)
			{
				danhSachDong.Add(dongMoi);
			}

			File.WriteAllLines(fileProfile, danhSachDong);

			MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
		{
			// Khi người dùng chọn ngày, đổi lại định dạng hiển thị bình thường
			dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
		}

		private void btnDangXuat_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				this.Close(); // Đóng form Home
			}
		}
	}
}
