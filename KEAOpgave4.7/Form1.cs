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
            listBoxResult.Items.Clear();

            // Variables
            double harmonic = 1.0;
            int counter = 0;

            for (int n = 2; harmonic <= 5; n++)
            {
                harmonic += (double)1 / n;
                listBoxResult.Items.Add($"{harmonic:F5}");
                counter++;
                textBoxLoops.Text = $"{counter}";
            }
        }
    }
}
