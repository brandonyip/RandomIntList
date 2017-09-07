using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomIntList
{
    /* Description: A class to test the logic of Shuffle.cs
     * Author: Brandon Yip
     */
    class Test
    {
        //Checks to see if list contains unique integers
        public bool TestUniqueness<T>(IList<T> list)
        {
            return list.Distinct().Count() == list.Count();
        }

        //Checks to see if list is same size
        public bool TestSize<T>(IList<T> list, int size)
        {
            return list.Count() == size;
        }

        public void main()
        {
            const int min = 1, max = 10000;
            Shuffle testShuffle = new Shuffle();

            IList<int> randomizedList = testShuffle.generateRandomList(min, max);
            testShuffle.printList(randomizedList);

            //test uniquness of the list
            Debug.Assert(TestUniqueness(randomizedList));

            //test size of list
            Debug.Assert(TestSize(randomizedList, max));
        }

    }
}
