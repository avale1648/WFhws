namespace WF2hw
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toMessageBoxesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageBoxesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseCoordinatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toMessageBoxesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(180, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "Launch...";
            // 
            // toMessageBoxesToolStripMenuItem
            // 
            this.toMessageBoxesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageBoxesToolStripMenuItem,
            this.mouseCoordinatesToolStripMenuItem,
            this.timerToolStripMenuItem,
            this.requestToolStripMenuItem});
            this.toMessageBoxesToolStripMenuItem.Name = "toMessageBoxesToolStripMenuItem";
            this.toMessageBoxesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.toMessageBoxesToolStripMenuItem.Text = "Go to...";
            // 
            // messageBoxesToolStripMenuItem
            // 
            this.messageBoxesToolStripMenuItem.Name = "messageBoxesToolStripMenuItem";
            this.messageBoxesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.messageBoxesToolStripMenuItem.Text = "Message Boxes";
            this.messageBoxesToolStripMenuItem.Click += new System.EventHandler(this.messageBoxesToolStripMenuItem_Click);
            // 
            // mouseCoordinatesToolStripMenuItem
            // 
            this.mouseCoordinatesToolStripMenuItem.Name = "mouseCoordinatesToolStripMenuItem";
            this.mouseCoordinatesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mouseCoordinatesToolStripMenuItem.Text = "Mouse Coordinates";
            this.mouseCoordinatesToolStripMenuItem.Click += new System.EventHandler(this.mouseCoordinatesToolStripMenuItem_Click);
            // 
            // timerToolStripMenuItem
            // 
            this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            this.timerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.timerToolStripMenuItem.Text = "Timer";
            this.timerToolStripMenuItem.Click += new System.EventHandler(this.timerToolStripMenuItem_Click);
            // 
            // requestToolStripMenuItem
            // 
            this.requestToolStripMenuItem.Name = "requestToolStripMenuItem";
            this.requestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.requestToolStripMenuItem.Text = "Request";
            this.requestToolStripMenuItem.Click += new System.EventHandler(this.requestToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 194);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toMessageBoxesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageBoxesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouseCoordinatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

