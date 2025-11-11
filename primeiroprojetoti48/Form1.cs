using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace primeiroprojetoti48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void AD_Click(object sender, EventArgs e)
        {
            double soma1 = double.Parse(textBox1.Text);
            double soma2 = double.Parse(textBox2.Text);
            double resultado = soma1 + soma2;
            textBox3.Text = resultado.ToString();
        }

        private void SUB_Click(object sender, EventArgs e)
        {
            double subtracao1 = double.Parse(textBox1.Text);
            double subtracao2 = double.Parse(textBox2.Text);
            double resultado = subtracao1 - subtracao2;
            textBox3.Text = resultado.ToString();
        }

        private void MUL_Click(object sender, EventArgs e)
        {
            double mult1 = double.Parse(textBox1.Text);
            double mult2 = double.Parse(textBox2.Text);
            double resultado = mult1 * mult2;
            textBox3.Text = resultado.ToString();
        }

        private void DIV_Click(object sender, EventArgs e)
        {
            double div1 = double.Parse(textBox1.Text);
            double div2 = double.Parse(textBox2.Text);
            double resultado = div1 / div2;
            textBox3.Text = resultado.ToString();
        }
    }
}
