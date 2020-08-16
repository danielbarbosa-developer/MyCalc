using System;
using Functions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OperationsTest
{
    [TestClass]
    public class ValuesTest
    {
        Values values = new Values();

        [TestMethod]
        public void SetValue_Test_Method_When_Operator_Is_Null()
        {
            values.Operator = String.Empty;
            values.SetValue(10);
            Assert.AreEqual(values.FirstNumber, 10);
        }
        [TestMethod]
        public void SetValue_Test_Method_When_Operator_Is_Full()
        {
            values.Operator = "+";
            values.SetValue(10);
            Assert.AreEqual(values.SecondNumber, 10);
        }
    }
}
