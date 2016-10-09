﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2x2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowsCols = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = rowsCols[0];
            int cols = rowsCols[1];
            var matrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                var lines = Console.ReadLine().Split(' ');

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = lines[col];
                }
            }        
            int count = 0;
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    if (matrix[row, col] == matrix[row + 1, col] && matrix[row + 1, col] == matrix[row, col + 1]
                        && matrix[row, col + 1] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}


