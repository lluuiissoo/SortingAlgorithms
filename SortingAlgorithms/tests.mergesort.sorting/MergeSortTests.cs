using System;
using NUnit.Framework;
using mergesort.sorting;
using System.Collections.Generic;

namespace tests.mergesort.sorting
{
    [TestFixture]
    public class MergeSortTests
    {
        private MergeSort algorithm;

        [SetUp]
        public void Setup()
        {
            algorithm = new MergeSort();
        }

        [Test]
        public void MergeSort_SortedList_ReturnsSameList()
        {
            List<int> sortedList = new List<int> { 1, 2, 3, 4, 6 };
            
            var result = algorithm.Sort(sortedList);
 
            Assert.That(result, Is.EqualTo(sortedList));
        }

        [Test]
        public void MergeSort_UnsortedList_ReturnsSortedList()
        {
            List<int> unsortedList = new List<int> { 5, 7, 3, 4, 6, 2, 1 };

            List<int> sortedList = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

            var result = algorithm.Sort(unsortedList);

            Assert.That(result, Is.EqualTo(sortedList));
        }
    }
}
