﻿using ParamsDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Science: Student
    {
        
            public int physics { get; set; }
            public int chemistry { get; set; }

            public int maths { get; set; }

            public  double GetAvgMarks()
            {
                return (physics + chemistry + maths) / 3;
            }
        }

    }

