using System;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //declare variable that holds no value - declaring
            int x;
            int y;
            //assign values to initialized variables
            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();
            

            Console.WriteLine("What is your name?");
            Console.Write("Please Type your first name: ");
            //declaring and initializing variables in one step
            string firstName = Console.ReadLine();


            Console.WriteLine("What is your last name?");
            Console.Write("Please type in your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Hi, {firstName} {lastName}, I am Morpheus.");
            Console.WriteLine("We don't have much time; Follow the white rabbit");
            */

            Console.WriteLine("What programming term do you need defined?");
            Console.Write("Type in a C# concept: ");
            string userInput1 = Console.ReadLine();
            userInput1 = userInput1.ToUpper();

            if (userInput1 == "OPERATOR")
            {
                string inputDefinition = "An Operator is a the data type category that tells the computer what functions it can invoke on the variable";
                Console.WriteLine(inputDefinition);
            }
            
               
        }
    }
}
