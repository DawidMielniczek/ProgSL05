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

namespace zad1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class Student
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public int NrIndeksu { get; set; }
        public string wydzial { get; set; }

        public Student(string imie, string nazwisko, int NrIndeksu, string wydzial)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.NrIndeksu = NrIndeksu;
            this.wydzial = wydzial;
        }
        public Student()
            : this("", "", 0, "")
        { }
    }

    public partial class MainWindow : Window
    {
        public List<Student> ListaStudentow { get; set; }
        public MainWindow()
        {
            ListaStudentow = new List<Student>()
            {
                 new Student() { imie = "Jan ", nazwisko = "Kowalski", NrIndeksu = 1234, wydzial = "KiS" },
                 new Student() { imie = "Jarek ", nazwisko = "Kononowicz", NrIndeksu = 61900, wydzial = "WiS" },
                 new Student() { imie = "Dagmara ", nazwisko = "Potocka", NrIndeksu = 57685, wydzial = "Kis" },
            };

            InitializeComponent();

            DgStudent.Columns.Add(new DataGridTextColumn() { Header = "Imię", Binding = new Binding("imie") });
            DgStudent.Columns.Add(new DataGridTextColumn() { Header = "Nazwisko", Binding = new Binding("nazwisko") });
            DgStudent.Columns.Add(new DataGridTextColumn() { Header = "NrAlbumu", Binding = new Binding("NrIndeksu") });
            DgStudent.Columns.Add(new DataGridTextColumn() { Header = "Wydzial", Binding = new Binding("wydzial") });

            DgStudent.AutoGenerateColumns = false;
            DgStudent.ItemsSource = ListaStudentow;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new StudentWindow();
            if (dialog.ShowDialog() == true)
            {
                ListaStudentow.Add(dialog.student);
                DgStudent.Items.Refresh();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (DgStudent.SelectedItem is Student)
            {
                ListaStudentow.Remove((Student)DgStudent.SelectedItem);
                DgStudent.Items.Refresh();
            }
        }
    }
}
