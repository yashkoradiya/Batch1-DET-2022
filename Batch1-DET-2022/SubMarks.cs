using ParamsDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsDemo
{
    public abstract class Student
    {
        public int regno { get; set; }
        public string Name { get; set; }



        public abstract double GetAvgMarks();



    }
}


namespace BATCH1_DET_2022
{
    internal class ScienceStudent : Student
    {
        public int physics { get; set; }
        public int chemistry { get; set; }

        public int maths { get; set; }

        public override double GetAvgMarks()
        {
            return (physics + chemistry + maths) / 3;
        }
    }

    internal class CommerceStudent : Student
    {
        public int economices { get; set; }
        public int accounts { get; set; }

        public int banking { get; set; }

        public override double GetAvgMarks()
        {
            return (economices + accounts + banking) / 3;
        }
    }
}


