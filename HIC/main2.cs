using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Media;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIC
{
    public partial class main2 : Form
    {
        public main2()
        {
            InitializeComponent();
            schedulerControl1.Start = DateTime.Now;
        }
        int counter = 0;
        int len = 0;
        string txt;

        
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


        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;

            if (counter > len)
            {
                counter = 0;
                labelTop.Text = "";
            }

            else
            {

                labelTop.Text = txt.Substring(0, counter);

                if (labelTop.ForeColor == Color.Black)
                    labelTop.ForeColor = Color.Red;
                else
                    labelTop.ForeColor = Color.Black;

            }
        }

        private void main2_Load(object sender, EventArgs e)
        {
            txt = labelTop.Text;
            len = txt.Length;
            labelTop.Text = "";
            timer1.Start();

            // Sets Position for the first bubble on the top
            bbl_old.Top = 0 - bbl_old.Height;

            // Load Chat from the log file
            if (File.Exists("chat.log"))
            {
                using (StreamReader sr = File.OpenText("chat.log"))
                {
                    int i = 0; // to count lines
                    while (sr.Peek() >= 0) // loop till the file ends
                    {
                        if (i % 2 == 0) // check if line is even
                        {
                            addInMessage(sr.ReadLine());
                        }
                        else
                        {
                            addOutMessage(sr.ReadLine());
                        }
                        i++;
                    }
                    // scroll to the bottom once finished loading.
                    panel2.VerticalScroll.Value = panel2.VerticalScroll.Maximum;
                    panel2.PerformLayout();
                }
            }
        }


        SpeechSynthesizer reader = new SpeechSynthesizer();
        bool textToSpeech = false;


        private void showOutput()
        {
            if (!(string.IsNullOrWhiteSpace(InputTxt.Text))) // Make sure the textbox isnt empty
            {
                SoundPlayer Send = new SoundPlayer("SOUND1.wav"); // Send Sound Effect
                SoundPlayer Rcv = new SoundPlayer("SOUND2.wav"); // Recieve Sound Effect

                // Show the user message and play the sound
                addInMessage(InputTxt.Text);
                Send.Play();

                // Store the Bot's Output by giving it our input.
                string outtt = "Hello";

                if (outtt.Length == 0)
                {
                    outtt = "I don't understand.";
                }

                //=========== Creates backup of chat from user and bot to the given location ============
                FileStream fs = new FileStream(@"chat.log", FileMode.Append, FileAccess.Write);
                if (fs.CanWrite)
                {
                    byte[] write = System.Text.Encoding.ASCII.GetBytes(InputTxt.Text + Environment.NewLine + outtt + Environment.NewLine);
                    fs.Write(write, 0, write.Length);
                }
                fs.Flush();
                fs.Close();
                //=======================================================================================

                // Make a Dynamic Timer to delay the bot's response to make it feel humanlike.
                var t = new Timer();

                // Time in milseconds - minimum delay of 1s plus 0.1s per character.
                t.Interval = 1000 + (outtt.Length * 100);

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
                    addOutMessage(outtt);
                    Rcv.Play();

                    // Text to Speech if enabled
                    if (textToSpeech)
                    {
                        reader.SpeakAsync(outtt);
                    }

                    InputTxt.Focus(); // Put the cursor back on the textbox
                    t.Stop();
                };
                t.Start(); // Start Timer

                InputTxt.Text = ""; // Reset textbox
            }
        }

        // Call the Output method when the send button is clicked.
        private void button1_Click(object sender, EventArgs e)
        {
            showOutput();
        }

        // Call the Output method when the enter key is pressed.
        private void InputTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                showOutput();
                e.SuppressKeyPress = true; // Disable windows error sound
            }
        }

        // Dummy Bubble created to store the previous bubble data.
        bubble bbl_old = new bubble();

        // User Message Bubble Creation
        public void addInMessage(string message)
        {
            // Create new chat bubble
            bubble bbl = new bubble(message, msgtype.In);
            bbl.Location = bubble1.Location; // Set the new bubble location from the bubble sample.
            bbl.Left += 50; // Indent the bubble to the right side.
            bbl.Size = bubble1.Size; // Set the new bubble size from the bubble sample.
            bbl.Top = bbl_old.Bottom + 10; // Position the bubble below the previous one with some extra space.

            // Add the new bubble to the panel.
            panel2.Controls.Add(bbl);

            // Force Scroll to the latest bubble
            bbl.Focus();

            // save the last added object to the dummy bubble
            bbl_old = bbl;
        }

        // Bot Message Bubble Creation
        public void addOutMessage(string message)
        {
            // Create new chat bubble
            bubble bbl = new bubble(message, msgtype.Out);
            bbl.Location = bubble1.Location; // Set the new bubble location from the bubble sample.
            bbl.Size = bubble1.Size; // Set the new bubble size from the bubble sample.
            bbl.Top = bbl_old.Bottom + 10; // Position the bubble below the previous one with some extra space.

            // Add the new bubble to the panel.
            panel2.Controls.Add(bbl);

            // Force Scroll to the latest bubble
            bbl.Focus();

            // save the last added object to the dummy bubble
            bbl_old = bbl;
        }

        // Custom close button to close the program when clicked.
        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // Clear all the bubbles and chat.log
        private void clearChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Delete the log file
            File.Delete(@"chat.log");

            // Clear the chat Bubbles
            panel2.Controls.Clear();

            // This reset the position for the next bubble to come back to the top.
            bbl_old.Top = 0 - bbl_old.Height;
        }


        private void menuButton_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(menuButton, new System.Drawing.Point(0, -contextMenuStrip1.Size.Height));
        }

        private void toggleVoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // whenever the toggle is clicked, true is set to false visa versa.
            textToSpeech = !textToSpeech;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

