using System;

namespace LastKNumbersSum
{
    class LastKnumbersSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            var arr = new long[n];
            arr[0] = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i - 1; j >= i - k; j--)
                {
                    if (j < 0)
                    {
                        break;
                    }
                    arr[i] += arr[j];
                }
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
