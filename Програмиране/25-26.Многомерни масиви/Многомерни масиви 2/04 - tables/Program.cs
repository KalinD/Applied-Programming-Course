using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tables {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int[] aboveAvarage = new int[n];
            int k = 0;
            while(k < n){
                List<int> rowsAndColomns = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                int rows = rowsAndColomns[0];
                int cols = rowsAndColomns[1];
                int[,] arr = new int[rows, cols];
                int min = int.MaxValue;
                int max = int.MinValue;
                int sum = 0;
                for(int i = 0; i < rows; i++){
                    List<int> row = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                    for(int j = 0; j < cols; j++){
                        arr[i, j] = row[j];
                        sum += row[j];
                        if(row[j] < min){
                            min = row[j];
                        }
                        if(row[j] > max){
                            max = row[j];
                        }
                    }
                }
                double avarage = Math.Round(1.0 * sum / (cols * rows), 2);
                Console.WriteLine($"{min} {max} {avarage}");
                for(int i = 0; i < rows; i++){
                    for(int j = 0; j < cols; j++){
                        if(arr[i, j] > avarage){
                            aboveAvarage[k]++;
                        }
                    }
                }
                k++;
            }
            Console.WriteLine(string.Join(" ", aboveAvarage));
        }
    }
}
