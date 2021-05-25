using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace zad1_w61922
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var x = Convert.ToDouble(TextBox1.Text);
                var y = Convert.ToDouble(TextBox2.Text);
                Label1.Content = "Suma " + x.ToString() + " + " + y.ToString() + " = " + (x + y);
            }
            catch (Exception ex)
            {
                Label1.Content = ex.Message;
                MessageBox.Show(ex.Message);
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var x = Convert.ToDouble(TextBox1.Text);
                var y = Convert.ToDouble(TextBox2.Text);
                Label1.Content = "Różnica " +  x.ToString() +" - "+ y.ToString() + " = " + (x-y);
            }
            catch (Exception ex)
            {
                Label1.Content = ex.Message;
                MessageBox.Show(ex.Message);
                
            }
        }

        private void Iloczyn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var x = Convert.ToDouble(TextBox1.Text);
                var y = Convert.ToDouble(TextBox2.Text);
                Label1.Content = "Iloczyn " + x.ToString() + " * " + y.ToString() + " = " + (x * y);
            }
            catch (Exception ex)
            {
                Label1.Content = ex.Message;
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                var x = Convert.ToDecimal (TextBox1.Text);
                var y = Convert.ToDecimal(TextBox2.Text);
                Label1.Content = "Iloraz " + x.ToString() + " / " + y.ToString() + " = " + (x / y);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }
    }
}
