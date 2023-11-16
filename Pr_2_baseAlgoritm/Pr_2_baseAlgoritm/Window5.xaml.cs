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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        private int[,] array; // объявление массива как поле класса
        public Window5()
        {
            InitializeComponent();
        }

        private void btnArray_Click(object sender, RoutedEventArgs e)
        {
            int M = 5; //количество столбцов
            int N = 7; //количество строк
            array = new int[N, M]; //объявление и создание массива

            Random random = new Random(); //создание объекта Random для генерации случайных чисел

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    array[i, j] = random.Next(-10, 11); //заполнение массива случайными числами от -10 до 10
                }
            }

            //вывод массива в ListBox_1
            for (int i = 0; i < N; i++)
            {
                string row = "";
                for (int j = 0; j < M; j++)
                {
                    row += array[i, j] + "\t";
                }
                lbNewArray.Items.Add(row);
            }
        }
        private void btnSort_Click(object sender, RoutedEventArgs e)
        {
            int M = 5; //количество столбцов
            int N = 7; //количество строк

            // Создание копии массива для сортировки
            int[,] sortedArray = new int[N, M];
            Array.Copy(array, sortedArray, array.Length);

            // Преобразование двумерного массива в одномерный для удобства сортировки
            List<int> sortedListAsc = new List<int>();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    sortedListAsc.Add(sortedArray[i, j]);
                }
            }

            // Сортировка пузырьком
            for (int i = 0; i < N * M - 1; i++)
            {
                for (int j = 0; j < N * M - i - 1; j++)
                {
                    if (sortedListAsc[j] > sortedListAsc[j + 1])
                    {
                        int temp = sortedListAsc[j];
                        sortedListAsc[j] = sortedListAsc[j + 1];
                        sortedListAsc[j + 1] = temp;
                    }
                }
            }

            // Отображение отсортированных элементов по возрастанию в ListBox_2
            lbResultaterray.Items.Clear();
            for (int i = 0; i < sortedListAsc.Count; i += M)
            {
                string row = "";
                for (int j = i; j < i + M; j++)
                {
                    row += sortedListAsc[j] + "\t";
                }
                lbResultaterray.Items.Add(row);
            }
        }
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lbNewArray.Items.Clear();
            lbResultaterray.Items.Clear();
        } 
    }
}
