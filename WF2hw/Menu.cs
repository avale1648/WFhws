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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private DialogResult ShowMessageBoxes()
        {
            DialogResult result = MessageBox.Show("Текст сообщения", "Заголовок сообщения", MessageBoxButtons.OK);
            result = MessageBox.Show("Текст сообщения", "Заголовок сообщения", MessageBoxButtons.YesNo);
            result = MessageBox.Show("Текст сообщения", string.Empty, MessageBoxButtons.OK);

            result = MessageBox.Show("Сообщение от программиста!", string.Empty, MessageBoxButtons.OK);
            result = MessageBox.Show("Сообщение от программиста!", "Это заглавление!", MessageBoxButtons.OK);
            result = MessageBox.Show("Сообщение от программиста!", "Выбор", MessageBoxButtons.YesNoCancel);
            return result;

        }

        private void messageBoxesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            do
            {
                result = ShowMessageBoxes();
                if (result == DialogResult.Cancel)
                {
                    result = MessageBox.Show("Вы выбрали Cancel", string.Empty, MessageBoxButtons.OK);
                    break;
                }
            }
            while (true);
        }

        private void mouseCoordinatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MouseCoordinates mouseCoordinates = new MouseCoordinates();
            mouseCoordinates.Show();
        }

        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerForm timerForm = new TimerForm();
            timerForm.Show();
        }

        private void requestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
