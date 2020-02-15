using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace task4
{
    class Program
    {
        static void Main()
        {
            Factorial();
        }
        public static void Factorial ()
        {
            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());
            BigInteger f = 1;
            for (int i = 1; i <= num; i++)
            {
                f *= i;
            }
            Console.WriteLine(f);
            Console.ReadLine();
        }
    }
}
