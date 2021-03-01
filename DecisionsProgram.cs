// Test Comment

using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Tim's Big Giveaway!");
            Console.Write("Choose a door: 1, 2, or 3: ");
            string userInput = Console.ReadLine();
            string message = "";

            if (userInput == "1")
                message = "You won a brand new car!";
           
            else if (userInput == "2")
                message = "You won a vacation to the Bahamas!";
            
            else if (userInput == "3")
                message = "You won a $100 giftcard!";
            
            else
                message = "Sorry, please choose a numerical value from 1-3";
            
            Console.WriteLine(message);
            Console.ReadLine();
            */

            //If-Else Option: only when you have 2 possible options to account for
            Console.WriteLine("Welcome to Prize Door Game Show!");
            Console.Write("Please choose a door: 1, 2, or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "nothing, sucks to suck";

            //Console.WriteLine("You won a {0}.", message);
            Console.WriteLine("You entered: {0}, therefore you won {1}.", userValue, message);
            Console.ReadLine();
        }
    }
}
