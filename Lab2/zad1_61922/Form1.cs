using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad1_61922
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                int wzrost = Convert.ToInt32(textBox1.Text);

                if (rdoStan.Checked)
                {
                    label3.Text = " " + (wzrost - 100).ToString();
                }
                // idealna
                else if (rdoIdeal.Checked)
                {
                    if (checkBox2.Checked && checkBox1.Checked)
                    {
                        MessageBox.Show("Wybierz jedną płeć");
                    }
                    else
                    {
                        if (checkBox1.Checked)
                            label3.Text = ((wzrost - 100) * 0.85).ToString();
                        else if (checkBox2.Checked)
                            label3.Text = ((wzrost - 100) * 0.9).ToString();
                    }

                }
                else
                {
                    MessageBox.Show("Wybierz rodzaj wagi! ");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Wprowadz poprawnie dane!");
            }
        }
    }
}
