using System;

using System.Linq;


namespace ReverseArray
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < nums.Length/2; i++)
            {
                int prev = nums[i];
                nums[i] = nums[nums.Length - i - 1];
                nums[nums.Length - i - 1] = prev;               
            }         
            Console.WriteLine(string.Join(" ",nums));      
        }
    }
}
