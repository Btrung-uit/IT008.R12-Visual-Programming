using System.Diagnostics;

namespace System_Management
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
		}

		private void ExecuteSystemAction(string actionName)
		{
			ProcessStartInfo psi = new ProcessStartInfo();
			psi.FileName = "shutdown.exe";
			psi.CreateNoWindow = true;         // Ẩn cửa sổ CMD đen
			psi.UseShellExecute = false;

			switch (actionName)
			{
				case "Shutdown": // Tắt máy ngay lập tức
					psi.Arguments = "/s /t 0 /f";
					break;

				case "Restart": // Khởi động lại ngay lập tức
					psi.Arguments = "/r /t 0 /f";
					break;

				case "Logout": // Đăng xuất người dùng hiện tại
					psi.Arguments = "/l /f";
					break;

				default:
					return; // Nếu không khớp hành động nào thì bỏ qua
			}

			// Thực thi lệnh
			Process.Start(psi);
		}
		// Biến lưu trữ thời gian đếm ngược
		private int totalSecondRemaining = 0;

		private void btnRunCancel_Click(object sender, EventArgs e)
		{
			if (btnRunCancel.Text == "Run")
			{
				if (!int.TryParse(tbTime.Text, out int timeValue) || timeValue <= 0)
				{
					MessageBox.Show("Vui lòng nhập thời gian hợp lệ (lớn hơn 0!");
					return;
				}

				string unit = cbbTimeType.SelectedItem?.ToString() ?? "s";

				// Quy đổi ra giây tương ứng
				if (unit == "minutes")
				{
					totalSecondRemaining = timeValue * 60;
				}
				else if (unit == "hours")
				{
					totalSecondRemaining = timeValue * 3600;
				}
				else
				{
					totalSecondRemaining = timeValue;
				}

				string action = cbbAction.SelectedText;

				// Cập nhật hiển thị ban đầu lên ô Remaining Time
				UpdateTimeRemainingDisplay();

				// Kích hoạt đếm ngược
				timer1.Start();

				// Chuyển sang Cancel
				btnRunCancel.Text = "Cancel";
			}
			else
			{
				// Dung timer va reset
				timer1.Stop();
				totalSecondRemaining = 0;
				tbRemainingTime.Text = "00:00:00";

				// Trả về Run
				btnRunCancel.Text = "Run";
			}
		}

		private void UpdateTimeRemainingDisplay()
		{
			// chia giờ:phút:giây
			TimeSpan time = TimeSpan.FromSeconds(totalSecondRemaining);

			// định dạng hh:mm:ss
			tbRemainingTime.Text = time.ToString(@"hh\:mm\:ss");
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (totalSecondRemaining > 0)
			{
				// Giảm đi 1 giây sau mỗi 1000ms
				totalSecondRemaining--;

				// Cập nhật lại giao diện hiển thị
				UpdateTimeRemainingDisplay();
			}
			else
			{
				// Khi thời gian đã về 0
				timer1.Stop();

				string selectedAction = cbbAction.SelectedItem?.ToString() ?? "Shutdown";

				// Thực thi lệnh
				ExecuteSystemAction(selectedAction);
			}
		}
	}
}
