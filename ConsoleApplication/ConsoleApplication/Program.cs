using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Arthur";
            string state = "Idaho";
            var date = DateTime.Now;
            DateTime Christmas = new DateTime(2019, 12, 25);
            double daysUntilChristmas = Christmas.Subtract(DateTime.Today).TotalDays;

            Console.WriteLine($"Hello, my name is {name} and I am from {state}. It is {date.ToString("dddd, dd MMMM yyy")}");
            Console.WriteLine($"There are {daysUntilChristmas} days until Christmas");
        }
    }
}
