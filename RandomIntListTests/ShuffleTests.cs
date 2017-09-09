using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomIntList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomIntList.Tests
{
    /// <summary>
    /// A test class to check the logic in Shuffle.cs
    /// </summary>
    [TestClass()]
    public class ShuffleTests
    {
        /// <summary>
        /// Tests to see if the list contains unique integers
        /// </summary>
        [TestMethod()]
        public void TestUniqueness()
        {
            int min = 1, max = 10000;
            List<int> testList = Shuffle.GenerateRandomList(min, max);
            bool unique = (testList.Distinct().Count() == testList.Count());
            Assert.IsTrue(unique);
        }

        /// <summary>
        /// Test so see if the list is the correct size
        /// </summary>
        [TestMethod()]
        public void TestSize()
        {
            int min = 1, max = 10000;
            List<int> testList = Shuffle.GenerateRandomList(min, max);
            bool correctSize = (max == testList.Count());
            Assert.IsTrue(correctSize);
        }
    }
}