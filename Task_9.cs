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

            // Створити матрицю 10x8
            int[,] matrix = new int[10, 8];

            // Заповнити матрицю випадковими числами з діапазону [-10, 10]
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    matrix[i, j] = random.Next(-10, 11);
                }
            }

            // Розрахувати добуток від'ємних елементів
            int product = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        product *= matrix[i, j];
                    }
                }
            }

            // Вивести на екран добуток від'ємних елементів
            if (product == 1)
            {
                Console.WriteLine("В матриці немає від'ємних елементів.");
            }
            else
            {
                Console.WriteLine("Добуток від'ємних елементів: " + product);
            }
        }
    }
}
