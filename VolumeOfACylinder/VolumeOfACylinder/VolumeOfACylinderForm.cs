/*
 * Created by: Zachary Kranabetter
 * Created on: April 16th 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - Volume of a Cylinder
 * This program calculates the volume of a cylinder by using a function
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

namespace VolumeOfACylinder
{
    public partial class VolumeOfACylinderForm : Form
    {
        public VolumeOfACylinderForm()
        {
            InitializeComponent();
        }

        private double Calculate(double height, double radius)
        {

            //declare my variables
            double volume;

            //declare my constant
            const double PI = Math.PI;

            //calculate the volume
            volume = PI * radius * radius * height;

            //return the volume
            return volume;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare my variables
            double height;
            double radius;
            double volume;

            //convert them to the user's inputs
            height = Convert.ToDouble(txtHeight.Text);
            radius = Convert.ToDouble(txtRadius.Text);        

            //call the function to calculate the volume
            volume = Calculate(height, radius);

            //display the volume
            MessageBox.Show("The volume of the cylinder is " + volume+ " cubic units");
        }
    }
}
