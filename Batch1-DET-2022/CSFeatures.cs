using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal interface CSFeatures
    {
        public static void Main()
        {
            Action<string> action = (string name) => { Console.WriteLine($"Hi {name}"); };

            Action<string, string> action1 = (string name, string place) => { Console.WriteLine($"Hi {name}, am in {place}"); };
            Action<string, string , string> action2 = (string name, string place, string company) => { Console.WriteLine($"Hi {name}, am in {place}, work in {company}"); };

            action.Invoke("Yash" );
            action1.Invoke("Yash"," Bangalore");
            action2.Invoke("Yash", "Bangalore", "Sonata Software");


            Action<int, string, string> PrintEmp = (int id, string name, string email) => { Console.WriteLine($"Hi {id}, I am {name}, my {email}"); };
            
                
            

            PrintEmp.Invoke(22802, "Yash", "yash.k");

            HashSet<int> ids = new HashSet<int>();
            ids.Add(25345);
            ids.Add(25346);
            ids.Add(25347);
            ids.Add(25348);
            ids.Add(25349);

            foreach(int id in ids)
                Console.WriteLine(id);
        }
    }
}
