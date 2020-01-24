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

            //ACT
            int value = 6;
            int expected = 1;
            int actual;

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
    }
}
