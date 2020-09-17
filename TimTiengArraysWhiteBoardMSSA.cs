/* 
Programmer: Tim Tieng
Date: 03 September 2020
Description: Whiteboard Question

TASK:
Get two names (first and last) and print them in reverse alphabetical order by last name

Example:
Enter 1st Name: Duane Kord
Enter 2nd Name: Ray Charles

Expected output = Alphabetically those would be:
Ray Charles
Duane Kord
 
Assume that it will just be 2 names without punctation.
Assume that they are alphabetical characters and not anything other than a-z.

NOTES:

- Arrays Convert to char array
- Evaluate each letter in last name viaforeach loop (Some last names begins with same letter)
- Attach user input first name back to its appropriate user entry
- Use 

Duane Kord Comments 04AUG- Try to refactor so you only use 1x loop
*/

using System;

namespace WhiteBoardProblem
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ask user input in two separate forms - first name then last name for ease
            //Last name will be used to reorder, then attach first name at the end
            Console.Write("What is user 1 first name?: ");
            string user1FirstName = Console.ReadLine();
            Console.Write("What is user 1 last name?: ");
            string user1LastName = Console.ReadLine();

            //Repeat for User 2
            Console.Write("What is user 2 first name?: ");
            string user2FirstName = Console.ReadLine();
            Console.Write("What is user 2 last name?: ");
            string user2LastName = Console.ReadLine();

            //Convert lastname to Char array so you can evaluate every single letter
            //Reason is because some people may have last names that start with the same letter
            char[] user1CharLastName = user1LastName.ToCharArray();
            char[] user2CharLastName = user2LastName.ToCharArray();

            //Use logic to determine if index of both lastnames to determine which has alphabetical precedence
            //For this progam, the limit is 2 names -for loop range max = 2
            //for (int i = 0; i < user1CharLastName.Length || i < user2CharLastName.Length; i++)
            //{
            int i = 0;
                foreach (var letter in user1CharLastName)
                {

                    if (user1CharLastName[i] < user2CharLastName[i])
                    {
                        Console.WriteLine($"{user1FirstName} {user1LastName}");
                        Console.WriteLine($"{user2FirstName} {user2LastName}");
                        Console.ReadLine();
                    }
                    else if (user2CharLastName[i] < user1CharLastName[i])
                    {
                        Console.WriteLine($"{user2FirstName} {user2LastName}");
                        Console.WriteLine($"{user1FirstName} {user1LastName}");
                        Console.ReadLine();
                    }
                }
            //}
        }
    }
}
