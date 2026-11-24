using System.Data;
using System.Diagnostics;
using Microsoft.Data.SqlClient;

namespace _25521963_BT03
{
    public partial class QuanLySanPhamForm : Form
    {
        List<string> lstDonViTinh = new List<string>() {"Thùng", "Cái", "Chai", "Hộp", "Bịch"};
        public QuanLySanPhamForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void QuanLySanPhamForm_Load(object sender, EventArgs e)
        {
            try
            {
                cbbDonViTinh.DataSource = lstDonViTinh;
                QuanLySanPham QLSP = new QuanLySanPham();
                DataTable dt = QLSP.LayTatCaSanPham();
                dgvSanPham.DataSource = dt;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }


    }
}
