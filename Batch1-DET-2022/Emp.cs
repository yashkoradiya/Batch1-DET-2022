﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    public class Emp
    {
        //data declared inside class are known as "fields"
        int id;
        string name;
        string dept;
        double sal;
        DateOnly doj;
        private DateTime dateTime;

        //constructor - is a function used to init object data
        //has the same name as classname, no ret type
        public Emp(int id, string name, DateOnly doj)
        {
            this.id = id; this.name = name; this.doj = doj;
        }
        public Emp()
        {
            id = -1; name = "no name";
        }
        public Emp(int id, string name)
        {
            this.id = id; this.name = name;
        }

        public Emp(int id, string name, DateTime dateTime) : this(id, name) => this.dateTime = dateTime;

        //function written inside a class is known as method
        public int GetYearsofExp()
        {
            return DateTime.Now.Year - doj.Year;
        }

        public string Print()   //only virtual method can be overridden
        {
            return $"Emp Id={id}, Name={name}, Experience={GetYearsofExp()} Years";
        }


    }
}