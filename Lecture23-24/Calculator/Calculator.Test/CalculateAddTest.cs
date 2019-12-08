using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Library;

namespace Calculator.Test
{
    [TestClass]
    public class CalculateAddTest
    {
        [TestMethod]
        public void TestAddition()
        {
            // Arrange
            int expected = 5;
            int operand1 = 2;
            int operand2 = 3;

            // Act
            int actual = CalculatorAdd.AddValue(operand1, operand2);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
