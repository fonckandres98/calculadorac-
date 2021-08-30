using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora2
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        string operador;
        public Calculadora()
        {
            InitializeComponent();
        }
        clases.ClassSuma obj = new clases.ClassSuma();
        clases.ClassResta obj2 = new clases.ClassResta();
        clases.ClassMultiplicacion obj3 = new clases.ClassMultiplicacion();
        clases.ClassDivision obj4 = new clases.ClassDivision();


        private void btn0_Click(object sender, EventArgs e)
        {
            tbxtela.Text = tbxtela.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbxtela.Text = tbxtela.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbxtela.Text = tbxtela.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbxtela.Text = tbxtela.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbxtela.Text = tbxtela.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbxtela.Text = tbxtela.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbxtela.Text = tbxtela.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbxtela.Text = tbxtela.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbxtela.Text = tbxtela.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbxtela.Text = tbxtela.Text + "9";
        }

        private void buttonsuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(tbxtela.Text);
            tbxtela.Clear();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(tbxtela.Text);
            tbxtela.Clear();
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(tbxtela.Text);
            tbxtela.Clear();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(tbxtela.Text);
            tbxtela.Clear();
        }

        private void btnelimina_Click(object sender, EventArgs e)
        {
            tbxtela.Clear();
        }

        private void btnresultado_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(tbxtela.Text);
            double sum;
            double Rest;
            double Mul;
            double Div;

            switch (operador)
            {
                case "+":
                    sum = obj.Sumar((primero), (segundo));
                    tbxtela.Text = sum.ToString();
                    break;

                case "-":
                    Rest = obj2.Restar  ((primero), (segundo));
                    tbxtela.Text =Rest.ToString();
                    break;

                case "*":
                    Mul = obj3.Multiplicar((primero), (segundo));
                    tbxtela.Text = Mul.ToString();
                    break;

                case "/":
                    Div = obj4.Dividir ((primero), (segundo));
                    tbxtela.Text = Div.ToString();
                    break;
            }
        }

        private void btnborra_Click(object sender, EventArgs e)
        {
            if (tbxtela.Text.Length == 1)
                tbxtela.Text = "";
            else tbxtela.Text = tbxtela.Text.Substring(0, tbxtela.Text.Length - 1);
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            tbxtela.Text = tbxtela.Text + ".";
        }
    }
}
