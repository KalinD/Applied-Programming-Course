using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avarage_by_rows {
    class Program {
        static void Main(string[] args) {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] arr = new int[rows, cols];
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < rows; i++) {
                double sum = 0;
                for (int j = 0; j < cols; j++) {
                    sum += arr[i, j];
                    Console.Write("{0, 10}", arr[i, j]);
                }
                Console.WriteLine("{0, 10}", sum / cols);
            }
        }
    }
}
