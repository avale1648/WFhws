using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF2hw
{
    public partial class MouseCoordinates : Form
    {
        public MouseCoordinates()
        {
            InitializeComponent();
        }
        private void Form1_MouseClick(object sender, MouseEventArgs mE)
        {
            KeyEventArgs kE = new KeyEventArgs(Keys.ControlKey);
            Text += ", Click";
            if (kE.Equals(Keys.ControlKey) && mE.Button == MouseButtons.Left)
                Close();
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = $"{Cursor.Position}";
            if ((Cursor.Position.X > label1.Location.X && Cursor.Position.Y > label1.Location.X)
                || (Cursor.Position.X <= label1.Location.X + label1.Width && Cursor.Position.Y <= label1.Location.X + label1.Height))
                Text += "The Label";
            else
                Text += "The Form";
        }
    }
}
