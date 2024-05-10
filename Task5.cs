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
            // Створення двовимірного масиву з логінами та паролями
            string[][] users = new string[][]
            {
            new string[] { "user1", "password1" },
            new string[] { "user2", "password2" },
            new string[] { "OA-Horkun", "12345" }
            };

            // Введення логіну та паролю з клавіатури
            Console.Write("Введіть логін: ");
            string login = Console.ReadLine();

            Console.Write("Введіть пароль: ");
            string password = "";
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else
                {
                    password += key.KeyChar;
                    Console.Write("*");
                }
            }

            // Перевірка введених даних
            bool isValid = false;
            bool isAdmin = false;
            foreach (string[] user in users)
            {
                if (user[0] == login && user[1] == password)
                {
                    isValid = true;
                    if (user[0] == "admin")
                    {
                        isAdmin = true;
                    }
                    break;
                }
            }

            // Виведення відповідного повідомлення
            if (isValid)
            {
                Console.WriteLine("Welcome!");
                if (isAdmin)
                {
                    // Виведення інформації про користувачів
                    Console.WriteLine("\nІнформація про користувачів:");
                    foreach (string[] user in users)
                    {
                        Console.WriteLine($"Логін: {user[0]}, Пароль: {user[1]}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }
}
