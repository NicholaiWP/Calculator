using Microsoft.VisualStudio.TestTools.UnitTesting;
using Internship_interview_followup;
using System;

namespace TestCode
{
    [TestClass]
    public class UnitTest1
    {
        readonly Calculator calculator = new Calculator();

        [TestInitialize]
        public void TestInit()
        {
            Calculator calculator = new Calculator();

        }

        [TestMethod]
        public void TestAddition()
        {
            var expected = 5;
            //Assert.AreQqual(expected(arg1), actual(arg2));
            Assert.AreEqual(expected, calculator.Addition(2, 3));
        }

        [TestMethod]
        public void TestAdditionExtented()
        {
            var result = 10;
            Assert.AreEqual(result, calculator.Addition(2, 3, 5));
        }

        [TestMethod]
        public void TestSubtract()
        {
            var result = 2;
            Assert.AreEqual(result, calculator.Subtract(5,3));
        }

        [TestMethod]
        public void TestMultiply()
        {
            var result = 6;
            Assert.AreEqual(result, calculator.Multiply(2, 3));
        }

        [TestMethod]
        public void TestDivision()
        {        
            try
            {
                var result = 9;
                Assert.AreEqual(result, calculator.Division(81, 9));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't divide by zero on second argument");
            }
               

        }

        [TestMethod]
        public void TestDivisionIllegal()
        {
            try
            {
                var result = 0;
                Assert.AreEqual(result, calculator.Division(81, 0));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't divide by zero on second argument");
            }


        }

        [TestMethod]
        public void TestSquareRoot()
        {
            var result = 5;

            Assert.AreEqual(result, calculator.SquareRoot(25));
        }
    }
}
