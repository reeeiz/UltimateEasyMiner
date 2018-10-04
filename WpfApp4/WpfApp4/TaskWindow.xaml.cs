using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using Newtonsoft.Json;

namespace WpfApp4
{
    
    /// <summary>
    /// Логика взаимодействия для TaskWindow.xaml
    /// </summary>
    public partial class TaskWindow : MetroWindow
    {
        
        private string crypto_option;
        private string fiat_option;
        public static Boolean WindowOpened=true;
        public string ViewModel { get; set; }
        public static TaskWindow obj = new TaskWindow();
        public TaskWindow()
        {
            
            InitializeComponent();         
           
            this.Closing += MainWindow_Closing;
            this.Loaded += MainWindow_Loaded;

        }
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            WindowOpened = true;
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (StyleSheet.choosenstyle == 1)
                StyleSheet.Theme1_action_taskwindow(this);
            if (StyleSheet.choosenstyle == 2)
                StyleSheet.Theme2_action_taskwindow(this);
            if (StyleSheet.choosenstyle == 3)
                StyleSheet.Theme3_action_taskwindow(this);
            if (StyleSheet.choosenstyle == 4)
                StyleSheet.Theme4_action_taskwindow(this);
            if (LanguageSheet.choosenlang == 1)
                LanguageSheet.Language1_action_taskwindow(this);
            if (LanguageSheet.choosenlang == 2)
                LanguageSheet.Language2_action_taskwindow(this);
            if (LanguageSheet.choosenlang == 3)
                LanguageSheet.Language3_action_taskwindow(this);
            if (LanguageSheet.choosenlang == 4)
                LanguageSheet.Language4_action_taskwindow(this);
        }
            
        public void ShowViewModel()
        {
            MessageBox.Show(ViewModel);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void cryptobutton1_click(object sender, RoutedEventArgs e)
        {
            cryptobutton4.IsChecked = false;
            cryptobutton2.IsChecked = false;
            cryptobutton3.IsChecked = false;
            crypto_option = "BTC";
        }
        private void cryptobutton2_click(object sender, RoutedEventArgs e)
        {
            cryptobutton1.IsChecked = false;
            cryptobutton4.IsChecked = false;
            cryptobutton3.IsChecked = false;
            crypto_option = "DASH";
        }
        private void cryptobutton3_click(object sender, RoutedEventArgs e)
        {
            cryptobutton1.IsChecked = false;
            cryptobutton2.IsChecked = false;
            cryptobutton4.IsChecked = false;
            crypto_option = "ETH";


        }
        private void cryptobutton4_click(object sender, RoutedEventArgs e)
        {
            cryptobutton1.IsChecked = false;
            cryptobutton2.IsChecked = false;
            cryptobutton3.IsChecked = false;
            crypto_option = "XEM";
        }
        private void fiatbutton1_click(object sender, RoutedEventArgs e)
        {
            fiatbutton4.IsChecked = false;
            fiatbutton2.IsChecked = false;
            fiatbutton3.IsChecked = false;
            fiat_option = "USD";
        }
        private void fiatbutton2_click(object sender, RoutedEventArgs e)
        {
            fiatbutton1.IsChecked = false;
            fiatbutton4.IsChecked = false;
            fiatbutton3.IsChecked = false;
            fiat_option = "EUR";
        }
        private void fiatbutton3_click(object sender, RoutedEventArgs e)
        {
            fiatbutton1.IsChecked = false;
            fiatbutton2.IsChecked = false;
            fiatbutton4.IsChecked = false;
            fiat_option = "GBP";

        }
        private void fiatbutton4_click(object sender, RoutedEventArgs e)
        {
            fiatbutton1.IsChecked = false;
            fiatbutton2.IsChecked = false;
            fiatbutton3.IsChecked = false;
            fiat_option = "RUB";
        }

       
        private void get_currency(object sender, RoutedEventArgs e)
        {
            if (crypto_option != null && fiat_option != null)
            {
                var info = GetExchangeInfo(fiat_option, crypto_option);
               
                currency.Text = info.FriendlyLast;
            }

        }
        static ExchangeInfo GetExchangeInfo(string from, string to)
        {
            using (WebClient client = new WebClient())
            {
                var json = client.DownloadString(string.Format(@"https://spectrocoin.com/scapi/ticker/{0}/{1}/", from, to));
                return JsonConvert.DeserializeObject<ExchangeInfo>(json);
            }
        }

    }
    public class ExchangeInfo
    {
       
        [JsonProperty("friendlyLast")]
        public string FriendlyLast { get; set; }
    }
}
