using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    /// <summary>
    /// derived class from emp
    /// </summary>
    public class Manager : Emp
    {
        private DateTime dateTime;
        private string v1;
        private int v2;

        public string Project { get; set; }
        public int Teamsize { get; set; }
        /// <summary>
        /// calling base class constructor from derived class 'base' keyword
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="doj"></param>
        /// <param name="project"></param>
        /// <param name="teamsize"></param>
        public Manager(int id, string name, DateOnly doj, string project, int teamsize) : base(id, name, doj)
        {
            this.Project = project;
            Teamsize = teamsize;
        }

        public Manager(int id, string name, DateTime dateTime, string v1, int v2) : base(id, name)
        {
            this.dateTime = dateTime;
            this.v1 = v1;
            this.v2 = v2;
        }

        public string Print()
        {
            return $"Emp Details={base.Print()}, Project={Project},Teamsize={Teamsize}";
        }
    }
}