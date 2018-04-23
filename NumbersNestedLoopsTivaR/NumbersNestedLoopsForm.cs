using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 13-04-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #25 - Numbers Nested Loops
 * This program outputs numbers and then adds a number on to them
*/

namespace NumbersNestedLoopsTivaR
{
    public partial class frmNumbersNestedLoops : Form
    {
        public frmNumbersNestedLoops()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Declare Variables
            int firstNumber;
            int secondNumber;

            // Clear the list box
            this.lstNumbersOutput.Items.Clear();

            // Loop through the first number 
            for (firstNumber = 0; firstNumber <= 10; firstNumber++)
            {
                //Now to loop through the next number
                for (secondNumber = 0; secondNumber <= 10; secondNumber++)
                {
                    this.lstNumbersOutput.Items.Add(firstNumber + "->" + secondNumber);
                }
            }
        }
    }
}
