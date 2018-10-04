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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для OptionWindow.xaml
    /// </summary>
    public partial class OptionWindow : MetroWindow
    {
        
        public static Boolean WindowOpened = true;
        

        public OptionWindow()
        {
            InitializeComponent();
            this.Closing += MainWindow_Closing;
            this.Activated += MainWindow_Activating;
        }
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            WindowOpened = true;
        }
        private void MainWindow_Activating(object sender, EventArgs e)
        {
            if (StyleSheet.choosenstyle == 1)
                StyleSheet.Theme1_action_optionwindow(this);
            if (StyleSheet.choosenstyle == 2)
                StyleSheet.Theme2_action_optionwindow(this);
            if (StyleSheet.choosenstyle == 3)
                StyleSheet.Theme3_action_optionwindow(this);
            if (StyleSheet.choosenstyle == 4)
                StyleSheet.Theme4_action_optionwindow(this);
            if (LanguageSheet.choosenlang == 1)
                LanguageSheet.Language1_action_optionwindow(this);
            if (LanguageSheet.choosenlang == 2)
                LanguageSheet.Language2_action_optionwindow(this);
            if (LanguageSheet.choosenlang == 3)
                LanguageSheet.Language3_action_optionwindow(this);
            if (LanguageSheet.choosenlang == 4)
                LanguageSheet.Language4_action_optionwindow(this);
        }
       
        private void Theme1_Click(object sender, RoutedEventArgs e)
        {
            StyleSheet.Theme1_action_optionwindow(this);
            

        }

        private void Theme2_Click(object sender, RoutedEventArgs e)
        {

            StyleSheet.Theme2_action_optionwindow(this);
           
        }

        private void Theme3_Click(object sender, RoutedEventArgs e)
        {
            StyleSheet.Theme3_action_optionwindow(this);
           
        }

        private void Theme4_Click(object sender, RoutedEventArgs e)
        {
            StyleSheet.Theme4_action_optionwindow(this);
           
        }

        private void Englishtile_Click(object sender, RoutedEventArgs e)
        {
            LanguageSheet.Language1_action_optionwindow(this);
        }

        private void Russiantile_Click(object sender, RoutedEventArgs e)
        {
            LanguageSheet.Language2_action_optionwindow(this);
        }

        private void Germantile_Click(object sender, RoutedEventArgs e)
        {
            LanguageSheet.Language3_action_optionwindow(this);
        }

        private void Chinesetile_Click(object sender, RoutedEventArgs e)
        {
            LanguageSheet.Language4_action_optionwindow(this);
        }
    }
}
