using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomIntList
{
    /// <summary>
    /// This class generates a list of 10,000 integers in random order.
    /// Each number in the list must be unique and between 1 and 10,000 (inclusive)
    /// </summary>
    public class Shuffle
    {
        private static Random random = new Random();

        /// <summary>
        /// Function that generates a random unique list of integers given a range
        /// </summary>
        /// <param name="min"> The minimum integer</param>
        /// <param name="listSize">The size of the list</param>
        /// <returns>List of integers</returns>
        public static List<int> GenerateRandomList(int min, int listSize)
        {
            List<int> list = new List<int>(Enumerable.Range(min, listSize));

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



        /// <summary>
        /// Given a list, prints out the corresponding indices and elements.
        /// </summary>
        /// <param name="list">List of integers</param>
        public static void PrintList(List<int> list)
        {
            int i = 0;
            foreach (var element in list)
            {
                Console.WriteLine("index: " + i + "       value: " + element);
                i++;
            }
        }
    }
}
