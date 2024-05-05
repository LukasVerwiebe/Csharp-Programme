using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace AJ_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age >= 18)
            {
                Console.WriteLine("You are now signed up!");
            }
            else if(age > 100)
            {
                Console.WriteLine("You are too old to sign up!");
            }
            else if(age < 0)
            {
                Console.WriteLine("You are not born yet!");
            }
            else
            {
                Console.WriteLine("You must be 18+ to sign up!");
            }

            Console.WriteLine("Please enter your name: ");
            String name = Console.ReadLine();

            if(name == "")
            {
                Console.WriteLine("You did not enter your name!");
            }
            else
            {
                Console.WriteLine("Hello, " + name);
            }



            Console.WriteLine("What day is it today?");
            String day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("Its Monday!");
                    break;
                case "Tuesday":
                    Console.WriteLine("Its Tuesday!");
                    break;
                case "Wednesday":
                    Console.WriteLine("Its Wednesday!");
                    break;
                case "Thursday":
                    Console.WriteLine("Its Thursday!");
                    break;
                case "Friday":
                    Console.WriteLine("Its Friday!");
                    break;
                case "Saturday":
                    Console.WriteLine("Its Saturday!");
                    break;
                case "Sunday":
                    Console.WriteLine("Its Sunday!");
                    break;
                default:
                    Console.WriteLine(day + " is not a day!");
                    break;
            }

            Console.WriteLine("Whats the temperature outside: (C)");
            double temp = Convert.ToDouble(Console.ReadLine());

            if(temp >= 10 && temp <= 25)
            {
                Console.WriteLine("Its warm outside!");
            }
            else if(temp <= -50 || temp >= 50)
            {
                Console.WriteLine("DO NOT GO OUTSIDE!"); 
            }


            Console.Write("Enter your Name: ");
            String nameNew = Console.ReadLine();

            while(nameNew == "")
            {
                Console.Write("Enter your Name: ");
                nameNew = Console.ReadLine();
            }

            Console.WriteLine("Hello, " + nameNew);

            Console.ReadKey();
        }
    }
}
