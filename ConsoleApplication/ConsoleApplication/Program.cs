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

            // Part One
            string name;
            string location;
            var date = DateTime.Now;
            DateTime Christmas = new DateTime(2019, 12, 25);
            double daysUntilChristmas = Christmas.Subtract(DateTime.Today).TotalDays;

            Console.WriteLine("Please, enter your name:");
            name = Console.ReadLine();

            Console.WriteLine("Please, enter your location:");
            location = Console.ReadLine();

            Console.WriteLine($"Hello, my name is {name} and I am from {location}. It is {date.ToString("dddd, dd MMMM yyy")} and there are {daysUntilChristmas} days until Christmas");


            // Part Two

            double width, height, woodLength, glassArea;
            string widthString, heightString;


            Console.WriteLine("Please, enter the width:");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);


            Console.WriteLine("Please, enter the height:");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");

            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");
        }
    }
}
