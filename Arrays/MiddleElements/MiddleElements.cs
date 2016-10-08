using System;

using System.Linq;


namespace MiddleElements
{
    class MiddleElements
    {
        static void Main(string[] args)
        {

            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int start = arr.Length / 2 - 1;
            int end = start + 2;
            if (arr.Length == 1) start = end = 0;
            else if (arr.Length % 2 == 0) end--;
            int[] mid = new int[end - start + 1];
            int j = 0;
            while (j < mid.Length)
            {
                for (int i = start; i <= end; i++)
                {
                    mid[j] = arr[i];
                    j++;
                }
            }
            Console.WriteLine(string.Join(" ", mid));
        }
    }
}







//using System;

//using System.Linq;


//namespace MiddleElements
//{
//    class MiddleElements
//    {
//        static void Main(string[] args)
//        {
//            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//            int start = arr.Length / 2 - 1;
//            int end = arr.Length / 2 + 1;
//            if (arr.Length == 1)
//            {
//                start = end=0;
//            }
//            else if (arr.Length%2==0)
//            {
//                end = arr.Length / 2;
//            }
//            for (int i = start; i <=end; i++)
//            {
//                Console.Write(arr[i]+" ");
//            }
//            Console.WriteLine();
//        }
//    }
//}