using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Order
    {
        static void Main()
        {
            /*int[] numbers = { 7, 9, 5 };

            var result = numbers.OrderBy(n => n);

            Console.WriteLine("Ordered list of numbers:");
            foreach (int number in result)
               Console.WriteLine(number);*/

            /*var dates = new DateTime[] {
        new DateTime(2015, 2, 15),
        new DateTime(2015, 3, 25),
        new DateTime(2015, 1, 5)
    };

            var result = dates.OrderBy(d => d);

            Console.WriteLine("Ordered list of dates:");
            foreach (DateTime dt in result)
                Console.WriteLine(dt.ToString("yyyy/MM/dd"));*/

            /*string[] String = { "Powerful","People","Makes","Places","Powerful" };

            var result = String.Reverse();

            Console.WriteLine("Characters in reverse order:");
            foreach (string character in result)
                Console.WriteLine(character);*/

            /*string[] capitals = { "Berlin", "Paris", "Madrid", "Tokyo", "London",
                          "Athens", "Beijing", "Seoul" };

            var result = capitals.OrderBy(c => c.Length).ThenBy(c => c);

            Console.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
            foreach (string capital in result)
                Console.WriteLine(capital);*/


            /*string[] names = { "Ned", "Ben", "Susan" };

            var result = names.OrderByDescending(n => n);

            Console.WriteLine("Descending ordered list of names:");
            foreach (string name in result)
                Console.WriteLine(name);*/


            var dates = new DateTime[] {
        new DateTime(2015, 3, 1),
        new DateTime(2014, 7, 1),
        new DateTime(2013, 5, 1),
        new DateTime(2015, 1, 1),
        new DateTime(2015, 7, 1)
    };

            var result = dates.OrderByDescending(d => d.Year).ThenByDescending(d => d.Month);

            Console.WriteLine("List of dates first ordered by year descending, and then by month descending:");
            foreach (DateTime dt in result)
                Console.WriteLine(dt.ToString("yyyy/MM/dd"));
        }


    }
    }

