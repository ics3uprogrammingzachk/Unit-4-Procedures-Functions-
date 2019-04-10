using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassByReferenceZachK
{
    public partial class PassByReferenceZachForm : Form
    {
        public PassByReferenceZachForm()
        {
            InitializeComponent();
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            //declare my variables
            double number;
            int numberOfDecimals;

            //get the number they want to round
            number = Convert.ToDouble(txtNumber.Text);

            //get the number of decimals
            numberOfDecimals = Convert.ToInt32(nudDecimal.Value);

            round(ref number, numberOfDecimals);
        }

        private void round (ref double number, int numberOfDecimals)
        {
            //multiply the number they want to be rounded by 10 ^ the number of decimals
            //number *= (10^numberOfDecimals) + 0.5;
            numberOfDecimals = 10 ^ numberOfDecimals;
            number = number * numberOfDecimals;

            number += 0.5;

            number = Math.Truncate(number);

            number = number / numberOfDecimals;
          
            //lblRoundedNumber.Text = Convert.ToString(number);
            MessageBox.Show("The rounded number is " + number, "Round" );


        }
    }
}
