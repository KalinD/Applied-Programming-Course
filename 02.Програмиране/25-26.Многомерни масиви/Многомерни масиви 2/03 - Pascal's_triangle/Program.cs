using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascal_s_triangle {
    class Program {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            long[][] triangle = new long[h + 1][];
            for(int row = 0; row < h; row++){
                triangle[row] = new long[row + 1];
            }
            triangle[0][0] = 1;
            for(int row = 0; row < h - 1; row++){
                for(int col = 0; col <= row; col++){
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];

                }
            }
            Console.WriteLine();
            for (int row = 0; row < h; row++)
            {
                Console.Write($"{new string(' ', h* 2 - 2 - 2 * row)}");
                for (int col = 0; col < triangle[row].Length; col++)
                {
                    Console.Write($"{triangle[row][col]}{new string(' ', 4 - triangle[row][col].ToString().Length)}");
                }
                Console.WriteLine();
            }
        }
    }
}
