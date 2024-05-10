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

            // Двовимірний масив з назвами місяців та кількістю днів
            string[,] months = {
            { "Січень", "31" },
            { "Лютий", "28" }, // 29 днів у лютому у високосний рік
            { "Березень", "31" },
            { "Квітень", "30" },
            { "Травень", "31" },
            { "Червень", "30" },
            { "Липень", "31" },
            { "Серпень", "31" },
            { "Вересень", "30" },
            { "Жовтень", "31" },
            { "Листопад", "30" },
            { "Грудень", "31" }
        };

            // Вибір режиму роботи
            while (true)
            {
                Console.WriteLine("\nОберіть режим роботи:");
                Console.WriteLine("1. Отримати інформацію про конкретний місяць");
                Console.WriteLine("2. Вивести всю таблицю");
                Console.WriteLine("0. Вийти");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        GetMonthInfo(months);
                        break;
                    case 2:
                        PrintMonthTable(months);
                        break;
                    case 0:
                        Console.WriteLine("Вихід з програми...");
                        return;
                    default:
                        Console.WriteLine("Неправильний вибір. Спробуйте ще раз.");
                        break;
                }
            }
        }

        static void GetMonthInfo(string[,] months)
        {
            Console.WriteLine("\nВведіть номер місяця (1-12):");
            int monthIndex = int.Parse(Console.ReadLine());

            if (monthIndex < 1 || monthIndex > months.Length)
            {
                Console.WriteLine("Неправильний номер місяця.");
                return;
            }

            string monthName = months[monthIndex - 1, 0];
            string daysCount = months[monthIndex - 1, 1];

            Console.WriteLine("\nМісяць: " + monthName);
            Console.WriteLine("Кількість днів: " + daysCount);
        }

        static void PrintMonthTable(string[,] months)
        {
            Console.WriteLine("\n\tМісяць\t|\tКількість днів");
            Console.WriteLine("-----------------------------");
            for (int i = 0; i < months.Length; i++)
            {
                string monthName = months[i, 0].PadRight(10);
                string daysCount = months[i, 1].PadLeft(3);
                Console.WriteLine("{0}\t|\t{1}", monthName, daysCount);
            }
        }
    }
}
