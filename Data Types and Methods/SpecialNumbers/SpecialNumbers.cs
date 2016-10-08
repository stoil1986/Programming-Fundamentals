
using System;


namespace SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            for (int i = 1; i <= n; i++)
            {
                int sumOfDigits = 0;
                for ( num = i; num > 0; num/=10)
                {
                    sumOfDigits += num % 10;
                }
                bool special = (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11);
                Console.WriteLine("{0} -> {1}", i, special);
            }
        }
    }
}

