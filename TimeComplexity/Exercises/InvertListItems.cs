using System;
using System.Collections.Generic;

namespace TimeComplexity.Exercises
{
    public static class InvertListItems
    {
        public static List<int> Invert(List<int> list)
        {
            int initialCount = list.Count - 1;

            for (var i = initialCount; i >= 0; i--)
            {
                list.Add(list[i]);
                list.RemoveAt(i);
            }

            return list;
        }
    }
}
