using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace HIC
{
    class database
    {
        private static StringBuilder output = new StringBuilder();
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
            string rtin = "";

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

        public string Database(string message_send, string message_rev)
        {
            var P = GetWords(message_send);


            sentence_id = SelectRow("sentence", message_rev);

            if (sentence_id == "")
            {
                Debug.WriteLine("غير موجود");
                InsertRow("sentence", message_rev);
                sentence_id = SelectRow("sentence", message_rev);
            }
            Debug.WriteLine("Done rev rtin " + sentence_id);



            Debug.WriteLine("sentence_id " + sentence_id);
            foreach (string s in P.listwords)
            {

                string word_id = SelectRow("word", s);
                if (word_id == "")
                {
                    InsertRow("word", s);
                    word_id = SelectRow("word", s);
                }

                Debug.WriteLine("id is  " + word_id);
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
            var PP = GetWords(message_rev);
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

            Debug.WriteLine("Done send sentence " + sentence);
            myConn = new SQLiteConnection(sqConnectionString);
            query = "DROP TABLE results";
            sqCommand = new SQLiteCommand(query);
            sqCommand.Connection = myConn;
            myConn.Open();
            sqCommand.ExecuteNonQuery();
            myConn.Close();


            if (sentence == null)
            {
                Debug.WriteLine("sentence_id  is None " + sentence_id);
                query = "SELECT rowid, sentence FROM sentences WHERE used = (SELECT MIN(used) FROM sentences) ORDER BY RANDOM() LIMIT 1";
                sqCommand = new SQLiteCommand(query);
                sqCommand.Connection = myConn;
                myConn.Open();
                sqReader = sqCommand.ExecuteReader();

                while (sqReader.Read())
                {
                    sentence_id = sqReader["rowid"].ToString();
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

            return sentence;
        }
        string tip = "";
        public string Tips_database()
        {

            SQLiteConnection myConn = new SQLiteConnection(sqConnectionString);
            string query = "SELECT id, name FROM tips ORDER BY RANDOM() LIMIT 1";
            SQLiteCommand sqCommand = new SQLiteCommand(query);
            sqCommand = new SQLiteCommand(query);
            sqCommand.Connection = myConn;
            myConn.Open();
            SQLiteDataReader sqReader = sqCommand.ExecuteReader();

            while (sqReader.Read())
            {
                tip =  sqReader["name"].ToString();
                //output.Append(sqReader["name"]);
            }

            sqReader.Close();
            myConn.Close();
            return tip;

        }
        //public string Tips()
        //{
        //    Thread thread1 = new Thread(Tips_database);
        //    thread1.IsBackground = true;
        //    thread1.Start();
        //    Thread.Sleep(2000);
            
        //}
    }
}
