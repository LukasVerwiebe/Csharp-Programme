﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int friends = 10;

            friends = friends + 2;
            //friends += 2;
            //friends++;

            friends = friends - 1;
            //friends -= 1;
            //friends--;

            friends = friends * 2;
            //friends *= 2;

            friends = friends / 2;
            //friends /= 2;

            int remainder = friends % 2;

            Console.WriteLine(friends);
            Console.WriteLine(remainder);

            Console.ReadKey();
        }
    }
}
