using System;
using System.Collections.Generic;

namespace Array_Collection_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Tahidul", "Habiba", "Tayeb", "Tithi" };

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
