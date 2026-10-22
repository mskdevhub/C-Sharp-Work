using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFristProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is a simple C# program that prints "Hello, World!" to the console.
            /*
             * This program demonstrates the basic structure of a C# console application.
             * It includes a namespace, a class, and a Main method, which is the entry point of the program.
             */
            Console.Write("Hello, World!  ");
            Console.WriteLine("After hello, World! Press any key to exit...");
            Console.WriteLine("Escape Sequence");
            Console.WriteLine("This is a new line.\n This is another line.");
            Console.WriteLine("This is a tabbed line.\t This is another tabbed line.");
            Console.WriteLine("This is a backslash: \\ You can see it ");
            Console.WriteLine("This is a double quote: \" You can see it ");
            Console.WriteLine("This is a single quote: \' You can see it ");
            Console.WriteLine("This is a form feed: \f You can see it ");
            Console.WriteLine("This is a carriage return: \r You can see it ");
            Console.WriteLine("This is a vertical tab: \v You can see it ");
            Console.WriteLine("This is a null character: \0 You can see it ");
            Console.WriteLine("This is a Unicode character: \u263A You can see it ");
            Console.WriteLine("This is a hexadecimal character: \x263A You can see it ");
            Console.WriteLine("This is a backspace: \b You can see it ");
            Console.WriteLine("This is a line feed: \n You can see it ");
            Console.WriteLine("This is a horizontal tab: \t You can see it ");
            Console.Beep();
            Console.WriteLine("This is a bell sound: \a You can see it ");
            Console.ReadKey();
        }
    }
}
