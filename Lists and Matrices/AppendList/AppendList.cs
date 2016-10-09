//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AppendList
//{
//    class AppendList
//    {
//        static void Main(string[] args)
//        {
//            var lists = Console.ReadLine().Split('|').ToList();
//            for (int i = lists.Count - 1; i >= 0; i--)
//            {
//                var currentlist = lists[i].Split(' ');
//                foreach (var item in currentlist)
//                {
//                    if (item != "")
//                    {
//                        Console.Write(item + " ");
//                    }

//                }
//            }
//   
//        }
//    }
//}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendList
{
    class AppendList
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split('|');
            for (int i = list.Length - 1; i >= 0; i--)
            {
                var currentlist = list[i].Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j <currentlist.Length; j++)
                {                   
                    Console.Write(currentlist[j] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
