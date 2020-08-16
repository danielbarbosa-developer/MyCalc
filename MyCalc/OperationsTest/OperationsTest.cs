using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Functions;

namespace FunctionsTest
{
    [TestClass]
    public class OperationsTest
    {
        Values values = new Values();
        Operations operations = new Operations();

        
        [TestMethod]
        public void Calculate_Test_Method_When_Operator_Is_Plus()
        {
            values.Operator = "+";
            values.FirstNumber = 10;
            values.SecondNumber = 5;
            operations.Calculate(values);
            Assert.AreEqual(15, values.Result);
        }
       
        [TestMethod]
        public void Calculate_Test_Method_When_Operator_Is_Minus()
        {
            values.Operator = "-";
            values.FirstNumber = 10;
            values.SecondNumber = 5;
            operations.Calculate(values);
            Assert.AreEqual(5, values.Result);
        }
        [TestMethod]
        public void Calculate_Test_Method_When_Operator_Is_Times()
        {
            values.Operator = "*";
            values.FirstNumber = 10;
            values.SecondNumber = 5;
            operations.Calculate(values);
            Assert.AreEqual(50, values.Result);
        }
        [TestMethod]
        public void Calculate_Test_Method_When_Operator_Is_Divison()
        {
            values.Operator = "/";
            values.FirstNumber = 10;
            values.SecondNumber = 5;
            operations.Calculate(values);
            Assert.AreEqual(2, values.Result);
        }
        [TestMethod]
        public void Calculate_Test_Method_When_Zero_Is_Insert_As_Divider_So_It_Should_Throw_Exception()
        {
            values.Operator = "/";
            values.FirstNumber = 10;
            values.SecondNumber = 0;
            Assert.ThrowsException<System.DivideByZeroException>(() => operations.Calculate(values));
        }

    }
}
