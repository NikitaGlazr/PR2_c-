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

namespace Pr_2_baseAlgoritm
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

        //btn_windows
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 form1 = new Window1();      
            form1.Show();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Window2 form2 = new Window2();
            form2.Show();
        }
        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            Window3 form3 = new Window3();
            form3.Show();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            Window4 form4 = new Window4();
            form4.Show();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            Window5 form5 = new Window5();
            form5.Show();
        }
        //btn_windows





    }
}
