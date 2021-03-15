namespace HIC
{
    partial class ChatPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatPanel));
            this.topPanel = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.clientnameLabel = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.chatTextbox = new System.Windows.Forms.TextBox();
            this.attachButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.itemsPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.topPanel.Controls.Add(this.statusLabel);
            this.topPanel.Controls.Add(this.phoneLabel);
            this.topPanel.Controls.Add(this.clientnameLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Padding = new System.Windows.Forms.Padding(15);
            this.topPanel.Size = new System.Drawing.Size(480, 77);
            this.topPanel.TabIndex = 0;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusLabel.Location = new System.Drawing.Point(398, 40);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(67, 15);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "LastViewed";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.phoneLabel.Location = new System.Drawing.Point(15, 41);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(62, 21);
            this.phoneLabel.TabIndex = 1;
            this.phoneLabel.Text = "المساعد";
            // 
            // clientnameLabel
            // 
            this.clientnameLabel.AutoSize = true;
            this.clientnameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientnameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.clientnameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clientnameLabel.Location = new System.Drawing.Point(15, 15);
            this.clientnameLabel.Name = "clientnameLabel";
            this.clientnameLabel.Size = new System.Drawing.Size(52, 25);
            this.clientnameLabel.TabIndex = 0;
            this.clientnameLabel.Text = "Chat";
            this.clientnameLabel.Click += new System.EventHandler(this.clientnameLabel_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.bottomPanel.Controls.Add(this.chatTextbox);
            this.bottomPanel.Controls.Add(this.attachButton);
            this.bottomPanel.Controls.Add(this.removeButton);
            this.bottomPanel.Controls.Add(this.sendButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bottomPanel.Location = new System.Drawing.Point(0, 143);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.bottomPanel.Size = new System.Drawing.Size(480, 54);
            this.bottomPanel.TabIndex = 1;
            // 
            // chatTextbox
            // 
            this.chatTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatTextbox.Location = new System.Drawing.Point(15, 10);
            this.chatTextbox.Multiline = true;
            this.chatTextbox.Name = "chatTextbox";
            this.chatTextbox.Size = new System.Drawing.Size(321, 34);
            this.chatTextbox.TabIndex = 7;
            this.chatTextbox.TextChanged += new System.EventHandler(this.chatTextbox_TextChanged);
            // 
            // attachButton
            // 
            this.attachButton.BackColor = System.Drawing.Color.GhostWhite;
            this.attachButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.attachButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.attachButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attachButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.attachButton.Image = ((System.Drawing.Image)(resources.GetObject("attachButton.Image")));
            this.attachButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.attachButton.Location = new System.Drawing.Point(336, 10);
            this.attachButton.Name = "attachButton";
            this.attachButton.Size = new System.Drawing.Size(35, 34);
            this.attachButton.TabIndex = 6;
            this.attachButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.attachButton.UseVisualStyleBackColor = false;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Red;
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeButton.Location = new System.Drawing.Point(371, 10);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(19, 34);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "X";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Visible = false;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.sendButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(390, 10);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 34);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // itemsPanel
            // 
            this.itemsPanel.AutoScroll = true;
            this.itemsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsPanel.Location = new System.Drawing.Point(0, 77);
            this.itemsPanel.Name = "itemsPanel";
            this.itemsPanel.Size = new System.Drawing.Size(480, 66);
            this.itemsPanel.TabIndex = 2;
            this.itemsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.itemsPanel_Paint);
            // 
            // ChatPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 197);
            this.ControlBox = false;
            this.Controls.Add(this.itemsPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "ChatPanel";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label clientnameLabel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button attachButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox chatTextbox;
        private System.Windows.Forms.Panel itemsPanel;
    }
}