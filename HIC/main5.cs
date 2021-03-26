using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace HIC
{
    public partial class main5 : Form
    {
        public main5()
        {
            InitializeComponent();

            this.radChat1.Author = new Author(Properties.Resources.icons8_Chat_32, "Nancy");

        }

        private void main5_Load(object sender, EventArgs e)
        {

        }

        //private void AddMessageProgrammatically()
        //{
        //    this.radChat1.AutoAddUserMessages = false;
        //    this.radChat1.SendMessage += radChat1_SendMessage;
        //}
        private void radChat1_SendMessage(object sender, SendMessageEventArgs e)
        {
            ChatTextMessage textMessage = e.Message as ChatTextMessage;

            //ChatTextMessage message1 = new ChatTextMessage("Hello", author2, DateTime.Now.AddHours(1));
            //this.radChat1.AddMessage(message1);


            //textMessage.Message = textMessage.Message;
            if (textMessage.Message == "السلام عليكم")
            {
                Author author2 = new Author(Properties.Resources.icons8_Email_Send_32, "Andrew");

                ChatTextMessage message3 = new ChatTextMessage("عليكم السلام", author2, DateTime.Now);
                this.radChat1.AddMessage(message3);

            }
            //this.radChat1.AddMessage(textMessage);
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
