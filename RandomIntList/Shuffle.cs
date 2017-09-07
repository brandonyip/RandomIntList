using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomIntList
{
    /* Description: The class that generates the list of randomized integers.
     * Author: Brandon Yip
     */
    public class Shuffle
    {
        private static Random random = new Random();

        //generates the unique random list of integers between 1-10000
        public IList<int> generateRandomList(int min, int listSize)
        {
            IList<int> list = new List<int>(Enumerable.Range(min, listSize));

            //Fisher-Yates algorithm
            for (int i = listSize - 1; i >= min; i--)
            {
                //select a random integer in the list
                int j = random.Next(listSize - 1);

                //swap random selected integer and the last integer
                int temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }

            return list;
        }

        //prints out a list of integers
        public void printList(IList<int> list)
        {
            int i = 0;
            foreach (var element in list)
            {
                Console.WriteLine("index: " + i + "       value: " + element);
                i++;
            }
        }


        
        public void start()
        {
            //variables
            const int min = 1, max = 10000;

            Console.WriteLine("This is a program that will generate a list of random unique numbers between 1-10000. Press any key to continue...");
            Console.ReadLine();
      
            //generate the list of randomized integers
            IList<int> randomizedList = generateRandomList(min, max);

            //print the list of randomized integers
            printList(randomizedList);

            Console.WriteLine("List generated. Press any key to exit program...");
            Console.ReadLine();
        }
    }
}
