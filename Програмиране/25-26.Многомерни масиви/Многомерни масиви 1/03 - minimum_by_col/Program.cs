using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimum_by_col {
    class Program {
        static void Main(string[] args) {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] arr = new int[rows, cols];
            for(int i = 0; i < rows; i++){
                int[] row = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for(int j = 0; j < cols; j++){
                    arr[i, j] = row[j];
                }
            }
            int[] min = new int[cols];
            for(int i = 0; i < cols; i++){
                int j = 0;
                int minValue = arr[j, i];
                for (; j < rows; j++){
                    if(minValue > arr[j, i]){
                        minValue = arr[j, i];
                    }
                }
                min[i] = minValue;
            }
            for(int i = 0; i < rows; i++){
                for(int j = 0; j < cols; j++){
                    Console.Write("{0, 5}", arr[i, j]);
                }
                Console.WriteLine();
            }
            for(int i = 0; i < cols; i++){
                Console.Write("{0, 5}", min[i]);
            }
            Console.WriteLine();
        }
    }
}
