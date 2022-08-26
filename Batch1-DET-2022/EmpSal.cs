using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ParamsDemo
{
    internal class EmpSal
    {
        int rollno;
        string name;
        string address;
        int pincode;
        long phonenum;
        int gsal;
        int pf;

        public EmpSal (int rollno, string name, string address, int pincode, long phonenum, int gsal)
        {
            this. rollno = rollno;
            this.name = name;
            this. address = address;
            this. pincode = pincode;
            this. phonenum = phonenum;
            this. gsal = gsal;
            //this. pf = pf;
        }
        
        public int GetEmpnetsalary()
        {
            int netsalary;
            pf = 12 * gsal / 100;
            netsalary = gsal - pf;
            return netsalary;
        }

        public char GetEmpGrade()
        {
            if (GetEmpnetsalary() > 10000)
            {
                return 'A';
            }
            else if (GetEmpnetsalary() > 5000)
            {
                return 'B';
            }
            else return 'C';
        }
    }
}
