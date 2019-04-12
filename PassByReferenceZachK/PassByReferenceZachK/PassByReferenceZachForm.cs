/*
 * Created by: Zachary Kranabetter
 * Created on: April 10th 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #31 - Rounding Program
 * This program takes a user inputted number along with the amount of decimals places the user wants 
 * then rounds the number accordingly by using a pass by reference procedure.
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

            //call the round procedure
            round(ref number, ref numberOfDecimals);
        }

        private void round (ref double number, ref int numberOfDecimals)
        {
            //multiply the number by 10 to the power of the number of decimals
            number = number * (Math.Pow(10, numberOfDecimals));

            //add 0.5 to the number
            number = number + 0.5;

            //get rid of the decimals
            number = Math.Truncate(number);

            //divide the number by 10 to the power of the number of decimals
            number = number / (Math.Pow(10, numberOfDecimals));
            
            //display the rounded number to the user
            MessageBox.Show("The rounded number is " + number, "Round" );
        }
    }
}
