using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace year
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the year you want to judge : ");
            string input = Console.ReadLine();
            var year = int.Parse(input);

            if(year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine(year + "is a leap year");
            }
            else 
            {
                Console.WriteLine(year + "not a leap year");
            }

            Console.ReadLine();
        }
    }
}
