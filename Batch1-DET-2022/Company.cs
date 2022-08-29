using ParamsDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsDemo
{
    internal class Company
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string phone { get; set; }
        public string Phone { get; internal set; }
        public string Website { get; set; }

        public CompanyManager Manager { get; set; } //containment

        public string Print()
        {
            return $"Name={Name}, Address={Address}, phone={Phone}, Website={Website}, Manager={Manager.Print()}";
        }




    }
}
