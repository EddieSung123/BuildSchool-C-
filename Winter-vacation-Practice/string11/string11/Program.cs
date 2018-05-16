using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string11
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, MyData> _dictionary = new Dictionary<string, MyData>();
            _dictionary.Add("0", new MyData { Number = "零" });
            _dictionary.Add("1", new MyData { Number = "壹" });
            _dictionary.Add("2", new MyData { Number = "貳" });
            _dictionary.Add("3", new MyData { Number = "參" });
            _dictionary.Add("4", new MyData { Number = "肆" });
            _dictionary.Add("5", new MyData { Number = "伍" });
            _dictionary.Add("6", new MyData { Number = "陸" });
            _dictionary.Add("7", new MyData { Number = "柒" });
            _dictionary.Add("8", new MyData { Number = "捌" });
            _dictionary.Add("9", new MyData { Number = "玖" });

            Console.Write("輸入 : ");
            string input = Console.ReadLine();
            var number = input.ToCharArray();
            Console.Write("顯示 : ");
            for (var i = 0; i<4; i++)
            {
                var y = number[i].ToString();
                Console.Write(_dictionary[y].Number + " ");
            }

            Console.ReadLine();
        }
        
      
    }
}
