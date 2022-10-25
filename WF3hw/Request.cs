using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF3hw
{
    public partial class Req : Form
    {
        string request;
        public Req()
        {
            InitializeComponent();
            dateTimePicker1.MinDate = new DateTime(DateTime.Now.Year - 60, DateTime.Now.Month, DateTime.Now.Day);
            request += $"Surname: {Surname.Text}\nName: {name.Text}\n Patronimic: {Patronimic.Text}\n";

            if(Country_combox.SelectedIndex == 0)
            {
                request += "Russia";
                CityComBox.Items.AddRange(new string[] { "Moscow, Saint Petersburg, Krasnodar" });
                request += CityComBox.SelectedIndex.ToString();
            }
            if(Country_combox.SelectedIndex == 0)
            {
                request += "Germany";
                CityComBox.Items.AddRange(new string[] { "Berlin, Hamburg, " });
            }
        }

    }
}
