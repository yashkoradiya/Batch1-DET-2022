﻿using ParamsDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class CommerceStudent : Student
    {
        public int economices { get; set; }
        public int accounts { get; set; }

        public int banking { get; set; }

        internal bool GetAvgMarks()
        {
            throw new NotImplementedException();
        }
    }
}


