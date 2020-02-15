using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1 // В пространстве имён System содержится метод для сортировки массива Array.Sort 
                // для поиска элемента в массиве метод Array.IndexOf
{
    class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 50);
            }
            Console.WriteLine("Массив до сортировки");
            foreach(int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Sort(array);
            Console.WriteLine("Массив после сортировки");
            foreach(int number in array)
            {
                Console.Write(number + " ");
            }
            Search(array);
            Console.ReadLine();
        }

        public static int[] Sort(int[] numbers) 
        {
            for(int i = 0; i < numbers.Length - 1; i++)
            {
                int temp;
                int min = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[min] > numbers[j])
                    {
                        min = j;
                    }
                }
                temp = numbers[min];
                numbers[min] = numbers[i];
                numbers[i] = temp;
            }
            return numbers;
        }

        public static void Search(int[] numbers)
        {
            int left = 0;
            int right = numbers.Length - 1;
            bool flag = true;
            int middle;
            Console.WriteLine();
            Console.WriteLine("Введите число, которое нужно найти в массиве");
            int value = Convert.ToInt32(Console.ReadLine());
            while (left <= right && flag)
            {
                middle = (left + right) / 2;
                if (numbers[middle] == value)
                {
                    flag = false;
                    Console.WriteLine("Значение " + value + " содержится в массиве");
                }
                else if (numbers[middle] > value)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            if (flag) 
            { 
                Console.WriteLine("Значение " + value + " не содержится в массиве"); 
            }
        }  
    }
}
