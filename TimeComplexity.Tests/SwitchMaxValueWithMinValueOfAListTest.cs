using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;
using TimeComplexity.Exercises;

namespace TimeComplexity.Tests
{
    [TestFixture]
    public class SwitchMaxValueWithMinValueOfAListTest
    {
        //  Write a method that receives a list of int and switch the positions of the
        //  max value and the min value.
        //  Example: [ 1, 2, 3, 4] to [ 4, 2, 3, 1]
        //  The method should have a time complexity of O(n).

        [Test, TestCaseSource(nameof(ShouldSwitchTheMaxValueWithTheMinValueOfAListTestCaseSource))]
        public void ShouldSwitchTheMaxValueWithTheMinValueOfAList(List<int> listToManipulate, List<int> expected)
        {
            var output = SwitchMaxValueWithMinValueOfAList.Switch(listToManipulate);

            output.Should().BeEquivalentTo(expected);
        }

        private static IEnumerable<TestCaseData> ShouldSwitchTheMaxValueWithTheMinValueOfAListTestCaseSource
        {
            get
            {
                yield return new TestCaseData(new List<int> { 1, 2, 3, 4, 5 }, new List<int> { 5, 2, 3, 4, 1 });
                yield return new TestCaseData(new List<int> { 2, 3, 1, 5 }, new List<int> { 2, 3, 5, 1 });
            }
        }
    }
}
