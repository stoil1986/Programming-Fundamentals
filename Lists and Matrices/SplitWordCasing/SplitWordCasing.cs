//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SplitWordCasing
//{
//    class SplitWordCasing
//    {
//        static void Main(string[] args)
//        {
//            var separators = ",;:.!()\"'/\\[] ".ToArray();
//            var words = Console.ReadLine().Split(separators,StringSplitOptions.RemoveEmptyEntries);
//            var lowerWords = new List<string>();
//            var mixedWords = new List<string>();
//            var upperWords = new List<string>();
//            foreach (var word in words)
//            {
//                var lowerLetter = 0;
//                var upperLetter = 0;
//                foreach (var letter  in word)
//                {
//                    if (char.IsLower(letter))
//                    {
//                        lowerLetter++;
//                    }
//                    if (char.IsUpper(letter))
//                    {
//                        upperLetter++;
//                    }
//                }
//                if (upperLetter==word.Length)
//                {
//                    upperWords.Add(word);
//                }
//                else if (lowerLetter == word.Length)
//                {
//                    lowerWords.Add(word);
//                }
//                else
//                {
//                    mixedWords.Add(word);
//                }           
//            }
//            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerWords));
//            Console.WriteLine("mixed-case: {0}", string.Join(", ", mixedWords));
//            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperWords));


//        }
//    }
//}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitWordCasing
{
    class SplitWordCasing
    {
        static void Main(string[] args)
        {
            var separator = ",;:.!()\"'/\\[] ".ToArray();
            var words = Console.ReadLine().Split(separator,StringSplitOptions.RemoveEmptyEntries);
            var lowerWords = new List<string>();
            var upperWords = new List<string>();
            var mixedWords = new List<string>();
            foreach (var word in words)
            {
                var lowerLetter = 0;
                var upperLetter = 0;
                foreach (var letter in word)
                {                  
                    if (char.IsLower(letter))
                    {
                        lowerLetter++;
                    }
                    else if (char.IsUpper(letter))
                    {
                        upperLetter++;
                    }
                }
                if (lowerLetter==word.Length)
                {
                    lowerWords.Add(word);
                }
                else if (upperLetter==word.Length)
                {
                    upperWords.Add(word);
                }
                else
                {
                    mixedWords.Add(word);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lowerWords)}");
            Console.WriteLine("mixed-case: {0}", string.Join(", ", mixedWords));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperWords));
        }
    }
}
