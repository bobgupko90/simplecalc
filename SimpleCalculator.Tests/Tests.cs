using NUnit.Framework;


namespace SimpleCalculator.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
         public void Add_WithOneAndOne_ReturnsTwo()
        {
            var result = SimpleCalculator.Add(1, 1);

            Assert.AreEqual(2, result);
        }

        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(1, 0, ExpectedResult = 1)]
        [TestCase(0, 1, ExpectedResult = 1)]
        [TestCase(1, 1, ExpectedResult = 2)]
        public int Add(int x, int y)
        {
            return SimpleCalculator.Add(x, y);
        }

        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(1, 0, ExpectedResult = 1)]
        [TestCase(0, 1, ExpectedResult = -1)]
        [TestCase(1, 1, ExpectedResult = 0)]
        public int Sub(int x, int y)
        {
            return SimpleCalculator.Sub(x, y);
        }
    }
}
