using System;

namespace IntToString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and Initialize variable - INT and empty String value
            int integerVariable = 19;
            string convertedString;

            //test the console interprets value as INT
            Console.WriteLine(integerVariable);
            Console.ReadLine();

            //Convert INT to String type using string conversion method
            convertedString = integerVariable.ToString();
            Console.WriteLine($"The newly converted string = {convertedString}");
            Console.ReadLine();

            //Now convert a string into an integer. Declare and initialize string and empty int value

            string stringVariable = "200";
           

            Console.WriteLine(stringVariable);
            Console.ReadLine();

            //int intVar = Int32.Parse(stringVariable);
            int intVar = Int16.Parse(stringVariable);
            Console.WriteLine(intVar);
            Console.ReadLine();
        }
    }
}
