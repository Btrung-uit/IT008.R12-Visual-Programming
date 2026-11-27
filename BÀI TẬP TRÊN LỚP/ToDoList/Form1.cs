using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace ToDoList
{
	public partial class Form1 : Form
	{
		private readonly ToDoList toDoList = new ToDoList();

		public Form1()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			try
			{
				HienThiDuLieuManHinh();
			}
			catch (SqlException ex)
			{
				Debug.WriteLine(ex.ToString());
				MessageBox.Show("Không tải được danh sách công việc.");
			}
		}

		public void GanDuLieuManHinh(Task? t)
		{
			if (t != null)
			{
				tbSTT.Text = t.STT;
				tbTitle.Text = t.Title;
				dtpStartDate.Value = DateTime.Parse(t.StartDate);
				dtpDueDate.Value = DateTime.Parse(t.DueDate);
			}
			else
			{
				tbTitle.Text = "";
				dtpStartDate.Value = DateTime.Now;
				dtpDueDate.Value = DateTime.Now;
			}
		}

		public void HienThiDuLieuManHinh()
		{
			DataTable dt = toDoList.LayTatCaNhiemVu();
			dgvToDo.DataSource = dt;

			int maxSTT = dt.Compute("MAX(STT)", null) is int stt ? stt : 0;
			tbSTT.Text = maxSTT == int.MaxValue ? string.Empty : (maxSTT + 1).ToString();

			GanDuLieuManHinh(null);
			dgvToDo.ClearSelection();
		}

		public Task LayDuLieuManHinh()
		{
			Task t = new Task();
			t.STT = tbSTT.Text;
			t.Title = tbTitle.Text.Trim();
			t.StartDate = dtpStartDate.Value.ToString("yyyy-MM-dd");
			t.DueDate = dtpDueDate.Value.ToString("yyyy-MM-dd");
			return t;
		}
		private void btnNew_Click(object sender, EventArgs e)
		{
			Task task = LayDuLieuManHinh();

			if (task.Title.Length == 0 || task.Title.Length > 100)
			{
				MessageBox.Show("Tiêu đề phải có từ 1 đến 100 ký tự.");
				tbTitle.Focus();
				return;
			}

			if (dtpDueDate.Value.Date < dtpStartDate.Value.Date)
			{
				MessageBox.Show("Hạn chót phải từ ngày bắt đầu trở đi.");
				dtpDueDate.Focus();
				return;
			}

			bool daLuu = false;

			try
			{
				daLuu = toDoList.NewTask(task) == 1;
				if (!daLuu)
				{
					MessageBox.Show("Không thêm được công việc.");
					return;
				}

				HienThiDuLieuManHinh();
			}
			catch (SqlException ex)
			{
				Debug.WriteLine(ex.ToString());
				MessageBox.Show(daLuu
					? "Đã lưu công việc nhưng chưa tải lại được danh sách."
					: "Không lưu được công việc.");
			}
		}
	}
}
