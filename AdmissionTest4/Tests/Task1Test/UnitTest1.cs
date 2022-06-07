using NUnit.Framework;
using Task1;

namespace Task1Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Hello World", 2)]
        [TestCase("my$password", 2)]
        [TestCase("this123is a very;big   text.", 6)]
        [TestCase("fnnlklnwvwepokoei&(*h32rkj39723hkzkjdlsdh sdhfjsd s sdjkhd ssdss   :{@bjdlfdj", 9)]
        [TestCase("!%#!*&^(*!&#)!&(23927392", 0)]
        [TestCase("", 0)]
        [TestCase("           ", 0)]
        public void Test1(string text, int count)
        {
            WordCounter counter = new WordCounter();
            var result = counter.Count(text);
            Assert.AreEqual(count, result);
        }
    }
}