using System.Collections.Generic;
using System.Xml;

namespace Two_Sum
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }

        private int[] solve(int[] nums, int target)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int index;
                if (dictionary.TryGetValue(target - nums[i], out index))
                {
                    return new int[]{i, index};
                }
                if(!dictionary.ContainsKey(nums[i]))
                {
                    dictionary.Add(nums[i], i);
                }
            }
            return null;
        }
    }
}