
namespace HIC
{
    partial class main
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
            Syncfusion.Windows.Forms.Tools.DigitalClockRenderer digitalClockRenderer1 = new Syncfusion.Windows.Forms.Tools.DigitalClockRenderer();
            Syncfusion.Windows.Forms.Tools.ClockRenderer clockRenderer1 = new Syncfusion.Windows.Forms.Tools.ClockRenderer();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnminimize = new Guna.UI.WinForms.GunaCircleButton();
            this.btnclose = new Guna.UI.WinForms.GunaCircleButton();
            this.schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.clock1 = new Syncfusion.Windows.Forms.Tools.Clock();
            this.panel3 = new System.Windows.Forms.Panel();
            this.itemsPanel = new System.Windows.Forms.Panel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaCircleButton1 = new Guna.UI.WinForms.GunaCircleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.youBubble1 = new HIC.YouBubble();
            this.youBubble2 = new HIC.YouBubble();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btnminimize);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 26);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnminimize
            // 
            this.btnminimize.AnimationHoverSpeed = 0.07F;
            this.btnminimize.AnimationSpeed = 0.03F;
            this.btnminimize.BaseColor = System.Drawing.Color.LimeGreen;
            this.btnminimize.BorderColor = System.Drawing.Color.Black;
            this.btnminimize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnminimize.FocusedColor = System.Drawing.Color.Empty;
            this.btnminimize.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminimize.ForeColor = System.Drawing.Color.White;
            this.btnminimize.Image = null;
            this.btnminimize.ImageSize = new System.Drawing.Size(52, 52);
            this.btnminimize.Location = new System.Drawing.Point(765, 4);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.OnHoverBaseColor = System.Drawing.Color.DarkGreen;
            this.btnminimize.OnHoverBorderColor = System.Drawing.Color.YellowGreen;
            this.btnminimize.OnHoverForeColor = System.Drawing.Color.Lime;
            this.btnminimize.OnHoverImage = null;
            this.btnminimize.OnPressedColor = System.Drawing.Color.YellowGreen;
            this.btnminimize.Size = new System.Drawing.Size(19, 19);
            this.btnminimize.TabIndex = 9;
            this.btnminimize.Text = "-";
            this.btnminimize.Click += new System.EventHandler(this.gunaCircleButton2_Click);
            // 
            // btnclose
            // 
            this.btnclose.AnimationHoverSpeed = 0.07F;
            this.btnclose.AnimationSpeed = 0.03F;
            this.btnclose.BaseColor = System.Drawing.Color.Red;
            this.btnclose.BorderColor = System.Drawing.Color.Black;
            this.btnclose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnclose.FocusedColor = System.Drawing.Color.Empty;
            this.btnclose.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Image = null;
            this.btnclose.ImageSize = new System.Drawing.Size(52, 52);
            this.btnclose.Location = new System.Drawing.Point(790, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.OnHoverBaseColor = System.Drawing.Color.Brown;
            this.btnclose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnclose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnclose.OnHoverImage = null;
            this.btnclose.OnPressedColor = System.Drawing.Color.Black;
            this.btnclose.Size = new System.Drawing.Size(19, 20);
            this.btnclose.TabIndex = 6;
            this.btnclose.Text = "x";
            this.btnclose.Click += new System.EventHandler(this.gunaCircleButton1_Click);
            // 
            // schedulerDataStorage1
            // 
            // 
            // 
            // 
            this.schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
            // 
            // 
            // 
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.SystemColors.Window, "None", "&None"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))), "Important", "&Important"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))), "Business", "&Business"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))), "Personal", "&Personal"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))), "Vacation", "&Vacation"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))), "Must Attend", "Must &Attend"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))), "Travel Required", "&Travel Required"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))), "Needs Preparation", "&Needs Preparation"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))), "Birthday", "&Birthday"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))), "Anniversary", "&Anniversary"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))), "Phone Call", "Phone &Call"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.SystemColors.Window, "None", "&None"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))), "Important", "&Important"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))), "Business", "&Business"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))), "Personal", "&Personal"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))), "Vacation", "&Vacation"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))), "Must Attend", "Must &Attend"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))), "Travel Required", "&Travel Required"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))), "Needs Preparation", "&Needs Preparation"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))), "Birthday", "&Birthday"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))), "Anniversary", "&Anniversary"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))), "Phone Call", "Phone &Call"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.SystemColors.Window, "None", "&None"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))), "Important", "&Important"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))), "Business", "&Business"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))), "Personal", "&Personal"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))), "Vacation", "&Vacation"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))), "Must Attend", "Must &Attend"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))), "Travel Required", "&Travel Required"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))), "Needs Preparation", "&Needs Preparation"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))), "Birthday", "&Birthday"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))), "Anniversary", "&Anniversary"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))), "Phone Call", "Phone &Call"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.SystemColors.Window, "None", "&None"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))), "Important", "&Important"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))), "Business", "&Business"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))), "Personal", "&Personal"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))), "Vacation", "&Vacation"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))), "Must Attend", "Must &Attend"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))), "Travel Required", "&Travel Required"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))), "Needs Preparation", "&Needs Preparation"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))), "Birthday", "&Birthday"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))), "Anniversary", "&Anniversary"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))), "Phone Call", "Phone &Call"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.SystemColors.Window, "None", "&None"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))), "Important", "&Important"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))), "Business", "&Business"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))), "Personal", "&Personal"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))), "Vacation", "&Vacation"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))), "Must Attend", "Must &Attend"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))), "Travel Required", "&Travel Required"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))), "Needs Preparation", "&Needs Preparation"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))), "Birthday", "&Birthday"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))), "Anniversary", "&Anniversary"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))), "Phone Call", "Phone &Call"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.SystemColors.Window, "None", "&None"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))), "Important", "&Important"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))), "Business", "&Business"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))), "Personal", "&Personal"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))), "Vacation", "&Vacation"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))), "Must Attend", "Must &Attend"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))), "Travel Required", "&Travel Required"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))), "Needs Preparation", "&Needs Preparation"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))), "Birthday", "&Birthday"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))), "Anniversary", "&Anniversary"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))), "Phone Call", "Phone &Call"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.SystemColors.Window, "None", "&None"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))), "Important", "&Important"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(213)))), ((int)(((byte)(255))))), "Business", "&Business"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(244)))), ((int)(((byte)(156))))), "Personal", "&Personal"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(199))))), "Vacation", "&Vacation"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(206)))), ((int)(((byte)(147))))), "Must Attend", "Must &Attend"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(244)))), ((int)(((byte)(255))))), "Travel Required", "&Travel Required"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))), "Needs Preparation", "&Needs Preparation"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(207)))), ((int)(((byte)(233))))), "Birthday", "&Birthday"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(233)))), ((int)(((byte)(223))))), "Anniversary", "&Anniversary"));
            this.schedulerDataStorage1.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(165))))), "Phone Call", "Phone &Call"));
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.clock1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.schedulerControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 500);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.gunaTextBox1);
            this.panel5.Controls.Add(this.youBubble1);
            this.panel5.Location = new System.Drawing.Point(380, 423);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(420, 63);
            this.panel5.TabIndex = 7;
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(3, 0);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 20;
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(423, 63);
            this.gunaTextBox1.TabIndex = 2;
            // 
            // clock1
            // 
            this.clock1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.clock1.BeforeTouchSize = new System.Drawing.Size(136, 75);
            this.clock1.ClockFormat = "HH:mm:ss";
            this.clock1.ClockFrame = Syncfusion.Windows.Forms.Tools.ClockFrames.RectangularFrame;
            this.clock1.ClockShape = Syncfusion.Windows.Forms.Tools.ClockShapes.Rectangle;
            this.clock1.ClockType = Syncfusion.Windows.Forms.Tools.ClockTypes.Digital;
            this.clock1.CurrentDateTime = new System.DateTime(2021, 3, 13, 19, 25, 4, 225);
            this.clock1.CustomTime = new System.DateTime(2021, 3, 15, 2, 14, 42, 107);
            this.clock1.DigitalRenderer = digitalClockRenderer1;
            this.clock1.DisplayDates = true;
            this.clock1.Location = new System.Drawing.Point(672, 7);
            this.clock1.MinimumSize = new System.Drawing.Size(75, 75);
            this.clock1.Name = "clock1";
            this.clock1.Now = new System.DateTime(((long)(0)));
            this.clock1.Remainder = new System.DateTime(2021, 3, 13, 19, 25, 4, 193);
            this.clock1.Renderer = clockRenderer1;
            this.clock1.ShowClockFrame = false;
            this.clock1.ShowCustomTimeClock = false;
            this.clock1.ShowHourDesignator = false;
            this.clock1.Size = new System.Drawing.Size(136, 75);
            this.clock1.StopTimer = false;
            this.clock1.TabIndex = 5;
            this.clock1.Text = "clock1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.BackgroundImage = global::HIC.Properties.Resources.stethoscope_99px;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.itemsPanel);
            this.panel3.Controls.Add(this.gunaPanel1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(380, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 411);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint_1);
            // 
            // itemsPanel
            // 
            this.itemsPanel.AutoScroll = true;
            this.itemsPanel.BackColor = System.Drawing.Color.Transparent;
            this.itemsPanel.Location = new System.Drawing.Point(18, 28);
            this.itemsPanel.Name = "itemsPanel";
            this.itemsPanel.Size = new System.Drawing.Size(250, 296);
            this.itemsPanel.TabIndex = 2;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel1.BackgroundImage = global::HIC.Properties.Resources.صورة5;
            this.gunaPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gunaPanel1.Controls.Add(this.gunaCircleButton1);
            this.gunaPanel1.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel1.ForeColor = System.Drawing.Color.Transparent;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 342);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(286, 65);
            this.gunaPanel1.TabIndex = 2;
            // 
            // gunaCircleButton1
            // 
            this.gunaCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaCircleButton1.AnimationSpeed = 0.03F;
            this.gunaCircleButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaCircleButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaCircleButton1.ForeColor = System.Drawing.Color.White;
            this.gunaCircleButton1.Image = global::HIC.Properties.Resources.icons8_microphone_48;
            this.gunaCircleButton1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleButton1.Location = new System.Drawing.Point(122, 21);
            this.gunaCircleButton1.Name = "gunaCircleButton1";
            this.gunaCircleButton1.OnHoverBaseColor = System.Drawing.SystemColors.WindowFrame;
            this.gunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.CornflowerBlue;
            this.gunaCircleButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gunaCircleButton1.OnHoverImage = null;
            this.gunaCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaCircleButton1.Size = new System.Drawing.Size(37, 36);
            this.gunaCircleButton1.TabIndex = 0;
            this.gunaCircleButton1.Click += new System.EventHandler(this.gunaCircleButton1_Click_5);
            this.gunaCircleButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gunaCircleButton1_MouseDown);
            this.gunaCircleButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gunaCircleButton1_MouseUp);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Aquamarine;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(286, 22);
            this.panel4.TabIndex = 0;
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month;
            this.schedulerControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.schedulerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.schedulerControl1.DataStorage = this.schedulerDataStorage1;
            this.schedulerControl1.DateNavigationBar.CalendarButton.Show = true;
            this.schedulerControl1.DateNavigationBar.ShowNavigationButtons = false;
            this.schedulerControl1.DateNavigationBar.ShowTodayButton = true;
            this.schedulerControl1.ForeColor = System.Drawing.Color.Black;
            this.schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;
            this.schedulerControl1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.schedulerControl1.LimitInterval.Duration = System.TimeSpan.Parse("2914237.23:59:59.9999999");
            this.schedulerControl1.LimitInterval.Start = new System.DateTime(2021, 2, 1, 0, 0, 0, 0);
            this.schedulerControl1.Location = new System.Drawing.Point(3, 3);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.PaintStyleName = "Skin";
            this.schedulerControl1.Size = new System.Drawing.Size(368, 494);
            this.schedulerControl1.Start = new System.DateTime(2021, 2, 28, 0, 0, 0, 0);
            this.schedulerControl1.TabIndex = 0;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.AgendaView.Enabled = false;
            this.schedulerControl1.Views.DayView.AllowScrollAnimation = false;
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl1.Views.MonthView.Appearance.AdditionalHeaderCaption.Options.UseBackColor = true;
            this.schedulerControl1.Views.MonthView.Appearance.AdditionalHeaderCaption.Options.UseBorderColor = true;
            this.schedulerControl1.Views.MonthView.Appearance.AdditionalHeaderCaption.Options.UseFont = true;
            this.schedulerControl1.Views.MonthView.Appearance.AdditionalHeaderCaption.Options.UseForeColor = true;
            this.schedulerControl1.Views.MonthView.Appearance.AdditionalHeaderCaption.Options.UseImage = true;
            this.schedulerControl1.Views.MonthView.Appearance.AdditionalHeaderCaption.Options.UseTextOptions = true;
            this.schedulerControl1.Views.WeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            this.schedulerControl1.Views.YearView.UseOptimizedScrolling = false;
            this.schedulerControl1.Click += new System.EventHandler(this.schedulerControl1_Click_1);
            // 
            // youBubble1
            // 
            this.youBubble1.BackColor = System.Drawing.Color.Transparent;
            this.youBubble1.Body = " This is a sample text message. This is a sample text message. This is a sample t" +
    "ext message. \n\nThis is a sample text message. ";
            this.youBubble1.ChatImageCursor = System.Windows.Forms.Cursors.Default;
            this.youBubble1.ChatTextCursor = System.Windows.Forms.Cursors.IBeam;
            this.youBubble1.Location = new System.Drawing.Point(32767, 32767);
            this.youBubble1.Margin = new System.Windows.Forms.Padding(537657, 1333685, 537657, 1333685);
            this.youBubble1.MinimumSize = new System.Drawing.Size(0, 1671649);
            this.youBubble1.MsgColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.youBubble1.MsgTextColor = System.Drawing.SystemColors.ControlDarkDark;
            this.youBubble1.Name = "youBubble1";
            this.youBubble1.Padding = new System.Windows.Forms.Padding(0, 2051823, 0, 2051823);
            this.youBubble1.Size = new System.Drawing.Size(65535, 65535);
            this.youBubble1.Status = HIC.MessageStatus.Custom;
            this.youBubble1.StatusImage = null;
            this.youBubble1.TabIndex = 0;
            this.youBubble1.Time = "";
            this.youBubble1.TimeColor = System.Drawing.Color.White;
            this.youBubble1.UserImage = null;
            // 
            // youBubble2
            // 
            this.youBubble2.BackColor = System.Drawing.Color.Transparent;
            this.youBubble2.Body = "الف لا بأس عليك ";
            this.youBubble2.ChatImageCursor = System.Windows.Forms.Cursors.Default;
            this.youBubble2.ChatTextCursor = System.Windows.Forms.Cursors.IBeam;
            this.youBubble2.Location = new System.Drawing.Point(6, 8);
            this.youBubble2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.youBubble2.MinimumSize = new System.Drawing.Size(0, 78);
            this.youBubble2.MsgColor = System.Drawing.Color.DodgerBlue;
            this.youBubble2.MsgTextColor = System.Drawing.SystemColors.ControlDarkDark;
            this.youBubble2.Name = "youBubble2";
            this.youBubble2.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.youBubble2.Size = new System.Drawing.Size(243, 78);
            this.youBubble2.Status = HIC.MessageStatus.Custom;
            this.youBubble2.StatusImage = null;
            this.youBubble2.TabIndex = 0;
            this.youBubble2.Time = "";
            this.youBubble2.TimeColor = System.Drawing.Color.White;
            this.youBubble2.UserImage = null;
            // 
            // main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(812, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaCircleButton btnminimize;
        private Guna.UI.WinForms.GunaCircleButton btnclose;
        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
        //private DevExpress.XtraScheduler.GoogleCalendar.DXGoogleCalendarSync dxGoogleCalendarSync1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI.WinForms.GunaCircleButton gunaCircleButton1;
        public DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private Syncfusion.Windows.Forms.Tools.Clock clock1;
        private System.Windows.Forms.Panel panel5;
        private YouBubble youBubble1;
        private System.Windows.Forms.Panel itemsPanel;
        private YouBubble youBubble2;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
    }
}

