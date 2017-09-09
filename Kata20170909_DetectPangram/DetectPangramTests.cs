using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170909_DetectPangram
{
    [TestClass]
    public class DetectPangramTests
    {
        [TestMethod]
        public void input_all_letters_should_return_true()
        {
            PangramShouldBeTrue("abcdefghijklmnopqrstuvwxyz");
        }

        [TestMethod]
        public void input_all_letters_but_have_not_a_should_return_false()
        {
            PangramShouldBeFalse("bcdefghijklmnopqrstuvwxyz");
        }

        [TestMethod]
        public void input_all_letters_have_whitespace_should_return_true()
        {
            PangramShouldBeTrue("abc deno pqr stu vwxf ghi jkl m yz");
        }

        private static void PangramShouldBeFalse(string str)
        {
            var kata = new Kata();
            var actual = kata.IsPangram(str);
            Assert.IsFalse(actual);
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
            return str.ToLower().Where(char.IsLetter).Distinct().Count() == 26;
        }
    }
}
