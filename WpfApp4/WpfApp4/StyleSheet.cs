using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfApp4
{
    public class StyleSheet
    {

      
    public static int choosenstyle;

        
        //-----------------------OPTION WINDOW
        public static void Theme1_action_optionwindow(OptionWindow w)
        {
            
            w.Englishtile.Background = Brushes.LightSteelBlue;
            w.Russiantile.Background = Brushes.LightSteelBlue;
            w.Germantile.Background = Brushes.LightSteelBlue;
            w.Chinesetile.Background = Brushes.LightSteelBlue;
            w.LeftStackpanel.Background = Brushes.Lavender;
            w.RightStackpanel.Background = Brushes.Lavender;
            w.CenterStackpanel.Background = Brushes.LightGray;
            w.OptionWindowName.WindowTitleBrush = Brushes.DeepSkyBlue;
            w.LeftText.Foreground = Brushes.Black;
            w.RightText.Foreground = Brushes.Black;
            choosenstyle = 1;
            DbActions.StyleSet();


        }
        public static void Theme2_action_optionwindow(OptionWindow w)
        {
            
            w.Englishtile.Background = Brushes.LightGreen;
            w.Russiantile.Background = Brushes.LightGreen;
            w.Germantile.Background = Brushes.LightGreen;
            w.Chinesetile.Background = Brushes.LightGreen;
            w.LeftStackpanel.Background = Brushes.LemonChiffon;
            w.RightStackpanel.Background = Brushes.LemonChiffon;
            w.CenterStackpanel.Background = Brushes.PaleGoldenrod;
            w.OptionWindowName.WindowTitleBrush = Brushes.OliveDrab;
            w.LeftText.Foreground = Brushes.Black;
            w.RightText.Foreground = Brushes.Black;
            choosenstyle = 2;
            DbActions.StyleSet();
        }
        public static void Theme3_action_optionwindow(OptionWindow w)
        {
            
            w.Englishtile.Background = Brushes.DarkSalmon;
            w.Russiantile.Background = Brushes.DarkSalmon;
            w.Germantile.Background = Brushes.DarkSalmon;
            w.Chinesetile.Background = Brushes.DarkSalmon;
            w.LeftStackpanel.Background = Brushes.PeachPuff;
            w.RightStackpanel.Background = Brushes.PeachPuff;
            w.CenterStackpanel.Background = Brushes.LightSalmon;
            w.OptionWindowName.WindowTitleBrush = Brushes.Firebrick;
            w.LeftText.Foreground = Brushes.Black;
            w.RightText.Foreground = Brushes.Black;
            choosenstyle = 3;
            DbActions.StyleSet();
        }
        public static void Theme4_action_optionwindow(OptionWindow w)
        {
            w.Englishtile.Background = Brushes.DarkSlateBlue;
            w.Russiantile.Background = Brushes.DarkSlateBlue;
            w.Germantile.Background = Brushes.DarkSlateBlue;
            w.Chinesetile.Background = Brushes.DarkSlateBlue;
            w.LeftStackpanel.Background = Brushes.SlateGray;
            w.RightStackpanel.Background = Brushes.SlateGray;
            w.CenterStackpanel.Background = Brushes.DarkSlateGray;
            w.OptionWindowName.WindowTitleBrush = Brushes.MidnightBlue;
            w.LeftText.Foreground = Brushes.LightGray;
            w.RightText.Foreground = Brushes.LightGray;
            choosenstyle = 4;
            DbActions.StyleSet();
        }
        //-----------------------


        //-----------------------TASK WINDOW
        public static void Theme1_action_taskwindow(TaskWindow w)
        {
            
            w.LeftStackpanel.Background = Brushes.Lavender;
            w.RightStackpanel.Background = Brushes.Lavender;
            w.CenterStackpanel.Background = Brushes.LightGray;
            w.Taskwindow.WindowTitleBrush = Brushes.DeepSkyBlue;
            w.cryptobutton1.Background = Brushes.White;
            w.cryptobutton2.Background = Brushes.White;
            w.cryptobutton3.Background = Brushes.White;
            w.cryptobutton4.Background = Brushes.White;
            w.fiatbutton1.Background = Brushes.White;
            w.fiatbutton2.Background = Brushes.White;
            w.fiatbutton3.Background = Brushes.White;
            w.fiatbutton4.Background = Brushes.White;
            w.cryptobutton1.Foreground = Brushes.Black;
            w.cryptobutton2.Foreground = Brushes.Black;
            w.cryptobutton3.Foreground = Brushes.Black;
            w.cryptobutton4.Foreground = Brushes.Black;
            w.fiatbutton1.Foreground = Brushes.Black;
            w.fiatbutton2.Foreground = Brushes.Black;
            w.fiatbutton3.Foreground = Brushes.Black;
            w.fiatbutton4.Foreground = Brushes.Black;
            w.ActionButton.Background = Brushes.White;
            w.ActionButton.Foreground = Brushes.Black;
            w.currency.Background = Brushes.White;
            w.currency.Foreground = Brushes.Black;          
            w.Arrow.Source = BitmapFrame.Create(new Uri(System.IO.Path.GetFullPath(@"..\..\") + @"Resources\arrow1.png"));
        }
        public static void Theme2_action_taskwindow(TaskWindow w)
        {
            w.LeftStackpanel.Background = Brushes.PaleGoldenrod;
            w.RightStackpanel.Background = Brushes.PaleGoldenrod;
            w.CenterStackpanel.Background = Brushes.LemonChiffon;
            w.Taskwindow.WindowTitleBrush = Brushes.OliveDrab;
            w.cryptobutton1.Background = Brushes.LightGreen;
            w.cryptobutton2.Background = Brushes.LightGreen;
            w.cryptobutton3.Background = Brushes.LightGreen;
            w.cryptobutton4.Background = Brushes.LightGreen;
            w.fiatbutton1.Background = Brushes.LightGreen;
            w.fiatbutton2.Background = Brushes.LightGreen;
            w.fiatbutton3.Background = Brushes.LightGreen;
            w.fiatbutton4.Background = Brushes.LightGreen;
            w.cryptobutton1.Foreground = Brushes.Black;
            w.cryptobutton2.Foreground = Brushes.Black;
            w.cryptobutton3.Foreground = Brushes.Black;
            w.cryptobutton4.Foreground = Brushes.Black;
            w.fiatbutton1.Foreground = Brushes.Black;
            w.fiatbutton2.Foreground = Brushes.Black;
            w.fiatbutton3.Foreground = Brushes.Black;
            w.fiatbutton4.Foreground = Brushes.Black;
            w.ActionButton.Background = Brushes.LightGreen;
            w.ActionButton.Foreground = Brushes.Black;
            w.currency.Background = Brushes.LightGreen;
            w.currency.Foreground = Brushes.Black;
            w.Arrow.Source = BitmapFrame.Create(new Uri(System.IO.Path.GetFullPath(@"..\..\") + @"Resources\arrow2.png"));
        }
        public static void Theme3_action_taskwindow(TaskWindow w)
        {
            w.LeftStackpanel.Background = Brushes.LightSalmon;
            w.RightStackpanel.Background = Brushes.LightSalmon;
            w.CenterStackpanel.Background = Brushes.PeachPuff;
            w.Taskwindow.WindowTitleBrush = Brushes.Firebrick;
            w.cryptobutton1.Background = Brushes.Tomato;
            w.cryptobutton2.Background = Brushes.Tomato;
            w.cryptobutton3.Background = Brushes.Tomato;
            w.cryptobutton4.Background = Brushes.Tomato;
            w.fiatbutton1.Background = Brushes.Tomato;
            w.fiatbutton2.Background = Brushes.Tomato;
            w.fiatbutton3.Background = Brushes.Tomato;
            w.fiatbutton4.Background = Brushes.Tomato;
            w.cryptobutton1.Foreground = Brushes.White;
            w.cryptobutton2.Foreground = Brushes.White;
            w.cryptobutton3.Foreground = Brushes.White;
            w.cryptobutton4.Foreground = Brushes.White;
            w.fiatbutton1.Foreground = Brushes.White;
            w.fiatbutton2.Foreground = Brushes.White;
            w.fiatbutton3.Foreground = Brushes.White;
            w.fiatbutton4.Foreground = Brushes.White;
            w.ActionButton.Background = Brushes.DarkSalmon;
            w.ActionButton.Foreground = Brushes.White;
            w.currency.Background = Brushes.DarkSalmon;
            w.currency.Foreground = Brushes.White;
            w.Arrow.Source = BitmapFrame.Create(new Uri(System.IO.Path.GetFullPath(@"..\..\") + @"Resources\arrow3.png"));
        }
        public static void Theme4_action_taskwindow(TaskWindow w)
        {
            w.LeftStackpanel.Background = Brushes.DarkSlateGray;
            w.RightStackpanel.Background = Brushes.DarkSlateGray;
            w.CenterStackpanel.Background = Brushes.SlateGray;
            w.Taskwindow.WindowTitleBrush = Brushes.MidnightBlue;
            w.cryptobutton1.Background = Brushes.SlateGray;
            w.cryptobutton2.Background = Brushes.SlateGray;
            w.cryptobutton3.Background = Brushes.SlateGray;
            w.cryptobutton4.Background = Brushes.SlateGray;
            w.fiatbutton1.Background = Brushes.SlateGray;
            w.fiatbutton2.Background = Brushes.SlateGray;
            w.fiatbutton3.Background = Brushes.SlateGray;
            w.fiatbutton4.Background = Brushes.SlateGray;
            w.cryptobutton1.Foreground = Brushes.White;
            w.cryptobutton2.Foreground = Brushes.White;
            w.cryptobutton3.Foreground = Brushes.White;
            w.cryptobutton4.Foreground = Brushes.White;
            w.fiatbutton1.Foreground = Brushes.White;
            w.fiatbutton2.Foreground = Brushes.White;
            w.fiatbutton3.Foreground = Brushes.White;
            w.fiatbutton4.Foreground = Brushes.White;
            w.ActionButton.Background = Brushes.DarkSlateGray;
            w.ActionButton.Foreground = Brushes.White;
            w.currency.Background = Brushes.DarkSlateGray;
            w.currency.Foreground = Brushes.White;
            w.Arrow.Source = BitmapFrame.Create(new Uri(System.IO.Path.GetFullPath(@"..\..\") + @"Resources\arrow4.png"));
        }
        //-----------------------


        //----------------------- main window
        public static void Theme1_action_mainwindow(MainWindow w)
        {
            
            w.Button1.Background = Brushes.White;
            w.Button2.Background = Brushes.White;
            w.Button3.Background = Brushes.White;
            w.Button1.Foreground = Brushes.Black;
            w.Button2.Foreground = Brushes.Black;
            w.Button3.Foreground = Brushes.Black;
            w.MainStackpanel.Background = Brushes.Lavender;
            w.mainWindow.WindowTitleBrush = Brushes.DeepSkyBlue;
            w.Button4.Background = Brushes.White;
            w.Button4.Foreground = Brushes.Black;

        }
        public static void Theme2_action_mainwindow(MainWindow w)
        {

            w.Button1.Background = Brushes.LightGreen;
            w.Button2.Background = Brushes.LightGreen;
            w.Button3.Background = Brushes.LightGreen;
            w.Button1.Foreground = Brushes.Black;
            w.Button2.Foreground = Brushes.Black;
            w.Button3.Foreground = Brushes.Black;
            w.MainStackpanel.Background = Brushes.LemonChiffon;
            w.mainWindow.WindowTitleBrush = Brushes.OliveDrab;
            w.Button4.Background = Brushes.LightGreen;
            w.Button4.Foreground = Brushes.Black;

        }
        public static void Theme3_action_mainwindow(MainWindow w)
        {

            w.Button1.Background = Brushes.Tomato;
            w.Button2.Background = Brushes.Tomato;
            w.Button3.Background = Brushes.Tomato;
            w.Button1.Foreground = Brushes.White;
            w.Button2.Foreground = Brushes.White;
            w.Button3.Foreground = Brushes.White;
            w.MainStackpanel.Background = Brushes.PeachPuff;
            w.mainWindow.WindowTitleBrush = Brushes.Firebrick;
            w.Button4.Background = Brushes.Tomato;
            w.Button4.Foreground = Brushes.White;

        }
        public static void Theme4_action_mainwindow(MainWindow w)
        {

            w.Button1.Background = Brushes.DarkSlateGray;
            w.Button2.Background = Brushes.DarkSlateGray;
            w.Button3.Background = Brushes.DarkSlateGray;
            w.Button1.Foreground = Brushes.White;
            w.Button2.Foreground = Brushes.White;
            w.Button3.Foreground = Brushes.White;
            w.MainStackpanel.Background = Brushes.SlateGray;
            w.mainWindow.WindowTitleBrush = Brushes.MidnightBlue;
            w.Button4.Background = Brushes.DarkSlateGray;
            w.Button4.Foreground = Brushes.White;

        }
        //----------------------- mining space
        public static void Theme1_action_miningspace(MiningSpace w)
        {
            w.algorithm_gpu1.Background = Brushes.Lavender;
            w.algorithm_gpu2.Background = Brushes.Lavender;
            w.algorithm_gpu3.Background = Brushes.Lavender;
            w.algorithm_gpu4.Background = Brushes.Lavender;
            w.algorithm_gpu5.Background = Brushes.Lavender;
            w.algorithm_cpu1.Background = Brushes.Lavender;
            w.algorithm_cpu2.Background = Brushes.Lavender;
            w.algorithm_cpu3.Background = Brushes.Lavender;
            w.algorithm_cpu4.Background = Brushes.Lavender;
            w.algorithm_gpu1.Foreground = Brushes.Black;
            w.algorithm_gpu2.Foreground = Brushes.Black;
            w.algorithm_gpu3.Foreground = Brushes.Black;
            w.algorithm_gpu4.Foreground = Brushes.Black;
            w.algorithm_gpu5.Foreground = Brushes.Black;
            w.algorithm_cpu1.Foreground = Brushes.Black;
            w.algorithm_cpu2.Foreground = Brushes.Black;
            w.algorithm_cpu3.Foreground = Brushes.Black;
            w.algorithm_cpu4.Foreground = Brushes.Black;
            w.LeftStackpanel.Background = Brushes.White;
            w.RightStackpanel.Background = Brushes.White;
            w.CenterStackpanel.Background = Brushes.Lavender;
            w.textblockgpu.Foreground = Brushes.Black;
            w.pooladresstext.Foreground = Brushes.Black;
            w.wallettext.Foreground = Brushes.Black;
            w.urchoose.Foreground = Brushes.Black;
            w.start_button.Foreground = Brushes.Black;
            w.urchoose.Foreground = Brushes.Black;
            w.advanceoption_button.Foreground = Brushes.Black;
            w.pooladress.Foreground = Brushes.Black;
            w.wallet.Foreground = Brushes.Black; 
                w.start_button.Background = Brushes.LightGreen;
            // w.MainStackpanel.Background = Brushes.Lavender;  pooladresstext wallettext urchoose start_button advanceoption_button urchoose pooladress wallet
            // w.mainWindow.WindowTitleBrush = Brushes.DeepSkyBlue;
        }
        public static void Theme2_action_miningspace(MiningSpace w)
        {

            w.algorithm_gpu1.Background = Brushes.LightGreen;
            w.algorithm_gpu2.Background = Brushes.LightGreen;
            w.algorithm_gpu3.Background = Brushes.LightGreen;
            w.algorithm_gpu4.Background = Brushes.LightGreen;
            w.algorithm_gpu5.Background = Brushes.LightGreen;
            w.algorithm_cpu1.Background = Brushes.LightGreen;
            w.algorithm_cpu2.Background = Brushes.LightGreen;
            w.algorithm_cpu3.Background = Brushes.LightGreen;
            w.algorithm_cpu4.Background = Brushes.LightGreen;
            w.algorithm_gpu1.Foreground = Brushes.Black;
            w.algorithm_gpu2.Foreground = Brushes.Black;
            w.algorithm_gpu3.Foreground = Brushes.Black;
            w.algorithm_gpu4.Foreground = Brushes.Black;
            w.algorithm_gpu5.Foreground = Brushes.Black;
            w.algorithm_cpu1.Foreground = Brushes.Black;
            w.algorithm_cpu2.Foreground = Brushes.Black;
            w.algorithm_cpu3.Foreground = Brushes.Black;
            w.algorithm_cpu4.Foreground = Brushes.Black;
            w.LeftStackpanel.Background = Brushes.LemonChiffon;
            w.RightStackpanel.Background = Brushes.LemonChiffon;
            w.CenterStackpanel.Background = Brushes.PaleGoldenrod;
            w.textblockgpu.Foreground = Brushes.Black;
            w.pooladresstext.Foreground = Brushes.Black;
            w.textblockgpu.Foreground = Brushes.Black;
            w.textblockcpu.Foreground = Brushes.Black;
            w.wallettext.Foreground = Brushes.Black;
            w.urchoose.Foreground = Brushes.Black;
            w.start_button.Foreground = Brushes.Black;
            w.urchoose.Foreground = Brushes.Black;
            w.advanceoption_button.Foreground = Brushes.Black;
            w.pooladress.Background = Brushes.LightGreen;
            w.wallet.Background = Brushes.LightGreen;
            w.pooladress.Foreground = Brushes.Black;
            w.wallet.Foreground = Brushes.Black;
            w.start_button.Background = Brushes.Green;
            w.MiningWindow.WindowTitleBrush = Brushes.OliveDrab;
            w.start_button.Background = Brushes.Green;
        }
        public static void Theme3_action_miningspace(MiningSpace w)
        {

            w.algorithm_gpu1.Background = Brushes.Tomato;
            w.algorithm_gpu2.Background = Brushes.Tomato;
            w.algorithm_gpu3.Background = Brushes.Tomato;
            w.algorithm_gpu4.Background = Brushes.Tomato;
            w.algorithm_gpu5.Background = Brushes.Tomato;
            w.algorithm_cpu1.Background = Brushes.Tomato;
            w.algorithm_cpu2.Background = Brushes.Tomato;
            w.algorithm_cpu3.Background = Brushes.Tomato;
            w.algorithm_cpu4.Background = Brushes.Tomato;
            w.algorithm_gpu1.Foreground = Brushes.White;
            w.algorithm_gpu2.Foreground = Brushes.White;
            w.algorithm_gpu3.Foreground = Brushes.White;
            w.algorithm_gpu4.Foreground = Brushes.White;
            w.algorithm_gpu5.Foreground = Brushes.White;
            w.algorithm_cpu1.Foreground = Brushes.White;
            w.algorithm_cpu2.Foreground = Brushes.White;
            w.algorithm_cpu3.Foreground = Brushes.White;
            w.algorithm_cpu4.Foreground = Brushes.White;
            w.LeftStackpanel.Background = Brushes.PeachPuff;
            w.RightStackpanel.Background = Brushes.PeachPuff;
            w.CenterStackpanel.Background = Brushes.LightSalmon;
            w.textblockgpu.Foreground = Brushes.White;
            w.pooladresstext.Foreground = Brushes.White;
            w.textblockgpu.Foreground = Brushes.Black;
            w.textblockcpu.Foreground = Brushes.Black;
            w.wallettext.Foreground = Brushes.White;
            w.urchoose.Foreground = Brushes.White;
            w.start_button.Foreground = Brushes.White;
            w.urchoose.Foreground = Brushes.White;
            w.advanceoption_button.Foreground = Brushes.White;
            w.pooladress.Background = Brushes.Tomato;
            w.wallet.Background = Brushes.Tomato;
            w.pooladress.Foreground = Brushes.White;
            w.wallet.Foreground = Brushes.White;
            w.MiningWindow.WindowTitleBrush = Brushes.Firebrick;
            w.start_button.Background = Brushes.Green;
            w.advanceoption_button.Background = Brushes.MidnightBlue;
        }
        public static void Theme4_action_miningspace(MiningSpace w)
        {

            w.algorithm_gpu1.Background = Brushes.SlateGray;
            w.algorithm_gpu2.Background = Brushes.SlateGray;
            w.algorithm_gpu3.Background = Brushes.SlateGray;
            w.algorithm_gpu4.Background = Brushes.SlateGray;
            w.algorithm_gpu5.Background = Brushes.SlateGray;
            w.algorithm_cpu1.Background = Brushes.SlateGray;
            w.algorithm_cpu2.Background = Brushes.SlateGray;
            w.algorithm_cpu3.Background = Brushes.SlateGray;
            w.algorithm_cpu4.Background = Brushes.SlateGray;
            w.algorithm_gpu1.Foreground = Brushes.White;
            w.algorithm_gpu2.Foreground = Brushes.White;
            w.algorithm_gpu3.Foreground = Brushes.White;
            w.algorithm_gpu4.Foreground = Brushes.White;
            w.algorithm_gpu5.Foreground = Brushes.White;
            w.algorithm_cpu1.Foreground = Brushes.White;
            w.algorithm_cpu2.Foreground = Brushes.White;
            w.algorithm_cpu3.Foreground = Brushes.White;
            w.algorithm_cpu4.Foreground = Brushes.White;
            w.LeftStackpanel.Background = Brushes.DarkSlateGray;
            w.RightStackpanel.Background = Brushes.DarkSlateGray;
            w.CenterStackpanel.Background = Brushes.SlateGray;
            w.textblockgpu.Foreground = Brushes.White;
            w.pooladresstext.Foreground = Brushes.White;
            w.textblockgpu.Foreground = Brushes.White;
            w.textblockcpu.Foreground = Brushes.White;
            w.wallettext.Foreground = Brushes.White;
            w.urchoose.Foreground = Brushes.White;
            w.start_button.Foreground = Brushes.White;
            w.urchoose.Foreground = Brushes.White;
            w.advanceoption_button.Foreground = Brushes.White;
            w.pooladress.Background = Brushes.DarkSlateGray;
            w.wallet.Background = Brushes.DarkSlateGray;
            w.pooladress.Foreground = Brushes.White;
            w.wallet.Foreground = Brushes.White;
            w.MiningWindow.WindowTitleBrush = Brushes.MidnightBlue;
            w.start_button.Background = Brushes.Green;
            w.advanceoption_button.Background = Brushes.MidnightBlue;
        }
        //AdvancedOptionWindow
        public static void Theme1_action_advwindow(AdvancedOptionWindow w)
        {
            w.AdvancedOptionWindowName.WindowTitleBrush = Brushes.DeepSkyBlue;
            w.collertext.Foreground = Brushes.Black;
        
            w.cptext.Foreground = Brushes.Black;
            w.advtext.Foreground = Brushes.Black;
            w.advtextbox.Background = Brushes.White;
            w.advtextbox.Foreground = Brushes.Black;
            w.cooler.Foreground = Brushes.Black;
            w.cp.Foreground = Brushes.Black;
          
            w.save.Background = Brushes.LightGreen;
            w.reset.Background = Brushes.LightBlue;
            w.mainstackpanel.Background = Brushes.White;
            w.save.Foreground = Brushes.Black;
            w.reset.Foreground = Brushes.Black;


        }
        public static void Theme2_action_advwindow(AdvancedOptionWindow w)
        {


            w.AdvancedOptionWindowName.WindowTitleBrush = Brushes.OliveDrab;
            w.collertext.Foreground = Brushes.Black;
           
            w.cptext.Foreground = Brushes.Black;
            w.FirstSlider.BorderBrush = Brushes.LightGreen;
            w.advtext.Foreground = Brushes.Black;
            w.advtextbox.Background = Brushes.LightGreen;
            w.advtextbox.Foreground = Brushes.Black;
            w.cooler.Foreground = Brushes.Black;
            w.cp.Foreground = Brushes.Black;
          
            w.save.Background = Brushes.Green;
            w.reset.Background = Brushes.LightBlue;
            w.mainstackpanel.Background = Brushes.LemonChiffon;
            w.save.Foreground = Brushes.Black;
            w.reset.Foreground = Brushes.Black;

        }
        public static void Theme3_action_advwindow(AdvancedOptionWindow w)
        {
            w.AdvancedOptionWindowName.WindowTitleBrush = Brushes.Firebrick;
            w.collertext.Foreground = Brushes.Black;
        
            w.cptext.Foreground = Brushes.Black;
            w.advtext.Foreground = Brushes.Black;
            w.advtextbox.Background = Brushes.LightSalmon;
            w.advtextbox.Foreground = Brushes.Black;
            w.cooler.Foreground = Brushes.Black;
            w.cp.Foreground = Brushes.Black;
            
            w.save.Background = Brushes.LightGreen;
            w.reset.Background = Brushes.LightBlue;
            w.mainstackpanel.Background = Brushes.PeachPuff;
            w.save.Foreground = Brushes.Black;
            w.reset.Foreground = Brushes.Black;


        }
        public static void Theme4_action_advwindow(AdvancedOptionWindow w)
        {

            w.AdvancedOptionWindowName.WindowTitleBrush = Brushes.MidnightBlue;
            w.collertext.Foreground = Brushes.White;
           
            w.cptext.Foreground = Brushes.White;
            w.advtext.Foreground = Brushes.White;
            w.advtextbox.Background = Brushes.SlateGray;
            w.advtextbox.Foreground = Brushes.White;
            w.cooler.Foreground = Brushes.White;
            w.cp.Foreground = Brushes.White;
           
            w.save.Background = Brushes.Green;
            w.reset.Background = Brushes.Blue;
            w.mainstackpanel.Background = Brushes.DarkSlateGray;
            w.save.Foreground = Brushes.White;
            w.reset.Foreground = Brushes.White;

        }
        public static void Theme1_action_calcwindow(MiningCalc w)
        {
           w.cryptobutton1.Background = Brushes.White;
           w.cryptobutton2.Background = Brushes.White;
           w.cryptobutton3.Background = Brushes.White;
           w.cryptobutton4.Background = Brushes.White;
           w.cryptobutton1.Foreground = Brushes.Black;
           w.cryptobutton2.Foreground = Brushes.Black;
           w.cryptobutton3.Foreground = Brushes.Black;
           w.cryptobutton4.Foreground = Brushes.Black;
           w.LeftStackpanel.Background = Brushes.Lavender;
           w.RightStackpanel.Background = Brushes.LightGray;
           w.choosencoin.Foreground = Brushes.Black;
           w.hashratetext.Foreground = Brushes.Black;
           w.wattstext.Foreground = Brushes.Black;
           w.cost_kwh_text.Foreground = Brushes.Black;
           w.fee_text.Foreground = Brushes.Black;
           w.calcbtn.Foreground = Brushes.Black;
           w.hashrate.Foreground = Brushes.Black;
           w.watts.Foreground = Brushes.Black;
           w.cost_kwh.Foreground = Brushes.Black;
           w.fee.Foreground = Brushes.Black;
           w.CalcWindow.WindowTitleBrush = Brushes.DeepSkyBlue;
           w.calcbtn.Background = Brushes.White;
           w.hashrate.Background = Brushes.White;
           w.watts.Background = Brushes.White;
           w.cost_kwh.Background = Brushes.White;
           w.fee.Background = Brushes.White;
           w.day.Foreground = Brushes.Black;
           w.dayprofit.Foreground = Brushes.Black;
           w.minedday.Foreground = Brushes.Black;
           w.powercostday.Foreground = Brushes.Black;
           w.week.Foreground = Brushes.Black;
           w.profitweek.Foreground = Brushes.Black;
           w.minedweek.Foreground = Brushes.Black;
           w.powercostweek.Foreground = Brushes.Black;
           w.month.Foreground = Brushes.Black;
           w.profitmonth.Foreground = Brushes.Black;
           w.minedmonth.Foreground = Brushes.Black;
           w.powercostmonth.Foreground = Brushes.Black;

        }
        public static void Theme2_action_calcwindow(MiningCalc w)
        {
            w.cryptobutton1.Background = Brushes.LightGreen;
            w.cryptobutton2.Background = Brushes.LightGreen;
            w.cryptobutton3.Background = Brushes.LightGreen;
            w.cryptobutton4.Background = Brushes.LightGreen;
            w.cryptobutton1.Foreground = Brushes.Black;
            w.cryptobutton2.Foreground = Brushes.Black;
            w.cryptobutton3.Foreground = Brushes.Black;
            w.cryptobutton4.Foreground = Brushes.Black;
            w.LeftStackpanel.Background = Brushes.LemonChiffon;
            w.RightStackpanel.Background = Brushes.PaleGoldenrod;
            w.choosencoin.Foreground = Brushes.Black;
            w.hashratetext.Foreground = Brushes.Black;
            w.wattstext.Foreground = Brushes.Black;
            w.cost_kwh_text.Foreground = Brushes.Black;
            w.fee_text.Foreground = Brushes.Black;
            w.calcbtn.Foreground = Brushes.Black;
            w.hashrate.Foreground = Brushes.Black;
            w.watts.Foreground = Brushes.Black;
            w.cost_kwh.Foreground = Brushes.Black;
            w.fee.Foreground = Brushes.Black;
            w.CalcWindow.WindowTitleBrush = Brushes.OliveDrab;
            w.calcbtn.Background = Brushes.LightGreen;
            w.hashrate.Background = Brushes.LightGreen;
            w.watts.Background = Brushes.LightGreen;
            w.cost_kwh.Background = Brushes.LightGreen;
            w.fee.Background = Brushes.LightGreen;
            w.day.Foreground = Brushes.Black;
            w.dayprofit.Foreground = Brushes.Black;
            w.minedday.Foreground = Brushes.Black;
            w.powercostday.Foreground = Brushes.Black;
            w.week.Foreground = Brushes.Black;
            w.profitweek.Foreground = Brushes.Black;
            w.minedweek.Foreground = Brushes.Black;
            w.powercostweek.Foreground = Brushes.Black;
            w.month.Foreground = Brushes.Black;
            w.profitmonth.Foreground = Brushes.Black;
            w.minedmonth.Foreground = Brushes.Black;
            w.powercostmonth.Foreground = Brushes.Black;

        }
        public static void Theme3_action_calcwindow(MiningCalc w)
        {
            w.cryptobutton1.Background = Brushes.Tomato;
            w.cryptobutton2.Background = Brushes.Tomato;
            w.cryptobutton3.Background = Brushes.Tomato;
            w.cryptobutton4.Background = Brushes.Tomato;
            w.cryptobutton1.Foreground = Brushes.White;
            w.cryptobutton2.Foreground = Brushes.White;
            w.cryptobutton3.Foreground = Brushes.White;
            w.cryptobutton4.Foreground = Brushes.White;
            w.LeftStackpanel.Background = Brushes.PeachPuff;
            w.RightStackpanel.Background = Brushes.LightSalmon;
            w.choosencoin.Foreground = Brushes.White;
            w.hashratetext.Foreground = Brushes.White;
            w.wattstext.Foreground = Brushes.White;
            w.cost_kwh_text.Foreground = Brushes.White;
            w.fee_text.Foreground = Brushes.White;
            w.calcbtn.Foreground = Brushes.White;
            w.hashrate.Foreground = Brushes.White;
            w.watts.Foreground = Brushes.White;
            w.cost_kwh.Foreground = Brushes.White;
            w.fee.Foreground = Brushes.White;
            w.CalcWindow.WindowTitleBrush = Brushes.Firebrick;
            w.calcbtn.Background = Brushes.Tomato;
            w.hashrate.Background = Brushes.Tomato;
            w.watts.Background = Brushes.Tomato;
            w.cost_kwh.Background = Brushes.Tomato;
            w.fee.Background = Brushes.Tomato;
            w.day.Foreground = Brushes.White;
            w.dayprofit.Foreground = Brushes.White;
            w.minedday.Foreground = Brushes.White;
            w.powercostday.Foreground = Brushes.White;
            w.week.Foreground = Brushes.White;
            w.profitweek.Foreground = Brushes.White;
            w.minedweek.Foreground = Brushes.White;
            w.powercostweek.Foreground = Brushes.White;
            w.month.Foreground = Brushes.White;
            w.profitmonth.Foreground = Brushes.White;
            w.minedmonth.Foreground = Brushes.White;
            w.powercostmonth.Foreground = Brushes.White;

        }
        public static void Theme4_action_calcwindow(MiningCalc w)
        {
            w.cryptobutton1.Background = Brushes.DarkSlateGray;
            w.cryptobutton2.Background = Brushes.DarkSlateGray;
            w.cryptobutton3.Background = Brushes.DarkSlateGray;
            w.cryptobutton4.Background = Brushes.DarkSlateGray;
            w.cryptobutton1.Foreground = Brushes.White;
            w.cryptobutton2.Foreground = Brushes.White;
            w.cryptobutton3.Foreground = Brushes.White;
            w.cryptobutton4.Foreground = Brushes.White;
            w.LeftStackpanel.Background = Brushes.SlateGray;
            w.RightStackpanel.Background = Brushes.DarkSlateGray;
            w.choosencoin.Foreground = Brushes.White;
            w.hashratetext.Foreground = Brushes.White;
            w.wattstext.Foreground = Brushes.White;
            w.cost_kwh_text.Foreground = Brushes.White;
            w.fee_text.Foreground = Brushes.White;
            w.calcbtn.Foreground = Brushes.White;
            w.hashrate.Foreground = Brushes.White;
            w.watts.Foreground = Brushes.White;
            w.cost_kwh.Foreground = Brushes.White;
            w.fee.Foreground = Brushes.White;
            w.CalcWindow.WindowTitleBrush = Brushes.MidnightBlue;
            w.calcbtn.Background = Brushes.SlateGray;
            w.hashrate.Background = Brushes.SlateGray;
            w.watts.Background = Brushes.SlateGray;
            w.cost_kwh.Background = Brushes.SlateGray;
            w.fee.Background = Brushes.SlateGray;
            w.day.Foreground = Brushes.White;
            w.dayprofit.Foreground = Brushes.White;
            w.minedday.Foreground = Brushes.White;
            w.powercostday.Foreground = Brushes.White;
            w.week.Foreground = Brushes.White;
            w.profitweek.Foreground = Brushes.White;
            w.minedweek.Foreground = Brushes.White;
            w.powercostweek.Foreground = Brushes.White;
            w.month.Foreground = Brushes.White;
            w.profitmonth.Foreground = Brushes.White;
            w.minedmonth.Foreground = Brushes.White;
            w.powercostmonth.Foreground = Brushes.White;

        }
    }
}
