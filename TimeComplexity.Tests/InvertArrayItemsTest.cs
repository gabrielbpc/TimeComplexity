using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;
using TimeComplexity.Exercises;

namespace TimeComplexity.Tests
{
    [TestFixture]
    public class InvertArrayItemsTest
    {
        //  Write a method that reverses the order of a list. 
        //  You shall not use another list as auxiliary list.
        //  The method should have a time complexity of O(n).

        [Test]
        public void ShouldInvertTheOrderOfItems()
        {
            List<int> array = new List<int> { 1, 2, 3, 4, 5 };

            var result = InvertArrayItems.Invert(array);

            result.Should().BeEquivalentTo(new List<int> { 5, 4, 3, 2, 1 });
        }
    }
}
