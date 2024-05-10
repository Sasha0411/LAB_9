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

            // Отримати кількість спортсменів і стрибків
            Console.WriteLine("Введіть кількість спортсменів:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть кількість стрибків:");
            int m = int.Parse(Console.ReadLine());

            // Створити масив для зберігання результатів
            double[,] results = new double[n, m];

            // Заповнити масив результатами
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    results[i, j] = random.NextDouble() * 10 + 1; // Стрибки в діапазоні 1-10
                }
            }

            // Вивести таблицю результатів
            Console.WriteLine("Результати:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Спортсмен " + (i + 1) + ": ");
                for (int j = 0; j < m; j++)
                {
                    Console.Write(results[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Знайти переможця
            double bestResult = 0;
            int winnerIndex = 0;
            for (int i = 0; i < n; i++)
            {
                double total = 0;
                for (int j = 0; j < m; j++)
                {
                    total += results[i, j];
                }
                if (total > bestResult)
                {
                    bestResult = total;
                    winnerIndex = i;
                }
            }

            // Вивести інформацію про переможця
            Console.WriteLine("\nПереможець: Спортсмен " + (winnerIndex + 1));
            Console.WriteLine("Його результат: " + bestResult);
        }
    }
}
