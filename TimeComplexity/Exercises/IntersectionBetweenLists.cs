using System.Collections.Generic;

namespace TimeComplexity.Exercises
{
    public static class IntersectionBetweenLists
    {
        public static List<int> GetIntersectionWith(this List<int> thisList, List<int> otherList)
        {
            List<int> result = new List<int>();

            foreach( int number in thisList)
            {
                if (otherList.Contains(number))
                    result.Add(number);
            }

            return result;
        }
    }
}
