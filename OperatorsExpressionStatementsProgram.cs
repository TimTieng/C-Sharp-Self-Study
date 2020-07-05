using System;

namespace OperatorsExpressionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration and Assignment
            int x = 3;
            int y = 2;
            int a = 1;
            int b = 0;

            //Mathematical Operator Examples
            //Addition Operator
            x = 3 + 40;

            //Subtraction Operator
            x = 3 - 1;

            //Multiplication Operator
            x = 3 * 10;

            //Division Operator
            x = 3 / 3;

            //Inequality Operators
            if (x < y)
            {
                Console.WriteLine("X is greater in value");
            }
            //Conditional Operator: AND
            if ((x > y) && (a > b))
            {

            }
            //Conditional Operator: OR
            if ((x > y) || (a > b))
            {
                Console.WriteLine("True");
            }
            //Member Access and Method Invocation (.WriteLine() is the method
            Console.WriteLine("Console is the member access, .WriteLine() is the method invocation");
        }
    }
}
