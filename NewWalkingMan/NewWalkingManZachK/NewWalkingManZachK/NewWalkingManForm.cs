using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace NewWalkingManZachK
{
    public partial class NewWalkingManForm : Form
    {
        public NewWalkingManForm()
        {
            InitializeComponent();
        }

        private void GeneratePictureBoxes()
        {
            // generate the picture boxes on the form
            GeneratePictureBox(61, 78);
            GeneratePictureBox(464, 78);
            GeneratePictureBox(61, 358);
            GeneratePictureBox(464, 358);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GeneratePictureBoxes();
        }

        private void GeneratePictureBox(int x, int y)
        {
            // dynamically generate a new picture box and a new point at the given location (x, y)
            PictureBox tmpPicMan = new PictureBox();
            Point pntPic = new System.Drawing.Point(x, y);

            // set the location of the picture box
            tmpPicMan.Location = pntPic;

            // assign the image to the picture box
            tmpPicMan.Image = Properties.Resources.walk1;

            // stretch the image to the size of the picture box
            tmpPicMan.SizeMode = PictureBoxSizeMode.StretchImage;

            // make the picture box width and height to be the same as the image
            tmpPicMan.ClientSize = new Size(Properties.Resources.walk1.Width, Properties.Resources.walk1.Height);

            // add the event listener
            tmpPicMan.Click += new System.EventHandler(PictureBox_Click);

            // add the picture box to the form
            this.Controls.Add(tmpPicMan);
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox tmpPicMan = (PictureBox)sender;

            //Declare local variables
            const byte MAX_FRAMES = 10;
            int pictureFrameCounter = 1;

            //Continue the loop while the frame counter has not reached the max number of frames
            while (pictureFrameCounter < MAX_FRAMES + 1)
            {
                if (pictureFrameCounter == 1)
                {
                    tmpPicMan.Image = Properties.Resources.walk1;
                }

                else if (pictureFrameCounter == 2)
                {
                    tmpPicMan.Image = Properties.Resources.walk2;
                }

                else if (pictureFrameCounter == 3)
                {
                    tmpPicMan.Image = Properties.Resources.walk3;
                }

                else if (pictureFrameCounter == 4)
                {
                    tmpPicMan.Image = Properties.Resources.walk4;
                }

                else if (pictureFrameCounter == 5)
                {
                    tmpPicMan.Image = Properties.Resources.walk5;
                }

                else if (pictureFrameCounter == 6)
                {
                    tmpPicMan.Image = Properties.Resources.walk6;
                }

                else if (pictureFrameCounter == 7)
                {
                    tmpPicMan.Image = Properties.Resources.walk7;
                }

                else if (pictureFrameCounter == 8)
                {
                    tmpPicMan.Image = Properties.Resources.walk8;
                }

                else if (pictureFrameCounter == 9)
                {
                    tmpPicMan.Image = Properties.Resources.walk9;
                }

                else if (pictureFrameCounter == 10)
                {
                    tmpPicMan.Image = Properties.Resources.walk10;
                }

                //Increment the counter
                pictureFrameCounter++;

                //Refresh the screen
                this.Refresh();

                //Pause the loop for 100 milliseconds 
                Thread.Sleep(100);
            }
        }
    }
}

/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace NewWalkingMan
{
    public partial class NewWalkingManForm : Form
    {
        public NewWalkingManForm()
        {
            InitializeComponent();
        }

        private void GeneratePictureBoxes()
        {
            // generate the picture boxes on the form
            GeneratePictureBox(61, 78);
            GeneratePictureBox(464, 78);
            GeneratePictureBox(61, 358);
            GeneratePictureBox(464, 358);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GeneratePictureBoxes();
        }

        private void GeneratePictureBox(int x, int y)
        {
            // dynamically generate a new picture box and a new point at the given location (x, y)
            PictureBox tmpPicMan = new PictureBox();
            Point pntPic = new System.Drawing.Point(x, y);

            // set the location of the picture box
            tmpPicMan.Location = pntPic;

            // assign the image to the picture box
            tmpPicMan.Image = Properties.Resources.walk1;

            // stretch the image to the size of the picture box
            tmpPicMan.SizeMode = PictureBoxSizeMode.StretchImage;

            // make the picture box width and height to be the same as the image
            tmpPicMan.ClientSize = new Size(Properties.Resources.walk1.Width, Properties.Resources.walk1.Height);

            // add the event listener
            tmpPicMan.Click += new System.EventHandler(PictureBox_Click);

            // add the picture box to the form
            this.Controls.Add(tmpPicMan);
        }

        private void NewWalkingManForm_Load(object sender, EventArgs e)
        {

        }
    }

    /*


