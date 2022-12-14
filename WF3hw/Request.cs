using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WF2hw
{
    public partial class Req : Form
    {
        string request;
        public Req()
        {
            InitializeComponent();
            dateTimePicker1.MinDate = new DateTime(DateTime.Now.Year - 60, DateTime.Now.Month, DateTime.Now.Day);
            request += $"Surname: {Surname.Text}\nName: {name.Text}\n Patronimic: {Patronimic.Text}\nCountry: ";

            if(Country_combox.SelectedIndex == 0)
            {
                request += "Russia\n";
                CityComBox.Items.Clear();
                CityComBox.Items.AddRange(new string[] { "Moscow, Saint Petersburg, Krasnodar" });
            }
            if(Country_combox.SelectedIndex == 1)
            {
                request += "Germany\n";
                CityComBox.Items.Clear();
                CityComBox.Items.AddRange(new string[] { "Berlin, Hamburg, Bavaria" });
            }
            if(Country_combox.SelectedIndex == 2)
            {
                request += "UK\n";
                CityComBox.Items.Clear();
                CityComBox.Items.AddRange(new string[] { "London, Manchester, Chelsea" });
            }
            request += $"City: {CityComBox.SelectedIndex.ToString()}\n";
            request += $"Phone number: {PhoneNoTxtBox.Text}\n";
            request += $"Birthdate: {dateTimePicker1.Value.ToShortDateString()}";
            request += $"Gender: ";
            request += radioButton1.Checked ? "Male\n" : "Female\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show(request, "Filled request", MessageBoxButtons.OKCancel);
            if(dialog == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(".\\Request.txt");
            }
        }
    }
}
