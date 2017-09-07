using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Description: A program that generates a list of 10,000 numbers in random order each time it is run. 
 *   Each number in the list must be unique and be between 1 and 10,000 (inclusive)
 *  Author: Brandon Yip
*/
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start
            Console.WriteLine("This is a program that will randomly shuffle a list.");
            Console.WriteLine("Please enter a range of integers. Eg: (1 to 5)");

            //variables
            int min, max;
            bool validRange = true;
            string userInput;

            do
            {
                //User prompt for min value
                Console.WriteLine("Enter an integer for the minimum value...");
                //Try to convert input into an int
                while(!int.TryParse(Console.ReadLine(), out min))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                }

                //User prompt for max value
                Console.WriteLine("Enter an integer for the maximum value...");
                //Try to convert input into an int
                while (!int.TryParse(Console.ReadLine(), out max))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                }
                




            } while (validRange);



        }
    }
}
