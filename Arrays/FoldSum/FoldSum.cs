using System;
using System.Collections.Generic;
using System.Linq;

namespace FoldSum
{
    class FoldSum
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var newArr = new int[arr.Length / 2];
            int j = 0;
            while (j < arr.Length / 2)
            {
                for (int i = arr.Length / 4 - 1; i >= -1; i--)
                {
                    if (i == -1)
                    {
                        i = arr.Length - 1;
                    }
                    if (i == arr.Length * 3 / 4 - 1)
                    {
                        break;
                    }
                    newArr[j] = arr[i];
                    j++;
                }
            }
            j = 0;
            for (int i = arr.Length / 4; i < arr.Length * 3 / 4; i++)
            {
                newArr[j] += arr[i];
                j++;
            }
            Console.WriteLine(string.Join(" ", newArr));
        }
    }
}




