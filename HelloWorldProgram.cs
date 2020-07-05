using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I am ChatBot! What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}, Would you like to have a conversation?");
            string userResponse = Console.ReadLine();

        }
    }
}
