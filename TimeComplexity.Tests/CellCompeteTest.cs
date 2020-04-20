using NUnit.Framework;
using System.Collections.Generic;

namespace TimeComplexity.Tests
{
    [TestFixture]
    public class CellCompeteTest
    {
        //  Eight houses, represented as cells, are arranged in a straight line. Each day every cell competes
        //  with its adjacent cell (neighbors). An integer value of 1 represents an active cell and a value
        //  of 0 represents an inactive cell. If the neighbors on both sides of a cell are either active or
        //  inactive, the cell becomes inactive on the next day; otherwise the cell becomes active. The two
        //  cells on each end have a single adjacent cell, so assume that the unoccupied space on the opposite
        //  side is an inactive cell. Even after updating the cell state, consider its previous state when
        //  updating the state of other cells. the state information of all cells should be updated simultaneously.

        //  Write a method which takes takes an array of integers cells representing the current 
        //  state of 8 cells and one integer days representing the number of days to simulate. 

        [Test, TestCaseSource(nameof(ShouldCompeteCellsTestAndReturnTheNewStateSource))]
        public void ShouldCompeteCellsTestAndReturnTheNewState(int[] cellsState, int days, int[] stateExpected)
        {

        }

        private static IEnumerable<TestCaseData> ShouldCompeteCellsTestAndReturnTheNewStateSource
        {
            get
            {
                yield return new TestCaseData(new int[] { 1, 0, 0, 0, 0, 1, 0, 0 }, 1, new int[] { 0, 1, 0, 0, 1, 0, 1, 0 });
                yield return new TestCaseData(new int[] { 1, 1, 1, 0, 1, 1, 1, 1 }, 2, new int[] { 0, 0, 0, 0, 0, 1, 1, 0 });
            }
        }
    }
}
