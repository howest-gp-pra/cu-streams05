using System;
using System.Collections.Generic;
using System.Linq;
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
using Pra.Streams05.Core;

using System.Net;
using Newtonsoft.Json;

namespace Pra.Streams05.Wpf
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

        private void BtnPresidents_Click(object sender, RoutedEventArgs e)
        {
            // https://mysafeinfo.com/api/data?list=presidents&format=jsonp
            var json = new WebClient().DownloadString("https://mysafeinfo.com/api/data?list=presidents&format=json");
            List<PresidentInfo> presidents = JsonConvert.DeserializeObject<List<PresidentInfo>>(json);
            dgrPresident.ItemsSource = presidents;

        }

        private void BtnPostalCodes_Click(object sender, RoutedEventArgs e)
        {
            var json = new WebClient().DownloadString("https://raw.githubusercontent.com/jief/zipcode-belgium/master/zipcode-belgium.json");
            List<PostalCode> postalCodes = JsonConvert.DeserializeObject<List<PostalCode>>(json);
            dgrPost.ItemsSource = postalCodes;
        }
    }
}
