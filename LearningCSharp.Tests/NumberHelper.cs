using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearningCSharp1;


namespace LearningCSharp.Tests
{
    [TestClass]
    public class FizzBuzz_Tests
    {
        [TestMethod]
        public void Test_FizzBuzz_RegularNumbers()
        {
            Assert.AreEqual("1", NumberHelper.FizzBuzz(1));
            Assert.AreEqual("2", NumberHelper.FizzBuzz(2));
            Assert.AreEqual("4", NumberHelper.FizzBuzz(4));
            Assert.AreEqual("7", NumberHelper.FizzBuzz(7));
            Assert.AreEqual("8", NumberHelper.FizzBuzz(8));
        }

        [TestMethod]
        public void Test_FizzBuzz_FizzOnly()
        {
            Assert.AreEqual("Fizz", NumberHelper.FizzBuzz(3));
            Assert.AreEqual("Fizz", NumberHelper.FizzBuzz(6));
            Assert.AreEqual("Fizz", NumberHelper.FizzBuzz(9));
            Assert.AreEqual("Fizz", NumberHelper.FizzBuzz(12));
            Assert.AreEqual("Fizz", NumberHelper.FizzBuzz(18));
        }

        [TestMethod]
        public void Test_FizzBuzz_BuzzOnly()
        {
            Assert.AreEqual("Buzz", NumberHelper.FizzBuzz(5));
            Assert.AreEqual("Buzz", NumberHelper.FizzBuzz(10));
            Assert.AreEqual("Buzz", NumberHelper    .FizzBuzz(20));
            Assert.AreEqual("Buzz", NumberHelper.FizzBuzz(25));
            Assert.AreEqual("Buzz", NumberHelper.FizzBuzz(35));
        }

        [TestMethod]
        public void Test_FizzBuzz_FizzBuzzCombo()
        {
            Assert.AreEqual("FizzBuzz", NumberHelper.FizzBuzz(15));
            Assert.AreEqual("FizzBuzz", NumberHelper.FizzBuzz(30));
            Assert.AreEqual("FizzBuzz", NumberHelper.FizzBuzz(45));
        }

        [TestMethod]
        public void Test_FizzBuzz_Zero()
        {
            Assert.AreEqual("FizzBuzz", NumberHelper.FizzBuzz(0));
        }

        [TestMethod]
        public void Test_FizzBuzz_NegativeNumbers()
        {
            Assert.AreEqual("-1", NumberHelper.FizzBuzz(-1));
            Assert.AreEqual("-2", NumberHelper.FizzBuzz(-2));
            Assert.AreEqual("Fizz", NumberHelper.FizzBuzz(-3));
            Assert.AreEqual("Buzz", NumberHelper.FizzBuzz(-5));
            Assert.AreEqual("FizzBuzz", NumberHelper.FizzBuzz(-15));
        }
    }

    /*
    [TestClass]
    public class IsPrime_TEsts
    {
        [TestMethod]
        public void Test_IsPrime_NonPrimeNumbers()
        {
            Assert.IsFalse(NumberHelper.IsPrime(9));

        }

        [TestMethod]
        public void Test_IsPrime_PrimeNumbersOnly()
        {
            Assert.AreEqual("Fizz", NumberHelper.FizzBuzz(3));
            Assert.AreEqual("Fizz", NumberHelper.FizzBuzz(6));
            Assert.AreEqual("Fizz", NumberHelper.FizzBuzz(9));
            Assert.AreEqual("Fizz", NumberHelper.FizzBuzz(12));
            Assert.AreEqual("Fizz", NumberHelper.FizzBuzz(18));
        }

        [TestMethod]
        public void Test_IsPrime_Zero()
        {
            Assert.AreEqual("FizzBuzz", NumberHelper.FizzBuzz(0));
        }

        [TestMethod]
        public void Test_IsPrime_NegativeNumbers()
        {
            Assert.AreEqual("-1", NumberHelper.FizzBuzz(-1));
            Assert.AreEqual("-2", NumberHelper.FizzBuzz(-2));
            Assert.AreEqual("Fizz", NumberHelper.FizzBuzz(-3));
            Assert.AreEqual("Buzz", NumberHelper.FizzBuzz(-5));
            Assert.AreEqual("FizzBuzz", NumberHelper.FizzBuzz(-15));
        }
    }
    */

}
