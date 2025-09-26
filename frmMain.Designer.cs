namespace Julian_Date_Selector
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.calMonth = new System.Windows.Forms.MonthCalendar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ttTips = new System.Windows.Forms.ToolTip(this.components);
            this.lblSelectedFormatOutput = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.mtbDate = new System.Windows.Forms.MaskedTextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbxNotifyOnCopy = new System.Windows.Forms.CheckBox();
            this.btnClearJtoC = new System.Windows.Forms.Button();
            this.lblCalendarOutput = new System.Windows.Forms.Label();
            this.btnJulianToCalendar = new System.Windows.Forms.Button();
            this.txtJulianInput = new System.Windows.Forms.TextBox();
            this.lblJulianDate = new System.Windows.Forms.Label();
            this.lblJulianDateOutput = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSetFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDDD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYYDDD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYY_DDD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYYYYDDD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYYYY_DDD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDarkMode = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpWebsite = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSelectedFormat = new System.Windows.Forms.Label();
            this.grpLookup = new System.Windows.Forms.GroupBox();
            this.lblSearchDate = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpConvertJulianToCalendarDate = new System.Windows.Forms.GroupBox();
            this.mnuUserGuide = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.grpLookup.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grpConvertJulianToCalendarDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // calMonth
            // 
            this.calMonth.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.calMonth.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calMonth.Location = new System.Drawing.Point(10, 36);
            this.calMonth.Margin = new System.Windows.Forms.Padding(15, 13, 15, 13);
            this.calMonth.MaxSelectionCount = 1;
            this.calMonth.MinDate = new System.DateTime(1901, 1, 1, 0, 0, 0, 0);
            this.calMonth.Name = "calMonth";
            this.calMonth.TabIndex = 1;
            this.ttTips.SetToolTip(this.calMonth, "Pick a Calendar date");
            this.calMonth.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calMonth_DateChanged);
            this.calMonth.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calMonth_DateSelected);
            // 
            // ttTips
            // 
            this.ttTips.BackColor = System.Drawing.Color.Yellow;
            this.ttTips.ForeColor = System.Drawing.Color.Black;
            this.ttTips.IsBalloon = true;
            // 
            // lblSelectedFormatOutput
            // 
            this.lblSelectedFormatOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSelectedFormatOutput.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedFormatOutput.Location = new System.Drawing.Point(322, 351);
            this.lblSelectedFormatOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedFormatOutput.Name = "lblSelectedFormatOutput";
            this.lblSelectedFormatOutput.Size = new System.Drawing.Size(163, 29);
            this.lblSelectedFormatOutput.TabIndex = 4;
            this.lblSelectedFormatOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttTips.SetToolTip(this.lblSelectedFormatOutput, "The currently selected Format based on your \'Set Format\' choice");
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(511, 351);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(183, 73);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "Click here to &Copy to the Clipoard";
            this.ttTips.SetToolTip(this.btnCopy, "Copy the julian date to the clipboard");
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(387, 49);
            this.btnFind.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(138, 33);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "Click here to &Find";
            this.ttTips.SetToolTip(this.btnFind, "Find a Calendar Date");
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // mtbDate
            // 
            this.mtbDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDate.Location = new System.Drawing.Point(149, 52);
            this.mtbDate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mtbDate.Mask = "00/00/0000";
            this.mtbDate.Name = "mtbDate";
            this.mtbDate.Size = new System.Drawing.Size(226, 26);
            this.mtbDate.TabIndex = 5;
            this.ttTips.SetToolTip(this.mtbDate, "Type in a Calendar Date in the MM/DD/YYYY format to find");
            this.mtbDate.ValidatingType = typeof(System.DateTime);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(149, 85);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtpDate.MinDate = new System.DateTime(1901, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(376, 26);
            this.dtpDate.TabIndex = 7;
            this.ttTips.SetToolTip(this.dtpDate, "Pick a Calendar date (drop down or arrow  up/down)");
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged_1);
            // 
            // cbxNotifyOnCopy
            // 
            this.cbxNotifyOnCopy.AutoSize = true;
            this.cbxNotifyOnCopy.Location = new System.Drawing.Point(511, 430);
            this.cbxNotifyOnCopy.Name = "cbxNotifyOnCopy";
            this.cbxNotifyOnCopy.Size = new System.Drawing.Size(142, 23);
            this.cbxNotifyOnCopy.TabIndex = 8;
            this.cbxNotifyOnCopy.Text = "&Notify on Copy";
            this.ttTips.SetToolTip(this.cbxNotifyOnCopy, "Click here to Toggle Notify of Copy on/off");
            this.cbxNotifyOnCopy.UseVisualStyleBackColor = true;
            // 
            // btnClearJtoC
            // 
            this.btnClearJtoC.Location = new System.Drawing.Point(636, 35);
            this.btnClearJtoC.Name = "btnClearJtoC";
            this.btnClearJtoC.Size = new System.Drawing.Size(28, 26);
            this.btnClearJtoC.TabIndex = 15;
            this.btnClearJtoC.Text = "X";
            this.ttTips.SetToolTip(this.btnClearJtoC, "Click here to Clear Julian to Calendar Date choices");
            this.btnClearJtoC.UseVisualStyleBackColor = true;
            // 
            // lblCalendarOutput
            // 
            this.lblCalendarOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCalendarOutput.Location = new System.Drawing.Point(414, 35);
            this.lblCalendarOutput.Name = "lblCalendarOutput";
            this.lblCalendarOutput.Size = new System.Drawing.Size(215, 26);
            this.lblCalendarOutput.TabIndex = 14;
            this.ttTips.SetToolTip(this.lblCalendarOutput, "Displays the converted Julian Date as a Calender Date, Double click to copy to th" +
        "e clipboard");
            // 
            // btnJulianToCalendar
            // 
            this.btnJulianToCalendar.Location = new System.Drawing.Point(108, 35);
            this.btnJulianToCalendar.Name = "btnJulianToCalendar";
            this.btnJulianToCalendar.Size = new System.Drawing.Size(306, 26);
            this.btnJulianToCalendar.TabIndex = 13;
            this.btnJulianToCalendar.Text = "Click here to Convert &Julian to Calendar date->";
            this.ttTips.SetToolTip(this.btnJulianToCalendar, "Converts a Julian Date to a Calendar date");
            this.btnJulianToCalendar.UseVisualStyleBackColor = true;
            this.btnJulianToCalendar.Click += new System.EventHandler(this.btnJulianToCalendar_Click);
            // 
            // txtJulianInput
            // 
            this.txtJulianInput.Location = new System.Drawing.Point(6, 35);
            this.txtJulianInput.Name = "txtJulianInput";
            this.txtJulianInput.Size = new System.Drawing.Size(100, 26);
            this.txtJulianInput.TabIndex = 12;
            this.ttTips.SetToolTip(this.txtJulianInput, "Enter a Julian Date to convert");
            // 
            // lblJulianDate
            // 
            this.lblJulianDate.AutoSize = true;
            this.lblJulianDate.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJulianDate.Location = new System.Drawing.Point(176, 393);
            this.lblJulianDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJulianDate.Name = "lblJulianDate";
            this.lblJulianDate.Size = new System.Drawing.Size(148, 29);
            this.lblJulianDate.TabIndex = 5;
            this.lblJulianDate.Text = "Julian Date:";
            this.lblJulianDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblJulianDateOutput
            // 
            this.lblJulianDateOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJulianDateOutput.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJulianDateOutput.Location = new System.Drawing.Point(322, 393);
            this.lblJulianDateOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJulianDateOutput.Name = "lblJulianDateOutput";
            this.lblJulianDateOutput.Size = new System.Drawing.Size(163, 29);
            this.lblJulianDateOutput.TabIndex = 6;
            this.lblJulianDateOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttTips.SetToolTip(this.lblJulianDateOutput, "The currently selected Date in Julian Date Format");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSetFormat,
            this.mnuDarkMode,
            this.mnuHelp,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSetFormat
            // 
            this.mnuSetFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDDD,
            this.mnuYYDDD,
            this.mnuYY_DDD,
            this.mnuYYYYDDD,
            this.mnuYYYY_DDD});
            this.mnuSetFormat.Name = "mnuSetFormat";
            this.mnuSetFormat.Size = new System.Drawing.Size(104, 23);
            this.mnuSetFormat.Text = "&Set Format";
            this.mnuSetFormat.ToolTipText = "Click here to to see Julian Date Formatting Options";
            // 
            // mnuDDD
            // 
            this.mnuDDD.Checked = true;
            this.mnuDDD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuDDD.Name = "mnuDDD";
            this.mnuDDD.Size = new System.Drawing.Size(180, 24);
            this.mnuDDD.Text = "DDD";
            this.mnuDDD.Click += new System.EventHandler(this.mnuDDD_Click);
            // 
            // mnuYYDDD
            // 
            this.mnuYYDDD.Name = "mnuYYDDD";
            this.mnuYYDDD.Size = new System.Drawing.Size(180, 24);
            this.mnuYYDDD.Text = "YYDDD";
            this.mnuYYDDD.Click += new System.EventHandler(this.mnuYYDDD_Click);
            // 
            // mnuYY_DDD
            // 
            this.mnuYY_DDD.Name = "mnuYY_DDD";
            this.mnuYY_DDD.Size = new System.Drawing.Size(180, 24);
            this.mnuYY_DDD.Text = "YY DDD";
            this.mnuYY_DDD.Click += new System.EventHandler(this.YY_DDD_Click);
            // 
            // mnuYYYYDDD
            // 
            this.mnuYYYYDDD.Name = "mnuYYYYDDD";
            this.mnuYYYYDDD.Size = new System.Drawing.Size(180, 24);
            this.mnuYYYYDDD.Text = "YYYYDDD";
            this.mnuYYYYDDD.Click += new System.EventHandler(this.mnuYYYYDDD_Click);
            // 
            // mnuYYYY_DDD
            // 
            this.mnuYYYY_DDD.Name = "mnuYYYY_DDD";
            this.mnuYYYY_DDD.Size = new System.Drawing.Size(180, 24);
            this.mnuYYYY_DDD.Text = "YYYY DDD";
            this.mnuYYYY_DDD.Click += new System.EventHandler(this.mnuYYYY_DDD_Click);
            // 
            // mnuDarkMode
            // 
            this.mnuDarkMode.Name = "mnuDarkMode";
            this.mnuDarkMode.Size = new System.Drawing.Size(104, 23);
            this.mnuDarkMode.Text = "Dark-&Mode";
            this.mnuDarkMode.ToolTipText = "Click here to Temporarily turn on program specific Dark Mode";
            this.mnuDarkMode.Click += new System.EventHandler(this.mnuDarkMode_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUserGuide,
            this.mnuHelpWebsite,
            this.toolStripSeparator1,
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(56, 23);
            this.mnuHelp.Text = "&Help";
            this.mnuHelp.ToolTipText = "Click here to for Help";
            // 
            // mnuHelpWebsite
            // 
            this.mnuHelpWebsite.Name = "mnuHelpWebsite";
            this.mnuHelpWebsite.Size = new System.Drawing.Size(191, 24);
            this.mnuHelpWebsite.Text = "Help &Website";
            this.mnuHelpWebsite.Click += new System.EventHandler(this.mnuHelpWebsite_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(191, 24);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(50, 23);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblSelectedFormat
            // 
            this.lblSelectedFormat.AutoSize = true;
            this.lblSelectedFormat.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedFormat.Location = new System.Drawing.Point(5, 351);
            this.lblSelectedFormat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedFormat.Name = "lblSelectedFormat";
            this.lblSelectedFormat.Size = new System.Drawing.Size(319, 29);
            this.lblSelectedFormat.TabIndex = 3;
            this.lblSelectedFormat.Text = "Currently Selected Format:";
            this.lblSelectedFormat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpLookup
            // 
            this.grpLookup.Controls.Add(this.btnFind);
            this.grpLookup.Controls.Add(this.lblSearchDate);
            this.grpLookup.Controls.Add(this.mtbDate);
            this.grpLookup.Controls.Add(this.dtpDate);
            this.grpLookup.Location = new System.Drawing.Point(24, 200);
            this.grpLookup.Name = "grpLookup";
            this.grpLookup.Size = new System.Drawing.Size(670, 133);
            this.grpLookup.TabIndex = 2;
            this.grpLookup.TabStop = false;
            this.grpLookup.Text = "Date Search:";
            // 
            // lblSearchDate
            // 
            this.lblSearchDate.AutoSize = true;
            this.lblSearchDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchDate.Location = new System.Drawing.Point(146, 28);
            this.lblSearchDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSearchDate.Name = "lblSearchDate";
            this.lblSearchDate.Size = new System.Drawing.Size(88, 19);
            this.lblSearchDate.TabIndex = 4;
            this.lblSearchDate.Text = "Find &Date:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 541);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(704, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel1.Text = "   ";
            // 
            // grpConvertJulianToCalendarDate
            // 
            this.grpConvertJulianToCalendarDate.Controls.Add(this.btnClearJtoC);
            this.grpConvertJulianToCalendarDate.Controls.Add(this.lblCalendarOutput);
            this.grpConvertJulianToCalendarDate.Controls.Add(this.btnJulianToCalendar);
            this.grpConvertJulianToCalendarDate.Controls.Add(this.txtJulianInput);
            this.grpConvertJulianToCalendarDate.Location = new System.Drawing.Point(24, 459);
            this.grpConvertJulianToCalendarDate.Name = "grpConvertJulianToCalendarDate";
            this.grpConvertJulianToCalendarDate.Size = new System.Drawing.Size(670, 79);
            this.grpConvertJulianToCalendarDate.TabIndex = 9;
            this.grpConvertJulianToCalendarDate.TabStop = false;
            this.grpConvertJulianToCalendarDate.Text = "Convert Julian to Calendar Date";
            // 
            // mnuUserGuide
            // 
            this.mnuUserGuide.Name = "mnuUserGuide";
            this.mnuUserGuide.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuUserGuide.Size = new System.Drawing.Size(191, 24);
            this.mnuUserGuide.Text = "&User Guide";
            this.mnuUserGuide.Click += new System.EventHandler(this.mnuUserGuide_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnCopy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(704, 563);
            this.Controls.Add(this.grpConvertJulianToCalendarDate);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cbxNotifyOnCopy);
            this.Controls.Add(this.grpLookup);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lblSelectedFormatOutput);
            this.Controls.Add(this.lblSelectedFormat);
            this.Controls.Add(this.lblJulianDateOutput);
            this.Controls.Add(this.lblJulianDate);
            this.Controls.Add(this.calMonth);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar Date To Julian Date";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpLookup.ResumeLayout(false);
            this.grpLookup.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpConvertJulianToCalendarDate.ResumeLayout(false);
            this.grpConvertJulianToCalendarDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar calMonth;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolTip ttTips;
        private System.Windows.Forms.Label lblJulianDate;
        private System.Windows.Forms.Label lblJulianDateOutput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSetFormat;
        private System.Windows.Forms.ToolStripMenuItem mnuDDD;
        private System.Windows.Forms.ToolStripMenuItem mnuYYDDD;
        private System.Windows.Forms.ToolStripMenuItem mnuYY_DDD;
        private System.Windows.Forms.ToolStripMenuItem mnuYYYYDDD;
        private System.Windows.Forms.ToolStripMenuItem mnuYYYY_DDD;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.Label lblSelectedFormatOutput;
        private System.Windows.Forms.Label lblSelectedFormat;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.GroupBox grpLookup;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblSearchDate;
        private System.Windows.Forms.MaskedTextBox mtbDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.CheckBox cbxNotifyOnCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpWebsite;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuDarkMode;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox grpConvertJulianToCalendarDate;
        private System.Windows.Forms.Label lblCalendarOutput;
        private System.Windows.Forms.Button btnJulianToCalendar;
        private System.Windows.Forms.TextBox txtJulianInput;
        private System.Windows.Forms.Button btnClearJtoC;
        private System.Windows.Forms.ToolStripMenuItem mnuUserGuide;
        }
}