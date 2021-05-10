using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w61922_zad2
{
    public partial class Form1 : Form
    {
        string num1 = " ";
        string num2 = " ";
        string operacja = " ";
        public Form1()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            switch (operacja)
            {
                case "+":
                    textBoxG.Text = (Convert.ToDouble(num1) + Convert.ToDouble(num2)).ToString();
                    num1 = (Convert.ToDouble(num1) + Convert.ToDouble(num2)).ToString();
                    num2 = " ";
                    break;
                case "-":
                    textBoxG.Text = (Convert.ToDouble(num1) - Convert.ToDouble(num2)).ToString();
                    num1 = (Convert.ToDouble(num1) - Convert.ToDouble(num2)).ToString();
                    num2 = " ";
                    break;
                case "*":
                    textBoxG.Text = (Convert.ToDouble(num1) * Convert.ToDouble(num2)).ToString();
                    num1 = (Convert.ToDouble(num1) * Convert.ToDouble(num2)).ToString();
                    num2 = " ";
                    break;
                case "/":
                    try
                    {
                        if (Convert.ToDouble(num2) == 0)
                        {
                            MessageBox.Show("Nie mozna dzielic przez 0!", "Alert", MessageBoxButtons.OK);
                        }
                        else
                        {
                            textBoxG.Text = (Convert.ToDouble(num1) / Convert.ToDouble(num2)).ToString();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Tylko dane liczbowe!", "Alert", MessageBoxButtons.OK);
                    }
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //1
            DodajL("1");
            textBoxG.Text += 1.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 2
            DodajL("2");
            textBoxG.Text += 2.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //3
            DodajL("3");
            textBoxG.Text += 3.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //4
            DodajL("4");
            textBoxG.Text += 4.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //5
            DodajL("5");
            textBoxG.Text += 5.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //6
            DodajL("6");
            textBoxG.Text += 6.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //7
            DodajL("7");
            textBoxG.Text += 7.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //8
            DodajL("8");
            textBoxG.Text += 8.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //9
            DodajL("9");
            textBoxG.Text += 9.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // dodawanie
            operacja = "+";
            textBoxG.Text += "+";

        }
        private void button13_Click(object sender, EventArgs e)
        {
            // odejmowanie
            operacja = "-";
            textBoxG.Text += "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // iloczyn
            operacja = "*";
            textBoxG.Text += "*";
        }
        private void button16_Click(object sender, EventArgs e)
        {
            // dzielenie 
            operacja = "/";
            textBoxG.Text += "/";
        }

        private void DodajL(string liczba)
        {
            if (operacja == " ")
            {
                num1 += liczba;

            }
            else
            {
                num2 += liczba;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DodajL("0");
            textBoxG.Text += "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // clean 
            textBoxG.Clear();
            operacja = " ";
            num1 = " ";
            num2 = " ";
        }
    } 
}
