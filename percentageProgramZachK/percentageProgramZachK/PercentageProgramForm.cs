/*
 * Created by: Zachary Kranabetter
 * Created on: April 14th 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #31 - Percentage Program
 * This program gets a level from the user then uses a switch statement to convert it to a percentage
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

namespace percentageProgramZachK
{
    public partial class PercentageProgramForm : Form
    {
        int percentage;

        public PercentageProgramForm()
        {
            InitializeComponent();

        }
        private int ConvertToPercent(string level)
        {
            switch (level)
            {
                //changes there mark to a percentage
                case "4++":
                    percentage = 98;
                    break;
                case "4+":
                    percentage = 95;
                    break;
                case "4":
                    percentage = 87;
                    break;
                case "4-":
                    percentage = 83;
                    break;
                case "3+":
                    percentage = 78;
                    break;
                case "3":
                    percentage = 75;
                    break;
                case "3-":
                    percentage = 72;
                    break;
                case "2+":
                    percentage = 68;
                    break;
                case "2":
                    percentage = 65;
                    break;
                case "2-":
                    percentage = 62;
                    break;
                case "1+":
                    percentage = 58;
                    break;
                case "1":
                    percentage = 55;
                    break;
                case "1-":
                    percentage = 52;
                    break;
                case "0+":
                    percentage = 45;
                    break;
                case "0":
                    percentage = 40;
                    break;
                case "0-":
                    percentage = 35;
                    break;
                case "0--":
                    percentage = 30;
                    break;
                case "0---":
                    percentage = 20;
                    break;
                case "0----":
                    percentage = 10;
                    break;

                //make sure they put a real mark
                default:
                    percentage = -1;
                    break;
            }

            //return the percentage
            return percentage;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //declare my variables
            string level = txtMark.Text;
            int mark;

            //call the function to caluclate their mark
            mark = ConvertToPercent(level);

            //display their mark
            MessageBox.Show("Your level is " + mark + "%");
        }      
    }
}
