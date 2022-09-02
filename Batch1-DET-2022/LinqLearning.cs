using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class LinqLearning
    {
        private static void Main()
        {
            //The Three Parts of a LINQ Query: deffered execution
            // 1. Data source.
            List<int> numbers = new List<int>();
            numbers.Add(101);
            numbers.Add(102);
            numbers.Add(103);
            numbers.Add(104);
            numbers.Add(105);



            //var numQuery = numbers.Select(x => x);
            // 2. Query creation. sql type
            // var numQuery = from num in numbers
            // where num > 102//select num from numbers
            // select num;


            //var numQuery = (from num in numbers //select num from numbers
            //select num).ToList();


            // numbers.Add(200);//here also its adds the data.

            //Lamda expression
            //var numQuery = numbers.Where(x => x > 102);


            //3. Query execution.

            //foreach (int num in numQuery)
            //{
                //Console.Write(" {0} ", num);
            //}
            //Console.ReadLine();


        }
    }
}
