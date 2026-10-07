using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		private void btnCong_Click(object sender, RoutedEventArgs e)
		{
			
			try
			{
				double so1 = Convert.ToDouble(tbSo1.Text.ToString());
				double so2 = Convert.ToDouble(tbSo2.Text.ToString());
				double tong = so1 + so2;
				string kq = string.Format("Kết quả: {0} + {1} = {2}", so1, so2, tong);
				tblKetQua.Text = kq;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

		}

		private void btnTru_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				double so1 = Convert.ToDouble(tbSo1.Text.ToString());
				double so2 = Convert.ToDouble(tbSo2.Text.ToString());
				double hieu = so1 - so2;
				string kq = string.Format("Kết quả: {0} + {1} = {2}", so1, so2, hieu);
				tblKetQua.Text = kq;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private void btnNhan_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				double so1 = Convert.ToDouble(tbSo1.Text.ToString());
				double so2 = Convert.ToDouble(tbSo2.Text.ToString());
				double tich = so1 * so2;
				string kq = string.Format("Kết quả: {0} * {1} = {2}", so1, so2, tich);
				tblKetQua.Text = kq;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private void btnChia_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				double so1 = Convert.ToDouble(tbSo1.Text.ToString());
				double so2 = Convert.ToDouble(tbSo2.Text.ToString());
				double thuong = so1 / so2;
				string kq = string.Format("Kết quả: {0} / {1} = {2}", so1, so2, thuong);
				tblKetQua.Text = kq;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}