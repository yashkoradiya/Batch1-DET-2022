﻿namespace ParamsDemo
{
    internal class PersonAgeBase
    {
        public void Main()
        {
            Console.WriteLine("Enter the Age");
            int age = Convert.ToInt32(Console.ReadLine());
            try
            {

                if (age > 120)
                {
                    throw new Exception("Age is invalid");
                }
                else
                {
                    Console.WriteLine($"Age is {age}");
                }
            }
            catch (InvalidageExeption i)
            {
                Console.WriteLine(i.message);
            }
            catch (Exception e)
            {
            }

        }
    }
}