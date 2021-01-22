using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrijzenMetForeach
{
    public partial class FormPrijzenForEach : Form
    {
        double[] prices = new double[20];
        List<double> input = new List<double>();
        public FormPrijzenForEach()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblInput.Text += $"{txtInput.Text}, ";
            input.Add(Convert.ToDouble(txtInput.Text));
            if (input.Count == 20)
            {
                btnAdd.Enabled = false;
                prices = input.ToArray();
                btnAverage.Enabled = true;
                btnCalc.Enabled = true;
            }
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            double average = 0.0;
            foreach (double price in prices)
            {
                average += price;
            }
            average = average / 20;
            lblAverage.Text += $"{average}";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            foreach (double price in prices)
            {
                if (price > 5.0)
                {
                    lblHigher.Text += $"{price}, ";
                }
            }
        }
    }
}
