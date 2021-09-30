using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiggestOf3
{
    public partial class BiggestOf3 : Form
    {
        public BiggestOf3()
        {
            InitializeComponent();
        }

        private void BiggestOf3_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
            label2.BackColor = Color.Red;
            label3.BackColor = Color.Red;

        }

        private void button1_Click(object sender, EventArgs e)
        {
         //Generate a random number and assign it to all 3 slots on click
            Random RNG = new Random();

            label1.Text = RNG.Next(1, 101).ToString();
            label2.Text = RNG.Next(1, 101).ToString();
            label3.Text = RNG.Next(1, 101).ToString();

            //Reset the colors to RED
            label1.BackColor = Color.Red;
            label2.BackColor = Color.Red;
            label3.BackColor = Color.Red;

            //set Check It to active button
            button2.Select();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int LABEL1;
            int LABEL2;
            int LABEL3;

            //Read the RNG numbers from the Text property and assign it to local INTS
            LABEL1 = Convert.ToInt16(label1.Text);
            LABEL2 = Convert.ToInt16(label2.Text);
            LABEL3 = Convert.ToInt16(label3.Text);

            //Test which number is bigger by comparing to each other. Change the color of the background to blue for biggest or multiple if matching numbers.
            if (LABEL1.CompareTo(LABEL2) >= 0 & LABEL1.CompareTo(LABEL3) >= 0)
            {
                label1.BackColor = Color.Blue;
            }
            if (LABEL2.CompareTo(LABEL1) >= 0 & LABEL2.CompareTo(LABEL3) >= 0)
            {
                label2.BackColor = Color.Blue;
            }
            if (LABEL3.CompareTo(LABEL1) >= 0 & LABEL3.CompareTo(LABEL2) >= 0)
            {
                label3.BackColor = Color.Blue;
            }
            //set Next button as active
            button1.Select();
        }
    }
}
