using Microsoft.Data.SqlClient;
using System.Data;

namespace _25521963_BT03
{
    public class QuanLySanPham
    {
        public DataTable LayTatCaSanPham()
        {
            try
            {
                string strSQL = "SELECT * FROM SanPham";
                Provider p = new Provider();
                DataTable dt = p.Select(CommandType.Text, strSQL);
                return dt;

            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
