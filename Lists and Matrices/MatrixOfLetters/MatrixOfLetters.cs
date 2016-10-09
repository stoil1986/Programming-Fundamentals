using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfLetters
{
    class MatrixOfLetters
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            var matrix = new char[rows, cols];
            char letter = 'A';
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i,j] = letter++;
                    if (letter == 'Z')
                    {
                        letter = 'A';
                    }
                    Console.Write(matrix[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
