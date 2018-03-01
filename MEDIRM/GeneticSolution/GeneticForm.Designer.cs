namespace Scheduling
{
    partial class GeneticForm
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
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange11 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange12 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange13 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange14 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange15 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.resPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.popnmud = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.mutnmud = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupnmud = new System.Windows.Forms.NumericUpDown();
            this.lblSpan = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblIdleTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.namelabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBarFooter = new System.Windows.Forms.ToolStripProgressBar();
            this.lblProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBestTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.nmudMinTime = new System.Windows.Forms.NumericUpDown();
            this.cbCOTypes = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkRefresh = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbMutTypes = new System.Windows.Forms.ComboBox();
            this.cbSelTypes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWorkingTime = new System.Windows.Forms.Label();
            this.calendar1 = new System.Windows.Forms.Calendar.Calendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.resPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popnmud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutnmud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupnmud)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudMinTime)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.CausesValidation = false;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.ForeColor = System.Drawing.Color.Green;
            this.btnStart.Location = new System.Drawing.Point(7, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 37);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "RUN";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(88, 13);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 36);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // resPanel
            // 
            this.resPanel.BackColor = System.Drawing.Color.Transparent;
            this.resPanel.Controls.Add(this.panel1);
            this.resPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resPanel.Location = new System.Drawing.Point(3, 16);
            this.resPanel.Name = "resPanel";
            this.resPanel.Size = new System.Drawing.Size(1074, 196);
            this.resPanel.TabIndex = 7;
            this.resPanel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 143);
            this.panel1.TabIndex = 0;
            // 
            // popnmud
            // 
            this.popnmud.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.popnmud.Location = new System.Drawing.Point(106, 17);
            this.popnmud.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.popnmud.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.popnmud.Name = "popnmud";
            this.popnmud.Size = new System.Drawing.Size(75, 20);
            this.popnmud.TabIndex = 8;
            this.popnmud.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mutation(%):";
            // 
            // mutnmud
            // 
            this.mutnmud.Location = new System.Drawing.Point(106, 46);
            this.mutnmud.Name = "mutnmud";
            this.mutnmud.Size = new System.Drawing.Size(75, 20);
            this.mutnmud.TabIndex = 8;
            this.mutnmud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Group Size:";
            // 
            // groupnmud
            // 
            this.groupnmud.Location = new System.Drawing.Point(106, 72);
            this.groupnmud.Name = "groupnmud";
            this.groupnmud.Size = new System.Drawing.Size(75, 20);
            this.groupnmud.TabIndex = 8;
            this.groupnmud.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblSpan
            // 
            this.lblSpan.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblSpan.Name = "lblSpan";
            this.lblSpan.Size = new System.Drawing.Size(4, 17);
            // 
            // lblIdleTime
            // 
            this.lblIdleTime.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblIdleTime.Name = "lblIdleTime";
            this.lblIdleTime.Size = new System.Drawing.Size(4, 17);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.namelabel1,
            this.lblSpan,
            this.toolStripStatusLabel3,
            this.lblIdleTime,
            this.toolStripStatusLabel1,
            this.progressBarFooter,
            this.lblProgress,
            this.toolStripStatusLabel2,
            this.lblBestTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 772);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1087, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // namelabel1
            // 
            this.namelabel1.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.namelabel1.Name = "namelabel1";
            this.namelabel1.Size = new System.Drawing.Size(64, 17);
            this.namelabel1.Text = "Makespan:";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(88, 17);
            this.toolStripStatusLabel3.Text = "Total Idle Time:";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel1.Text = "Progress:";
            // 
            // progressBarFooter
            // 
            this.progressBarFooter.Name = "progressBarFooter";
            this.progressBarFooter.Size = new System.Drawing.Size(100, 16);
            // 
            // lblProgress
            // 
            this.lblProgress.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(4, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel2.Text = "Best found at:";
            // 
            // lblBestTime
            // 
            this.lblBestTime.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblBestTime.Name = "lblBestTime";
            this.lblBestTime.Size = new System.Drawing.Size(4, 17);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(213, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Min. Time(%):";
            // 
            // nmudMinTime
            // 
            this.nmudMinTime.Location = new System.Drawing.Point(306, 15);
            this.nmudMinTime.Name = "nmudMinTime";
            this.nmudMinTime.Size = new System.Drawing.Size(75, 20);
            this.nmudMinTime.TabIndex = 8;
            // 
            // cbCOTypes
            // 
            this.cbCOTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCOTypes.FormattingEnabled = true;
            this.cbCOTypes.Items.AddRange(new object[] {
            "Single Point",
            "Two-Point",
            "Uniform",
            "Ordered"});
            this.cbCOTypes.Location = new System.Drawing.Point(306, 97);
            this.cbCOTypes.Name = "cbCOTypes";
            this.cbCOTypes.Size = new System.Drawing.Size(121, 21);
            this.cbCOTypes.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(213, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Crossing Over:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkRefresh);
            this.groupBox1.Controls.Add(this.groupnmud);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbMutTypes);
            this.groupBox1.Controls.Add(this.cbSelTypes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbCOTypes);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nmudMinTime);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.popnmud);
            this.groupBox1.Controls.Add(this.mutnmud);
            this.groupBox1.Location = new System.Drawing.Point(169, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 17);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // chkRefresh
            // 
            this.chkRefresh.AutoSize = true;
            this.chkRefresh.Location = new System.Drawing.Point(26, 101);
            this.chkRefresh.Name = "chkRefresh";
            this.chkRefresh.Size = new System.Drawing.Size(116, 17);
            this.chkRefresh.TabIndex = 13;
            this.chkRefresh.Text = "Refresh Population";
            this.chkRefresh.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(213, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Mutation Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(213, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Selection Type:";
            // 
            // cbMutTypes
            // 
            this.cbMutTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMutTypes.FormattingEnabled = true;
            this.cbMutTypes.Items.AddRange(new object[] {
            "Exchange Values",
            "Change Value",
            "Slip Block",
            "Replacement"});
            this.cbMutTypes.Location = new System.Drawing.Point(306, 69);
            this.cbMutTypes.Name = "cbMutTypes";
            this.cbMutTypes.Size = new System.Drawing.Size(121, 21);
            this.cbMutTypes.TabIndex = 10;
            // 
            // cbSelTypes
            // 
            this.cbSelTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelTypes.FormattingEnabled = true;
            this.cbSelTypes.Items.AddRange(new object[] {
            "Tournament",
            "Roulette Wheel"});
            this.cbSelTypes.Location = new System.Drawing.Point(306, 42);
            this.cbSelTypes.Name = "cbSelTypes";
            this.cbSelTypes.Size = new System.Drawing.Size(121, 21);
            this.cbSelTypes.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Population:";
            // 
            // lblWorkingTime
            // 
            this.lblWorkingTime.AutoSize = true;
            this.lblWorkingTime.Location = new System.Drawing.Point(4, 518);
            this.lblWorkingTime.Name = "lblWorkingTime";
            this.lblWorkingTime.Size = new System.Drawing.Size(0, 13);
            this.lblWorkingTime.TabIndex = 15;
            // 
            // calendar1
            // 
            this.calendar1.AllowItemEdit = false;
            this.calendar1.AllowItemResize = false;
            this.calendar1.AllowNew = false;
            this.calendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendar1.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calendar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            calendarHighlightRange11.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange11.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange11.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange12.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange12.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange12.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange13.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange13.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange13.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange14.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange14.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange14.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange15.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange15.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange15.StartTime = System.TimeSpan.Parse("08:00:00");
            this.calendar1.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange11,
        calendarHighlightRange12,
        calendarHighlightRange13,
        calendarHighlightRange14,
        calendarHighlightRange15};
            this.calendar1.Location = new System.Drawing.Point(12, 275);
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(773, 484);
            this.calendar1.TabIndex = 16;
            this.calendar1.LoadItems += new System.Windows.Forms.Calendar.Calendar.CalendarLoadEventHandler(this.calendar1_LoadItems);
            this.calendar1.DayHeaderClick += new System.Windows.Forms.Calendar.Calendar.CalendarDayEventHandler(this.calendar1_DayHeaderClick);
            this.calendar1.ItemSelected += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.calendar1_ItemSelected);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.resPanel);
            this.groupBox2.Location = new System.Drawing.Point(7, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1080, 215);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Overtime Preview";
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreview.CausesValidation = false;
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPreview.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnPreview.Location = new System.Drawing.Point(791, 275);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(102, 37);
            this.btnPreview.TabIndex = 18;
            this.btnPreview.Text = "PREVIEW";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.propertyGrid1);
            this.groupBox3.Location = new System.Drawing.Point(791, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 441);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(3, 16);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(278, 422);
            this.propertyGrid1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.CausesValidation = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(970, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 37);
            this.button1.TabIndex = 20;
            this.button1.Text = "PDF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PDF_Click);
            // 
            // GeneticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 794);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.calendar1);
            this.Controls.Add(this.lblWorkingTime);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "GeneticForm";
            this.Text = "Genetic Scheduler";
            this.resPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popnmud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutnmud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupnmud)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudMinTime)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Panel resPanel;
        private System.Windows.Forms.NumericUpDown popnmud;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown mutnmud;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown groupnmud;
        private System.Windows.Forms.ToolStripStatusLabel lblSpan;
        private System.Windows.Forms.ToolStripStatusLabel lblIdleTime;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel namelabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmudMinTime;
        private System.Windows.Forms.ComboBox cbCOTypes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblProgress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbSelTypes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbMutTypes;
        private System.Windows.Forms.ToolStripStatusLabel lblBestTime;
        private System.Windows.Forms.Label lblWorkingTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkRefresh;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar progressBarFooter;
        private System.Windows.Forms.Calendar.Calendar calendar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button button1;
    }
}

