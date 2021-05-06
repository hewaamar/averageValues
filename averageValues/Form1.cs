using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace averageValues
{
    public partial class Form1 : Form
    {

        // convert input number to text
        double number = 0;

        // count # of times user has entered an input
        int tracker = 0;

        // n
        double sum = 0;

        // avg
        double avg;

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            // convert number input from text to double for math operatons
            number = Convert.ToDouble(addInput.Text);

            if (number != 0)
            {  
                // if the number is not zero, output that the number has been added to sum
                textOutput.Text = $"{number} has been added to the sum";

                // add the input to the sum
                sum += number;

                // add 1 to the tracker
                tracker++;
            }
            else
            {
               // calculate average
                avg = sum / tracker;
                // output average
                textOutput.Text = $" the average is {avg}";
            } 
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            // clear inputs and outputs
            textOutput.Text = "";
            addInput.Text = "";
            tracker = 0;
            sum = 0;

        }
    }
}
