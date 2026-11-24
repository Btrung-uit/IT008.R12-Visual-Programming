using Microsoft.Data.SqlClient;
using System.Data;

namespace _25521963_BT03
{
	public class Provider
	{
		public static string ConnectionString = @"Data Source=localhost\SQL2025DEV;Initial Catalog=QuanLySanPham_DB;Integrated Security=True;Trust Server Certificate=True";
		SqlConnection? Connection { get; set; }
		public void Connect()
		{
			try
			{

				if (Connection == null)
					Connection = new SqlConnection(ConnectionString);
				if (Connection.State != ConnectionState.Closed)
					Connection.Close();
				Connection.Open();
			}
			catch (Exception ex)
			{
				throw;
			}
		}

		public void Disconnect()
		{
			if (Connection != null && Connection.State == ConnectionState.Open)
				Connection.Close();
		}

		public DataTable Select(CommandType commandType, string sqlSQL, params SqlParameter[] parameters)
		{
			DataTable dt;
			try
			{
				Connect();
				SqlCommand cmd = Connection.CreateCommand();
				cmd.CommandType = commandType;
				cmd.CommandText = sqlSQL;
				if (parameters != null && parameters.Length > 0)
					cmd.Parameters.AddRange(parameters);
				dt = new DataTable();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}
			catch (Exception ex)
			{
				throw;
			}
			finally
			{
				Disconnect();
			}
			return dt;
		}
	}
}
