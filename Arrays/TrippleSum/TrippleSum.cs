using System;
using System.Linq;

namespace TrippleSum
{
    class TrippleSum
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            int count = 0;
            for (int left = 0; left < arr.Length; left++)
            {
                for (int right = left + 1; right < arr.Length; right++)
                {
                    sum = arr[left] + arr[right];

                    bool exist = Contains(arr, sum);
                    if (exist)
                    {
                        Console.WriteLine($"{arr[left]} + {arr[right]} == {sum}");
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
        private static bool Contains(int[] arr, int element)
        {
            bool exist = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element)
                {
                    exist = true;
                    break;
                }
            }
            return exist;
        }
    }
}




//using System;
//using System.Linq;

//namespace TrippleSum
//{
//    class TrippleSum
//    {
//        static void Main(string[] args)
//        {
//            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

//            for (int i = 0; i < nums.Length; i++)
//                for (int j = i + 1; j < nums.Length; j++)
//                {
//                    int a = nums[i];
//                    int b = nums[j];
//                    int sum = a + b;
//                    if (nums.Contains(sum))
//                        Console.WriteLine($"{a} + {b} == {sum}");
//                }
//        }
//    }
//}

