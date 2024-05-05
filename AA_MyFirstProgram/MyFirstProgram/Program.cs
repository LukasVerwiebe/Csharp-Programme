using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Test");
            Console.Beep();
            //Console.Write("TestNeu");

            // Test Kommentar
            /*
             * Test Kommentar
             */

            Console.WriteLine("\tLu\bka\ns");



            int x; // declaration
            x = 123; // initialization

            int y = 3124;

            int z = x + y;

            int age = 21;
            double height = 200.5;
            bool alive = true;
            char symbol = '@';
            String name = "Test";   

            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your height is " + height + "cm");
            Console.WriteLine("Are you alive: " + alive);
            Console.WriteLine(symbol);
            Console.WriteLine(name);

            String userName = symbol + name;
            Console.WriteLine(userName);

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.ReadKey();
        }
    }
}
