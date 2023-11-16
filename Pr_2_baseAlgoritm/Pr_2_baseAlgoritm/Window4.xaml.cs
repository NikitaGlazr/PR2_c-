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
using System.Windows.Shapes;

namespace Pr_2_baseAlgoritm
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void btnArray_Click(object sender, RoutedEventArgs e)
        {
            string sentence = tbArray.Text;
            string[] words = sentence.Split(' ');

            int[] numbers = new int[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                numbers[i] = int.Parse(words[i]);
            }

            if (numbers.Length >= 5)
            {
                int temp = numbers[2];
                numbers[2] = numbers[4];
                numbers[4] = temp;
            }

            lbArray.Items.Clear();
            foreach (int number in numbers)
            {
                lbArray.Items.Add(number);
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lbArray.Items.Clear(); 
        }
    }
}
