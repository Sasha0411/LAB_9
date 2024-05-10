using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Горкун Олександр");

            // Отримати розміри матриці від користувача
            Console.WriteLine("Введіть кількість рядків матриці:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть кількість стовпців матриці:");
            int columns = int.Parse(Console.ReadLine());

            // Створити матрицю
            int[,] matrix = new int[rows, columns];

            // Заповнити матрицю випадковими числами
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(); // Зміна генерації випадкових чисел
                }
            }

            // Розрахувати середнє арифметичне
            double average = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    average += matrix[i, j];
                }
            }
            average /= rows * columns;

            // Підрахувати кількість елементів, більших за середнє
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] > average)
                    {
                        count++;
                    }
                }
            }

            // Вивести на екран результати
            Console.WriteLine("Середнє арифметичне: " + average);
            Console.WriteLine("Кількість елементів, більших за середнє: " + count);
        }
    }
}
