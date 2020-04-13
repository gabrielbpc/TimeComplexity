using System;
using System.Collections.Generic;
using System.Text;

namespace TimeComplexity.Exercises
{
    public static class BinarySearch
    {
        public static int FindIndex(int[] array, int number) => Search(array, 0, array.Length, number);

        private static int Search(int[] array, int left, int right, int number)
        {
            if (right >= left)
            {
                int mid = GetMiddle(left, right);

                if (array[mid] == number)
                    return mid;

                if (array[mid] > number)
                    return Search(array, left, mid - 1, number);

                return Search(array, mid + 1, right, number);
            }

            return -1;
        }

        private static int GetMiddle(int left, int right) => left + (right - left) / 2;
    }
}
