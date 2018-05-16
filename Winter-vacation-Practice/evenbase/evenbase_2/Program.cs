using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenbase_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("輸入 : ");
            string[] input = Console.ReadLine().Split(',');

            var even = input.Where((x) => int.Parse(x) % 2 == 0).OrderBy(x => int.Parse(x));
            var basee = input.Where((x) => int.Parse(x) % 2 != 0).OrderBy(x => int.Parse(x));

            Console.Write("偶數 : ");
            foreach (var o in even)
            {
                if (o == even.Max())
                {
                    Console.Write(o);
                }
                else
                {
                    Console.Write(o + ",");
                }
            }

            Console.WriteLine();

            Console.Write("奇數 : ");
            foreach (var o in basee)
            {
                if (o == basee.Max())
                {
                    Console.Write(o);
                }
                else
                {
                    Console.Write(o + ",");
                }                
            }

            Console.ReadLine();

            //Console.Write("偶數 : ");
            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (int.Parse(input[i]) % 2 == 0)
            //    {
            //        Console.Write(input[i] + ",");
            //    }
            //}

            //Console.WriteLine();
            //Console.Write("奇數 : ");
            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (int.Parse(input[i]) % 2 == 1)
            //    {
            //        Console.Write(input[i] + ",");
            //    }

            //}
            //Console.ReadLine();
        }

    }
}
