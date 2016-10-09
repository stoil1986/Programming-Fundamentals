﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintReceipt
{
    class PrintReceipt
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(decimal.Parse);
            Console.WriteLine(@"/----------------------\");
            foreach (var num in nums)
            {
                Console.WriteLine("| {0,20:f2} |", num);
            }                 
            Console.WriteLine(@"|----------------------|");
            decimal sum = 0;
            foreach (var num in nums)
            {
                 sum += num;                
            }           
            Console.WriteLine("| Total:{0,14:f2} |", sum);
            Console.WriteLine(@"\----------------------/");

        }
    }
}
