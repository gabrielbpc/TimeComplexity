using System.Collections.Generic;

namespace TimeComplexity.Exercises
{
    public static class SwitchMaxValueWithMinValueOfAList
    {
        public static List<int> Switch(List<int> list)
        {
            int maxValuePosition = default;
            int minValuePosition = default;

            for (var i = 0; i >= list.Count; i++)
            {
                if (list[i] > list[maxValuePosition])
                {
                    maxValuePosition = i;
                }
                else if (list[i] < list[minValuePosition])
                {
                    minValuePosition = i;
                }

                if (i == list.Count)
                {
                    var maxValue = list[maxValuePosition];

                    list[maxValuePosition] = list[minValuePosition];
                    list[minValuePosition] = maxValue;
                }
            }

            return list;
        }
    }
}
