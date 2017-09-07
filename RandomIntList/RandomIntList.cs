using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Description: A program that generates a list of 10,000 numbers in random order each time it is run. 
 *   Each number in the list must be unique and between 1 and 10,000 (inclusive)
 *  Author: Brandon Yip
*/
namespace RandomIntList
{
    public static class RandomIntList
    {
        static void Main(string[] args)
        {
            Shuffle shuffle = new Shuffle();
            shuffle.start();
        }
    }
}
