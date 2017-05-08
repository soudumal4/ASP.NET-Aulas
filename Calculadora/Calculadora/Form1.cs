using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;


namespace Calculadora
{
    public partial class Calculadora : Form
    {
        double acumula = 0;
        string operacao = "";

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            display.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            display.Text += "1";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            display.Text += "1";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {

        }

        private void Btn5_Click(object sender, EventArgs e)
        {

        }

        private void Btn6_Click(object sender, EventArgs e)
        {

        }

        private void Btn7_Click(object sender, EventArgs e)
        {

        }

        private void Btn8_Click(object sender, EventArgs e)
        {

        }

        private void Btn9_Click(object sender, EventArgs e)
        {

        }

        private void Btn0_Click(object sender, EventArgs e)
        {

        }
    }
}
