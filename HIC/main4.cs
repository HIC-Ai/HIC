using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using System.Media;
using System.IO; // needed for filing
using System.Speech.Synthesis;
using System.Diagnostics;
using System.Threading;

namespace HIC
{
    public partial class main4 : Form
    {
        public main4()
        {
            InitializeComponent();
            guna2Button1.Enabled = false;
            schedulerControl1.Start = DateTime.Now;
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }
        public string message_send = "السلام عليكم";
        public string message_rev = "السلام عليكم";

        int counter = 0;
        int len = 0;
        string txt;
        private void radClock1_Click(object sender, EventArgs e)
        {

        }

        private void radCalendar1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void clock1_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

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

        private void schedulerControl1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaTextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void schedulerControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaCircleButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        string tip = "";
        private void Tips_call()
        {
            while (true)
            {
                tip = new database().Tips_database();

                //main4.label1.Text = tip;
                //Thread.Sleep(2000);
            }
        }
        int i = 0;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            while (true)
            {
                i = i + 1;
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(2000);
                    //tip = new database().Tips_database();
                    worker.ReportProgress(i * 1);
                    
                    //label1.Text = tip;
                }
            }
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            tip = new database().Tips_database();
            //label1.Text = (e.ProgressPercentage.ToString());
            label1.Text = tip;
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label1.Text = "Complete";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
                backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
                backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
                backgroundWorker1.RunWorkerAsync();
            }

            Thread thread1 = new Thread(Tips_call);
            thread1.IsBackground = true;
            thread1.Start();
            //    Thread.Sleep(2000);

            AddIncomming(message_send);
            //new recognitionArabic().CloudTextToSpeech(message_send);
            txt = label1.Text;
            len = txt.Length;


            //label1.Text = "نصائح طبية";
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void send(string message_rev)
        {
            //if (InputTxt.Text.Trim().Length == 0) return;
            AddOutgoing(message_rev);
            InputTxt.Text = string.Empty;
            //Label5.Text = "typing...";
            timer1.Start();
        }

        void AddIncomming(string message)
        {
            chat.Incomming bubble = new chat.Incomming();
            PnlContainer.Controls.Add(value: bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Message = message;
            bubble.Focus();
        }

        void AddOutgoing(string message)
        {
            var bubble = new chat.Outgoing();
            PnlContainer.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Message = message;
            bubble.Focus();
        }

        private void bunifuTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {

                AddOutgoing(InputTxt.Text);
                InputTxt.Text = string.Empty;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            //Label5.Text = "OOFline";
            //AddIncomming("Sorry,I don't Know the answer");
        }

        private void bunifuImageButton2_Load(object sender, EventArgs e)
        {
            txt = label1.Text;
            len = txt.Length;
            label1.Text = "";
            timer1.Start();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }


        private void txtTyping_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void InputTxt_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //showOutput();
                e.SuppressKeyPress = true; // Disable windows error sound
            }
        }

        private void PnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            message_rev = InputTxt.Text;
            if (message_rev != null)
            {
                SoundPlayer Send = new SoundPlayer("SOUND1.wav"); // Send Sound Effect
                SoundPlayer Rcv = new SoundPlayer("SOUND2.wav"); // Recieve Sound Effect
                send(InputTxt.Text);
                Send.Play();

                var t = new System.Windows.Forms.Timer();

                // Time in milseconds - minimum delay of 1s plus 0.1s per character.
                t.Interval = 1000 + ("Hello".Length * 100);

                // Show the "Bot is typing.." text
                txtTyping.Show();

                // disable the chat box white the bot is typing to prevent user spam.
                InputTxt.Enabled = false;

                t.Tick += (s, d) =>
                {
                // Once the timer ends

                InputTxt.Enabled = true; // Enable Chat box

                // Hide the "Bot is typing.." text
                txtTyping.Hide();
                    message_send = new database().Database(message_send, message_rev);
                    new recognitionArabic().CloudTextToSpeech(message_send);

                // Show the bot message and play the sound
                AddIncomming(message_send);

                //addOutMessage(outtt);
                Rcv.Play();

                // Text to Speech if enabled
                //if (textToSpeech)
                //{
                //    reader.SpeakAsync(outtt);
                //}

                InputTxt.Focus(); // Put the cursor back on the textbox
                t.Stop();
                };
                t.Start(); // Start Timer

                InputTxt.Text = ""; // Reset textbox
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            
            new recognitionArabic().Louding(true, false);
            guna2CircleButton1.Enabled = false;
            guna2Button1.Enabled = true;
            guna2Button1.FillColor = Color.Red;
            InputTxt.Enabled = false;


        }

        private void colorPickerButton1_Click(object sender, EventArgs e)
        {


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            message_rev = new recognitionArabic().Louding(false, true);
            if (message_rev != "")
            {
                guna2CircleButton1.Enabled = true;
                guna2Button1.Enabled = false;



                SoundPlayer Send = new SoundPlayer("SOUND1.wav"); // Send Sound Effect
                SoundPlayer Rcv = new SoundPlayer("SOUND2.wav"); // Recieve Sound Effect
                send(message_rev);
                Send.Play();

                var t = new System.Windows.Forms.Timer();

                // Time in milseconds - minimum delay of 1s plus 0.1s per character.
                t.Interval = 1000 + (message_rev.Length * 100);

                // Show the "Bot is typing.." text
                txtTyping.Show();

                // disable the chat box white the bot is typing to prevent user spam.
                InputTxt.Enabled = false;

                t.Tick += (s, d) =>
                {
                    InputTxt.Enabled = true; // Enable Chat box

                    // Hide the "Bot is typing.." text
                    txtTyping.Hide();

                    // Show the bot message and play the sound



                    //message_send = message_rev;
                    message_send = new database().Database(message_send, message_rev);
                    new recognitionArabic().CloudTextToSpeech(message_send);
                    Debug.WriteLine("message_send " + message_send);
                    //if (message_send == null)
                    //{
                    //    message_send = message_rev;
                    //}
                    AddIncomming(message_send);

                    //addOutMessage(outtt);
                    Rcv.Play();

                    // Text to Speech if enabled
                    //if (textToSpeech)
                    //{
                    //    reader.SpeakAsync(outtt);
                    //}

                    InputTxt.Focus(); // Put the cursor back on the textbox
                    t.Stop();
                };
                t.Start(); // Start Timer

                InputTxt.Text = ""; // Reset textbox

            }
            
            guna2CircleButton1.Enabled = true;
            guna2Button1.Enabled = false;
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}

