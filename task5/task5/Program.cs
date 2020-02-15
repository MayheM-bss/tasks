using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main()
        {
            Bs();
        }
        public static void Bs()
        {
            Console.WriteLine("Введите скобочную последовательность");
            string brackets = Console.ReadLine();
            while(brackets.Contains("()") || brackets.Contains("[]") || brackets.Contains("{}"))
            {
                brackets = brackets.Replace("()", "");
                brackets = brackets.Replace("[]", "");
                brackets = brackets.Replace("{}", "");
            }
            if (string.IsNullOrWhiteSpace(brackets))
            {
                Console.WriteLine("Данная последовательность правильная");
            }
            else
            {
                Console.WriteLine("Данная последовательность неправильная");
            }
            Console.ReadLine();
        }
    }
}
