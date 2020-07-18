using System;


namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            bool displayMenu = true;
            while (displayMenu == true)
            {
                displayMenu = MainMenu();
            }
            MainMenu();
        }
        private static bool MainMenu()
        {
            Console.WriteLine("Option 1 = Division Application");
            Console.WriteLine("Option 2 = Array of Integers Application");
            Console.WriteLine("Option 3 = Exit Program");

            string result = Console.ReadLine();

            if (result == "1")
            {
                DivisionMethod();
                return true;
            }
            else if (result == "2")
            {
                GetNumber();
                return true;
            }
            else if (result == "3")
            {
                Console.Clear();
                return false;
            }
            else
            {
                return true;
            }
        }
        private static void DivisionMethod()
        {
            Console.Clear();
            try//This is the code block where errors can occur (formatting, out of range, dividebyzero exception etc)
            {
                Console.Write("Please enter a number: ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter another number: ");
                int number2 = Convert.ToInt32(Console.ReadLine());

                int divideNumbers = number1 / number2;

                Console.WriteLine($"The quotient is {divideNumbers}");
            }
            catch (DivideByZeroException e) //this catch block specifically executes code block if a divide by zero exception is thrown
            {
                Console.WriteLine(e.Message);//Returns "attempt to divide by zero"
            }
            catch (FormatException e)//catch block executes code if a format exception is thrown
            {
                Console.WriteLine(e.Message);//Returns 'improper string format error"
            }
        }
        private static void GetNumber()
        {
            Console.Clear();
            try
            {
                int[] numbers = new int[] { 1, 3, 5, 7, 9 };
                Console.Write("What number do you want to access in the array?: ");
                int position = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(numbers[position]);
            }
            catch (IndexOutOfRangeException indexe)
            {
                Console.WriteLine(indexe.Message);
            }
            catch (FormatException formate)
            {
                Console.WriteLine(formate.Message);
            }
        }
    }
}
/*
 This is good for handling and diagnosing errors.
 */