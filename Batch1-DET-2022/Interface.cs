﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal interface Interface
    {
        string SendEMail();
    }

    public interface INotify
    {
        string SendSMS();
    }

    class Author : Interface, INotify
    {
        internal Author author;
        internal int Price;
        internal int Qty;

        public string Name { get; set; }
        public string EMail { get; set; }
        public char Gender { get; set; }

        public string SendEMail()
        {
            return $"Mail sent to {Name}, {EMail},{Gender}";
        }

        public string SendSMS()
        {
            return $"{Name} subscribed SMS notifications";
        }
    }

    class SITLAuthor : Author, Interface
    {
        public string SendEMail()
        {
            return $"mail sent to Name={Name}, EMail={EMail},Gender={Gender}";
        }
    }

    class TestIAuthor
    {
        public static void Main()
        {
            Author a = new Author { Name = "mary", EMail = "mary.s", Gender = 'F' };
            SITLAuthor sa = new SITLAuthor { Name = "roja", EMail = "roja.p", Gender = 'F' };

            Console.WriteLine(a.SendEMail());
            Console.WriteLine(a.SendSMS());
            Console.WriteLine(sa.SendEMail());
        }
    }
}


