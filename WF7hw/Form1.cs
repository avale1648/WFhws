using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF7hw
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Bitmap sky, plane, cloud, cloud2, cloud3;
        private Rectangle rectangle1;
        private Rectangle rectangle2;
        private Rectangle rectangle3;
        private Rectangle rectangle4;
        private Random random;
        private int dx;
        private int cx;

        Boolean isShow = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            graphics.DrawImage(sky, new Point(0, 0));
            if (rectangle1.X < ClientRectangle.Width || rectangle2.X > ClientRectangle.Width || rectangle3.X > ClientRectangle.Width || rectangle4.X > ClientRectangle.Width)
            {
                rectangle1.X += dx;
                rectangle2.X += cx;
                rectangle3.X += cx;
                rectangle4.X += cx;
            }
            else
            {
                rectangle1.X = -40;
                rectangle1.Y = 20 + random.Next(ClientSize.Height - 40 - plane.Height);
                dx = 2 + random.Next(5);

                rectangle2.X = 1000;
                rectangle2.Y = 20 + random.Next(ClientSize.Height - 40 - cloud.Height);
                cx = -2 - random.Next(5);

                rectangle3.X = 1100;
                rectangle3.Y = 40 + random.Next(ClientSize.Height - 20 - cloud.Height);
                cx = -2 - random.Next(6);

                rectangle4.X = 1100;
                rectangle4.Y = 40 + random.Next(ClientSize.Height - 20 - cloud.Height);
                cx = -2 - random.Next(6);

            }

            graphics.DrawImage(cloud2, rectangle3.X, rectangle3.Y);
            if (!isShow)
                Invalidate(rectangle3);
            else
            {
                Rectangle reg = new Rectangle(20, 20, sky.Width - 40, sky.Height - 40);
                graphics.DrawRectangle(Pens.Black, reg.X, reg.Y, reg.Width - 1, reg.Height - 1);
                Invalidate(reg);
            }

            graphics.DrawImage(plane, rectangle1.X, rectangle1.Y);
            if (!isShow)
                Invalidate(rectangle1);
            else
            {
                Rectangle reg = new Rectangle(20, 20, sky.Width - 40, sky.Height - 40);
                graphics.DrawRectangle(Pens.Black, reg.X, reg.Y, reg.Width - 1, reg.Height - 1);
                Invalidate(reg);
            }

            graphics.DrawImage(cloud, rectangle2.X, rectangle2.Y);
            if (!isShow)
                Invalidate(rectangle2);
            else
            {
                Rectangle reg = new Rectangle(20, 20, sky.Width - 40, sky.Height - 40);
                graphics.DrawRectangle(Pens.Black, reg.X, reg.Y, reg.Width - 1, reg.Height - 1);
                Invalidate(reg);
            }

            graphics.DrawImage(cloud3, rectangle4.X, rectangle4.Y);
            if (!isShow)
                Invalidate(rectangle4);
            else
            {
                Rectangle reg = new Rectangle(20, 20, sky.Width - 40, sky.Height - 40);
                graphics.DrawRectangle(Pens.Black, reg.X, reg.Y, reg.Width - 1, reg.Height - 1);
                Invalidate(reg);
            }

        }

        public Form1()
        {
            InitializeComponent();
            try
            {
                sky = new Bitmap("sky.bmp");
                plane = new Bitmap("plane.bmp");
                cloud = new Bitmap("cloud.png");
                cloud2 = new Bitmap("cloud.png");
                cloud3 = new Bitmap("cloud.png");
                BackgroundImage = new Bitmap("sky.bmp");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            plane.MakeTransparent();
            cloud.MakeTransparent();
            cloud2.MakeTransparent();
            cloud3.MakeTransparent();
            ClientSize = new Size(new Point(BackgroundImage.Width, BackgroundImage.Height));
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            graphics = Graphics.FromImage(BackgroundImage);
            random = new Random();
            rectangle1.X = -40;
            rectangle1.Y = 20 + random.Next(20);
            rectangle1.Width = plane.Width;
            rectangle1.Height = plane.Height;
            dx = 5;
            rectangle2.X = 400;
            rectangle2.Y = 20 + random.Next(20);
            rectangle2.Width = cloud.Width;
            rectangle2.Height = cloud.Height;
            rectangle3.X = 1100;
            rectangle3.Y = 20 + random.Next(20);
            rectangle3.Width = cloud.Width;
            rectangle3.Height = cloud.Height;
            rectangle4.X = 1300;
            rectangle4.Y = 20 + random.Next(20);
            rectangle4.Width = cloud.Width;
            rectangle4.Height = cloud.Height;
            cx = -3;
            timer1.Interval = 20;
            timer1.Enabled = true;
        }
    }
}
