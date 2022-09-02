using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Aggregate
    {
        private static void Sample_Aggregate_Lambda_Simple()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var result = numbers.Aggregate((a, b) => a * b);
            Console.WriteLine("Aggregated numbers by multiplication:");
            Console.WriteLine(result); 
}
        static void Sample_Average_Lambda()
        {
        int[] numbers = { 10, 10, 11, 11 };
        var result = numbers.Average();
        Console.WriteLine("Average is:");
        Console.WriteLine(result);
        }

        static void Sample_Count_Lambda()
        {
            string[] names = { "Peter", "John", "Kathlyn", "Allen", "Tim" };
            var result = names.Count();
            Console.WriteLine("Counting names gives:");
            Console.WriteLine(result); 
         }
            
            static void Sample_Max_Lambda()
            {
            var coloroptions = new string[4];
            coloroptions[1] = "red";
            }


            static void Sample_Min_Lambda()
            {
                int[] numbers = { 6, 9, 3, 7, 5,1,0 };
                var result = numbers.Min();
                Console.WriteLine("Lowest number is:");
                Console.WriteLine(result);
            }

        static void Sample_Sum_Lambda()
        {
            int[] numbers = { 2, 5, 10 };
            var result = numbers.Sum();
           Console.WriteLine("Summing the numbers yields:");
           Console.WriteLine(result);
        }




        public static void Main()
        {
            Sample_Max_Lambda();
        }

    }

        
    }

