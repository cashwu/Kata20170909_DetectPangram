using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170909_DetectPangram
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void input_all_letters_should_return_true()
        {
            PangramShouldBeTrue("abcdefghijklmnopqrstuvwxyz");
        }

        private static void PangramShouldBeTrue(string str)
        {
            var kata = new Kata();
            var actual = kata.IsPangram(str);
            Assert.IsTrue(actual);
        }
    }

    public class Kata
    {
        public bool IsPangram(string str)
        {
            return true;
        }
    }
}
