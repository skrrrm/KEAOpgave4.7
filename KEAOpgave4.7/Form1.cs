using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEAOpgave4._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Clear(); // Clears listbox

            // Variables
            double harmonic = 1.0;
            int counter = 0;

            for (double n = 2; harmonic <= 5.0; n++) // while the sum of the harmonic series is lower than 5.
            {
                harmonic += (double)1 / n; // harmonic = harmonic + 1 / n - making sure to use double
                listBoxResult.Items.Add($"{harmonic:F5}"); // prints to listbox with 5 decimals
                counter++; // for counting loops
            }
            textBoxLoops.Text = $"{counter}"; // prints the total count
        }
    }
}
