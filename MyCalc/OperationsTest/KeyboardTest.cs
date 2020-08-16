using System;
using Functions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionsTest
{
    [TestClass]
    public class KeyboardTest
    {
        [TestMethod]
        public void KeyboardEntries_Test_Method_When_LastNumber_Is_Null()
        {
            string number;
            number = Keyboard.KeyboardEntries("1", String.Empty);

            Assert.AreEqual("1", number);
        }

        [TestMethod]
        public void KeyboardEntries_Test_Method_When_LastNumber_Is_Full()
        {
            string number;
            number = Keyboard.KeyboardEntries("1", Keyboard.KeyboardEntries("2", String.Empty));

            Assert.AreEqual("21", number);
        }

        [TestMethod]
        public void KeyboardEntries_Test_Method_When_LastNumber_Is_Negative_Signal()
        {
            string number;
            number = Keyboard.KeyboardEntries("1", Keyboard.KeyboardEntries("-", String.Empty));

            Assert.AreEqual("-1", number);
        }
       
        [TestMethod]
        public void KeyboardEntries_Test_Method_When_LastNumber_Is_Positive_Signal()
        {
            string number;
            number = Keyboard.KeyboardEntries("1", Keyboard.KeyboardEntries("+", String.Empty));

            Assert.AreEqual("+1", number);
        }
        [TestMethod]
        public void KeyboardEntries_Test_Method_When_Number_Is_Negative_Signal()
        {
            string number;
            number = Keyboard.KeyboardEntries("-", String.Empty);

            Assert.AreEqual("-", number);
        }

    }
}
