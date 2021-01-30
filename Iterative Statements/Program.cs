/*
Author: Ashlee Sewell
Date: 1/29/2021
Comments: Deliverable 1 Conditional Statements
*/
using System;

namespace Iterative_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the User for input
            Console.WriteLine("Enter an interger value between 1 and 100");
            // use try catch to validate user input
            try
            {
                //read user input as string
                string input = Console.ReadLine();
                // parse input as integer
                int value_of_input = int.Parse(input);

                // IF else to test values of user Input
                //Execute for loop if values are between 0 and 101
                if ((value_of_input > 0) && (value_of_input <= 100))
                {
                    Console.WriteLine("Executing a for Loop!");
                    Console.WriteLine("The for loop will iterate " + value_of_input.ToString() + " times.");
                    // here is the for loop
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("The value of the variable i in this iteration is: " + i.ToString());

                    }
                    Console.WriteLine("press any key to exit to the program ...");
                    // pause progam and await user to press any key to exit program
                    Console.ReadKey(true);
                }
                // if user does not enter number between 1 and 100, display message
                else
                {
                    Console.WriteLine("Please enter key between 1 and 100 and try again");
                    Console.WriteLine("Press any key to exit program and try again");
                    Console.ReadKey(true);
                }
            }



            catch
            {
                Console.WriteLine("Please enter key between 1 and 100 and try again");
                Console.WriteLine("Press any key to exit program and try again");
                Console.ReadKey(true);
            }





            
        }
    }
}
