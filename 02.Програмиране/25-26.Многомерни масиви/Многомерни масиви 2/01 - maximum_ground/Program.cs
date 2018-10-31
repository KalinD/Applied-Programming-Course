using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum_ground {
    class Program {
        static void Main(string[] args) {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] arr = new int[rows, cols];
            for(int i = 0; i < rows; i++){
                List<int> row = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                for (int j = 0; j < cols; j++){
                    arr[i, j] = row[j];
                }
            }
            int[] maxindex = {0, 0};
            int max = arr[maxindex[0], maxindex[1]];
            for(int i = 0 ; i < rows - 1; i++){
                for(int j = 0; j < cols - 1; j++){
                    int current = arr[i, j] + arr[i + 1, j] + arr[i, j + 1] + arr[i + 1, j + 1];
                    if(current > max){
                        max = current;
                        maxindex[0] = i;
                        maxindex[1] = j;
                    }
                }
            }
            Console.WriteLine($"{arr[maxindex[0], maxindex[1]]} {arr[maxindex[0], maxindex[1] + 1]}\n{arr[maxindex[0] + 1, maxindex[1]]} {arr[maxindex[0] + 1, maxindex[1] + 1]}");
        }
    }
}
