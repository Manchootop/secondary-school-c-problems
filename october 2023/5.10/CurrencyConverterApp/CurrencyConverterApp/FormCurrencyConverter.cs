using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverterApp
{
    public partial class FormCurrencyConverter : Form
    {
        public FormCurrencyConverter()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            // Прочитаме стойността, въведена от потребителя
            var initialSum = double.Parse(this.textBoxAmount.Text);

            // Конвертираме сумата от лева в евро
            var convertedSum = initialSum / 1.95583;

            // Визуализираме сумата в евро в labelResult
            this.labelResult.Text += $"{initialSum} BGN = {convertedSum:f2} EUR";

        }
    }
}
