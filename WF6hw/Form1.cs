using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF6hw
{
    public partial class Form1 : Form
    {
        private Bitmap bitmap = null;
        private Graphics graphics = null;
        private bool isMouseDown = false;
        private Point pX, pY;
        private Pen pen = new Pen(Color.Black, 1);
        private Pen rubber = new Pen(Color.White, 5);
        private string option = string.Empty;
        private int x, y, sX, sY, cX, cY;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pictureBox1.Image = bitmap;
            option = buttonPen.Text;
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = !isMouseDown;
            pY = e.Location;

            cX = e.X;
            cY = e.Y;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                if (option == buttonPen.Text)
                {
                    pX = e.Location;
                    graphics.DrawLine(pen, pX, pY);
                    pY = pX;
                }
                if (option == buttonRubber.Text)
                {
                    pX = e.Location;
                    graphics.DrawLine(rubber, pX, pY);
                    pY = pX;
                }
            }
            pictureBox1.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.X - cY;
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = !isMouseDown;

            sX = x - cX;
            sY = y - cY;

            if(option == buttonEllipse.Text)
                graphics.DrawEllipse(pen, cX,cY,sX,sY);
            if(option == buttonRectangle.Text)
                graphics.DrawRectangle(pen, cX,cY,sX,sY);
            if (option == buttonLine.Text)
                graphics.DrawLine(pen, cX, cY, x, y);
        }
        private void buttonPen_Click(object sender, EventArgs e)
        {
            option = buttonPen.Text;
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics preview = e.Graphics;
            if(isMouseDown)
            {
                if (option == buttonEllipse.Text)
                    preview.DrawEllipse(pen, cX, cY, sX, sY);
                if (option == buttonRectangle.Text)
                    preview.DrawRectangle(pen, cX, cY, sX, sY);
                if (option == buttonLine.Text)
                    preview.DrawLine(pen, cX, cY, x, y);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
            rubber.Width = trackBar1.Value;
        }
        private void buttonRubber_Click(object sender, EventArgs e)
        {
            option = buttonRubber.Text;
        }
        private void buttonFill_Click(object sender, EventArgs e)
        {
            option = buttonFill.Text;
        }
        private void buttonLine_Click(object sender, EventArgs e)
        {
            option = buttonLine.Text;
        }
        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            option = buttonRectangle.Text;
        }
        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            option = buttonEllipse.Text;
        }
        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button21.BackColor = button14.BackColor;
            pen.Color = button14.ForeColor;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button21.BackColor = button12.BackColor;
            pen.Color = button12.ForeColor;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button21.BackColor = button13.BackColor;
            pen.Color = button13.ForeColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button21.BackColor = button2.BackColor;
            pen.Color = button2.ForeColor;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button21.BackColor = button15.BackColor;
            pen.Color = button15.ForeColor;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button21.BackColor = button16.BackColor;
            pen.Color = button16.ForeColor;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button21.BackColor = button17.BackColor;
            pen.Color = button17.ForeColor;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button21.BackColor = button18.BackColor;
            pen.Color = button18.ForeColor;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button21.BackColor = button19.BackColor;
            pen.Color = button19.ForeColor;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button21.BackColor = button20.BackColor;
            pen.Color = button20.ForeColor;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button21.BackColor = button10.BackColor;
            pen.Color = button10.ForeColor;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button21.BackColor = button9.BackColor;
            pen.Color = button9.ForeColor;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button21.BackColor = button8.BackColor;
            pen.Color = button8.ForeColor;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button21.BackColor = button7.BackColor;
            pen.Color = button7.ForeColor;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button21.BackColor = button6.BackColor;
            pen.Color = button6.ForeColor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button21.BackColor = button5.BackColor;
            pen.Color = button5.ForeColor;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button21.BackColor = button4.BackColor;
            pen.Color = button4.ForeColor;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button21.BackColor = button11.BackColor;
            pen.Color = button11.BackColor;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button21.BackColor = colorDialog1.Color;
                pen.Color = colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button21.BackColor = button3.BackColor;
            pen.Color = button3.ForeColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button21.BackColor = button1.BackColor;
            pen.Color = button1.ForeColor;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if(option == buttonFill.Text)
            {
                Point point = SetPoint(pictureBox1, e.Location);
                Fill(bitmap, point.X, point.Y, pen.Color);
            }
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Image (*.jpg) |*.jpg|(*.*|*.*";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap temp = bitmap.Clone(new Rectangle(0,0,pictureBox1.Width,pictureBox1.Height),
                    bitmap.PixelFormat);
                temp.Save(saveFileDialog1.FileName,ImageFormat.Jpeg);
            }
        }
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            pictureBox1.Image = bitmap;
            option = buttonPen.Text;
        }

        private static Point SetPoint(PictureBox pictureBox, Point point)
        {
            float pX = 1f * pictureBox.Width / pictureBox.Width;
            float pY = 1f * pictureBox.Height / pictureBox.Height;
            return new Point(Convert.ToInt32(point.X * pX), Convert.ToInt32(point.Y * pY));
        }
        private void Validate(Bitmap bitmap, Stack<Point> points, int x, int y,
            Color oldColour, Color newColour)
        {
            Color cx = bitmap.GetPixel(x, y);
            if(cx == oldColour)
            {
                points.Push(new Point(x, y));
                bitmap.SetPixel(x, y, newColour);
            }
        }
        private void Fill(Bitmap bitmap, int x, int y, Color newColour)
        {
            Color oldColour = bitmap.GetPixel(x, y);
            Stack<Point> points = new Stack<Point>();
            points.Push(new Point(x, y));
            bitmap.SetPixel(x,y,newColour);
            if (oldColour == newColour)
                return;
            while(points.Count > 0)
            {
                Point point = points.Pop();
                if(point.X > 0 && point.Y > 0 &&
                   point.X < bitmap.Width - 1 && point.Y < bitmap.Height - 1)
                {
                    Validate(bitmap, points, point.X - 1, point.Y, oldColour, newColour);
                    Validate(bitmap, points, point.X, point.Y - 1, oldColour, newColour);
                    Validate(bitmap, points, point.X + 1, point.Y, oldColour, newColour);
                    Validate(bitmap, points, point.X, point.Y + 1, oldColour, newColour);
                }
            }
        }
    }
}
