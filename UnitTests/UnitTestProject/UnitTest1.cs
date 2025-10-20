using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Simple_App_For_Azure;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(3, 3, 6)]
        [DataRow(4, 4, 8)]
        [DataRow(5, 0, 5)]
        public void AdditionTest(double numberOne, double numberTwo, double expected)
        {
            double actual = Program.Addition(numberOne, numberTwo);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(1, 1, 0)]
        [DataRow(2, 2, 0)]
        [DataRow(3, 3, 0)]
        [DataRow(4, 4, 0)]
        [DataRow(5, 0, 5)]
        public void SubtractionTest(double numberOne, double numberTwo, double expected)
        {
            double actual = Program.Subtraction(numberOne, numberTwo);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(2, 2, 4)]
        [DataRow(3, 3, 9)]
        [DataRow(4, 4, 16)]
        [DataRow(5, 0, 0)]
        public void MultiplicationTest(double numberOne, double numberTwo, double expected)
        {
            double actual = Program.Multiplication(numberOne, numberTwo);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(2, 2, 1)]
        [DataRow(3, 3, 1)]
        [DataRow(4, 4, 1)]
        [DataRow(5, 0, 0)]
        public void DivisionTest(double numberOne, double numberTwo, double expected)
        {
            double actual = Program.Division(numberOne, numberTwo);
            Assert.AreEqual(expected, actual);
        }
    }
}
