using Microsoft.VisualStudio.TestTools.UnitTesting;
using Generics_UnitTesting;
using System;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        GreatestNum obj;
        [TestInitialize]
        public void SetUp()
        {
            obj = new GreatestNum();

        }
        //USE CASE 1
        [TestMethod]
        public void UseCase1_1()
        {
            int first = 100, second = 30, third = 10, actualValue, expectedValue;
            expectedValue = first;
            actualValue = obj.LargestNumber(first, second, third);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void UseCase1_2()
        {
            int first = 103, second = 300, third = 10, actualValue, expectedValue;
            expectedValue = second;
            actualValue = obj.LargestNumber(first, second, third);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void UseCase1_3()
        {
            int first = 10, second = 30, third = 100, actualValue, expectedValue;
            expectedValue = third;
            actualValue = obj.LargestNumber(first, second, third);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        //USE CASE 2
        public void UseCase2_1()
        {
            float first = 100.1F, second = 30.4F, third = 10.6F, expectedValue, actualValue;
            expectedValue = first;
            actualValue = obj.LargestNumberFloat(first, second, third);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void UseCase2_2()
        {
            float first = 10.1F, second = 300.4F, third = 10.6F, expectedValue, actualValue;
            expectedValue = second;
            actualValue = obj.LargestNumberFloat(first, second, third);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void UseCase2_3()
        {
            float first = 10, second = 30, third = 100, actualValue, expectedValue;
            expectedValue = third;
            actualValue = obj.LargestNumberFloat(first, second, third);
            Assert.AreEqual(expectedValue, actualValue);
        }
        //USE CASE 3
    }
}
