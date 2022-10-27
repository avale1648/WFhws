using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF4hw
{
    public partial class EditProduct : Form
    {
        public string Header 
        {
            set 
            {
                Text = value; groupBox1.Text = value;
            } 
        }
        public string PName { get => textBoxName.Text; }
        public string PMadeIn { get => textBoxMadeIn.Text; }
        public double PPrice { get => double.Parse(textBoxPrice.Text); }
        public EditProduct()
        {
            InitializeComponent();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
