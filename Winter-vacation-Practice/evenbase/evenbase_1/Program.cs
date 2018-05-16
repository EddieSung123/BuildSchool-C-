using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenbase_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            Console.WriteLine("請輸入您要判斷的數字");
            string input = Console.ReadLine();
            value = int.Parse(input);

            if (value % 2 ==0)
            {
                Console.WriteLine(input + " 為偶數");
            }
            else
            {
             Console.WriteLine(input + "為奇數");
            }
            Console.ReadLine();

        }
    }
}
