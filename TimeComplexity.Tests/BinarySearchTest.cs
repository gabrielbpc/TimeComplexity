using AutoFixture;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Linq;
using TimeComplexity.Exercises;

namespace TimeComplexity.Tests
{
    [TestFixture]
    public class BinarySearchTest
    {
        private Fixture fixture;

        [OneTimeSetUp]
        public void SetUp()
        {
            fixture = new Fixture();
        }

        // Write a binary search that returns the index of the item.
        // Binary search is time complexity O(log n).

        [Test]
        public void ShouldFindAIntegerIndexOnAnArray()
        {
            int[] array = fixture.CreateMany<int>(100).OrderBy(k => k).ToArray();
            int position = new Random().Next(1, 100);

            var result = BinarySearch.FindIndex(array, array[position]);

            result.Should().BeOfType(typeof(int));
            result.Should().Be(position);
        }
    }
}
