using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HIC
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            schedulerControl1.Start = DateTime.Now;
        }

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

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void gunaCircleButton1_Click_2(object sender, EventArgs e)
        {
            //


        }

        private void gunaCircleButton1_Click_3(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        int i = 0;

        private void gunaCircleButton1_Click_4(object sender, EventArgs e)
        {




            ////panel3.Controls.Clear();
            //YouBubble bubble = new YouBubble();
            //bubble.Dock = DockStyle.Bottom;
            //bubble.SendToBack();
            //bubble.Body = "مرحبا " + i.ToString();
            //panel3.Controls.Add(bubble);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void gunaCircleButton1_Click_5(object sender, EventArgs e)
        {
            i = i + 1;
            var message = "مرحبا " + i.ToString();


        }

        private void gunaCircleButton1_MouseDown(object sender, MouseEventArgs e)
        {
            {
                new recognitionArabic().Louding(true, false);
            }
        }

        private void gunaCircleButton1_MouseUp(object sender, MouseEventArgs e)
        {
            var message = new recognitionArabic().Louding(false, true);
            if (message != "")
            {
                Console.WriteLine(message);

                var chatItem = new YouBubble();



                chatItem.Name = "chatItem" + itemsPanel.Controls.Count;
                chatItem.Dock = DockStyle.Top;
                itemsPanel.Controls.Add(chatItem);
                chatItem.BringToFront();

                chatItem.Body = message;

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
            itemsPanel.ScrollControlIntoView(bubble);
            //FakeRecieving();

  
        }

        private void youBubble3_Load(object sender, EventArgs e)
        {

        }
    }
}
