using System;
using System.Collections.Generic;

using System.Diagnostics;
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
using MahApps.Metro.Controls;

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        //private Style buttonStyleWhite;
      
        public MainWindow()
        {
            InitializeComponent();
            DbActions.StyleAction();
            DbActions.LanguageAction();
             
            this.Activated += MainWindow_Activating;
           
            
        }
        private void MainWindow_Activating(object sender, EventArgs e)
        {
           

            if (StyleSheet.choosenstyle == 1)
                    StyleSheet.Theme1_action_mainwindow(this);
                if (StyleSheet.choosenstyle == 2)
                    StyleSheet.Theme2_action_mainwindow(this);
                if (StyleSheet.choosenstyle == 3)
                    StyleSheet.Theme3_action_mainwindow(this);
                if (StyleSheet.choosenstyle == 4)
                    StyleSheet.Theme4_action_mainwindow(this);
            if (LanguageSheet.choosenlang == 1)
                LanguageSheet.Language1_action_mainnwindow(this);
            if (LanguageSheet.choosenlang == 2)
                LanguageSheet.Language2_action_mainnwindow(this);
            if (LanguageSheet.choosenlang == 3)
                LanguageSheet.Language3_action_mainnwindow(this);
            if (LanguageSheet.choosenlang == 4)
                LanguageSheet.Language4_action_mainnwindow(this);



         
        }
        private void exchange_rates(object sender, RoutedEventArgs e)
        {
           
            TaskWindow taskWindow = new TaskWindow();
            taskWindow.Owner = this;
            if (TaskWindow.WindowOpened && MiningSpace.WindowOpened && OptionWindow.WindowOpened && MiningCalc.WindowOpened)
            {
                taskWindow.Show();
                TaskWindow.WindowOpened = false;
            }
        }
        private void mining_space(object sender, RoutedEventArgs e)
        {

            MiningSpace miningWindow = new MiningSpace();
            miningWindow.Owner = this;
            if (TaskWindow.WindowOpened && MiningSpace.WindowOpened && OptionWindow.WindowOpened && MiningCalc.WindowOpened)
            {
                miningWindow.Show();
                MiningSpace.WindowOpened = false;
            }
        }

        private void program_option(object sender, RoutedEventArgs e)
        {
            OptionWindow optionWindow = new OptionWindow();
            optionWindow.Owner = this;
            if (TaskWindow.WindowOpened && MiningSpace.WindowOpened && OptionWindow.WindowOpened && MiningCalc.WindowOpened)
            {
                optionWindow.Show();
                OptionWindow.WindowOpened = false;
            }
        }

        private void mining_calc(object sender, RoutedEventArgs e)
        {

            MiningCalc miningCalc = new MiningCalc();
            miningCalc.Owner = this;
            if (MiningCalc.WindowOpened && MiningSpace.WindowOpened && OptionWindow.WindowOpened && TaskWindow.WindowOpened)
            {
                miningCalc.Show();
                MiningCalc.WindowOpened = false;
            }
        }
        
    }
}
