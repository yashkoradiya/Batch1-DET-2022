using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ParamsDemo
{
    internal class ReferencePerson
    {
        string Firstname;
        string Lastname;
        string Emailaddress;
        DateOnly dob;

        public object FirstName { get; private set; }
        public object LastName { get; private set; }

        public ReferencePerson(string Firstname, string Lastname, string Emailaddress, DateOnly dob)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Emailaddress = Emailaddress;
            this.dob = dob;
        }

        public ReferencePerson(string Firstname, string Lastname, string Emailaddress)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Emailaddress = Emailaddress;
        }

        public ReferencePerson(string Firstname, string Lastname, DateOnly dob)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.dob = dob;
        }

        private  int CalculateAge()
        {
            int age = 0;
            age = DateTime.Now.Year - dob.Year;
            if (DateTime.Now.DayOfYear < dob.DayOfYear)
                age = age - 1;

            return age;
        }
        public int BirthYear()
        {
            return dob.Year;
        }
        public string GetInfo()
        {
            return $"{Firstname} {Lastname}";
        }

        public string IsAdult()
        {
            int age = CalculateAge();
            if (age > 18)
            {
                return "Is Adult";
            }
            else
            {
                return "Is not an Adult";
            }
        }
        public string GetSunSign()
        {
            string str = string.Empty;
            int month = dob.Month;
            int day = dob.Day;
            if (((month == 3) && (day >= 21 || day <= 31)) || ((month == 4) && (day >= 01 || day <= 20)))
            {
                return "Aires";
            }
            if (((month == 4) && (day >= 21 || day <= 31)) || ((month == 5) && (day >= 01 || day <= 21)))
            {
                return "Taurus";
            }
            if (((month == 5) && (day >= 21 || day <= 31)) || ((month == 6) && (day >= 01 || day <= 21)))
            {
                return "Gemini";
            }
            if (((month == 6) && (day >= 22 || day <= 31)) || ((month == 7) && (day >= 01 || day <= 22)))
            {
                return "Cancer";
            }
            if (((month == 7) && (day >= 23 || day <= 31)) || ((month == 8) && (day >= 01 || day <= 22)))
            {
                return "leo";
            }
            if (((month == 8) && (day >= 23 || day <= 31)) || ((month == 9) && (day >= 01 || day <= 21)))
            {
                return "Virgo";
            }
            else
            {
                return "SUN SIGN UNKOWN";
            }
        }
        public string BDayStatus()
        {
            var dateNow = DateOnly.FromDateTime(DateTime.Now);
            if (dob == dateNow)
            {
                return "IT IS THE PERSON'S BIRTHDAY";
            }
            else
            {
                return "IT IS NOT THE PERSON'S BIRTHDAY";
            }
        }
        public string DefaultUsername()
        {
            return $"{FirstName}{LastName}{dob.Year}";
        }
        public string ChineseZodiac()
        {
            int year = dob.Year;
            if (year % 12 == 0) { return "Monkey"; }
            else if (year % 12 == 1) { return "Rooster"; }
            else if (year % 12 == 2) { return "Dog"; }
            else if (year % 12 == 3) { return "Pig"; }
            else if (year % 12 == 4) { return "Rat"; }
            else if (year % 12 == 5) { return "Ox"; }
            else if (year % 12 == 6) { return "Tiger"; }
            else if (year % 12 == 7) { return "Rabbit"; }
            else if (year % 12 == 8) { return "Dragon"; }
            else if (year % 12 == 9) { return "Snake"; }
            else if (year % 12 == 10) { return "Horse"; }
            else { return "Sheep"; }
        }
    }
}
   
    

