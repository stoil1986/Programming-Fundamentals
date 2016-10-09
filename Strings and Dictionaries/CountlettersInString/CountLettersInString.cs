using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountlettersInString
{
    class CountLettersInString
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower();
            // Count the character occurences
            int[] count = new int[str.Max() + 1];
            foreach (char ch in str)
            {
                count[ch]++;
            }
            // Print the non-zero counts
            for (char ch = (char)0; ch < count.Length; ch++)
            {
                if (count[ch] != 0)
                {
                    Console.WriteLine($"{ch} -> {count[ch]}");
                } 
            }                                      
        }
    }
}
