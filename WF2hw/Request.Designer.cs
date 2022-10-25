namespace WF2hw
{
    partial class Req
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Req));
            this.req_gb = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CityComBox = new System.Windows.Forms.ComboBox();
            this.Country_combox = new System.Windows.Forms.ComboBox();
            this.PhoneNoTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.Patronimic = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.City_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.req_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // req_gb
            // 
            this.req_gb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.req_gb.Controls.Add(this.button1);
            this.req_gb.Controls.Add(this.radioButton2);
            this.req_gb.Controls.Add(this.radioButton1);
            this.req_gb.Controls.Add(this.label5);
            this.req_gb.Controls.Add(this.label7);
            this.req_gb.Controls.Add(this.dateTimePicker1);
            this.req_gb.Controls.Add(this.CityComBox);
            this.req_gb.Controls.Add(this.Country_combox);
            this.req_gb.Controls.Add(this.PhoneNoTxtBox);
            this.req_gb.Controls.Add(this.Patronimic);
            this.req_gb.Controls.Add(this.name);
            this.req_gb.Controls.Add(this.Surname);
            this.req_gb.Controls.Add(this.label4);
            this.req_gb.Controls.Add(this.City_label);
            this.req_gb.Controls.Add(this.label6);
            this.req_gb.Controls.Add(this.label3);
            this.req_gb.Controls.Add(this.label2);
            this.req_gb.Controls.Add(this.label1);
            this.req_gb.Location = new System.Drawing.Point(12, 12);
            this.req_gb.Name = "req_gb";
            this.req_gb.Size = new System.Drawing.Size(236, 299);
            this.req_gb.TabIndex = 0;
            this.req_gb.TabStop = false;
            this.req_gb.Text = "Request";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 17;
            this.button1.Text = "Proceed";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(125, 250);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 17);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(71, 250);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Birth Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 224);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 10, 24, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Value = new System.DateTime(2022, 10, 24, 0, 0, 0, 0);
            // 
            // CityComBox
            // 
            this.CityComBox.FormattingEnabled = true;
            this.CityComBox.Location = new System.Drawing.Point(71, 148);
            this.CityComBox.Name = "CityComBox";
            this.CityComBox.Size = new System.Drawing.Size(150, 21);
            this.CityComBox.TabIndex = 11;
            // 
            // Country_combox
            // 
            this.Country_combox.FormattingEnabled = true;
            this.Country_combox.Location = new System.Drawing.Point(71, 121);
            this.Country_combox.Name = "Country_combox";
            this.Country_combox.Size = new System.Drawing.Size(150, 21);
            this.Country_combox.TabIndex = 10;
            // 
            // PhoneNoTxtBox
            // 
            this.PhoneNoTxtBox.Location = new System.Drawing.Point(71, 175);
            this.PhoneNoTxtBox.Mask = "(999) 000-0000";
            this.PhoneNoTxtBox.Name = "PhoneNoTxtBox";
            this.PhoneNoTxtBox.Size = new System.Drawing.Size(150, 20);
            this.PhoneNoTxtBox.TabIndex = 9;
            // 
            // Patronimic
            // 
            this.Patronimic.Location = new System.Drawing.Point(71, 76);
            this.Patronimic.Name = "Patronimic";
            this.Patronimic.Size = new System.Drawing.Size(150, 20);
            this.Patronimic.TabIndex = 8;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(71, 50);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(150, 20);
            this.name.TabIndex = 7;
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(71, 24);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(150, 20);
            this.Surname.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone No.";
            // 
            // City_label
            // 
            this.City_label.AutoSize = true;
            this.City_label.Location = new System.Drawing.Point(6, 151);
            this.City_label.Name = "City_label";
            this.City_label.Size = new System.Drawing.Size(24, 13);
            this.City_label.TabIndex = 4;
            this.City_label.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Patronimic";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surname";
            // 
            // Req
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 323);
            this.Controls.Add(this.req_gb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Req";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Request";
            this.req_gb.ResumeLayout(false);
            this.req_gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox req_gb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox CityComBox;
        private System.Windows.Forms.ComboBox Country_combox;
        private System.Windows.Forms.MaskedTextBox PhoneNoTxtBox;
        private System.Windows.Forms.TextBox Patronimic;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label City_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
    }
}

