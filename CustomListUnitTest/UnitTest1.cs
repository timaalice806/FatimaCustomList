using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FatimasCustomList;

namespace CustomListUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckValueAtIndexZero()
        {
            //ARRANGE
            TimaList<int> myList = new TimaList<int>();
            int value = 6;
            int expected = 6;
            int actual;

            //ACT
            myList.Add(value);
            actual = myList[0];

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckCountAfterAdd()
        {
            //ARRANGE
            TimaList<int> myList = new TimaList<int>();
            int value = 6;
            int expected = 1;
            int actual;
            //ACT
            myList.Add(value);
            actual = myList.Count;

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckOrderOfIndicesAfterAdd()
        {
            //ARRANGE
            TimaList<int> myList = new TimaList<int>();
            int value = 1;
            int secondValue = 2;
            int thirdValue = 3;

            //ACT
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList[0] = value;
            myList[1] = secondValue;
            myList[2] = thirdValue;

            //ASSERT
            Assert.AreEqual(thirdValue, myList[2]);
        }
        [TestMethod]
        public void CheckArrayCapacity()
        {
            //ARRANGE
            TimaList<int> myList = new TimaList<int>();
            int expectedCapcity = 8;
            int actualCapacity;

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);

            //ACT
            myList.Add(5);
            actualCapacity = myList.Capacity;

            //ASSERT
            Assert.AreEqual(expectedCapcity, actualCapacity);
        }
        [TestMethod]
        public void CheckElementsAddedToEmptyArray()
        {
            //ARRANGE
            TimaList<int> myList = new TimaList<int>();
            int expected = 2;
            int actual;

            //ACT
            myList.Add(1);
            myList.Add(2);
            actual = myList.Count;

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        ////////////////////////////////////////////////////////
        [TestMethod]
        public void CheckCountAfterRemoval()
        {
            //ARRANGE
            TimaList<int> myList = new TimaList<int>();
            int value = 6;
            int expected = 0;
            int actual;

            //ACT
            myList.Remove(value);
            actual = myList.Count;

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveItemFromSpecificIndex()
        {
            //ARRANGE
            TimaList<int> myList = new TimaList<int>();
            int value1 = 6;
            int value2 = 8;
            int expected = 0;

            //ACT
            myList.Add(value1);
            myList.Add(value2);
            myList.Remove(value2);


            //ASSERT
            Assert.AreEqual(expected, myList[1]);
        }
        [TestMethod]
        public void RemoveNonexistentItem()
        {
            //ARRANGE
            TimaList<int> even = new TimaList<int>() { 2, 4, 6 };
            int value = 1;
            int actual;
            int expected = 0;

            //ACT
            even.Remove(value);
            actual = even.Count;

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ConfirmIndexZip()
        {
            //ARRANGE
            TimaList<int> odd = new TimaList<int>() { 1, 3, 5 };
            TimaList<int> even = new TimaList<int>() { 2, 4, 6 };
            TimaList<int> zipped;

            int expected = 4;

            //ACT
            zipped = TimaList<int>.Zip(odd, even);

            //ASSERT
            Assert.AreEqual(expected, zipped[3]);
        }
        [TestMethod]
        public void ConfirmToString()
        {
            //ARRANGE
            TimaList<int> list = new TimaList<int>() { 1, 2, 3, 4, 5 };
            string expected = "12345";

            //ACT
            string actual = list.ToString();

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ConfirmToStringCapacity()
        {
            //ARRANGE
            TimaList<int> list = new TimaList<int>() { 1, 2, 3, };
            string expected = "123";

            //ACT
            string actual = list.ToString();

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
    }
}
