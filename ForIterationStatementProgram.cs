using System;

namespace ForIterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            /*FOR LOOP/ITERATION- To execute a statement or block of code while specified Boolean parameters evaluate
             to be TRUE. The FOR Loop executes code blocks REPEATEDLY until the specified condition returnes FALSE*/

            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(i);

                if (i == 7)
                {
                    Console.WriteLine("Found the i=7 value!");
                    break; //used to "break/bust" out of the FOR LOOP
                }
                //FOR loop should execute a total of 10 times when i= 9 at iteration 10 because condition still evaluates as TRUE
            }

            for (int myValue = 0; myValue < 12; myValue++)
            {
                Console.WriteLine(myValue);
            }

            Console.ReadLine();


        }
    }
}
