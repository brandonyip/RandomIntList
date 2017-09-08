using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RandomIntList
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //variables
            const int min = 1, max = 10000;

            Console.WriteLine("This is a program that will generate a list of random unique numbers between 1-10000. Press any key to continue...");
            Console.ReadLine();

            //generate the list of randomized integers
            List<int> randomizedList = Shuffle.GenerateRandomList(min, max);

            //print the list of randomized integers
            Shuffle.PrintList(randomizedList);

            Console.WriteLine("List generated. Press any key to exit program...");
            Console.ReadLine();
        }
    }
}
