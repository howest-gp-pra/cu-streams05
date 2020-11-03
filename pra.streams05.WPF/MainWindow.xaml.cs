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
using pra.streams05.CORE;

using System.Net;
using Newtonsoft.Json;

namespace pra.streams05.WPF
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

        private void btnPresidenten_Click(object sender, RoutedEventArgs e)
        {
            // https://mysafeinfo.com/api/data?list=presidents&format=jsonp

            var inhoud = new WebClient().DownloadString("https://mysafeinfo.com/api/data?list=presidents&format=json");
            List<PresidentInfo> presidenten;
            presidenten = JsonConvert.DeserializeObject<List<PresidentInfo>>(inhoud);
            dgrPresident.ItemsSource = presidenten;

        }

        private void btnPostcodes_Click(object sender, RoutedEventArgs e)
        {
            List<PostalCode> postalCodes;
            var json = new WebClient().DownloadString("https://raw.githubusercontent.com/jief/zipcode-belgium/master/zipcode-belgium.json");
            postalCodes = JsonConvert.DeserializeObject<List<PostalCode>>(json);
            dgrPost.ItemsSource = postalCodes;
        }
    }
}
