using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLParser
{
    class URLParser
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var parsedInput = input.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            string protocol = "";
            string server = "";
            string resource = "";
            var result = new List<string>();

            if (parsedInput.Length == 1)
            {
                server = input;
            }
            else if (parsedInput.Length == 2)
            {
                protocol = parsedInput[0].Substring(0, parsedInput[0].Length - 1);
                server = parsedInput[1];
            }
            else if (parsedInput.Length >= 3)
            {
                protocol = parsedInput[0].Substring(0, parsedInput[0].Length - 1);
                server = parsedInput[1];
                for (int i = 2; i < parsedInput.Length; i++)
                {
                    result.Add(parsedInput[i]);
                }            
            }
            Console.WriteLine($"[protocol] = \"{protocol}\"");
            Console.WriteLine(($"[server] = \"{server}\""));
            Console.WriteLine(($"[resource] = \"{string.Join("/", result)}\""));
        }
    }
}



//работи но дава 90 точки

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace URLParser
//{
//    class URLParser
//    {
//        static void Main(string[] args)
//        {
//            string input = Console.ReadLine();
//            int indexOfProtokol = input.IndexOf("://");
//            int indexOfServer = input.IndexOf("/", indexOfProtokol + 3);
//            string result = "";
//            string result1 = "";
//            string result2 = "";
//            if (indexOfProtokol != -1)
//            {
//                result = input.Substring(0, indexOfProtokol);
//                Console.WriteLine($"[protocol] = \"{result}\"");
//            }
//            else
//            {
//                Console.WriteLine("[protocol] = \"\"");
//            }

//            if (indexOfServer != -1)
//            {
//                result1 = input.Substring(indexOfProtokol + 3, indexOfServer - indexOfProtokol - 3);
//                result2 = input.Substring(indexOfServer + 1, input.Length - result.Length - result1.Length - 4);
//            }
//            else
//            {
//                result1 = input;
//                result2 = "";
//            }
//            Console.WriteLine(($"[server] = \"{result1}\""));
//            Console.WriteLine(($"[resource] = \"{result2}\""));

//        }
//    }
//}
