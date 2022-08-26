using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsDemo
{
    internal class TestCircle
    {
        static void Main()
        {
            Circle e = new Circle(50);
            Console.WriteLine($"area of circle={e.GetArea()}");



        }
    }
}
