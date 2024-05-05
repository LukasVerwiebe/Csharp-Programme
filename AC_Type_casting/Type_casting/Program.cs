using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_casting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double a = 3.14;
            int b = Convert.ToInt32(a);

            int c = 123;
            double d = Convert.ToDouble(c) + 0.1;

            int e = 312;
            String f = Convert.ToString(e);

            String g = "&";
            char h = Convert.ToChar(g);

            String i = "true";
            bool j = Convert.ToBoolean(i);

            Console.WriteLine(b);
            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());
            Console.WriteLine(d.GetType());
            Console.WriteLine(d);
            Console.WriteLine(f);
            Console.WriteLine(f.GetType());
            Console.WriteLine(h.GetType());
            Console.WriteLine(h);
            Console.WriteLine(i.GetType());
            Console.WriteLine(i);

            Console.ReadKey();  
        }
    }
}
