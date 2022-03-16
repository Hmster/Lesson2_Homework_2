using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "OOO Магазин";
            string saller = "Иванов И.И.";
            decimal sum1 = 1450;
            decimal sum2 = 2500;
            DateTime date = DateTime.Now;
            int sale = 2345;
            int check = 3211;
            decimal sum = sum1 + sum2;

            Console.WriteLine($"\t\tМагазин {name}\n\t\tЧек N {check}\n\t\tКассир: {saller}");
            Console.WriteLine("\t----------------------------------");
            Console.WriteLine($"1.Какой-то товар\t-----------\t 1шт.");
            Console.WriteLine($"  Стоимость\t\t-----------\t{sum1}р.");
            Console.WriteLine($"2.Еще один товар\t-----------\t 1шт.");
            Console.WriteLine($"  Стоимость\t\t-----------\t{sum2}р.\n");
            Console.WriteLine("\t----------------------------------");
            Console.WriteLine($"Всего:\t\t-----------\t\t{sum}р.");
            Console.WriteLine("\t----------------------------------\n");
            Console.WriteLine($"Итого:\t\t-----------\t\t{sum}р.\n");
            Console.WriteLine($"\t    Дата: {date}");

            Console.ReadKey();
        }
     
    }
}
