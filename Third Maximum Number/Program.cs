//https://leetcode.com/problems/third-maximum-number/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Maximum_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 3, 7, 45, 96, 100, 45, 214, 1, 1, 2, 3, 44 };
            string _nums = "";
            for (int i = 0; i < nums.Length; i++)
            {
                _nums += nums[i] + " ";
            }
            _nums = _nums.TrimEnd();
            Console.WriteLine("source array = "+_nums);
            Console.WriteLine("3rd max int in array is  = " + ThirdMax(nums));            
            Console.ReadLine();
        }

        static int ThirdMax(int[] nums)
        {
            nums = nums.OrderByDescending(x => x).ToArray().Distinct().ToArray();

            if (nums.Length == 2)
            {
                return nums[0]; // 1st in array
            }
            else if (nums.Length == 1)
            {
                return nums[0]; // 1st in array
            }
            else
            {
                return nums[2]; // 3rd in array
            }             
        }
    }
}
