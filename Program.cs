using System;
namespace HomeTask_1.NET
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введiть цiну одного зошита: ");
            decimal x = decimal.Parse(Console.ReadLine());
            Console.Write("Введiть цiну одної ручки: ");
            decimal y = decimal.Parse(Console.ReadLine());

            Console.Write("\nВведiть кiлькiсть зошитiв: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введiть кiлькiсть ручок: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write($"\nЗагальна сума покупки: {x * n + y * m}");
            }
        }
    }
