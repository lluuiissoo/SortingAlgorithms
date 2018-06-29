using NUnit.Framework;
using System.Collections.Generic;
using quickSort.sorting;

namespace quicksort.tests
{
    [TestFixture]
    public class QuickSortTests
    {
        private QuickSort algorithm;

        [SetUp]
        public void Setup()
        {
            algorithm = new QuickSort();
        }

        [Test]
        public void QuickSort_SortedList_ReturnsSameList()
        {
            List<int> sortedList = new List<int> { 1, 2, 3, 4, 6 };

            var result = algorithm.Sort(sortedList);

            Assert.That(result, Is.EqualTo(sortedList));
        }

        [Test]
        public void QuickSort_UnsortedList_ReturnsSortedList()
        {
            List<int> unsortedList = new List<int> { 5, 7, 3, 4, 6, 2, 1 };

            List<int> sortedList = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

            var result = algorithm.Sort(unsortedList);

            Assert.That(result, Is.EqualTo(sortedList));
        }
    }
}
