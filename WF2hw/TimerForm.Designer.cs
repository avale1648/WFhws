namespace WF2hw
{
    partial class TimerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerForm));
            this.presetsGroupBox = new System.Windows.Forms.GroupBox();
            this.minuteCustomRadioButton = new System.Windows.Forms.RadioButton();
            this.minute15RadioButton = new System.Windows.Forms.RadioButton();
            this.minute10RadioButton = new System.Windows.Forms.RadioButton();
            this.minute5RadioButton = new System.Windows.Forms.RadioButton();
            this.minute3RadioButton = new System.Windows.Forms.RadioButton();
            this.minute1RadioButton = new System.Windows.Forms.RadioButton();
            this.hourNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minuteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.secondNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.presetsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hourNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // presetsGroupBox
            // 
            this.presetsGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.presetsGroupBox.Controls.Add(this.minuteCustomRadioButton);
            this.presetsGroupBox.Controls.Add(this.minute15RadioButton);
            this.presetsGroupBox.Controls.Add(this.minute10RadioButton);
            this.presetsGroupBox.Controls.Add(this.minute5RadioButton);
            this.presetsGroupBox.Controls.Add(this.minute3RadioButton);
            this.presetsGroupBox.Controls.Add(this.minute1RadioButton);
            this.presetsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.presetsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.presetsGroupBox.Name = "presetsGroupBox";
            this.presetsGroupBox.Size = new System.Drawing.Size(410, 50);
            this.presetsGroupBox.TabIndex = 0;
            this.presetsGroupBox.TabStop = false;
            this.presetsGroupBox.Text = "Presets";
            // 
            // minuteCustomRadioButton
            // 
            this.minuteCustomRadioButton.AutoSize = true;
            this.minuteCustomRadioButton.Location = new System.Drawing.Point(323, 19);
            this.minuteCustomRadioButton.Name = "minuteCustomRadioButton";
            this.minuteCustomRadioButton.Size = new System.Drawing.Size(79, 19);
            this.minuteCustomRadioButton.TabIndex = 1;
            this.minuteCustomRadioButton.TabStop = true;
            this.minuteCustomRadioButton.Text = "Custom...";
            this.minuteCustomRadioButton.UseVisualStyleBackColor = true;
            this.minuteCustomRadioButton.CheckedChanged += new System.EventHandler(this.minuteCustomRadioButton_CheckedChanged);
            // 
            // minute15RadioButton
            // 
            this.minute15RadioButton.AutoSize = true;
            this.minute15RadioButton.Location = new System.Drawing.Point(256, 19);
            this.minute15RadioButton.Name = "minute15RadioButton";
            this.minute15RadioButton.Size = new System.Drawing.Size(61, 19);
            this.minute15RadioButton.TabIndex = 1;
            this.minute15RadioButton.TabStop = true;
            this.minute15RadioButton.Text = "15 min";
            this.minute15RadioButton.UseVisualStyleBackColor = true;
            this.minute15RadioButton.CheckedChanged += new System.EventHandler(this.minute15RadioButton_CheckedChanged);
            // 
            // minute10RadioButton
            // 
            this.minute10RadioButton.AutoSize = true;
            this.minute10RadioButton.Location = new System.Drawing.Point(189, 19);
            this.minute10RadioButton.Name = "minute10RadioButton";
            this.minute10RadioButton.Size = new System.Drawing.Size(61, 19);
            this.minute10RadioButton.TabIndex = 1;
            this.minute10RadioButton.TabStop = true;
            this.minute10RadioButton.Text = "10 min";
            this.minute10RadioButton.UseVisualStyleBackColor = true;
            this.minute10RadioButton.CheckedChanged += new System.EventHandler(this.minute10RadioButton_CheckedChanged);
            // 
            // minute5RadioButton
            // 
            this.minute5RadioButton.AutoSize = true;
            this.minute5RadioButton.Location = new System.Drawing.Point(128, 19);
            this.minute5RadioButton.Name = "minute5RadioButton";
            this.minute5RadioButton.Size = new System.Drawing.Size(55, 19);
            this.minute5RadioButton.TabIndex = 1;
            this.minute5RadioButton.TabStop = true;
            this.minute5RadioButton.Text = "5 min";
            this.minute5RadioButton.UseVisualStyleBackColor = true;
            this.minute5RadioButton.CheckedChanged += new System.EventHandler(this.minute5RadioButton_CheckedChanged);
            // 
            // minute3RadioButton
            // 
            this.minute3RadioButton.AutoSize = true;
            this.minute3RadioButton.Location = new System.Drawing.Point(67, 19);
            this.minute3RadioButton.Name = "minute3RadioButton";
            this.minute3RadioButton.Size = new System.Drawing.Size(55, 19);
            this.minute3RadioButton.TabIndex = 1;
            this.minute3RadioButton.TabStop = true;
            this.minute3RadioButton.Text = "3 min";
            this.minute3RadioButton.UseVisualStyleBackColor = true;
            this.minute3RadioButton.CheckedChanged += new System.EventHandler(this.minute3RadioButton_CheckedChanged);
            // 
            // minute1RadioButton
            // 
            this.minute1RadioButton.AutoSize = true;
            this.minute1RadioButton.Location = new System.Drawing.Point(6, 19);
            this.minute1RadioButton.Name = "minute1RadioButton";
            this.minute1RadioButton.Size = new System.Drawing.Size(55, 19);
            this.minute1RadioButton.TabIndex = 0;
            this.minute1RadioButton.TabStop = true;
            this.minute1RadioButton.Text = "1 min";
            this.minute1RadioButton.UseVisualStyleBackColor = true;
            this.minute1RadioButton.CheckedChanged += new System.EventHandler(this.minute1RadioButton_CheckedChanged);
            // 
            // hourNumericUpDown
            // 
            this.hourNumericUpDown.Location = new System.Drawing.Point(40, 74);
            this.hourNumericUpDown.Name = "hourNumericUpDown";
            this.hourNumericUpDown.Size = new System.Drawing.Size(55, 20);
            this.hourNumericUpDown.TabIndex = 1;
            // 
            // minuteNumericUpDown
            // 
            this.minuteNumericUpDown.Location = new System.Drawing.Point(40, 100);
            this.minuteNumericUpDown.Name = "minuteNumericUpDown";
            this.minuteNumericUpDown.Size = new System.Drawing.Size(55, 20);
            this.minuteNumericUpDown.TabIndex = 2;
            // 
            // secondNumericUpDown
            // 
            this.secondNumericUpDown.Location = new System.Drawing.Point(40, 126);
            this.secondNumericUpDown.Name = "secondNumericUpDown";
            this.secondNumericUpDown.Size = new System.Drawing.Size(55, 20);
            this.secondNumericUpDown.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.timeLabel);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(182, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 81);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Times Left";
            // 
            // timeLabel
            // 
            this.timeLabel.Location = new System.Drawing.Point(6, 16);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(228, 59);
            this.timeLabel.TabIndex = 9;
            this.timeLabel.Text = "00:00:00";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(101, 72);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(101, 97);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(101, 123);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "H:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "M:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "S:";
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(435, 161);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.secondNumericUpDown);
            this.Controls.Add(this.minuteNumericUpDown);
            this.Controls.Add(this.hourNumericUpDown);
            this.Controls.Add(this.presetsGroupBox);
            this.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TimerForm";
            this.Text = "Timer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimerForm_FormClosing);
            this.Load += new System.EventHandler(this.TimerForm_Load);
            this.presetsGroupBox.ResumeLayout(false);
            this.presetsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hourNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox presetsGroupBox;
        private System.Windows.Forms.RadioButton minuteCustomRadioButton;
        private System.Windows.Forms.RadioButton minute15RadioButton;
        private System.Windows.Forms.RadioButton minute10RadioButton;
        private System.Windows.Forms.RadioButton minute5RadioButton;
        private System.Windows.Forms.RadioButton minute3RadioButton;
        private System.Windows.Forms.RadioButton minute1RadioButton;
        private System.Windows.Forms.NumericUpDown hourNumericUpDown;
        private System.Windows.Forms.NumericUpDown minuteNumericUpDown;
        private System.Windows.Forms.NumericUpDown secondNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}