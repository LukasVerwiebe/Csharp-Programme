﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, " + name);
            Console.WriteLine("Your age is " + age);

            Console.ReadKey();
        }
    }
}
