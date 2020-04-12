using System;
using System.Collections.Generic;

namespace TimeComplexity.Exercises
{
    public static class InvertListItems
    {
        public static List<int> Invert(List<int> array)
        {
            int initialCount = array.Count - 1;

            for (var i = initialCount; i >= 0; i--)
            {
                array.Add(array[i]);
                array.RemoveAt(i);
            }

            return array;
        }
    }
}
