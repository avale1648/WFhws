using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Country_combox.Items.AddRange(new string[] {"Russia","Germany","UK" });
            request += Country_combox.SelectedIndex.ToString();
            if (Country_combox.SelectedIndex == 0)
            {
                CityComBox.Items.Clear();
                CityComBox.Items.AddRange(new string[] { "Moscow, Saint Petersburg, Krasnodar" });
            }
            if (Country_combox.SelectedIndex == 1)
            {
                CityComBox.Items.Clear();
                CityComBox.Items.AddRange(new string[] { "Berlin, Hamburg, Bavaria" });
            }
            if (Country_combox.SelectedIndex == 2)
            {
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
            MessageBox.Show("request", "Filled Request", MessageBoxButtons.OKCancel);
                StreamWriter streamWriter = new StreamWriter(".\\Request.txt");
        }
    }
}
