namespace WF2hw
{
    partial class Timer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timer));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Presets = new System.Windows.Forms.GroupBox();
            this.Custom = new System.Windows.Forms.RadioButton();
            this.FifteenMinutes = new System.Windows.Forms.RadioButton();
            this.TenMinutes = new System.Windows.Forms.RadioButton();
            this.FiveMinutes = new System.Windows.Forms.RadioButton();
            this.ThreeMinutes = new System.Windows.Forms.RadioButton();
            this.OneMinute = new System.Windows.Forms.RadioButton();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Hours = new System.Windows.Forms.NumericUpDown();
            this.Minutes = new System.Windows.Forms.NumericUpDown();
            this.Seconds = new System.Windows.Forms.NumericUpDown();
            this.TimeLeft = new System.Windows.Forms.GroupBox();
            this.Time = new System.Windows.Forms.Label();
            this.Presets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Seconds)).BeginInit();
            this.TimeLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Presets
            // 
            this.Presets.Controls.Add(this.Custom);
            this.Presets.Controls.Add(this.FifteenMinutes);
            this.Presets.Controls.Add(this.TenMinutes);
            this.Presets.Controls.Add(this.FiveMinutes);
            this.Presets.Controls.Add(this.ThreeMinutes);
            this.Presets.Controls.Add(this.OneMinute);
            this.Presets.Location = new System.Drawing.Point(12, 12);
            this.Presets.Name = "Presets";
            this.Presets.Size = new System.Drawing.Size(369, 50);
            this.Presets.TabIndex = 0;
            this.Presets.TabStop = false;
            this.Presets.Text = "Presets";
            // 
            // Custom
            // 
            this.Custom.AutoSize = true;
            this.Custom.Location = new System.Drawing.Point(303, 19);
            this.Custom.Name = "Custom";
            this.Custom.Size = new System.Drawing.Size(60, 17);
            this.Custom.TabIndex = 5;
            this.Custom.TabStop = true;
            this.Custom.Text = "Custom";
            this.Custom.UseVisualStyleBackColor = true;
            this.Custom.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // FifteenMinutes
            // 
            this.FifteenMinutes.AutoSize = true;
            this.FifteenMinutes.Location = new System.Drawing.Point(241, 19);
            this.FifteenMinutes.Name = "FifteenMinutes";
            this.FifteenMinutes.Size = new System.Drawing.Size(56, 17);
            this.FifteenMinutes.TabIndex = 4;
            this.FifteenMinutes.TabStop = true;
            this.FifteenMinutes.Text = "15 min";
            this.FifteenMinutes.UseVisualStyleBackColor = true;
            this.FifteenMinutes.CheckedChanged += new System.EventHandler(this.FifteenMinutes_CheckedChanged);
            // 
            // TenMinutes
            // 
            this.TenMinutes.AutoSize = true;
            this.TenMinutes.Location = new System.Drawing.Point(179, 19);
            this.TenMinutes.Name = "TenMinutes";
            this.TenMinutes.Size = new System.Drawing.Size(56, 17);
            this.TenMinutes.TabIndex = 3;
            this.TenMinutes.TabStop = true;
            this.TenMinutes.Text = "10 min";
            this.TenMinutes.UseVisualStyleBackColor = true;
            this.TenMinutes.CheckedChanged += new System.EventHandler(this.TenMinutes_CheckedChanged);
            // 
            // FiveMinutes
            // 
            this.FiveMinutes.AutoSize = true;
            this.FiveMinutes.Location = new System.Drawing.Point(123, 19);
            this.FiveMinutes.Name = "FiveMinutes";
            this.FiveMinutes.Size = new System.Drawing.Size(50, 17);
            this.FiveMinutes.TabIndex = 2;
            this.FiveMinutes.TabStop = true;
            this.FiveMinutes.Text = "5 min";
            this.FiveMinutes.UseVisualStyleBackColor = true;
            this.FiveMinutes.CheckedChanged += new System.EventHandler(this.FiveMinutes_CheckedChanged);
            // 
            // ThreeMinutes
            // 
            this.ThreeMinutes.AutoSize = true;
            this.ThreeMinutes.Location = new System.Drawing.Point(67, 19);
            this.ThreeMinutes.Name = "ThreeMinutes";
            this.ThreeMinutes.Size = new System.Drawing.Size(50, 17);
            this.ThreeMinutes.TabIndex = 1;
            this.ThreeMinutes.TabStop = true;
            this.ThreeMinutes.Text = "3 min";
            this.ThreeMinutes.UseVisualStyleBackColor = true;
            this.ThreeMinutes.CheckedChanged += new System.EventHandler(this.ThreeMinutes_CheckedChanged);
            // 
            // OneMinute
            // 
            this.OneMinute.AutoSize = true;
            this.OneMinute.Location = new System.Drawing.Point(11, 19);
            this.OneMinute.Name = "OneMinute";
            this.OneMinute.Size = new System.Drawing.Size(50, 17);
            this.OneMinute.TabIndex = 0;
            this.OneMinute.TabStop = true;
            this.OneMinute.Text = "1 min";
            this.OneMinute.UseVisualStyleBackColor = true;
            this.OneMinute.CheckedChanged += new System.EventHandler(this.OneMinute_CheckedChanged);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(306, 68);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(306, 97);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 2;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(306, 126);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Hours
            // 
            this.Hours.Enabled = false;
            this.Hours.Location = new System.Drawing.Point(23, 71);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(50, 20);
            this.Hours.TabIndex = 4;
            // 
            // Minutes
            // 
            this.Minutes.Enabled = false;
            this.Minutes.Location = new System.Drawing.Point(79, 71);
            this.Minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(50, 20);
            this.Minutes.TabIndex = 5;
            // 
            // Seconds
            // 
            this.Seconds.Enabled = false;
            this.Seconds.Location = new System.Drawing.Point(135, 71);
            this.Seconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(50, 20);
            this.Seconds.TabIndex = 6;
            // 
            // TimeLeft
            // 
            this.TimeLeft.Controls.Add(this.Time);
            this.TimeLeft.Location = new System.Drawing.Point(12, 99);
            this.TimeLeft.Name = "TimeLeft";
            this.TimeLeft.Size = new System.Drawing.Size(288, 49);
            this.TimeLeft.TabIndex = 7;
            this.TimeLeft.TabStop = false;
            this.TimeLeft.Text = "Time Left";
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(6, 16);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(276, 18);
            this.Time.TabIndex = 0;
            this.Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 160);
            this.Controls.Add(this.TimeLeft);
            this.Controls.Add(this.Seconds);
            this.Controls.Add(this.Minutes);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Presets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Timer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.Presets.ResumeLayout(false);
            this.Presets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Seconds)).EndInit();
            this.TimeLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox Presets;
        private System.Windows.Forms.RadioButton Custom;
        private System.Windows.Forms.RadioButton FifteenMinutes;
        private System.Windows.Forms.RadioButton TenMinutes;
        private System.Windows.Forms.RadioButton FiveMinutes;
        private System.Windows.Forms.RadioButton ThreeMinutes;
        private System.Windows.Forms.RadioButton OneMinute;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.NumericUpDown Hours;
        private System.Windows.Forms.NumericUpDown Minutes;
        private System.Windows.Forms.NumericUpDown Seconds;
        private System.Windows.Forms.GroupBox TimeLeft;
        private System.Windows.Forms.Label Time;
    }
}