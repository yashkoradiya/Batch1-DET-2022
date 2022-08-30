﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ParamsDemo
{
    internal class ParamDemo
    {
        public static int Sum(params int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
                sum += i;
            return sum;
        }
        public void Main()
        {
            int x;
           
            try
            {
                DateTime DOB = new DateTime(19, 56, 8, 12, 8, 12, 23);
                Console.WriteLine("Enter a number");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine(Sum(1, 2, 3, x));
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("please enter a number <=10000");//user friendly messages
            }
            catch (FormatException ex)
            {
                Console.WriteLine("please enter a valid number");//user friendly messages
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, error occured...contact admin");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
            }

            
            finally
            {
                Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
                int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
                Console.WriteLine(Sum(a));
             
                Console.WriteLine("Thanks For Entering Number");
            }
            
        }
    }
}
