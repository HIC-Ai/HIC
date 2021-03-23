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
namespace HIC
{
    public partial class main4 : Form
    {
        public main4()
        {
            InitializeComponent();

            schedulerControl1.Start = DateTime.Now;
        }
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

        private void Form1_Load(object sender, EventArgs e)
        {


            txt = label1.Text;
            len = txt.Length;
            label1.Text = "";
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


        void send()
        {
            if (InputTxt.Text.Trim().Length == 0) return;
            AddOutgoing(InputTxt.Text);
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
            //timer1.Stop();
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
            SoundPlayer Send = new SoundPlayer("SOUND1.wav"); // Send Sound Effect
            SoundPlayer Rcv = new SoundPlayer("SOUND2.wav"); // Recieve Sound Effect
            send();
            Send.Play();

            var t = new Timer();

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

                // Show the bot message and play the sound
                AddIncomming("Sorry,I don't Know the answer");

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

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}

