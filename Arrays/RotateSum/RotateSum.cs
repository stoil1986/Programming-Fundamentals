using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateSum
{
    class RotateSum
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var sumArr = new int[arr.Length];
            var k = int.Parse(Console.ReadLine());
            while (k > 0)
            {
                k--;
                var arr1 = new int[arr.Length];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr1[0] = arr[arr.Length - 1];
                    arr1[i + 1] = arr[i];
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    sumArr[i] += arr1[i];
                }
                arr = arr1;
            }
            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}


//        }
//    }
//}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace RotateSum
//{
//    class RotateSum
//    {
//        static void Main(string[] args)
//        {
//            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
//            int k = int.Parse(Console.ReadLine());
//            var sum = new int[list.Count];
//            int m = 0;
//            for (int i = 0; i < k; i++)
//            {
//                m = list[list.Count - 1];
//                list.RemoveAt(list.Count - 1);
//                list.Insert(0, m);
//                Console.WriteLine(string.Join(" ", list));

//                for (int j = 0; j < list.Count; j++)
//                {
//                    sum[j] += list[j];
//                }
//            }
//            Console.WriteLine(string.Join(" ", sum));
//        }
//    }
//}
