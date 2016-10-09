
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 0;
            int maxSequence = 0;
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                counter = 0;
                int j = i;
                while (arr[i] == arr[j])
                {
                    counter++;
                    j++;
                    if (j >= arr.Length)
                    {
                        break;
                    }
                }
                if (counter > maxSequence)
                {
                    maxSequence = counter;
                    index = i;
                }
            }
            for (int i = index; i <= index + maxSequence - 1; i++)
            {
                if (i != index + maxSequence - 1)
                {
                    Console.Write(arr[i] + " ");
                }
                else
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}






