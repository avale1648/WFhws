using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF1._1hw_Maze_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            MoveToStart();
        }
        private void MoveToStart()
        {
            Point start = panel1.Location;
            start.Offset(25, 25);
            Cursor.Position = PointToScreen(start);
        }
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void Stop_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Maze 1 completed!");
            Close();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Cursor.Clip = Bounds;
        }
    }
}
