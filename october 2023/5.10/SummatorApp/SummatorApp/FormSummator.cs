using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SummatorApp
{
    public partial class FormSummator : Form
    {
        public FormSummator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            var num1 = decimal.Parse(this.textBoxNum1.Text);
            var num2 = decimal.Parse(this.textBoxNum2.Text);
            var sum = num1 + num2;
            textBoxSum.Text = sum.ToString();

        }
    }
}
