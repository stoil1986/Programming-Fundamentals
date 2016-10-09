using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OccurrencesString
{
    class OccurrencesString
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();
            int count = 0;
            int offset = 0;
            while (true)
            {
                offset = text.IndexOf(word,offset);
                if (offset == -1)
                {
                    break;
                }  
                count++;
                offset++;
            }
            Console.WriteLine($"Occurrencies: {count}");

        }
    }
}
