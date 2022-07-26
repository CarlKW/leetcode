using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    
    public class TwoSum
    {
       
        //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        public static int[] TwoSumFunction(int[] nums, int target)
        {
            int[] ints = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        ints[0] = i;
                        ints[1] = j;

                    }
                }
            }
            return ints;
        }
    }
}
