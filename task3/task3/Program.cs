using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3 
{
    class Program
    {
        static void Main()
        {
            InString();
        }
        public static void InString()
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            str = str.ToLower();
            string[] words = str.Split(new char[] { ' ', ',', '.', ':', '!', '?', ';', '\'', '\"', '*', '%', '/', '+', '-', '(', ')', '=' }, StringSplitOptions.RemoveEmptyEntries);
            int l;
            for(int i = 0; i < words.Length; i++)
            {
                l = 0;
                for(int j = 0; j < words.Length; j++)
                {
                    if(words[i] == words[j])
                    {
                        l += 1;
                    }
                }
                if (l < 2)
                {
                    Console.WriteLine(words[i]);
                }  
            }
            Console.ReadLine();
        }
    }
}
