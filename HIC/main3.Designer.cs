
namespace HIC
{
    partial class main3
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
            this.radChat1 = new Telerik.WinControls.UI.RadChat();
            ((System.ComponentModel.ISupportInitialize)(this.radChat1)).BeginInit();
            this.SuspendLayout();
            // 
            // radChat1
            // 
            this.radChat1.Location = new System.Drawing.Point(12, 12);
            this.radChat1.Name = "radChat1";
            // 
            // 
            // 
            this.radChat1.RootElement.TextChanged += new System.EventHandler(this.radChat1_RootElement_TextChanged);
            this.radChat1.Size = new System.Drawing.Size(360, 500);
            this.radChat1.TabIndex = 0;
            this.radChat1.Text = "radChat1";
            this.radChat1.ThemeName = "Fluent";
            this.radChat1.TimeSeparatorInterval = System.TimeSpan.Parse("1.00:00:00");
            this.radChat1.SendMessage += new Telerik.WinControls.UI.SendMessageEventHandler(this.radChat1_SendMessage);
            this.radChat1.SuggestedActionClicked += new Telerik.WinControls.UI.SuggestedActionEventHandler(this.radChat1_SuggestedActionClicked_1);
            this.radChat1.TextChanged += new System.EventHandler(this.radChat1_TextChanged);
            this.radChat1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.radChat1_ControlAdded);
            this.radChat1.Enter += new System.EventHandler(this.radChat1_Enter);
            // 
            // main3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 514);
            this.Controls.Add(this.radChat1);
            this.Name = "main3";
            this.Text = "main3";
            this.Load += new System.EventHandler(this.main3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radChat1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadChat radChat1;
        //private AutoTuneView autoTuneView1;
    }
}