using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal interface ICar
    {
        int GetPrice(string name);
    }

    class BMW : ICar
    {
        internal string Name;
        internal string Color;

        public int GetPrice(string name)
        {
            if (name == "M3")
                return 13000000;
            else if (name == "X7")
                return 9600000;
            else
                return 3500000;
        }
    }

    class Hyundai : ICar
    {
        internal string Name;
        internal string Color;

        public int GetPrice(string name)
        {
            if (name == "Creta")
                return 1700000;
            else if (name == "Verna")
                return 1300000;
            else
                return 800000;
        }
    }

    class TestIcar
    {
        public static void Main()
        {
            BMW a = new BMW { Name = "X7", Color = "Black" };
            Hyundai sa = new Hyundai { Name = "Creta", Color = "White" };

            Console.WriteLine(a.GetPrice("M3"));
            Console.WriteLine(a.GetPrice("X7"));
            Console.WriteLine(sa.GetPrice("Creta"));
        }
    }
}



