using AutoFixture;
using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using TimeComplexity.Exercises;

namespace TimeComplexity.Tests
{
    [TestFixture]
    public class IntersectionBetweenListsTest
    {
        private Fixture fixture;

        [OneTimeSetUp]
        public void SetUp()
        {
            fixture = new Fixture();
        }

        //  Write a method that receives two lists of int and returns the intersection of them. 
        //  This method should have a time complexity of O(n).

        [Test]
        public void ShouldReturnTheIntersectionBetweenTheTwoLists()
        {
            List<int> listOne = fixture.CreateMany<int>(10).ToList();
            List<int> listTwo = fixture.CreateMany<int>(10).ToList();

            var output = listOne.GetIntersectionWith(listTwo);

            // The method Intersect used on the line below is from System.Linq library.
            output.Should().BeEquivalentTo(listOne.Intersect(listTwo));
        }
    }
}
