using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaraiblesAndConstants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //To store whole integer values we can use int data type
            //method 1
            int x; //declaring a variable
            x = 135; //assigning a value to the variable
            //method 2
            int y = 531; //declaring and assigning a value to the variable
            int add = x + y;
            //To store decimal values we can use float, double and decimal data types
            float z = 3.14f;
            double w = 2.71828;
            decimal v = 1.61803m;
            //to store single character values we can use char data type
            char c = 'A';
            //to store true or false values we can use bool data type
            bool isTrue = true;
            //to store text values we can use string data type
            string name = "John Doe";
            //===================================================//
            //constant is immutable value which means once it is assigned a value it cannot be changed
            // suppost double w= 2.71828; is a varaible value we can change it to double w= 3.14; but if we declare it as a constant we cannot change it
            w=3.14; //the value is changed because it is a variable
            //but if we declare it as a constant we cannot change it with keyword const so it will be not changed for lifetime 
            //const double C = 7.9; //the value cannot be changed because it is a constant
            const double C = 7.9; //the value cannot be changed because it is a constant
            // like w=3.14 we change the value ... but in the C we write C=3.14 ; it will give an error because it is a constant and cannot be changed
            //C=7.9; //the value cannot be changed because it is a constant




            Console.WriteLine("The value of x is: " + x + ", The Value of y is: "+y+", The sum of x and y is: "+add);
            Console.WriteLine("the decimal values are: float: " + z + ", double: " + w + ", decimal: " + v);
            Console.WriteLine("the character value is: " + c +", the boolean value is: " + isTrue + ", the string value is "+name);
            Console.WriteLine("the constant value is: " + C);

            Console.WriteLine("Press any key to exit...\a");
            Console.ReadKey();
        }
    }
}
