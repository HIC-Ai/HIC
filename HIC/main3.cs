using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace HIC
{
    public partial class main3 : Form
    {
        public main3()
        {
            InitializeComponent();


            this.radChat1.Author = new Author(Properties.Resources.Online_32, "Nancy");

            this.radChat1.ChatElement.ChatFactory = new CustomChatFactory();

            Author author2 = new Author(Properties.Resources.Online_32, "Andrew");
            ChatTextMessage message1 = new ChatTextMessage("Hello", author2, DateTime.Now.AddHours(1));
            this.radChat1.AddMessage(message1);
            ChatTextMessage message2 = new ChatTextMessage("Hi", this.radChat1.Author, DateTime.Now.AddHours(1).AddMinutes(10));
            this.radChat1.AddMessage(message2);
            ChatTextMessage message3 = new ChatTextMessage("We would like to announce that in the R2 2018 release " +
                                                           "we introduced Conversational UI", author2, DateTime.Now.AddHours(3));
            this.radChat1.AddMessage(message3);
            ChatTextMessage message4 = new ChatTextMessage("This control provides rich conversational experience " +
                                                           "that goes beyond the natural language understanding and " +
                                                           "personality of your chatbot.", author2, DateTime.Now.AddHours(3));
            this.radChat1.AddMessage(message4);


            //this.radChat1.ChatElement.MessagesViewElement.TimeSeparatorInterval = TimeSpan.FromHours(1);


            //this.radChat1.Author = new Author(Properties.Resources.icons8_Call_32, "Nancy");
            //Author author2 = new Author(Properties.Resources.icons8_Attach_321, "Andrew");

            //ChatTextMessage message1 = new ChatTextMessage("Hello", author2, DateTime.Now.AddHours(1));
            //this.radChat1.AddMessage(message1);

            //ChatTextMessage message2 = new ChatTextMessage("Hi", this.radChat1.Author, DateTime.Now.AddHours(1).AddMinutes(10));
            //this.radChat1.AddMessage(message2);

            //ChatTextMessage message3 = new ChatTextMessage("How are you?", author2, DateTime.Now.AddHours(3));
            //this.radChat1.AddMessage(message3);

        }
        public class CustomChatFactory : ChatFactory
        {
            public override BaseChatItemElement CreateItemElement(BaseChatDataItem item)
            {
                if (item.GetType() == typeof(TextMessageDataItem))
                {
                    return new MyTextMessageItemElement();
                }
                return base.CreateItemElement(item);
            }
        }

        public class MyTextMessageItemElement : TextMessageItemElement
        {
            protected override Type ThemeEffectiveType
            {
                get
                {
                    return typeof(TextMessageItemElement);
                }
            }

            protected override LightVisualElement CreateMainMessageElement()
            {
                return new CustomChatMessageBubbleElement();
            }

            public override void Synchronize()
            {
                base.Synchronize();
                CustomChatMessageBubbleElement bubble = this.MainMessageElement as CustomChatMessageBubbleElement;
                bubble.DrawText = false;
                bubble.TextBoxElement.Multiline = true;
                bubble.TextBoxElement.DrawFill = false;
                bubble.TextBoxElement.DrawBorder = false;
                bubble.TextBoxElement.IsReadOnly = true;
            }
        }

        public class CustomChatMessageBubbleElement : ChatMessageBubbleElement
        {
            protected override Type ThemeEffectiveType
            {
                get
                {
                    return typeof(ChatMessageBubbleElement);
                }
            }

            RadTextBoxControlElement textBoxElement;

            public RadTextBoxControlElement TextBoxElement
            {
                get
                {


                    return this.textBoxElement;
                }
            }

            protected override void CreateChildElements()
            {
                base.CreateChildElements();
                textBoxElement = new RadTextBoxControlElement();
                textBoxElement.ContextMenuOpening += textBoxElement_ContextMenuOpening;
                this.Children.Add(textBoxElement);
            }


            private void textBoxElement_ContextMenuOpening(object sender, TreeBoxContextMenuOpeningEventArgs e)
            {
                foreach (RadItem item in e.ContextMenu.Items)
                {
                    if (item.Text.Contains("&Copy"))
                    {
                        item.Visibility = ElementVisibility.Visible;
                    }
                    else
                    {
                        item.Visibility = ElementVisibility.Collapsed;
                    }
                }
            }

            public override string Text
            {
                get
                {
                    Console.WriteLine(base.Text);
                    return base.Text;
                }
                set
                {
                    base.Text = value;
                    this.textBoxElement.Text = value;
                }
            }
        }

        Font f = new Font("Calibri", 12f, FontStyle.Bold);
        private void RadChat1_ItemFormattingCildren(object sender, ChatItemElementEventArgs e)
        {
            ChatMessageAvatarElement avatar = e.ItemElement.AvatarPictureElement;
            ChatMessageNameElement name = e.ItemElement.NameLabelElement;
            ChatMessageStatusElement status = e.ItemElement.StatusLabelElement;
            LightVisualElement bubble = e.ItemElement.MainMessageElement;
            if (!e.ItemElement.IsOwnMessage && e.ItemElement is TextMessageItemElement)
            {
                avatar.DrawImage = false;
                name.Font = f;
                bubble.DrawFill = true;
                bubble.BackColor = Color.LightGreen;
                bubble.ShadowDepth = 3;
                bubble.ShadowColor = Color.Green;
            }
            else
            {
                avatar.ResetValue(LightVisualElement.ImageProperty, Telerik.WinControls.ValueResetFlags.Local);
                name.ResetValue(LightVisualElement.FontProperty, Telerik.WinControls.ValueResetFlags.All);
                status.ResetValue(LightVisualElement.VisibilityProperty, Telerik.WinControls.ValueResetFlags.Local);
                bubble.ResetValue(LightVisualElement.DrawFillProperty, Telerik.WinControls.ValueResetFlags.Local);
                bubble.ResetValue(LightVisualElement.BackColorProperty, Telerik.WinControls.ValueResetFlags.Local);
                bubble.ResetValue(LightVisualElement.ShadowDepthProperty, Telerik.WinControls.ValueResetFlags.Local);
                bubble.ResetValue(LightVisualElement.ShadowColorProperty, Telerik.WinControls.ValueResetFlags.Local);
            }
        }
        private void AddSuggestedActions()
        {
            this.radChat1.AddMessage(new ChatTextMessage("Hello, here are the choices", this.radChat1.Author, DateTime.Now));

            List<SuggestedActionDataItem> actions = new List<SuggestedActionDataItem>();
            for (int i = 0; i < 7; i++)
            {
                actions.Add(new SuggestedActionDataItem("Option " + (i + 1)));
            }
            Author author = new Author(Properties.Resources.icons8_Chat_32, "Andrew");
            ChatSuggestedActionsMessage suggestionActionsMessage = new ChatSuggestedActionsMessage(actions, author, DateTime.Now);
            this.radChat1.AddMessage(suggestionActionsMessage);
            this.radChat1.SuggestedActionClicked += radChat1_SuggestedActionClicked;
        }

        private void radChat1_SuggestedActionClicked(object sender, SuggestedActionEventArgs e)
        {
            Console.WriteLine(e.Action.Text);
            this.radChat1.AddMessage(new ChatTextMessage("You have chosen " + e.Action.Text, this.radChat1.Author, DateTime.Now));
        }

        private void radChat1_SendMessage(object sender, SendMessageEventArgs e)
        {
            var author = e.Message;
            Console.WriteLine("Lo" + author);



            //Console.WriteLine(this.radChat1.Author.Data);
            //    RadTextBoxElement textBox = new RadTextBoxElement();
            //    textBox.Text = "Enter text here";
            //    textBox.MinSize = new Size(100, 0);
            //    Console.WriteLine(textBox);
            //this.radChat1.ChatElement.MessagesViewElement.TimeSeparatorInterval = TimeSpan.FromHours(1);


            //this.radChat1.Author = new Author(Properties.Resources.icons8_Call_32, "Nancy");
            //Author author2 = new Author(Properties.Resources.icons8_Attach_321, "Andrew");

            //ChatTextMessage message1 = new ChatTextMessage("Hello", author2, DateTime.Now.AddHours(1));
            //this.radChat1.AddMessage(message1);

            //ChatTextMessage message2 = new ChatTextMessage("Hi", this.radChat1.Author, DateTime.Now.AddHours(1).AddMinutes(10));
            //this.radChat1.AddMessage(message2);

            //ChatTextMessage message3 = new ChatTextMessage("How are you?", author2, DateTime.Now.AddHours(3));
            //this.radChat1.AddMessage(message3);
        }

        private void radChat1_SuggestedActionClicked_1(object sender, SuggestedActionEventArgs e)
        {

            //this.radChat1.AddMessage(new ChatTextMessage("Hello, here are the choices", this.radChat1.Author, DateTime.Now));

            //List<SuggestedActionDataItem> actions = new List<SuggestedActionDataItem>();
            //for (int i = 0; i < 7; i++)
            //{
            //    actions.Add(new SuggestedActionDataItem("Option " + (i + 1)));
            //}
            //Author author = new Author(Properties.Resources.icons8_Chat_32, "Andrew");
            //ChatSuggestedActionsMessage suggestionActionsMessage = new ChatSuggestedActionsMessage(actions, author, DateTime.Now);
            //this.radChat1.AddMessage(suggestionActionsMessage);
            //this.radChat1.SuggestedActionClicked += radChat1_SuggestedActionClicked;
        }

        private void radChat1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radChat1_ControlAdded(object sender, ControlEventArgs e)
        {
            Console.WriteLine(e.Control);
        }

        private void radChat1_RootElement_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(e.ToString());
        }

        private void radChat1_Enter(object sender, EventArgs e)
        {
            Console.WriteLine(e);
        }
        private void Chat_SendMessage_(object sender, SendMessageEventArgs e)
        {
        }

        private void main3_Load(object sender, EventArgs e)
        {
            //this.radChat1.TextChanged = "onSendMessage";
        }

        private void recordNavigationControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
