using System;
using System.Collections.Generic;

namespace Task5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = new string[] { "1", "2", "1" };
            string[] secondArray = new string[] { "3", "2" };
            List<string> list = new List<string>();
            Unite(list, firstArray.Length, firstArray);
            Unite(list, secondArray.Length, secondArray);

            foreach (var item in list)
                Console.WriteLine(item);
        }

        static void Unite(List<string> list, int arrayLength, string[] array)
        {
            for (int i = 0; i < arrayLength; i++)
            {
                if (list.Contains(array[i]) != true)
                {
                    list.Add(array[i]);
                }
            }
        }
    }
}
