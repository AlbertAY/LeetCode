using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public static class 两数之和
    {

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] arry = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = nums.Length - 1; j > i; j--)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        arry[0] = i;
                        arry[1] = j;
                    }
                }

            }
            return arry;
        }
    }
}
