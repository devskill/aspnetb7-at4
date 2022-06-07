using NUnit.Framework;
using Task4;

namespace Task4Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("0171757    ", false)]
        [TestCase("0171757", false)]
        [TestCase("0161731", false)]
        [TestCase("017#7879731", false)]
        [TestCase("01810579701", true)]
        [TestCase("01315570749", true)]
        [TestCase("01516579831", true)]
        [TestCase("01617979730", true)]
        [TestCase("01717577737", true)]
        [TestCase("", false)]
        public void Test1(string number, bool isCorrect)
        {
            FormatChecker formatChecker = new FormatChecker();
            var result = formatChecker.IsValid(number);
            Assert.AreEqual(isCorrect, result);
        }
    }
}