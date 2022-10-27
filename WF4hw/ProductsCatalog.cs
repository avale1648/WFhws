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
    public partial class ProductsCatalog : Form
    {
        public ProductsCatalog()
        {
            InitializeComponent();
            ToggleButtons(false);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            EditProduct eP = new EditProduct();
            eP.Header = "Add New Product";
            eP.ShowDialog();
            if (eP.DialogResult == DialogResult.OK)
            {
                listBox1.Items.Add(new Product(eP.PName, eP.PMadeIn, eP.PPrice));
                ToggleButtons(true);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Product tmp = listBox1.SelectedItem as Product;
            if (listBox1.SelectedIndex >= 0)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            else
                buttonEdit.Enabled = false;
            EditProduct eP = new EditProduct();
            eP.Header = "Edit Product";
            eP.ShowDialog();
            if (eP.DialogResult == DialogResult.OK)
                listBox1.Items.Add(new Product(eP.PName, eP.PMadeIn, eP.PPrice));
            else
                listBox1.Items.Insert(listBox1.SelectedIndex, tmp);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete product?", string.Empty, MessageBoxButtons.YesNo);
            if (listBox1.SelectedIndex >= 0 && dialogResult == DialogResult.Yes)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Clear products' catalogue?", string.Empty, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                listBox1.Items.Clear();
                ToggleButtons(false);
            }
        }
        private void ToggleButtons(bool areEnabled)
        {
            if(areEnabled)
            {
                buttonEdit.Enabled = true;
                buttonDelete.Enabled = true;
                buttonClear.Enabled = true;
            }
            else 
            {
                buttonEdit.Enabled = false;
                buttonDelete.Enabled = false;
                buttonClear.Enabled = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                buttonDelete.Enabled = true;
                buttonEdit.Enabled = true;
            }
            else
            {
                buttonDelete.Enabled = false;
                buttonEdit.Enabled = false;
            }
        }
    }
}
