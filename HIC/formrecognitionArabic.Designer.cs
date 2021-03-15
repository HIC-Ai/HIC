
namespace HIC
{
    partial class formrecognitionArabic
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuTextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.SystemTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.WorkingArea = new System.Windows.Forms.Panel();
            this.WorkingArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.DefaultText = "";
            this.bunifuTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bunifuTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bunifuTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bunifuTextBox1.DisabledState.Parent = this.bunifuTextBox1;
            this.bunifuTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bunifuTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bunifuTextBox1.FocusedState.Parent = this.bunifuTextBox1;
            this.bunifuTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bunifuTextBox1.HoverState.Parent = this.bunifuTextBox1;
            this.bunifuTextBox1.Location = new System.Drawing.Point(66, 20);
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.PlaceholderText = "";
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.ShadowDecoration.Parent = this.bunifuTextBox1;
            this.bunifuTextBox1.Size = new System.Drawing.Size(200, 36);
            this.bunifuTextBox1.TabIndex = 0;
            // 
            // SystemTrayIcon
            // 
            this.SystemTrayIcon.Text = "notifyIcon1";
            this.SystemTrayIcon.Visible = true;
            this.SystemTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // WorkingArea
            // 
            this.WorkingArea.Controls.Add(this.bunifuTextBox1);
            this.WorkingArea.Location = new System.Drawing.Point(122, 55);
            this.WorkingArea.Name = "WorkingArea";
            this.WorkingArea.Size = new System.Drawing.Size(311, 87);
            this.WorkingArea.TabIndex = 1;
            // 
            // recognitionArabic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 219);
            this.Controls.Add(this.WorkingArea);
            this.Name = "recognitionArabic";
            this.Text = "RecognitionArabic";
            this.Load += new System.EventHandler(this.recognitionArabic_Load);
            this.WorkingArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox bunifuTextBox1;
        private System.Windows.Forms.NotifyIcon SystemTrayIcon;
        private System.Windows.Forms.Panel WorkingArea;
    }
}