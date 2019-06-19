﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulitplyNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantial the Class
            Multiply inputs = new Multiply();

            int num2 = 1;

            //Ask user for input
            Console.WriteLine("Please enter one or two numbers one at a time \nEnter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number if you want to.");
            string optionalNum = Console.ReadLine();
            
            //Display results if user gives one number
            {
                if (String.IsNullOrEmpty(optionalNum))
                {
                    Console.WriteLine("Your number multiplied by 1 is: " + inputs.multiplyInputs(num1, num2));
                }
               //Display resluts if user gives two numbers
                else
                {
                    num2 = Convert.ToInt32(optionalNum);
                    Console.WriteLine("Your numbers multiplied together is: " + inputs.multiplyInputs(num1, num2));
                }

            }


            Console.ReadLine();
        }
    }
}
