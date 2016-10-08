using System;
using System.Linq;

namespace LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            var str1 = Console.ReadLine().Split(' ');
            var str2 = Console.ReadLine().Split(' ');
            int a = LargestCommonEnd1(str1, str2);
            int b = LargestCommonEnd2(str1, str2);
            if (a>0)
            {
                Console.WriteLine(a);
            }
            else if (b > 0)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(0);
            }
       
        }
        static int LargestCommonEnd1(string[] words1, string[] words2)
        {
            var rightCount = 0;
            while (rightCount < words1.Length && rightCount < words2.Length)
            {
                if (words1[words1.Length - rightCount - 1] == words2[words2.Length - rightCount - 1])
                {
                    rightCount++;
                }
                else
                {
                    break;
                }
            }
            return rightCount;
        }
        static int LargestCommonEnd2(string[] words1, string[] words2)
        {
            var leftCount = 0;
            while (leftCount < words1.Length && leftCount < words2.Length)
            {
                if (words1[leftCount] == words2[leftCount])
                {
                    leftCount++;
                }
                else
                {
                    break;
                }
            }
            return leftCount;
        }

    }
}
