using System;

namespace SearchForValue
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] nums = new int[10];

            string x;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
            }

            do
            {
                Console.WriteLine("Input integer value to control :");
                x = Console.ReadLine();
                int y;
                if (int.TryParse(x, out y))
                {
                    if (IncludeValue(y, nums))
                    {
                        Console.WriteLine("Include");
                    }
                    else
                    {
                        Console.WriteLine("Not Include");
                    }
                }
                else
                {
                    Console.WriteLine("integer value needed!!");
                }

                Console.WriteLine("Input Q to quit");
            } while (Console.ReadLine() != "Q");
        }

        private static bool IncludeValue(int i, int[] ar)
        {
            bool found = false;

            foreach (var x in ar)
            {
                if (x == i)
                {
                    found = true;
                }
            }
            return found;
        }
    }
}