using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomIntList
{
    /// <summary>
    /// This class contains the logic to generate a list of 10,000 integers in random order.
    /// Each number in the list must be unique and between 1 and 10,000 (inclusive).
    /// </summary>
    public class Shuffle
    {
        //External library that implements Mersenne Twister
        private static Meisui.Random.MersenneTwister MT = new Meisui.Random.MersenneTwister();

        /// <summary>
        /// Function that generates a random unique list of integers given a range
        /// </summary>
        /// <param name="min"> The minimum integer</param>
        /// <param name="listSize">The size of the list</param>
        /// <returns>List of integers</returns>
        public static List<int> GenerateRandomList(int min, int listSize)
        {
            List<int> list = new List<int>(Enumerable.Range(min, listSize));

            //Fisher-Yates algorithm using Mersenne Twister
            for (int i = listSize - 1; i >= min; i--)
            {
                //Generate a random number using Mersenne Twister, modulo by i
                int randomIndex = Convert.ToInt32(MT.genrand_Int32() % i);

                //swap randomly selected integer and the integer at i
                int temp = list[i];
                list[i] = list[randomIndex];
                list[randomIndex] = temp;
            }

            return list;
        }


        /// <summary>
        /// Given a list, prints out the corresponding indices and elements.
        /// </summary>
        /// <param name="list">List of integers</param>
        public static void PrintList(List<int> list)
        {
            Console.WriteLine("[{0}]", string.Join(", ", list));
        }
    }
}
