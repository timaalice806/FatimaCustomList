using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FatimasCustomList;

namespace CustomListUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckValueIndexZero()
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
            //ACT
            myList.Add(value);

            //ASSERT
            Assert.AreEqual(expected, myList.Count);
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
        public void CheckArrayCapacity()
        {
            //ARRANGE
            TimaList<int> myList = new TimaList<int>();

            //ACT

            //ASSERT

        }
    }
}
