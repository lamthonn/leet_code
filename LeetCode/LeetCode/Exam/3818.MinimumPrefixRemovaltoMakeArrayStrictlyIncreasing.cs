using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Exam
{
    public class MinimumPrefixRemovaltoMakeArrayStrictlyIncreasing
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[] { 4, 3, -2, -5 };
            int result = MinimumPrefixRemoval(nums);
            Console.WriteLine("Ket qua: " + result);
        }

        static public int MinimumPrefixRemoval(int[] nums)
        {
            int removeCount = 0;
            bool isStrictlyIncreasing = false;

            for (int i = nums.Length - 1; i > 0; i--)
            {
                if ((nums[i] > nums[i - 1]) && isStrictlyIncreasing == false)
                {
                    continue;
                }
                else {
                    isStrictlyIncreasing = true;
                    removeCount++;
                }
            }
            return removeCount;
        }
    }
}
