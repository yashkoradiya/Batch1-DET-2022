using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsDemo
{
    internal class ClassMy
    {
        public static void Main()
        {
            CompanyManager m = new CompanyManager { Name = "Balaji", Surname = "R", Phone = "9848445445" };
            Company company = new Company
            {
                Name = "SSL",
                Address = "Global City",
                Phone = "865835868",
                Website = "SONATA-SOFTWARE.COM ",
                Manager = m
            };

            Console.WriteLine(company.Print());
        }
    }
}

