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
            /* int x;
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

             //naming the variables #humanreadable #camelCase*/

            //Conditions

            /*Console.WriteLine("There is a great price waiting for you behind the door!");
            Console.WriteLine("Find out what is waiting for you!");
            Console.Write("Choose the card: 1, 2 or 3: ");
            string userInput = Console.ReadLine();
            string message = "";

            if (userInput == "1")
            {
                message = "Congratulations! You won a new car!";
               // Console.WriteLine(message);
            }
            else if (userInput == "2") {
                message = "Congratulations! You won a package holiday!";
               // Console.WriteLine(message);
            }
            else if (userInput == "3")
            {
                message = "Congratulations! You won a bag of cash!";
               // Console.WriteLine(message);
            }
            else
            {
                message = "Sorry, we didn't get your choice.";
                message = "Try again!";
                //Console.WriteLine(message);
            }

            Console.WriteLine(message);
            Console.ReadLine();*/


            //for IF/Else conditions
            Console.WriteLine("Find out what is waiting for you!");
            Console.Write("Choose the card: 1, 2 or 3: ");
            string userInput = Console.ReadLine();

            //ternary operator
            string price = (userInput == "1") ? "a new car" : "a can opener";
            /*  Console.Write("You won ");
             Console.Write(price);
             Console.Write(".");
             Console.ReadLine();*/

            //replacement code
            // Console.WriteLine("You won a {0}", price);
            Console.WriteLine("You entered: {0}, therefore you won a {1}.", userInput, price);
            Console.ReadLine();

        }
    }
}
