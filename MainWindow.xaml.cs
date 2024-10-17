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

namespace Dz_text
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Zadanie1 zad1 = new Zadanie1();
        Zadanie2 zad2 = new Zadanie2();
        private void z1_Click(object sender, RoutedEventArgs e)
        {
            zad1.ShowDialog();
        }

        private void z2_Click(object sender, RoutedEventArgs e)
        {
            zad2.ShowDialog();
        }
    }
}
