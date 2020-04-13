using FluentAssertions;
using NUnit.Framework;
using TimeComplexity.Exercises;

namespace TimeComplexity.Tests
{
    [TestFixture]
    public class GreatestCommonDivisorTest
    {
        // The greatest common divisor is the larger positive integer that divides all numbers without giving a remainder.

        [Test]
        public void ShouldFindTheGDCValue()
        {
            var input = new int[] { 2, 4, 6, 8, 10 };

            var output = GreatestCommonDivisor.FindGreatestCommonDivisor(input);

            output.Should().Be(2);
        }
    }
}
