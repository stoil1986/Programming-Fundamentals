﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(' ');
            List<int> nums = strings.Select(int.Parse).ToList();
            var sortedNums = nums.OrderBy(x => -x);
            Console.WriteLine(string.Join(" ",sortedNums));
            var largest3Nums = sortedNums.Take(3);
            Console.WriteLine(string.Join(" ", largest3Nums));

        }
    }
}
