using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                long number = Convert.ToInt32(tbox1.Text);
                int t = Convert.ToString(number).Trim().Length;
                if (number >= 1 && number <= 9999)
                {
                    if (number % 2 == 0)
                    {
                        string str = $"Четное {t}значное число";
                        Regex regex = new Regex(@"(\d)\.*");
                        str = regex.Replace(str, m =>
                        {
                            int digit = Convert.ToInt32(m.Groups[1].Value);
                            switch (digit)
                            {
                                case 1:
                                    return "одно";
                                case 2:
                                    return "двух";
                                case 3:
                                    return "трех";
                                case 4:
                                    return "четырех";
                                case 5:
                                    return "пяти";
                                case 6:
                                    return "шести";
                                case 7:
                                    return "семи";
                                case 8:
                                    return "восьми";
                                case 9:
                                    return "девяти";
                                default:
                                    return "";
                            }
                        });
                        listBox.Items.Add(str);
                    }
                    else
                    {
                        string str = $"Нечетное {t}значное число";
                        Regex regex = new Regex(@"(\d)\.*");
                        str = regex.Replace(str, m =>
                        {
                            int digit = Convert.ToInt32(m.Groups[1].Value);
                            switch (digit)
                            {
                                case 1:
                                    return "одна";
                                case 2:
                                    return "двух";
                                case 3:
                                    return "трех";
                                case 4:
                                    return "четырех";
                                case 5:
                                    return "пяти";
                                case 6:
                                    return "шести";
                                case 7:
                                    return "семи";
                                case 8:
                                    return "восьми";
                                case 9:
                                    return "девяти";
                                default:
                                    return "";
                            }
                        });
                        listBox.Items.Add(str);
                        }
                    }
                else
                {
                    MessageBox.Show("Число не входит в заданный диапазон. Повторите ввод.");
                }
            }
            catch
            {
                MessageBox.Show("Введено не число.");
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
        }
    }
}
