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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для AdvancedOptionWindow.xaml
    /// </summary>
    /// 

    public partial class AdvancedOptionWindow : MetroWindow
    {
        public static Boolean WindowOpened = true;
        int slider1 = 0, slider2 = 0, slider3 = 0;
        string advstring=null;
        public AdvancedOptionWindow()
        {
            InitializeComponent();
            this.Closing += MainWindow_Closing;
            this.Loaded += MainWindow_Loaded;
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (StyleSheet.choosenstyle == 1)
                StyleSheet.Theme1_action_advwindow(this);
            if (StyleSheet.choosenstyle == 2)
                StyleSheet.Theme2_action_advwindow(this);
            if (StyleSheet.choosenstyle == 3)
                StyleSheet.Theme3_action_advwindow(this);
            if (StyleSheet.choosenstyle == 4)
                StyleSheet.Theme4_action_advwindow(this);

            if (LanguageSheet.choosenlang == 1)
                LanguageSheet.Language1_action_advwindow(this);
            if (LanguageSheet.choosenlang == 2)
                LanguageSheet.Language2_action_advwindow(this);
            if (LanguageSheet.choosenlang == 3)
                LanguageSheet.Language3_action_advwindow(this);
            if (LanguageSheet.choosenlang == 4)
                LanguageSheet.Language4_action_advwindow(this);

        }
       
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            WindowOpened = true;
        }
        private void FirstSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double value = FirstSlider.Value;
            string str = value.ToString();
            
            try
            {
                if (value>9.99)
                cooler.Text = str.Substring(0, 2) + "%";
                else
                    cooler.Text = str.Substring(0, 1) + "%";
            }
            catch (Exception ex)
            {
                if(value ==0)
                {
                    cooler.Text = "0%";
                }
            }
            if(value==100)
            {
                cooler.Text = "100%";
            }
            slider1 = Convert.ToInt32(value);
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double value = SecondSlider.Value;
            string str = value.ToString();
            try
            {

                if (value > 9.99)
                    cp.Text = str.Substring(0, 2) + "%";
                else
                    cp.Text = str.Substring(0, 1) + "%";
            }
            catch (Exception ex)
            {
                if (value == 0)
                {
                    cp.Text = "0%";
                }
            }
            if (value == 100)
            {
                cp.Text = "100%";
            }
            slider2 = Convert.ToInt32(value);
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            // DbActions.Dbaction_action_advoption(this, MiningSpace.minerchoose);
            advstring = advtextbox.Text;
            DbActions.Dbaction_action_advoption(this, slider1, slider2, advtextbox.Text);
            actionasync(true);

        }


        private async void actionasync(bool t)
        {
           
                if (LanguageSheet.choosenlang == 1)
                    await this.ShowMessageAsync("Saving successful", "Your settings have been saved");
                if (LanguageSheet.choosenlang == 2)
                    await this.ShowMessageAsync("Успешно", "Ваши настройки сохранены");
                if (LanguageSheet.choosenlang == 3)
                    await this.ShowMessageAsync("Erfolgreich", "Ihre Einstellungen wurden gespeichert");
                if (LanguageSheet.choosenlang == 4)
                    await this.ShowMessageAsync("顺利", "您的设置已保存");
            
           
        }
    }
}
