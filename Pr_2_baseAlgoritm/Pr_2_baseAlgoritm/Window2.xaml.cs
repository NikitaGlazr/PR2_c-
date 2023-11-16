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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string sentence = tbProposal.Text.ToLower(); // Приводим предложение к нижнему регистру(мелкие буквы) для удобства подсчета гласных
            int vowelsCount = 0;

            foreach (char letter in sentence)
            {
                if ("аеёиоуыэюя".Contains(letter))
                {
                    vowelsCount++;
                }
            }

            lbNumber.Items.Add(vowelsCount);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string sentence = tbProposal.Text.ToLower(); // Приводим предложение к нижнему регистру(мелкие буквы) для удобства подсчета согласных
            int consonantsCount = 0;

            foreach (char letter in sentence)
            {
                if ("бвгджзйклмнпрстфхцчшщ".Contains(letter))
                {
                    consonantsCount++;
                }
            }

            lbNumber.Items.Add(consonantsCount);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            lbNumber.Items.Clear();
        }
    }
}
