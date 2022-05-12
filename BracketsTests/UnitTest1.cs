using BracketsValidator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BracketsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("(((){}[]]]])(", false)]
        [DataRow("(){}[][][]()", true)]
        [DataRow("({[]})()[]", true)]
        public void Test_Required(string input, bool expected)
        {
            Assert.AreEqual(Validator.Validate(input), expected);
        }
    }
}