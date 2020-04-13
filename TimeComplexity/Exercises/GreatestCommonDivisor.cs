namespace TimeComplexity.Exercises
{
    public static class GreatestCommonDivisor
    {
        public static int FindGreatestCommonDivisor(int[] array)
        {
            int result = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                result = Calculate(array[i], result);

                if (result == 1)
                    return 1;
            }

            return result;
        }

        private static int Calculate(int a, int b)
        {
            if (a == 0)
                return b;

            return Calculate(b % a, a);
        }
    }
}
