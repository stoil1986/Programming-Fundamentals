using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestIncreasingSubsequence
{
    class LargestIncreasingSubsequence
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine().Split()
           .Select(int.Parse).ToList();

            var longestAscendingSequence = ExtractAscendingSequence(data);
            Console.WriteLine(string.Join(" ", longestAscendingSequence));
        }

        private static IEnumerable<int> ExtractAscendingSequence(IList<int> data)
        {
            var maxStack = new Stack<int>();
            var currentStack = new Stack<int>();

            for (int index = 0; index < data.Count; index++)
            {
                currentStack.Push(data[index]);
                FindNextElement(data, index, ref maxStack, currentStack);
                currentStack.Pop();
            }
            return maxStack;
        }

        private static void FindNextElement(IList<int> data, int index, ref Stack<int> maxStack,
            Stack<int> currentStack)
        {
            for (int scanIndex = index + 1; scanIndex < data.Count; scanIndex++)
            {
                if (data[scanIndex] > data[index])
                {
                    currentStack.Push(data[scanIndex]);
                    FindNextElement(data, scanIndex, ref maxStack, currentStack);
                    currentStack.Pop();
                }
            }

            if (maxStack.Count < currentStack.Count)
                maxStack = new Stack<int>(currentStack);
        }
    }
}
