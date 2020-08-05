/*
Task: Create a Console Application that replicates the Fibonacci Sequence
Created By: Tim Tieng
Date: 23JUL2020
Description: To practice various concepts in preparation for whiteboard interviews
*/
using System;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            ListFibonacci();//Call Method to execute
        }
        private static void ListFibonacci()
        {
            //Define Required Variables
            int num1 = 0;
            int num2 = 1;
            int num3;
            int i;

            //Start the program; prompt user for back stop
            Console.Write("Enter how many values you want in your Fibonacci Sequence: ");
            int limitNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write($"[{num1}] [{num2}] ");

            //Iterate tasks using for loop
            for (i = 2; i < limitNumber; ++i) //start at 2 since first 2 values are printed, iterate up limit Number, increase counter
            {
                num3 = num1 + num2;
                Console.Write($"[{num3}] ");
                num1 = num2;
                num2 = num3;
            }

        }
    }
}
/*
Problem was found on this website. https://www.algoexpert.io/questions/Nth%20Fibonacci
 */
