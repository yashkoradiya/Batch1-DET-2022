using Batch1_DET_2022.Models;
using ConsoleAppDemo;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Emp = Batch1_DET_2022.Models.Emp;

namespace Batch1_DET_2022
{
    class DatabaseFirstApproach
    {


        static void Main()
        {
            UpdateEmpDetails();
            Console.ReadLine();
        }

        private static void GetEmployeeDetails()
        {
            var ctx = new TrainingContext();
            var employees = ctx.Emps.FromSqlRaw("GETALLEMPSDETAILSBYEMPNO @p0", 7788).ToList();
            foreach (var e in employees)
            {
                Console.WriteLine(e.Ename);
            }



        }

        private static void RemovingEmployeeDetails()
        {
            var ctx = new TrainingContext();
            var Value = 5689;
            int employee = ctx.Database.ExecuteSqlRaw("REMOVEEMPLOYEE @p0", Value);
            Console.WriteLine($"No Of Rows Affected {employee}");
        }


        private static void GetEmployeeDetailsWithoutPara()
        {
            var ctx = new TrainingContext();

            var employees = ctx.Emps.FromSqlRaw($"GETALLEMPSDETAILS").ToList();

            foreach (var e in employees)
            {
                Console.WriteLine(e.Ename);
            }
        }
        private static void UpdateEmpDetails()
        {
            var ctx = new TrainingContext();
            try
            {
                var id = 7876;
                string newName = "yash";
                int employee = ctx.Database.ExecuteSqlRaw("UPDATENAME @p0,@p1", id, newName);
                Console.WriteLine(employee);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }

     }

  }
 





     

   
   




            