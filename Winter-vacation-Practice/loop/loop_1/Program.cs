using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入 : ");
            string input = Console.ReadLine();
            var chars = input.ToCharArray();
            Console.Write("輸出 : ");
            for (int ctr = chars.Length - 1; ctr >= 0; ctr--)
            {

                Console.Write(chars[ctr]);
            }

            Console.ReadLine();
        }
    }
}
