using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCastingAndUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //user input = data provided by the user to the program





            Console.Beep();
            //type casting = converting a value from one data type to another data type
            //              defferent data types have different sizes and ranges of values they can store
            //              we have varaible we want to conver so we make  another varaible and call in the function to convert and the value

            double pi = 3.14159;
            int convertedPi = Convert.ToInt32(pi); 
            int a = 10;
            string b = Convert.ToString(a); //converting int to string
            char c = 'A';
            string d = Convert.ToString(c); //converting char to string
            bool e = true;
            string f = Convert.ToString(e); //converting bool to string


            Console.WriteLine("Value of pi: " + pi);
            Console.WriteLine("Converted pi to int: " + convertedPi);
            Console.WriteLine("Type of pi: " + pi.GetType());
            Console.WriteLine("Type of converted pi: " + convertedPi.GetType());
            Console.WriteLine("Value of a: " + a);
            Console.WriteLine("Converted a to string: " + b);
            Console.WriteLine("Type of a: " + a.GetType());
            Console.WriteLine("Type of converted a: " + b.GetType());
            Console.WriteLine("Value of c: " + c);
            Console.WriteLine("Converted c to string: " + d);
            Console.WriteLine("Type of c: " + c.GetType());
            Console.WriteLine("Type of converted c: " + d.GetType());
            Console.WriteLine("Value of e: " + e);
            Console.WriteLine("Converted e to string: " + f);
            Console.WriteLine("Type of e: " + e.GetType());
            Console.WriteLine("Type of converted e: " + f.GetType());

            Console.WriteLine("press any key to skip...\a");
            Console.ReadKey();

        }
    }
}
