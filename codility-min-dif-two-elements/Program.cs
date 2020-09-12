using System;

namespace codility_min_dif_two_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Solution
    {
        public int solution(int[] vector)
        {
            int diff = int.MaxValue;
            for (int i = 0; i < vector.Length - 1; i++)
                for (int j = i + 1; j < vector.Length; j++)
                    if (Math.Abs((vector[i] - vector[j])) < diff)
                        diff = Math.Abs((vector[i] - vector[j]));

            return diff;
        }
    }
}
