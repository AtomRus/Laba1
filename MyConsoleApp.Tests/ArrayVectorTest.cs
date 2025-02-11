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
        }

        [TestCase(new int[]{10,24}, 676)]
        [TestCase(new int[]{1,1}, 2)]
        [TestCase(new int[]{1}, 1)]
        public void GetNorm(int[] input, double expectedSquared)
        {
            ArrayVector arrayVector = new ArrayVector(input);
            ClassicAssert.AreEqual(arrayVector.GetNorm(), Math.Sqrt(expectedSquared));
        }
        [TestCase(new int[]{1,-1}, 0)]
        [TestCase(new int[]{1,1}, 1)]
        [TestCase(new int[]{1}, 0)]
        [TestCase(new int[]{1,-1,5}, 0)]
        [TestCase(new int[]{1,5,5}, 5)]
        [TestCase(new int[]{}, 0)]
        [TestCase(new int[]{1,5,5, -3}, 5)]
        [TestCase(new int[]{1,-3,5, -3}, 0)]
        public void SumPositivesFromChetIndex(int[] input, int expected)
        {
            ArrayVector arrayVector = new ArrayVector(input);
            ClassicAssert.AreEqual(arrayVector.SumPositivesFromChetIndex(), expected);
        }

        [TestCase(new int[]{1,-5}, 1)]
        [TestCase(new int[]{1,1,5}, 1)]
        [TestCase(new int[]{1}, 0)]
        [TestCase(new int[]{-1,-1,5}, -1)]
        public void SumLessFromNechetIndex(int[] input, int expected)
        {
            ArrayVector arrayVector = new ArrayVector(input);
            ClassicAssert.AreEqual(arrayVector.SumLessFromNechetIndex(), expected);
        }
        [TestCase(new int[]{1,-1}, -1)]
        [TestCase(new int[]{1,1,5}, 1)]
        [TestCase(new int[]{1}, 0)]
        [TestCase(new int[]{-1,-1,5,-1}, 1)]
        public void MultChet(int[] input, int expected)
        {
            ArrayVector arrayVector = new ArrayVector(input);
            ClassicAssert.AreEqual(arrayVector.MultChet(), expected);
        }
        public void MultNechet(int[] input, int expected)
        {
            ArrayVector arrayVector = new ArrayVector(input);
            ClassicAssert.AreEqual(arrayVector.MultNechet(), expected);
        }
        public void SortUp(int[] input, int[] expected)
        {
            ArrayVector arrayVector = new ArrayVector(input);
            ClassicAssert.AreEqual(arrayVector.MultNechet(), expected);
        }
        public void SortDown(int[] input, int[] expected)
        {
            ArrayVector arrayVector = new ArrayVector(input);
            ClassicAssert.AreEqual(arrayVector.MultNechet(), expected);
        }
    }
}