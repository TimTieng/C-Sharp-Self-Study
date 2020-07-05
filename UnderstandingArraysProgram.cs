using System;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Array(list) of Integers, titled "numbers", with X components of values in the list
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            //^^ shows the values of the array from x=1 to x=5 (BINARY)
            //numbers[5] = 42; //This would throw an exception bc this value is outside the original max values of the arrary in the declaration LINE10

            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length); //This statement shows how many values are in the arrary
            Console.ReadLine();
            */

            //Ex. of not declaring amount in the array/let the compiler determine how many values are in the arrary
            //int[] newNumbersArray = new int[] { 4, 8, 15, 16, 23, 42 };

            //string[] usaCities = new string[] { "Fayetteville", "Atlanta", "Boston", "New York City", "Philadelphia" };

            /*
            for (int i = 0; i <usaCities.Length; i++)
            {
                Console.WriteLine(usaCities[i]);
            }
            Console.ReadLine();
            */

            //FOREACH statement is used to iterate through the provided array MINDFUL OF SYNTAX
            /*
            foreach (string usaCity in usaCities)
            {
                Console.WriteLine(usaCity);
            }
            Console.ReadLine();
            */

            //Take a string and reverse the string. Convert string array to char[], then reverse method
            string quote = "Lions don't lose sleep over the opinion of sheep!";
            Console.WriteLine(quote);

            //Convert string to char[], then call Array.Reverse Method Array.Reverse()
            char[] charArray = quote.ToCharArray();
            Array.Reverse(charArray);

            foreach (char quoteChar in charArray)
            {
                Console.Write(quoteChar);
            }
            Console.ReadLine();

        }
    }
}
