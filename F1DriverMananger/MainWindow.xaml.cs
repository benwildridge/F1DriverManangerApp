using F1DriverMananger.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace F1DriverMananger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HttpClient client = new HttpClient();

        public MainWindow()
        {
            client.BaseAddress = new Uri("https://localhost:7266/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                );
            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, RoutedEventArgs e)
        {
            this.GetDrivers();
        }

        private async void GetDrivers()
        {
            var response = await client.GetStringAsync("Driver");
            var drivers = JsonConvert.DeserializeObject<List<Driver>>(response);
            dgDriverList.DataContext = drivers;
        }
    }
}
