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
            KeyEventArgs kE = new KeyEventArgs(Keys.Control);
            Text += ", Click";
            if (kE.Control && mE.Button == MouseButtons.Left)
                Close();
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int X = label1.Location.X, Y = label1.Location.Y, label1AB = 100, border = 5;
            Text = $"{Cursor.Position}";
            if ((Cursor.Position.X > X && Cursor.Position.Y > Y)
                || (Cursor.Position.X < X + border && Cursor.Position.Y < Y + border))
                Text += "The Label's Border";
            else if ((Cursor.Position.X > X && Cursor.Position.Y > Y)
                || (Cursor.Position.X < X + label1AB && Cursor.Position.Y < Y + label1AB))
                Text += "The Label";
            else
                Text += "The Form";
        }
    }
}
