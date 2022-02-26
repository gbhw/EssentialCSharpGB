using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBHWEssential
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now;

            Console.Write("Введите имя пользователя: ");
            string userName = Console.ReadLine();

            Console.WriteLine($"Привет, {userName}, сегодня {currentDate.Date.ToShortDateString()} г.");

            Console.ReadKey();
        }
    }
}
