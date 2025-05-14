using System.Net.Http;
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

namespace Slot1_DemoHttpsClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public MainWindow() ...

        readonly HttpClient client = new HttpClient();

        private void btnClose_Click(object sender, RoutedEventArgs e) => Close();
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {

            txtContent.Text = string.Empty;
        }
        private async void btnViewHTML_Click(object sender, RoutedEventArgs e)
        {
            var url = txtURL.Text;

            try
            {
                // Call asynchronous network methods
                string responseBody = await client.GetStringAsync(url);
                txtContent.Text = responseBody.Trim();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Message: {ex.Message}");
            }
        }
    }
}