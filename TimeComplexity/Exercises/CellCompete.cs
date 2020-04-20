using System;
using System.Collections.Generic;
using System.Text;

namespace TimeComplexity.Exercises
{
    public static class CellCompete
    {
        private const int ACTIVE = 1;
        private const int INACTIVE = 0;

        public static int[] Compete(int[] cellStates, int days)
        {
            if (days == 0)
                return cellStates;

            int[] result = ProcessStates(cellStates);

            for (var day = 1; day <= days; day++)
                result = ProcessStates(result);

            return result;
        }

        private static int[] ProcessStates(int[] states)
        {
            int[] processResult = states;

            for (int index = 0; index < states.Length; index++)
            {
                if (index == 0)
                {
                    processResult[index] = CalculateNextState(0, states[index + 1], states[index]);
                }
                else if (index == states.Length - 1)
                {
                    processResult[index] = CalculateNextState(states[index - 1], 0, states[index]);
                }
                else
                {
                    processResult[index] = CalculateNextState(states[index - 1], states[index + 1], states[index]);
                }
            }

            return processResult;
        }

        private static int CalculateNextState(int left, int right, int currentState)
        {
            if (left == right)
            {
                return currentState == ACTIVE ? INACTIVE : ACTIVE;
            }
            else
            {
                return currentState;
            }
        }
    }
}
