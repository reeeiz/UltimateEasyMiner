using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SQLite;
namespace WpfApp4
{
    class DbActions
    {
        public static int currentchoose = 0;
        const string databaseName = @".\optionsdata.db";
        static SQLiteConnection connection =
                new SQLiteConnection(string.Format("Data Source={0};", databaseName));

        public static void StyleAction()
        {

            connection.Open();
            SQLiteCommand command = new SQLiteCommand("SELECT StyleChoose FROM Options  WHERE Id = 1;", connection);
            int i = -1;
            string str = null;
            using (SQLiteDataReader rdr = command.ExecuteReader())
            {
                while (rdr.Read())
                {
                    str = rdr[0].ToString();
                    break;
                }
            }
            i = Convert.ToInt32(str);
            StyleSheet.choosenstyle = i;
            connection.Close();
        }
        public static void StyleSet()
        {
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("UPDATE Options SET StyleChoose = "+StyleSheet.choosenstyle+" WHERE ID = 1; ", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static void LanguageAction()
        {

            connection.Open();
            SQLiteCommand command = new SQLiteCommand("SELECT LanguageChoose FROM Options  WHERE Id = 1;", connection);
            int i = -1;
            string str = null;
            using (SQLiteDataReader rdr = command.ExecuteReader())
            {
                while (rdr.Read())
                {
                    str = rdr[0].ToString();
                    break;
                }
            }
            i = Convert.ToInt32(str);
            LanguageSheet.choosenlang = i;
            connection.Close();
        }
        public static string LanguageSet()
        {
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("UPDATE Options SET LanguageChoose = "+LanguageSheet.choosenlang + " WHERE ID = 1; ", connection);
            command.ExecuteNonQuery();
            connection.Close();
            return (null);
        }
        public static string ReadMiner(MiningSpace w, int tmp1, int tmp2)
        {
            currentchoose = tmp2;
            try { connection.Open(); }
            catch(Exception ex)
            {

            }
            /* TMP1
             * 1- PoolAdress
             * 2- Wallet
             * 3- AdvancedOption
             * 
             * TMP2 - id of algorithms
             */
            string str = null;
            if (tmp1 == 1)
                str = "PoolAdress";
            if (tmp1 == 2)
                str = "Wallet";
            if (tmp1 == 3)
                str = "AdvancedOption";
         
            SQLiteCommand command = new SQLiteCommand("SELECT "+str+" FROM Options  WHERE Id = "+tmp2+";", connection);
            using (SQLiteDataReader rdr = command.ExecuteReader())
            {
                while (rdr.Read())
                {
                    str = rdr[0].ToString();
                    break;
                }
            }
            return str;
        }
      
        

        public static void Dbaction_action_miningspace(MiningSpace w, int id)
        {
           
            try { connection.Open();
            }
            catch (Exception ex)
            {

            }
            SQLiteCommand command1 = new SQLiteCommand("UPDATE Options SET PoolAdress = '"+w.pooladress.Text+"' WHERE Id = " + id, connection);
            SQLiteCommand command2 = new SQLiteCommand("UPDATE Options SET Wallet = '" + w.wallet.Text + "' WHERE Id = " + id, connection);
            command1.ExecuteNonQuery();
            command2.ExecuteNonQuery();
            connection.Close();
        }
        public static void Dbaction_action_advoption(AdvancedOptionWindow w, int value1, int value2, string str)
        {
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {

            }
            if (currentchoose != 0)
            {
                if (currentchoose == 1)
                {
                    SQLiteCommand command1 = new SQLiteCommand("UPDATE Options SET AdvancedOption = '-tt -" + value1 +" -li "+value2+ " "+str+"" +"' WHERE ID = " + currentchoose, connection);
                }
               else
                {
                    SQLiteCommand command1 = new SQLiteCommand("UPDATE Options SET AdvancedOption = '"+str+"' WHERE ID = " + currentchoose, connection);
                }
            }
          
            connection.Close();
        }

    }
}
