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
        private static Random random = new Random();

        //generates the unique random list of integers between 1-10000
        private static IList<int> generateRandomList(int min, int listSize)
        {
            IList<int> list = new List<int>(Enumerable.Range(min, listSize));

            for(int i = listSize-1; i >= min; i--)
            {
                int j = random.Next(listSize - 1);
                int temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }

            return list;
        }

        //prints out a list of integers
        private static void printList(IList<int> list)
        {
            int i = 0;
            foreach(var element in list)
            {
                Console.WriteLine("index: " + i + "       value: " + element);
                i++;
            }
        }

        //main frame
        public static void start()
        {
            //variables
            const int min = 1, max = 10000;

            //generate the list of randomized integers
            IList<int> randomizedList = generateRandomList(min, max);

            //print the list of randomized integers
            printList(randomizedList);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("This is a program that will generate a random ordered list of unique numbers between 1-10000. Press any key to continue...");
            Console.ReadLine();
            start();

            Console.WriteLine("List generated. Press any key to exit program...");
            Console.ReadLine();
        }
    }
}
