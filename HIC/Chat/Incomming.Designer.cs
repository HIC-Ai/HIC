
namespace HIC.chat
{
    partial class Incomming
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
            this.bunifuUserControl1 = new Bunifu.UI.WinForms.BunifuUserControl();
            this.Label3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuUserControl1
            // 
            this.bunifuUserControl1.AllowAnimations = false;
            this.bunifuUserControl1.AllowBorderColorChanges = false;
            this.bunifuUserControl1.AllowMouseEffects = false;
            this.bunifuUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuUserControl1.AnimationSpeed = 200;
            this.bunifuUserControl1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuUserControl1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(114)))), ((int)(((byte)(245)))));
            this.bunifuUserControl1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bunifuUserControl1.BorderRadius = 20;
            this.bunifuUserControl1.BorderStyle = Bunifu.UI.WinForms.BunifuUserControl.BorderStyles.Solid;
            this.bunifuUserControl1.BorderThickness = 1;
            this.bunifuUserControl1.ColorContrastOnClick = 30;
            this.bunifuUserControl1.ColorContrastOnHover = 30;
            this.bunifuUserControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuUserControl1.Image = null;
            this.bunifuUserControl1.ImageMargin = new System.Windows.Forms.Padding(0);
            this.bunifuUserControl1.Location = new System.Drawing.Point(66, 3);
            this.bunifuUserControl1.Name = "bunifuUserControl1";
            this.bunifuUserControl1.ShowBorders = true;
            this.bunifuUserControl1.Size = new System.Drawing.Size(251, 60);
            this.bunifuUserControl1.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.bunifuUserControl1.TabIndex = 0;
            // 
            // Label3
            // 
            this.Label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(114)))), ((int)(((byte)(245)))));
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Label3.Location = new System.Drawing.Point(77, 14);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label3.Size = new System.Drawing.Size(230, 40);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "السلام عليكم ";
            this.Label3.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias;
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = global::HIC.Properties.Resources.icons8_medical_doctor_48;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(3, 14);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(46, 42);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 1;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // Incomming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.gunaCirclePictureBox1);
            this.Controls.Add(this.bunifuUserControl1);
            this.Name = "Incomming";
            this.Size = new System.Drawing.Size(321, 66);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuUserControl bunifuUserControl1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI.WinForms.GunaLabel Label3;
    }
}
