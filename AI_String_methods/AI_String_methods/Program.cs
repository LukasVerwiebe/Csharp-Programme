using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_String_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String fullName = "Lukas Verwiebe";
            String phoneNumber = "123-456-7340";

            //fullName = fullName.ToUpper();
            //fullName = fullName.ToLower();
            //Console.WriteLine(fullName);

            //phoneNumber = phoneNumber.Replace("-", "/");
            //phoneNumber = phoneNumber.Replace("/", "");
            //Console.WriteLine(phoneNumber);

            //String userName = fullName.Insert(0, "Mr.");
            //Console.WriteLine(userName);

            //Console.WriteLine(fullName.Length);

            String firstName = fullName.Substring(0, 5);
            String lastName = fullName.Substring(6, 8);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);    

            Console.ReadKey();
        }
    }
}
