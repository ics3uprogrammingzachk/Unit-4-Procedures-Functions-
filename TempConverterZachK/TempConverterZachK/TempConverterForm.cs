/*
 * Created by: Zachary Kranabetter
 * Created on: April 4th 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - Temp Converter
 * This program gets a user inputted temperature in Celsius and converts it to Fahrenheit
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConverterZachK
{
    public partial class TempConverterForm : Form
    {
        public TempConverterForm()
        {
            InitializeComponent();
        }

        public void ConvertToFahrenheit (double temperature)
        {
            // convert the temperature to Fahrenheit
            temperature = (temperature * 9 / 5 ) + 32;

            // display thetemperature in Fahrenheit
            lblFahrenheit.Text = "the temperature in Fahrenheit = " + Convert.ToString(temperature) + "°";
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // get the temperature in Celsius
            double temperature = Convert.ToDouble(txtTemp.Text);

            // call the convert function
            this.ConvertToFahrenheit(temperature);
        }
    }
}
