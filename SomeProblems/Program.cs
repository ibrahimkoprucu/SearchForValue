using System;

namespace SomeProblems
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] ar = { 1, 4, 9, 4, 5, 6, 9, 3 };
            FindSecondLargest(ar);
        }

        /// <summary>
        /// Finds second largest element in a given array
        /// </summary>
        /// <param name="ar"></param>
        /// <param name="size"></param>
        private static void FindSecondLargest(int[] ar)
        {
            if (ar.Length < 2)
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            int first, second;
            int indexOfFirst = 0;
            int indexOfSecond = 0;

            first = second = ar[0];

            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > first)
                {
                    second = first;
                    indexOfSecond = indexOfFirst;
                    first = ar[i];
                    indexOfFirst = i;
                }
                else if (ar[i] > second && ar[i] != first)
                {
                    second = ar[i];
                    indexOfSecond = i;
                }
            }

            Console.WriteLine("Largest element:{0},second Largest element:{1}", first, second);
            Console.WriteLine(@"Index of Largest element:{0},Index of
                              second Largest element:{1}", indexOfFirst, indexOfSecond);
        }
    }
}