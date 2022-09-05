using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bubblesort;

namespace D1_Test
{
    [TestClass]
    public class BubbleSortTest
    {

        protected int[] initArray1()
        {
            int[] array = { 45, 32, 10, 45, 23, 12, 60, 22, 345, 12 };
            return array;
        }

        protected int[] actualArray1()
        {
            int[] array = { 10, 12, 12, 22, 23, 32, 45, 45, 60, 345 };
            return array;
        }

        [TestMethod]
        public void BubbleSort_ArraySorted()
        {
            int[] unsorted_array = initArray1();
            Sort.BubbleSort(unsorted_array);

            CollectionAssert.AreEqual(actualArray1(), unsorted_array, "Array not sorted correctly");

        }

        [TestMethod]
        public void BubbleSort_EmptyArray_NoResult()
        {
            int[] unsorted_array = new int[0];
            Sort.BubbleSort(unsorted_array);

            CollectionAssert.AreEqual(new int[0], unsorted_array, "Empty array sorting failed");

        }
    }
}