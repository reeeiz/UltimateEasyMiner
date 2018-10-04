using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    class LanguageSheet
    {
        public static int choosenlang;
        public static string langtmp;
        public static string langtmp_calc1;
        public static string langtmp_calc2;
        public static string langtmp_calc3;
        public static string langtmp_calc4;
        public static string langtmp_calc5;
        public static string langtmp_calc6;
        public static string langtmp_calc7;
        public static string langtmp_calc8;
        public static string langtmp_calc9;
        public static string langtmp_calc10;
        //option window
        public static void Language1_action_optionwindow(OptionWindow w)
        {

            w.Theme1.Count = "Original blue";
            w.Theme2.Count = "Lime green";
            w.Theme3.Count = "Fiery red";
            w.Theme4.Count = "Nocturnal void";
            w.LeftText.Text = "Switch language";
            w.RightText.Text = "Switch style";
            w.OptionWindowName.Title = "Settings window";
            choosenlang = 1;
            DbActions.LanguageSet();
        }
        public static void Language2_action_optionwindow(OptionWindow w)
        {
            w.Theme1.Count = "Оригинальный голубой";
            w.Theme2.Count = "Лаймово зеленый";
            w.Theme3.Count = "Огненно рыжий";
            w.Theme4.Count = "Полуночная пустота";
            w.LeftText.Text = "Выбор языка";
            w.RightText.Text = "Выбор стиля";
            w.OptionWindowName.Title = "Окно настроек";
            choosenlang = 2;
            DbActions.LanguageSet();
        }
        public static void Language3_action_optionwindow(OptionWindow w)
        {
            w.Theme1.Count = "Original blau";
            w.Theme2.Count = "Lindgrün";
            w.Theme3.Count = "Feuriges Rot";
            w.Theme4.Count = "Nächtliche Leere";
            w.LeftText.Text = "Sprache umstellen";
            w.RightText.Text = "Stil wechseln";
            w.OptionWindowName.Title = "Einstellungs fenster";
            choosenlang = 1;
            DbActions.LanguageSet();
            choosenlang = 3;
            DbActions.LanguageSet();
        }
        public static void Language4_action_optionwindow(OptionWindow w)
        {
            w.Theme1.Count = "原蓝色";
            w.Theme2.Count = "柠檬绿";
            w.Theme3.Count = "火红的";
            w.Theme4.Count = "夜间无效";
            w.LeftText.Text = "切换语言";
            w.RightText.Text = "切换风格";
            w.OptionWindowName.Title = "设置窗口";
            choosenlang = 1;
            DbActions.LanguageSet();
            choosenlang = 4;
            DbActions.LanguageSet();
        }
        //main window
        public static void Language1_action_mainnwindow(MainWindow w)
        {
            w.Button1.Content = "Enter to the mining space";
            w.Button2.Content = "Program settings";
            w.Button3.Content = "To see the current courses Crypto-currency";
            w.mainWindow.Title = "Ultimate easy miner";
            w.Button4.Content = "Mining profitability calculator";

        }
        public static void Language2_action_mainnwindow(MainWindow w)
        {
            w.Button1.Content = "Зайти в раздел добычи";
            w.Button2.Content = "Настройки программы";
            w.Button3.Content = "Узнать актуальные курсы криптовалют";
            w.mainWindow.Title = "Ультимативный легкий майнер";
            w.Button4.Content = "Калькулятор прибыльности майнинга";
        }
        public static void Language3_action_mainnwindow(MainWindow w)
        {
            w.Button1.Content = "Geben Sie den Mining-Bereich ein";
            w.Button2.Content = "Programmeinstellungen";
            w.Button3.Content = "Um die aktuellen Kurse Cryptocurrency zu sehen";
            w.mainWindow.Title = "Ultimativer einfacher Miner";
            w.Button4.Content = "Mining-Rentabilitätsrechner";
        }
        public static void Language4_action_mainnwindow(MainWindow w)
        {
            w.Button1.Content = "进入采矿空间";
            w.Button2.Content = "程序设置";
            w.Button3.Content = "要查看当前的课程加密货币";
            w.mainWindow.Title = "终极易矿工";
            w.Button4.Content = "挖掘盈利能力计算器";
        }
        //task window
        public static void Language1_action_taskwindow(TaskWindow w)
        {


            w.Taskwindow.Title = "Currency rates window";

            w.ActionButton.Content = "Get actual rates";

        }
        public static void Language2_action_taskwindow(TaskWindow w)
        {
            w.Taskwindow.Title = "Окно с курсами криптовалют";

            w.ActionButton.Content = "Получить актуальные курсы";
        }
        public static void Language3_action_taskwindow(TaskWindow w)
        {
            w.Taskwindow.Title = "Wechselkurse Fenster";

            w.ActionButton.Content = "Erhalten Sie die tatsächlichen Preise";
        }
        public static void Language4_action_taskwindow(TaskWindow w)
        {
            w.Taskwindow.Title = "货币汇率窗口";

            w.ActionButton.Content = "获得实际价格";
        }

        //mining space
        public static void Language1_action_miningspace(MiningSpace w)
        {


            w.textblockgpu.Text = "Algorithms available for mining on the GPU";
            w.textblockcpu.Text = "Algorithms available for mining on the CPU";
            w.pooladresstext.Text = "Enter the address of your pool";
            w.wallettext.Text = "Enter your wallet or employee name for identification on the pool";
            w.start_button.Content = "Start the mining";
            w.advanceoption_button.Content = "Advanced settings";
            w.MiningWindow.Title = "Mining space";
            langtmp = "Your choice of algorithm: ";


        }
        public static void Language2_action_miningspace(MiningSpace w)
        {
            w.textblockgpu.Text = "Алгоритмы доступные для майнинга на GPU";
            w.textblockcpu.Text = "Алгоритмы доступные для майнинга на CPU";
            w.pooladresstext.Text = "Введите адрес вашего пула";
            w.wallettext.Text = "Введите ваш кошелек или имя работника для идентификации на пуле";
            w.start_button.Content = "Начать добычу";
            w.advanceoption_button.Content = "Расширенные настройки";
            w.MiningWindow.Title = "Окно добычи";
            langtmp = "Your choice of algorithm: ";

           
        }
        public static void Language3_action_miningspace(MiningSpace w)
        {
            w.textblockgpu.Text = "Algorithmen zum Mining auf der GPU";
            w.textblockcpu.Text = "Algorithmen zum Mining auf der CPU verfügbar";
            w.pooladresstext.Text = "Gib die Adresse deines Pools ein";
            w.wallettext.Text = "Geben Sie Ihre Brieftasche oder den Namen des Mitarbeiters zur Identifikation im Pool ein";
            w.start_button.Content = "Starten Sie das Mining";
            w.advanceoption_button.Content = "Erweiterte Einstellungen";
            w.MiningWindow.Title = "Mining space";
            langtmp = "Ihre Wahl des Algorithmus: ";
        }
        public static void Language4_action_miningspace(MiningSpace w)
        {
            w.textblockgpu.Text = "可用于在GPU上挖掘的算法";
            w.textblockcpu.Text = "可用于在CPU上挖掘的算法";
            w.pooladresstext.Text = "输入您的池地址";
            w.wallettext.Text = "输入您的钱包或员工姓名，以便在池中进行识别";
            w.start_button.Content = "开始采矿";
            w.advanceoption_button.Content = "高级设置";
            w.MiningWindow.Title = "采矿空间";
            langtmp = "您选择的算法: ";
        }
        //adv window option
        public static void Language1_action_advwindow(AdvancedOptionWindow w)
        {
            w.AdvancedOptionWindowName.Title = "Advanced options window";
            w.collertext.Text = "Speed of rotation of coolers of a video card";

            w.cptext.Text = "Limiting the load";
            w.advtext.Text = "Additional settings";
            w.save.Content = "Save";
            w.reset.Content = "Reset settings";

        }
        public static void Language2_action_advwindow(AdvancedOptionWindow w)
        {
            w.AdvancedOptionWindowName.Title = "Окно дополнительных настроек";
            w.collertext.Text = "Скорость вращения кулеров видеокарты";

            w.cptext.Text = "Ограничение нагрузки";
            w.advtext.Text = "Дополнительные настройки";
            w.save.Content = "Сохранить";
            w.reset.Content = "Сбросить настройки";
        }
        public static void Language3_action_advwindow(AdvancedOptionWindow w)
        {
            w.AdvancedOptionWindowName.Title = "Erweitertes Optionen-Fenster";
            w.collertext.Text = "Rotationsgeschwindigkeit von Kühlern einer Grafikkarte";

            w.cptext.Text = "Begrenzung der Last";
            w.advtext.Text = "Zusätzliche Einstellungen";
            w.save.Content = "Sparen";
            w.reset.Content = "Einstellungen zurücksetzen";

        }
        public static void Language4_action_advwindow(AdvancedOptionWindow w)
        {
            w.AdvancedOptionWindowName.Title = "高级选项窗口";
            w.collertext.Text = "视频卡冷却器的旋转速度";

            w.cptext.Text = "限制负载";
            w.advtext.Text = "其他设置";
            w.save.Content = "保存";
            w.reset.Content = "重新设置";
        }
        public static void Language1_action_miningcalc(MiningCalc w)
        {
            langtmp = "Your choice of coin: ";
            langtmp_calc1 = "Profit per day = ";
            langtmp_calc2 = "Mined/Day = ";
            langtmp_calc3 = "Power cost/Day = ";
            langtmp_calc4 = "Profit per week = ";
            langtmp_calc5 = "Mined/Week = ";
            langtmp_calc6 = "Power cost/Week = ";
            langtmp_calc7 = "Profit per month = ";
            langtmp_calc8 = "Mined/Month = ";
            langtmp_calc9 = "Power cost/Month = ";
            langtmp_calc10 = "Hash rate in ";        
            w.wattstext.Text = "Electricity consumption in Watts:";
            w.cost_kwh_text.Text = "Cost electricity in $/kWh:";
            w.fee_text.Text = "Pool fee in %:";
            w.calcbtn.Content = "Calculate";
            w.CalcWindow.Title = "Mining profitability calculator";
            w.day.Text = "Day";
            w.week.Text = "Week";
            w.month.Text = "Month";

        }
        public static void Language2_action_miningcalc(MiningCalc w)
        {
            
            langtmp = "Ваш выбор монеты: ";
            langtmp_calc1 = "Прибыль в день = ";
            langtmp_calc2 = "Добыто/День = ";
            langtmp_calc3 = "Стоимость энергии/День = ";
            langtmp_calc4 = "Прибыль в неделю = ";
            langtmp_calc5 = "Добыто/Неделя = ";
            langtmp_calc6 = "Стоимость энергии/Неделя = ";
            langtmp_calc7 = "Прибыль в месяц = ";
            langtmp_calc8 = "Добыто/Месяц = ";
            langtmp_calc9 = "Стоимость энергии/Месяц = ";
            langtmp_calc10 = "Хэшрейт в ";
            w.wattstext.Text = "Укажите потребление в Ваттах:";
            w.cost_kwh_text.Text = "Стоимость энергии в $/Квт:";
            w.fee_text.Text = "Комиссия пула в %:";
            w.calcbtn.Content = "Подсчитать";
            w.CalcWindow.Title = "Калькулятор доходности майнинга";
            w.day.Text = "День";
            w.week.Text = "Неделя";
            w.month.Text = "Месяц";
        }
        public static void Language3_action_miningcalc(MiningCalc w)
        {
            
            langtmp = "Ihre Wahl der Münze: ";
            langtmp_calc1 = "Gewinn pro Tag = ";
            langtmp_calc2 = "Abgebaut / Tag = ";
            langtmp_calc3 = "Stromkosten / Tag = ";
            langtmp_calc4 = "Gewinn pro Woche = ";
            langtmp_calc5 = "Abgebaut / Woche = ";
            langtmp_calc6 = "Stromkosten / Woche = ";
            langtmp_calc7 = "Gewinn pro Monat = ";
            langtmp_calc8 = "Abgebaut / Monat = ";
            langtmp_calc9 = "Stromkosten / Monat = ";
            langtmp_calc10 = "Hashrate im ";
            w.wattstext.Text = "Stromverbrauch in Watt:";
            w.cost_kwh_text.Text = "Kosten Strom in $/kWh:";
            w.fee_text.Text = "Poolgebühr in %:";
            w.calcbtn.Content = "Berechnung";
            w.CalcWindow.Title = "Mining-Rentabilitätsrechner";
            w.day.Text = "Tag";
            w.week.Text = "Woche";
            w.month.Text = "Monat";
        }
        public static void Language4_action_miningcalc(MiningCalc w)
        {
            langtmp = "您选择的硬币： ";
            langtmp_calc1 = "每日利润 = ";
            langtmp_calc2 = "开采/天 = ";
            langtmp_calc3 = "电费/日 = ";
            langtmp_calc4 = "每周利润 = ";
            langtmp_calc5 = "开采/周 =";
            langtmp_calc6 = "电力成本/周 = ";
            langtmp_calc7 = "每月利润 = ";
            langtmp_calc8 = "开采/月 =";
            langtmp_calc9 = "电力成本/月 =";
            langtmp_calc10 = "哈希率 ";
            w.wattstext.Text = "瓦特的耗电量：";
            w.cost_kwh_text.Text = "耗电量 $/kWh：";
            w.fee_text.Text = "泳池费用％：";
            w.calcbtn.Content = "计算";
            w.CalcWindow.Title = "挖掘盈利能力计算器";
            w.day.Text = "天";
            w.week.Text = "周";
            w.month.Text = "月";
        }
    }
}