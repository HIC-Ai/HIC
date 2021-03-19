using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace HIC
{
    public partial class main : Form
    {

        //private readonly SQLiteConnection myConn;
        //private readonly SQLiteCommand sqCommand;
        //private readonly DataSet _dsParticipants;

        //SQLiteConnection myConn = new SQLiteConnection(sqConnectionString);
        //SQLiteCommand sqCommand = new SQLiteCommand(query);

        string sqConnectionString = "DataSource=chatbot.sqlite;Version=3;";
        string sentence;
        string sentence_id;
        public class P
        {
            public string[] listwords { get; set; }
            public int lenwords { get; set; }
        }
        private void InsertRow(string entityName, string word)
        {
            string tableName = entityName + "s";
            string columnName = entityName;
            // If the connection string is empty, use default.
            
            SQLiteConnection myConn = new SQLiteConnection(sqConnectionString);
            string query = String.Format("INSERT INTO {0} ('{1}') VALUES ('{2}')", tableName, columnName, word);
            SQLiteCommand sqCommand = new SQLiteCommand(query);
            sqCommand.Connection = myConn;
            myConn.Open();
            try
            {
                sqCommand.ExecuteNonQuery();
            }
            finally
            {
                myConn.Close();
            }
        }

        private string SelectRow(string entityName, string word)
        {

            string tableName = entityName + "s";
            string columnName = entityName;
            string rtin = null;

            SQLiteConnection sqConnection = new SQLiteConnection(sqConnectionString);
            SQLiteCommand sqCommand = (SQLiteCommand)sqConnection.CreateCommand();
            sqCommand.CommandText = String.Format("SELECT rowid FROM {0} WHERE {1} = '{2}'", tableName, columnName, word);
            sqConnection.Open();
            SQLiteDataReader sqReader = sqCommand.ExecuteReader();

            while (sqReader.Read())
            {
                rtin = sqReader.GetInt32(0).ToString();
            }

            sqReader.Close();
            sqConnection.Close();

            if (rtin == null)
            {
                Debug.WriteLine("غير موجود");
                InsertRow(entityName, word);
                SelectRow(entityName, word);
            }

            return rtin;
        }




        public void InsertRow2(string word_id, string sentence_id, string weight)
        {
            // If the connection string is empty, use default.

            SQLiteConnection myConn = new SQLiteConnection(sqConnectionString);
            string query = String.Format("INSERT INTO associations VALUES ({0}, {1}, {2})", word_id, sentence_id, weight);
            SQLiteCommand sqCommand = new SQLiteCommand(query);
            sqCommand.Connection = myConn;
            myConn.Open();
            try
            {
                sqCommand.ExecuteNonQuery();
            }
            finally
            {
                myConn.Close();
            }
        }

        public void TEMPORARYCREATE()
        {
            // If the connection string is empty, use default.

            SQLiteConnection myConn = new SQLiteConnection(sqConnectionString);
            string query = "CREATE TEMPORARY TABLE results(sentence_id INT, sentence TEXT, weight REAL)";
            SQLiteCommand sqCommand = new SQLiteCommand(query);
            sqCommand.Connection = myConn;
            myConn.Open();
            try
            {
                sqCommand.ExecuteNonQuery();
            }
            finally
            {
                myConn.Close();
            }
        }
        private static P GetWords(string text)
        {
            int count = 0;
            List<string> lstreturn = new List<string>();
            var matches = Regex.Matches(text, @"\w+[^\s]*\w+|\w");
            foreach (Match match in matches)
            {
                {
                    count += match.Value.Length;
                    lstreturn.Add(match.Value);
                }
            }
            P p = new P();
            p.listwords = lstreturn.ToArray();
            p.lenwords = count;
            return p;
        }

        
        public main()
        {
            InitializeComponent();

            schedulerControl1.Start = DateTime.Now;
            //MainWindow MainWindow = new MainWindow();
            //MainWindow.Show();

            var bubble = new MeBubble();



            bubble.Name = "chatItem" + itemsPanel.Controls.Count;
            bubble.Dock = DockStyle.Top;
            itemsPanel.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Body = "مرحبا";
            //itemsPanel.ScrollControlIntoView(bubble);
        }

       

       
      

    

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void gunaCircleButton4_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        


    

        private void gunaCircleButton1_MouseDown(object sender, MouseEventArgs e)
        {
            {
                //new recognitionArabic().Louding(true, false);
            }
        }

        private void gunaCircleButton1_MouseUp(object sender, MouseEventArgs e)
        {
            //var message = new recognitionArabic().Louding(false, true);
            string message = "السلام عليكم";
            if (message != "")
            {

                //Debug.WriteLine(message);
                var P = GetWords(message);


                sentence_id = SelectRow("sentence", message);


                foreach (string s in P.listwords)
                {

                    string word_id = SelectRow("word", s);
                    var weight = (float)Math.Sqrt(1 / (float)P.lenwords);
                    InsertRow2(word_id, sentence_id, weight.ToString());
                }

                SQLiteConnection myConn = new SQLiteConnection(sqConnectionString);
                string query = "CREATE TABLE results (sentence_id INT, sentence TEXT, weight REAL)";
                SQLiteCommand sqCommand = new SQLiteCommand(query);
                sqCommand.Connection = myConn;
                myConn.Open();
                sqCommand.ExecuteNonQuery();
                myConn.Close();
                var PP = GetWords(message);
                foreach (string s in PP.listwords)
                {
                    var weight2 = (float)Math.Sqrt(1 / (float)PP.lenwords);
                    myConn = new SQLiteConnection(sqConnectionString);
                    query = String.Format("INSERT INTO results SELECT associations.sentence_id, sentences.sentence, {0}*associations.weight/(4+sentences.used) FROM words INNER JOIN associations ON associations.word_id=words.rowid INNER JOIN sentences ON sentences.rowid=associations.sentence_id WHERE words.word='{1}'", weight2, s);
                    sqCommand = new SQLiteCommand(query);
                    sqCommand.Connection = myConn;
                    myConn.Open();
                    sqCommand.ExecuteNonQuery();
                    myConn.Close();
                }

                string row0 = "";
                query = "SELECT sentence_id, sentence, SUM(weight) AS sum_weight FROM results GROUP BY sentence_id ORDER BY sum_weight DESC LIMIT 1";
                sqCommand = new SQLiteCommand(query);
                sqCommand.Connection = myConn;
                myConn.Open();
                SQLiteDataReader sqReader = sqCommand.ExecuteReader();

                while (sqReader.Read())
                {
                    //Debug.WriteLine(sqReader.GetInt32(0).ToString());
                    sentence_id = sqReader["sentence_id"].ToString();
                    sentence = sqReader["sentence"].ToString();
                }
                sqReader.Close();
                myConn.Close();


                myConn = new SQLiteConnection(sqConnectionString);
                query = "DROP TABLE results";
                sqCommand = new SQLiteCommand(query);
                sqCommand.Connection = myConn;
                myConn.Open();
                sqCommand.ExecuteNonQuery();
                myConn.Close();


                if (sentence_id == "")
                {
                    query = "SELECT rowid, sentence FROM sentences WHERE used = (SELECT MIN(used) FROM sentences) ORDER BY RANDOM() LIMIT 1";
                    sqCommand = new SQLiteCommand(query);
                    sqCommand.Connection = myConn;
                    myConn.Open();
                    sqReader = sqCommand.ExecuteReader();

                    while (sqReader.Read())
                    {
                        sentence_id = sqReader["sentence_id"].ToString();
                        sentence = sqReader["sentence"].ToString();
                    }
                    sqReader.Close();
                    myConn.Close();
                }

                myConn = new SQLiteConnection(sqConnectionString);
                query = "UPDATE sentences SET used=used+1 WHERE rowid=" + sentence_id;
                sqCommand = new SQLiteCommand(query);
                sqCommand.Connection = myConn;
                myConn.Open();
                sqCommand.ExecuteNonQuery();
                myConn.Close();

                message = sentence;
                Debug.WriteLine(message);
                var chatItem = new YouBubble();



                chatItem.Name = "chatItem" + itemsPanel.Controls.Count;
                chatItem.Dock = DockStyle.Top;
                itemsPanel.Controls.Add(chatItem);
                chatItem.BringToFront();

                chatItem.Body = message;
                //chatItem.Focus();
                itemsPanel.ScrollControlIntoView(chatItem);
                FakeRecieving(message);
            }

        }
        private void FakeRecieving(string message)
        {

            var bubble = new MeBubble();



            bubble.Name = "chatItem" + itemsPanel.Controls.Count;
            bubble.Dock = DockStyle.Top;
            itemsPanel.Controls.Add(bubble);
            bubble.BringToFront();

            if (message == "السلام عليكم ")
            {
                bubble.Body = "وعليكم السلام";
            }
            else
            {
                bubble.Body = "This is a message received.";
            }
            //bubble.Focus();
            itemsPanel.ScrollControlIntoView(bubble);
            //FakeRecieving();


        }

        private void gunaCircleButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
