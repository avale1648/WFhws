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
    public partial class Timer : Form
    {
        int seconds;
        public Timer()
        {
            InitializeComponent();
            Stop.Enabled = false; Reset.Enabled = false;
            timer1.Tick += new EventHandler(timer1_Tick);
            Time.Text = seconds.ToString();
        }
        private void ShowTimer(object sender, EventArgs e)
        {
            Time.Text = timer1.ToString();
        }

        private void OneMinute_CheckedChanged(object sender, EventArgs e)
        {
            seconds = 60;
        }

        private void ThreeMinutes_CheckedChanged(object sender, EventArgs e)
        {
            seconds = 60 * 3;
        }

        private void FiveMinutes_CheckedChanged(object sender, EventArgs e)
        {
            seconds = 60 * 5;
        }

        private void TenMinutes_CheckedChanged(object sender, EventArgs e)
        {
            seconds = 60 * 10;
        }

        private void FifteenMinutes_CheckedChanged(object sender, EventArgs e)
        {
            seconds = 60 * 15;
        }

        private void Custom_CheckedChanged(object sender, EventArgs e)
        {
            Seconds.Enabled = true; Minutes.Enabled = true; Hours.Enabled = true;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (Hours.Value == 0 && Minutes.Value == 0 && Seconds.Value == 0 && Custom.Checked)
            { Time.Text = "Wrong Interval"; return; } 
            Stop.Enabled = true; Reset.Enabled = true;
            if (Custom.Checked)
                seconds = Decimal.ToInt32((Hours.Value * 60 * 60) + (Minutes.Value * 60) + Seconds.Value);
            timer1.Start();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            timer1.Stop(); seconds = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds--; Time.Text = seconds.ToString();
            if (seconds == 0)
                timer1.Stop();
        }
    }
    public class Time
    {
        private int seconds = 0;
        private int minutes = 0;
        private int hours = 0;

        public Time(int i)
        {
            seconds = i;
            if (seconds > 59)
            { seconds = 0; minutes++; }
            if (minutes > 59)
            { minutes = 0; hours++; }
        }
        public override string ToString()
        {
            return $"{hours} : {minutes} : {seconds}";
        }
    }
}
