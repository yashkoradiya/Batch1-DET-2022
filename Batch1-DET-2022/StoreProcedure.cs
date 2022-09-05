using Batch1_DET_2022.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class StoreProcedure
    {

        static void Main()
        {
            updatenames();
            Console.ReadLine();
        }
        private static void updatenames()
        {
            var ctx = new TrainingContext();
            var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@empno",
                            SqlDbType =  System.Data.SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = 7566
                        },

                         new SqlParameter() {
                            ParameterName = "@ename",
                            SqlDbType =  System.Data. SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data. ParameterDirection.Input,
                            Value = "ammu",
                        }

                       //    new SqlParameter() {
                       //     ParameterName = "@deptno",
                       //     SqlDbType =  System.Data. SqlDbType.Int,
                       //     Size = 100,
                       //     Direction = System.Data. ParameterDirection.Input,
                       //     Value = "20"},
                       };

            try
            {
                var result = ctx.Database.ExecuteSqlRaw("updatename @empno, @ename", param);
                Console.WriteLine("added");
            }
            catch (Exception ex)
            {

                throw;
            }


            Console.WriteLine("update successful");

        }
    }
}
