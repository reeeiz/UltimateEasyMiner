using MahApps.Metro.Controls;
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
using System.Windows.Shapes;
using Newtonsoft.Json;
using System.Net;
using MahApps.Metro.Controls.Dialogs;

namespace WpfApp4
{
    public class ProfitInfo
    {
        [JsonProperty(PropertyName = "revenue")]
        public string Revenue;
    }
    /// <summary>
    /// Логика взаимодействия для MiningCalc.xaml
    /// </summary>
    public partial class MiningCalc : MetroWindow
    {

        public static Boolean WindowOpened = true;
       
        double divider = 0;
        static int indexcoin = 0;
        public MiningCalc()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
            this.Closing += MainWindow_Closing;
        }
        static ProfitInfo GetProfitInfo()
        {
            using (WebClient client = new WebClient())
            {

                var json = client.DownloadString(string.Format(@"https://whattomine.com/coins/"+indexcoin+".json"));
                return JsonConvert.DeserializeObject<ProfitInfo>(json);
            }
        }
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            WindowOpened = true;
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (StyleSheet.choosenstyle == 1)
                StyleSheet.Theme1_action_calcwindow(this);
            if (StyleSheet.choosenstyle == 2)
                StyleSheet.Theme2_action_calcwindow(this);
            if (StyleSheet.choosenstyle == 3)
                StyleSheet.Theme3_action_calcwindow(this);
            if (StyleSheet.choosenstyle == 4)
                StyleSheet.Theme4_action_calcwindow(this);

            if (LanguageSheet.choosenlang == 1)
            {
                LanguageSheet.Language1_action_miningcalc(this);              
            }
            if (LanguageSheet.choosenlang == 2)
            {
                LanguageSheet.Language2_action_miningcalc(this);
            }
            if (LanguageSheet.choosenlang == 3)
            {
                LanguageSheet.Language3_action_miningcalc(this);
            }
            if (LanguageSheet.choosenlang == 4)
            {
                LanguageSheet.Language4_action_miningcalc(this);
            }
            dayprofit.Text = LanguageSheet.langtmp_calc1 + " 0.00$";
            minedday.Text = LanguageSheet.langtmp_calc2 + " 0.00$";
            powercostday.Text = LanguageSheet.langtmp_calc3 + " 0.00$";
            profitweek.Text = LanguageSheet.langtmp_calc4 + " 0.00$";
            minedweek.Text = LanguageSheet.langtmp_calc5 + " 0.00$";
            powercostweek.Text = LanguageSheet.langtmp_calc6 + " 0.00$";
            profitmonth.Text = LanguageSheet.langtmp_calc7 + " 0.00$";
            minedmonth.Text = LanguageSheet.langtmp_calc8 + " 0.00$";
            powercostmonth.Text = LanguageSheet.langtmp_calc9 + " 0.00$";
            choosencoin.Text = LanguageSheet.langtmp + " Ethereum";
            hashratetext.Text = LanguageSheet.langtmp_calc10 + "Mh/s:";
           
            divider = 84;
            indexcoin = 151;

        }

            private void cryptobutton1_click(object sender, RoutedEventArgs e)
        {
            //101
            choosencoin.Text = LanguageSheet.langtmp + " Monero";
            hashratetext.Text = LanguageSheet.langtmp_calc10 + "H/s:";
           
            indexcoin = 101;
            divider = 2580;
        }
        private void cryptobutton2_click(object sender, RoutedEventArgs e)
        {
            //162
            choosencoin.Text = LanguageSheet.langtmp + " ETC";
            hashratetext.Text = LanguageSheet.langtmp_calc10 + "Mh/s:";
            
            indexcoin = 162;
            divider = 84;
        }

        private void cryptobutton3_click(object sender, RoutedEventArgs e)
        {
            //151
            choosencoin.Text = LanguageSheet.langtmp + " Ethereum";
            hashratetext.Text = LanguageSheet.langtmp_calc10 + "Mh/s:";
           
            indexcoin = 151;
            divider = 84;
        }

        private void cryptobutton4_click(object sender, RoutedEventArgs e)
        {
            //214
            choosencoin.Text = LanguageSheet.langtmp + "BTG";
            hashratetext.Text = LanguageSheet.langtmp_calc10 + "H/s:";
            
            indexcoin = 214;
            divider = 105;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double result1, result2 = 0;
                double mhs = Convert.ToDouble(hashrate.Text);
                double revenue = double.Parse(GetProfitInfo().Revenue.Substring(1), System.Globalization.CultureInfo.InvariantCulture) / divider;

                if (Convert.ToDouble(fee.Text) != 0 || fee.Text != null)
                {
                    result1 = (revenue * mhs) - ((revenue * mhs) * (Convert.ToDouble(fee.Text) / 100));
                    result2 = Math.Round((revenue * mhs), 2);
                }
                else
                {
                    result1 = revenue * mhs;
                    result2 = Math.Round((revenue * mhs), 2);
                }


                if (cost_kwh.Text == null || double.Parse(cost_kwh.Text, System.Globalization.CultureInfo.InvariantCulture) != 0 || watts.Text == null || double.Parse(watts.Text, System.Globalization.CultureInfo.InvariantCulture) != 0)
                {
                    dayprofit.Text = LanguageSheet.langtmp_calc1 + Convert.ToString(Math.Round(result1 - ((Convert.ToDouble(watts.Text) / 1000) * double.Parse(cost_kwh.Text, System.Globalization.CultureInfo.InvariantCulture) * 24),2)) + "$";
                    profitweek.Text = LanguageSheet.langtmp_calc4 + Convert.ToString(Math.Round((result1 * 7) - ((Convert.ToDouble(watts.Text) / 1000) * double.Parse(cost_kwh.Text, System.Globalization.CultureInfo.InvariantCulture) * 24 * 7),2)) + "$";
                    profitmonth.Text = LanguageSheet.langtmp_calc7 + Convert.ToString(Math.Round((result1 * 30) - ((Convert.ToDouble(watts.Text) / 1000) * double.Parse(cost_kwh.Text, System.Globalization.CultureInfo.InvariantCulture) * 24 * 30),2)) + "$";
                    minedday.Text = LanguageSheet.langtmp_calc2 + Convert.ToString(result2) + "$";
                    minedweek.Text = LanguageSheet.langtmp_calc5 + Convert.ToString(result2 * 7) + "$";
                    minedmonth.Text = LanguageSheet.langtmp_calc8 + Convert.ToString(result2 * 30) + "$";
                    powercostday.Text = LanguageSheet.langtmp_calc3 + Convert.ToString(Math.Round(((Convert.ToDouble(watts.Text) / 1000) * double.Parse(cost_kwh.Text, System.Globalization.CultureInfo.InvariantCulture) * 24),2)) + "$";
                    powercostweek.Text = LanguageSheet.langtmp_calc6 + Convert.ToString(Math.Round(((Convert.ToDouble(watts.Text) / 1000) * double.Parse(cost_kwh.Text, System.Globalization.CultureInfo.InvariantCulture) * 24 * 7),2)) + "$";
                    powercostmonth.Text = LanguageSheet.langtmp_calc9 + Convert.ToString(Math.Round(((Convert.ToDouble(watts.Text) / 1000) * double.Parse(cost_kwh.Text, System.Globalization.CultureInfo.InvariantCulture) * 24 * 30),2)) + "$";
                }
                else
                {
                    dayprofit.Text = LanguageSheet.langtmp_calc1 + Convert.ToString(Math.Round(result1,2)) + "$";
                    profitweek.Text = LanguageSheet.langtmp_calc4 + Convert.ToString(Math.Round(result1 * 7,2)) + "$";
                    profitmonth.Text = LanguageSheet.langtmp_calc7 + Convert.ToString(Math.Round(result1 * 30,2)) + "$";
                    minedday.Text = LanguageSheet.langtmp_calc2 + Convert.ToString(result2) + "$";
                    minedweek.Text = LanguageSheet.langtmp_calc5 + Convert.ToString(result2 * 7) + "$";
                    minedmonth.Text = LanguageSheet.langtmp_calc8 + Convert.ToString(result2 * 30) + "$";
                    powercostday.Text = LanguageSheet.langtmp_calc3 + "0.00$";
                    powercostweek.Text = LanguageSheet.langtmp_calc6 + "0.00$";
                    powercostmonth.Text = LanguageSheet.langtmp_calc9 + "0.00$";
                }
            }
            catch(Exception ex)
            {
                actionasync(true);
            }
        }
        private async void actionasync(bool t)
        {

            if (LanguageSheet.choosenlang == 1)
                await this.ShowMessageAsync("Error", "Data entered incorrectly");
            if (LanguageSheet.choosenlang == 2)
                await this.ShowMessageAsync("Ошибка", "Данные введены неверно");
            if (LanguageSheet.choosenlang == 3)
                await this.ShowMessageAsync("Fehler", "Daten falsch eingegeben");
            if (LanguageSheet.choosenlang == 4)
                await this.ShowMessageAsync("错误", "数据输入错误");


        }
    }
}
