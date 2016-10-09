using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences
{
    class OddOccurrences
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split(' ');
            var counts = new Dictionary<string, int>();
            foreach (var w in words)
                if (counts.ContainsKey(w))
                    counts[w]++;
                else counts[w] = 1;
            var result = new List<string>();
            foreach (var pair in counts)
            {
                if (pair.Value % 2 !=0)
                {
                    result.Add(pair.Key);
                }          
            }       
                Console.WriteLine(string.Join(", ", result));
        }
    }
}
