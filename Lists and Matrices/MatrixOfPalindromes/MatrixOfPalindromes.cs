using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {            
            var rowsCols= Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = rowsCols[0];        
            int cols = rowsCols[1];
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] =  ""+(char)('a' + row) + (char)('a' + row + col) + (char)('a' + row);                
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
