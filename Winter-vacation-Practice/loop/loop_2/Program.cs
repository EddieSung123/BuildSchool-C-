using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            Console.Write("請輸入數字 :");
            string input = Console.ReadLine();
            value = int.Parse(input);

            int k = value;
            for (int i =1; i<=value; i++)
            {
                for (int j=i; j>0; j--)
                {
                    Console.Write(k);
                }              
                Console.WriteLine();
                k--;
            }



            Console.ReadLine();
        }
       
    }
}
