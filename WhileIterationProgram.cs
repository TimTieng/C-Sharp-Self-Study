using System;

namespace WhileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //Practical Use - Menu Console Application
            Console.Clear(); //This clears the console menu

            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
            MainMenu();
        }
        private static bool MainMenu() //bool is part of the method declaration because we defined a boolean value in the Main Method.
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1). Option 1");
            Console.WriteLine("2). Option 2");
            Console.WriteLine("3). Exit Program");
            string result = Console.ReadLine();

            if (result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                Console.Clear();
                return false;//The false value is the trigger for the program to break out of the loop
            }
            else
            {
                return true;
            }
        }
        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print Numbers!");
            Console.Write("Type a number: ");
            int numberResult = int.Parse(Console.ReadLine());
            int counter = 1;//IMPORTANT TO SET THE INITIAL VALUE FOR THE COUNTER TO START AT.
            while (counter < numberResult + 1)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            Console.ReadLine();
        }
        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing Game!");
            
            Random myRandom = new Random(); //Random Class
            int randomNumber = myRandom.Next(1, 11);//(1,11)are the parameters for this code block. the random number generator will pick numbers from 1-10

            int playerGuess = 0; //Setting the count of guesses to start at 0
            bool incorrect = true;

            //Do while loop allows for the code block to run at least one time all the way through
            do 
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                string result = Console.ReadLine();
                playerGuess++;

                if (result == randomNumber.ToString())
                    incorrect = false;
                else
                    Console.WriteLine("Wrong!");
            } while (incorrect);
            Console.WriteLine("Correct! It took you {0} guesses!", playerGuess);
            Console.ReadLine();
        }
    }
}
