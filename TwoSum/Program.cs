using System;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
           var result = TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            Console.WriteLine($"[{ result[0]},{result[1]}]");
        }


        public static int[] TwoSum(int[] nums, int target)
        {
            int[] a = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                        continue;
                    else
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            a[0] = i;
                            a[1] = j;
                        }
                    }
                }
            }


            return a;
        }
    }
}
