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
    public partial class TimerForm : Form
    {
        System.Timers.Timer t;
        int hour = 0, minute = 0, second = 0;
        public TimerForm()
        {
            InitializeComponent();
            stopButton.Enabled = false; resetButton.Enabled = false;
            timeLabel.Text = $"{hour.ToString().PadLeft(2, '0')}:" +
                $"{minute.ToString().PadLeft(2, '0')}:{second.ToString().PadLeft(2, '0')}";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (minuteCustomRadioButton.Checked && hourNumericUpDown.Value == 0 &&
               minuteNumericUpDown.Value == 0 && secondNumericUpDown.Value == 0)
                startButton.Enabled = false;
            if(minuteCustomRadioButton.Checked)
            {
                hour = decimal.ToInt32(hourNumericUpDown.Value);
                minute = decimal.ToInt32(minuteNumericUpDown.Value);
                second = decimal.ToInt32(secondNumericUpDown.Value);
                timeLabel.Text = $"{hour.ToString().PadLeft(2, '0')}:" +
                $"{minute.ToString().PadLeft(2, '0')}:{second.ToString().PadLeft(2, '0')}";
            }
            stopButton.Enabled = true; resetButton.Enabled = true;
            t.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            t.Stop();
            stopButton.Enabled = false;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            t.Stop(); stopButton.Enabled = false;
            hour = 0; minute = 0; second = 0;
            timeLabel.Text = $"{hour.ToString().PadLeft(2, '0')}:" +
                $"{minute.ToString().PadLeft(2, '0')}:{second.ToString().PadLeft(2, '0')}";
        }

        private void minute1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            switchNumericUpDowns(false);
            minute = 1;
            timeLabel.Text = $"{hour.ToString().PadLeft(2, '0')}:" +
                $"{minute.ToString().PadLeft(2, '0')}:{second.ToString().PadLeft(2, '0')}";
        }

        private void minute3RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            switchNumericUpDowns(false);
            minute = 3;
            timeLabel.Text = $"{hour.ToString().PadLeft(2, '0')}:" +
                $"{minute.ToString().PadLeft(2, '0')}:{second.ToString().PadLeft(2, '0')}";
        }

        private void minute5RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            switchNumericUpDowns(false);
            minute = 5;
            timeLabel.Text = $"{hour.ToString().PadLeft(2, '0')}:" +
                $"{minute.ToString().PadLeft(2, '0')}:{second.ToString().PadLeft(2, '0')}";
        }

        private void minute10RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            switchNumericUpDowns(false);
            minute = 10;
            timeLabel.Text = $"{hour.ToString().PadLeft(2, '0')}:" +
                $"{minute.ToString().PadLeft(2, '0')}:{second.ToString().PadLeft(2, '0')}";
        }

        private void minute15RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            switchNumericUpDowns(false);
            minute = 15;
            timeLabel.Text = $"{hour.ToString().PadLeft(2, '0')}:" +
                $"{minute.ToString().PadLeft(2, '0')}:{second.ToString().PadLeft(2, '0')}";
        }

        private void minuteCustomRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            switchNumericUpDowns(true);
            hour = 0;
            minute = 0;
            second = 0;
            timeLabel.Text = $"{hour.ToString().PadLeft(2, '0')}:" +
                $"{minute.ToString().PadLeft(2, '0')}:{second.ToString().PadLeft(2, '0')}";
        }

        private void TimerForm_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
        }

        private void TimerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Stop();
            Application.DoEvents();
        }

        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                second--;
                if (second == -1 && minute != 0)
                {
                    second = 59;
                    minute--; 
                }
                if (second == -1 && hour != 0)
                { 
                    second = 59;
                    minute = 59;
                    hour--; 
                }
                if (second == 0 && minute == 0 && hour == 0)
                    t.Stop();

                timeLabel.Text = $"{hour.ToString().PadLeft(2, '0')}:" +
                $"{minute.ToString().PadLeft(2, '0')}:{second.ToString().PadLeft(2, '0')}";
            }));

        }
        private void switchNumericUpDowns(bool isEnabled)
        {
            if(isEnabled)
            {
                hourNumericUpDown.Enabled = true;
                minuteNumericUpDown.Enabled = true;
                secondNumericUpDown.Enabled = true;
            }
            else
            {
                hourNumericUpDown.Enabled = false;
                minuteNumericUpDown.Enabled = false; 
                secondNumericUpDown.Enabled = false;
            }
        }
    }
}
