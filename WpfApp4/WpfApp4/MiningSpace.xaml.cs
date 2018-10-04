using System;
using System.IO;
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
    /// Логика взаимодействия для MiningSpace.xaml
    /// </summary>
    public partial class MiningSpace : MetroWindow
    {
        private int minerchoose=1;
        
        public static Boolean WindowOpened = true;
        public MiningSpace()
        {
            InitializeComponent();
            this.Closing += MainWindow_Closing;
           
            this.Loaded += MainWindow_Loaded;
        }
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DbActions.Dbaction_action_miningspace(this, minerchoose);
            WindowOpened = true;
            
        }
      
       
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (StyleSheet.choosenstyle == 1)
                StyleSheet.Theme1_action_miningspace(this);
            if (StyleSheet.choosenstyle == 2)
                StyleSheet.Theme2_action_miningspace(this);
            if (StyleSheet.choosenstyle == 3)
                StyleSheet.Theme3_action_miningspace(this);
            if (StyleSheet.choosenstyle == 4)
                StyleSheet.Theme4_action_miningspace(this);

            if (LanguageSheet.choosenlang == 1)
                LanguageSheet.Language1_action_miningspace(this);
            if (LanguageSheet.choosenlang == 2)
                LanguageSheet.Language2_action_miningspace(this);
            if (LanguageSheet.choosenlang == 3)
                LanguageSheet.Language3_action_miningspace(this);
            if (LanguageSheet.choosenlang == 4)
                LanguageSheet.Language4_action_miningspace(this);
            pooladress.Text = DbActions.ReadMiner(this, 1, minerchoose);
            wallet.Text = DbActions.ReadMiner(this, 2, minerchoose);
            DbActions.Dbaction_action_miningspace(this, minerchoose);
            urchoose.Text = LanguageSheet.langtmp + " ETHASH";

        }
        /*
        1 - ethash
        2 - zhash
        3 - equihash
        4 - lyrav2
        5 - neoscrypt
        6 - cryptonightv7
        7 - hodl
        8 - cryptonight
        9 - lyra
        */
        private void ethash(object sender, RoutedEventArgs e)
        {
      
            DbActions.Dbaction_action_miningspace(this, minerchoose);
            urchoose.Text = LanguageSheet.langtmp+" ETHASH";
            minerchoose = 1;
            pooladress.Text = DbActions.ReadMiner(this, 1, minerchoose);
            wallet.Text = DbActions.ReadMiner(this, 2, minerchoose);

        }
        private void zhash(object sender, RoutedEventArgs e)
        {
            DbActions.Dbaction_action_miningspace(this, minerchoose);
            urchoose.Text = LanguageSheet.langtmp + " ZHASH";
            minerchoose = 2;
            pooladress.Text = DbActions.ReadMiner(this, 1, minerchoose);
            wallet.Text = DbActions.ReadMiner(this, 2, minerchoose);
        }
        private void TimeTravel10(object sender, RoutedEventArgs e)
        {
            DbActions.Dbaction_action_miningspace(this, minerchoose);
            urchoose.Text = LanguageSheet.langtmp + " TIMETRAVEL10";
            minerchoose = 3;
            pooladress.Text = DbActions.ReadMiner(this, 1, minerchoose);
            wallet.Text = DbActions.ReadMiner(this, 2, minerchoose);
        }
        private void lyrav2(object sender, RoutedEventArgs e)
        {
            DbActions.Dbaction_action_miningspace(this, minerchoose);
            urchoose.Text = LanguageSheet.langtmp + " LYRA2REV2";
            minerchoose = 4;
            pooladress.Text = DbActions.ReadMiner(this, 1, minerchoose);
            wallet.Text = DbActions.ReadMiner(this, 2, minerchoose);
        }
        private void neoscrypt(object sender, RoutedEventArgs e)
        {
            DbActions.Dbaction_action_miningspace(this, minerchoose);
            urchoose.Text = LanguageSheet.langtmp + " NEOSCRYPT";
            minerchoose = 5;
            pooladress.Text = DbActions.ReadMiner(this, 1, minerchoose);
            wallet.Text = DbActions.ReadMiner(this, 2, minerchoose);
        }
        private void cryptonightv7(object sender, RoutedEventArgs e)
        {
            DbActions.Dbaction_action_miningspace(this, minerchoose);
            urchoose.Text = LanguageSheet.langtmp + " CRYPTONIGHTV7";
            minerchoose = 6;
            pooladress.Text = DbActions.ReadMiner(this, 1, minerchoose);
            wallet.Text = DbActions.ReadMiner(this, 2, minerchoose);
        }
        private void hodl(object sender, RoutedEventArgs e)
        {
            DbActions.Dbaction_action_miningspace(this, minerchoose);
            urchoose.Text = LanguageSheet.langtmp + " HODL";
            minerchoose = 7;
            pooladress.Text = DbActions.ReadMiner(this, 1, minerchoose);
            wallet.Text = DbActions.ReadMiner(this, 2, minerchoose);
        }
        private void lbry(object sender, RoutedEventArgs e)
        {
            DbActions.Dbaction_action_miningspace(this, minerchoose);
            urchoose.Text = LanguageSheet.langtmp + " LBRY";
            minerchoose = 8;
            pooladress.Text = DbActions.ReadMiner(this, 1, minerchoose);
            wallet.Text = DbActions.ReadMiner(this, 2, minerchoose);
        }
        private void lyra(object sender, RoutedEventArgs e)
        {
            DbActions.Dbaction_action_miningspace(this, minerchoose);
            urchoose.Text = LanguageSheet.langtmp + " LYRA2RE";
            minerchoose = 9;
            pooladress.Text = DbActions.ReadMiner(this, 1, minerchoose);
            wallet.Text = DbActions.ReadMiner(this, 2, minerchoose);
        }
        private void startminer(object sender, RoutedEventArgs e)
        {
            string letsstart = null;
            string path = null;
            string adreess = pooladress.Text;
            string walletadress = wallet.Text;
            if (minerchoose == 1)
            {
                letsstart = "-epool " + adreess + " -ewal " + walletadress + " -epsw x " + DbActions.ReadMiner(this,3,1);
                path = System.IO.Path.GetFullPath(@"..\..\") + @"Resources\ethminer\EthDcrMiner64.exe";                
            }
            if (minerchoose == 2)
            {
                letsstart = "--server "+adreess+" --port 3333 --user "+walletadress+" --pass x " + DbActions.ReadMiner(this, 3, 2);
                path = System.IO.Path.GetFullPath(@"..\..\") + @"Resources\zashminer\miner.exe";
            }
            if (minerchoose == 3)
            {
                letsstart = "-a bitcore -o " + adreess + " -u " + walletadress + " -p x --cpu-priority 3 " + DbActions.ReadMiner(this, 3, 3);
                path = System.IO.Path.GetFullPath(@"..\..\") + @"Resources\timetravel\ccminer-x64.exe";
            }
            if (minerchoose == 4)
            {
                letsstart = "-a lyra2rev2 -o " + adreess + " -u " + walletadress + " -p x " + DbActions.ReadMiner(this, 3, 4);
                path = System.IO.Path.GetFullPath(@"..\..\") + @"Resources\ccminer\ccminer.exe";
            }
            if (minerchoose == 5)
            {
                letsstart = "-a neoscrypt -o " + adreess + " -u " + walletadress + " -p x " + DbActions.ReadMiner(this, 3, 5);
                path = System.IO.Path.GetFullPath(@"..\..\") + @"Resources\ccminer\ccminer.exe";
            }
            if (minerchoose == 6)
            {
                letsstart = "-o " + adreess + " -u " + walletadress + " -p x " + DbActions.ReadMiner(this, 3, 6);
                path = System.IO.Path.GetFullPath(@"..\..\") + @"\Resources\cryptonightcpu\NsCpuCNMiner64.exe";
            }
            if (minerchoose == 7)
            {
                letsstart = "-o " + adreess + " -u " + walletadress + " -p x " + DbActions.ReadMiner(this, 3, 7);
                path = System.IO.Path.GetFullPath(@"..\..\") + @"Resources\hodlminer.exe";
            }
           
            if (minerchoose == 9)
            {
                letsstart = "-a lyra2re -o "+ adreess + " -u "+ walletadress + " -p x " + DbActions.ReadMiner(this, 3, 8);
                path = System.IO.Path.GetFullPath(@"..\..\") + @"Resources\cpuminer\cpuminer.exe";
            }
            if (minerchoose == 8)
            {
                letsstart = "-a lbry -o " + adreess + " -u " + walletadress + " -p password " + DbActions.ReadMiner(this, 3, 9);
                path = System.IO.Path.GetFullPath(@"..\..\") + @"Resources\cpuminer\cpuminer.exe";
            }
            if (letsstart != null)
            {
                System.Diagnostics.Process.Start(path, letsstart);
            }
        }

        private void advanceoption_button_Click(object sender, RoutedEventArgs e)
        {
          
            AdvancedOptionWindow advancedOptionWindow = new AdvancedOptionWindow();
            advancedOptionWindow.Owner = this;
            if (AdvancedOptionWindow.WindowOpened)
            {
                advancedOptionWindow.Show();
                AdvancedOptionWindow.WindowOpened = false;
            }
        }
        
    }
}
