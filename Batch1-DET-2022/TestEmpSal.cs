using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsDemo
{
    internal class TestEmpSal
    {
        public static void Main()
        {
            EmpSal emp = new EmpSal(22555, "Yash", "Bangaluru", 560098, 8141727390, 33500);
            Console.WriteLine($"Employee sal={emp.GetEmpnetsalary()}");
            Console.WriteLine($"Employee grade={emp.GetEmpGrade()}");
        }
    }
}
