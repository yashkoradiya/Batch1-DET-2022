using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Set
    {
        private static object item;

        static void Sample_Distinct_Lambda()
        {
            int[] numbers = { 1, 2, 2, 3, 5, 6, 6, 6, 8, 9 };

            var result = numbers.Distinct();

            Console.WriteLine("Distinct removes duplicate elements:");
            foreach (int number in result)
               Console.WriteLine(number);
        }
        static void Sample_Except_Lambda()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5 };

            var result = numbers1.Except(numbers2);

            Console.WriteLine("Except creates a single sequence from numbers1 and removes the duplicates found in numbers2:");
            foreach (int number in result)
                Console.WriteLine(number);
        }

        static void Sample_Intersect_Lambda()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5 };

            var result = numbers1.Intersect(numbers2);

            Console.WriteLine("Intersect creates a single sequence with only the duplicates:");
            foreach (int number in result)
                Console.WriteLine(number);
        }

        static void Sample_Union_Lambda()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5 };

            var result = numbers1.Union(numbers2);

            Console.WriteLine("Union creates a single sequence and eliminates the duplicates:");
            foreach (int number in result)
                Console.WriteLine(number);
        }

        static void Sample_All_Lambda()
        {
            string[] names = { "John", "Peter", "Jacob", "Harry", "Jackson" };

            var result = names.Where(n => n.Contains("o"));

           
            Console.WriteLine(result);
        }

        static void Reverse()
        {
            string[] word = { "blueberry", "blackberry", "abacus" };
            foreach (string item in word)
                Console.WriteLine(item.Reverse().ToArray()); 
        }

        static void CountContains()
        {
            string[] names = { "John", "Peter", "Jacob", "Harry", "Jackson" };

            var name = from n in names
                       where n.Contains('o')
                       select n;

            foreach (string n in name)
                Console.WriteLine(n);
        }
        public static void WordsCount()
        {
            string[] words1 = { "believe", "relief", "receipt", "field" };

            foreach (string word in words1)
            {
                Console.WriteLine($"{word}--{word.Length} ");
            }
        }

        public static void OrderDescending()
        {
            string[] names = { "John", "Peter", "Jacob", "Harry", "Jackson" };
            var names1 = names.OrderByDescending(x => x.Length);
            var result = names1.Take(1);
            foreach (var name in result)
                Console.WriteLine(name);
        }
      // public static void Numbers()
        //{
            ///int[] numbers = { 1, 3, 2, 0 }; 
        //string[]={‘C#’, ‘SQL’, ‘LINQ’, ‘Java’};
        //}



           private static void String_Groupby()
            {
            List<string> list4 = new List<string>() { "basket", "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };
            var wordGroups = list4.GroupBy(x => x[0]).Select
                (y => new { FirstLetter = y.Key, Words = y });
            foreach (var group in wordGroups)
            {
                Console.WriteLine("Words that starts with the" + " letter '{0}': ", group.FirstLetter);

                foreach (var word in group.Words)
                {
                    Console.WriteLine(word);

                }
                Console.WriteLine();
            }
        }
         
    public static void Main()
        {
        String_Groupby();
        }
    }
}
