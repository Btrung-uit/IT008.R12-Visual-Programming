using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
	public class Task
	{
		string _stt;
		string _title;
		string _startDate;
		string _dueDate;

		public string STT { get => _stt; set => _stt = value; }
		public string Title { get => _title; set => _title = value; }
		public string StartDate { get => _startDate; set => _startDate = value; }
		public string DueDate { get => _dueDate; set => _dueDate = value; }

		public Task()
		{
		}

		public Task(string stt, string title, string startDate, string dueDate)
		{
			STT = stt.Trim();
			CapNhatThongTin(title, startDate, dueDate);
		}

		public void CapNhatThongTin(string title, string startDate, string dueDate)
		{
			if (string.IsNullOrWhiteSpace(title))
			{
				throw new ArgumentException("Nội dung nhiệm vụ không được để trống!");
			}

			if (string.IsNullOrEmpty(startDate))
			{
				throw new ArgumentException("Ngày bắt đầu không được để trống!");
			}
			if (string.IsNullOrEmpty(dueDate))
			{
				throw new ArgumentException("Ngày kết thúc không được để trống!");
			}

			Title = title;
			StartDate = startDate;
			DueDate = dueDate;
		}
	}
}