using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http.Headers;
using System.Text;

namespace ToDoList
{
	public class ToDoList
	{
		public DataTable LayTatCaNhiemVu()
		{
			try
			{
				string strSQL = "SELECT * FROM dbo.Task";
				Provider p = new Provider();
				DataTable dt = p.Select(CommandType.Text, strSQL);
				return dt;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public int NewTask(Task t)
		{
			try
			{
				string strSQL = """
						INSERT INTO dbo.Task (STT, Title, StartDate, DueDate)
						SELECT ISNULL(MAX(STT), 0) + 1, @Title, @StartDate, @DueDate
						FROM dbo.Task WITH (UPDLOCK, HOLDLOCK);
						""";
				Provider p = new Provider();
				int nRow = p.ExecuteNonQuery(CommandType.Text, strSQL,
					new SqlParameter { ParameterName = "@Title", Value = t.Title },
					new SqlParameter { ParameterName = "@StartDate", Value = t.StartDate },
					new SqlParameter { ParameterName = "@DueDate", Value = t.DueDate }
					);
				return nRow;
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
