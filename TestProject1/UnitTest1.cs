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
        //USE CASE 2
        [TestMethod]
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
        //USECASE 3
        [TestMethod]
        public void UseCase3_1()
        {
            string first = "Zoo", second = "Beach", third = "Park", expectedValue, actualValue;
            expectedValue = first;
            actualValue = obj.LargestNumberString(first, second, third);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void UseCase3_2()
        {
            string first = "Amusement", second = "Park", third = "Cinema", expectedValue, actualValue;
            expectedValue = second;
            actualValue = obj.LargestNumberString(first, second, third);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void UseCase3_3()
        {
            string first = "Hiking", second = "Beach", third = "Park", expectedValue, actualValue;
            expectedValue = third;
            actualValue = obj.LargestNumberString(first, second, third);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
