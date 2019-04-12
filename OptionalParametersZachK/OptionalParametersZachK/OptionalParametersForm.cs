/*
 * Created by: First Last
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - Address Program
 * This program...
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

namespace OptionalParametersZachK
{
    public partial class OptionalParametersForm : Form
    {
        public OptionalParametersForm()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //declare my variables
            String aptNumber, streetAdress, city, province, postalCode;

            //get the information from the text boxes
            aptNumber = this.txtAptNumber.Text;
            streetAdress = this.txtStreetAddress.Text;
            city = this.txtCity.Text;
            province = this.txtProvince.Text;
            postalCode = this.txtPostalCode.Text;

            //make the user enter a street adress
            if (streetAdress == "")
            {
                MessageBox.Show("Please enter your Street Adress", "Adress Program");
            }

            //make the user enter a city
            else if (city == "")
            {
                MessageBox.Show("Please enter your City", "Adress Program");
            }

            //make the user enter a province
            else if (province == "")
            {
                MessageBox.Show("Please enter your Province", "Adress Program");
            }

            //make the user enter a postal code
            else if (postalCode == "")
            {
                MessageBox.Show("Please enter your Postal Code", "Adress Program");
            }

            //if the user does not enter an Apt. Number, call the procedure that accepts 4 String parameters
            else if (aptNumber == "")
            {
                printInfo(streetAdress, city, province, postalCode);
            }

            //if the user enters all their info, call the procedure that accepts all 5 String parameters
            else
            {
                printInfo(aptNumber, streetAdress, city, province, postalCode);
            }
        }

        //display a message box with all 5 parameters Apt. Number, Street Addres, City, Province and Postal Code
        public void printInfo(String aptNumber, String streetAdress, String city, String province, String postalCode)
        {
            MessageBox.Show("Your adress is: " + aptNumber + " " + streetAdress + " " + city + " " + province + " " + postalCode);
        }

        //display a message box with 4 parameters Street Addres, City, Province and Postal Code
        public void printInfo(String streetAdress, String city, String province, String postalCode)
        {
            MessageBox.Show("Your adress is: " + streetAdress + " " + city + " " + province + " " + postalCode);
        }
    }
}
