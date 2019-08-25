using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Starter
            /*Console.WriteLine("Hello World!");
            Console.ReadLine();
            Console.WriteLine("What is your name?");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);
            Console.ReadLine();*/

            //Data Types
            //asking .net runtime to allocate space for particular variables of a particular type\

            //declaring variables
            int x;
            int y;

            x = 7;
            y = 3;

            Console.WriteLine(x + y);
            Console.ReadLine();

            Console.WriteLine("What is your name?");
            Console.Write("Write your first name: ");
            string myFirstName = Console.ReadLine();

            Console.Write("Type your last name: ");
            string myLastName = Console.ReadLine(); //initializations

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
            Console.ReadLine();

            //naming the variables #humanreadable #camelCase
        }
    }
}
