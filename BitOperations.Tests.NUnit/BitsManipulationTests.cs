using NUnit.Framework;
using System;

namespace BitOperations.Tests.NUnit
{
    [TestFixture]
    public class BitsManipulationTests
    {
        [Test]
        public void GetModifiedNumber_StartGreaterThanEnd_ThrowArgumentOutOfRangeException() =>
            Assert.Throws<ArgumentOutOfRangeException>(() => BitsManipulation.GetModifiedNumber(15, 15, 7, 1));

        public void GetModifiedNumber_NegativeBitNumber_ThrowArgumentOutOfRangeException(int startBitNumber, int endBitNumber) =>
            Assert.Throws<ArgumentOutOfRangeException>(() => BitsManipulation.GetModifiedNumber(15, 15, -5, 0));

        public void GetModifiedNumber_BitNumberGreaterThan31_ThrowArgumentOutOfRangeException(int startBitNumber, int endBitNumber) =>
            Assert.Throws<ArgumentOutOfRangeException>(() => BitsManipulation.GetModifiedNumber(15, 15, 0, -84));

        [TestCase(15, 15, 0, 0, ExpectedResult = 15)]
        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        [TestCase(8, 15, 3, 8, ExpectedResult = 120)]
        [TestCase(-8, -15, 3, 8, ExpectedResult = -120)]
        [TestCase(-91, 35, 1, 5, ExpectedResult = -121)]
        public int GetModifiedNumber_ConcreteNumbers_ReturnsModifiedNumber(int toChange, int inserted, int start, int end)
        {
            return BitsManipulation.GetModifiedNumber(toChange, inserted, start, end);
        }
    }
}
