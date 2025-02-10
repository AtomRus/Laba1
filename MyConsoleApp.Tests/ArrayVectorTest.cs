using Laba1;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace MyConsoleApp.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            ArrayVector arrayVector = new ArrayVector();
        }

        [TestCase(new int[]{10,24}, 676)]
        [TestCase(new int[]{1,1}, 2)]
        [TestCase(new int[]{1}, 1)]
        public void GetNorm10and24Equal26(int[] input, double expectedSquared)
        {
            ArrayVector arrayVector = new ArrayVector(input);
            ClassicAssert.AreEqual(arrayVector.GetNorm(), Math.Sqrt(expectedSquared));
        }
        [Test]
        public void TestMethod2()
        {
            Assert.Pass("Тест прошел успешно.");
        }
    }
}