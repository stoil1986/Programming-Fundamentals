using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateMatrix
{
    class RotateMatrix
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            var matrix = new string[rows, cols];    
            for (int row = 0; row < rows; row++)
            {
                var lines = Console.ReadLine().Split(' ');

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = lines[col];
                }
            }
            var result = new string[cols, rows];
            for (int row = 0; row < cols; row++)
            {
                for (int col = rows-1; col >=0; col--)
                {
                    result[row, col] = matrix[col, row];
                    Console.Write(result[row, col] + " ");
                }
                Console.WriteLine();
            }     
        }
    }
}





