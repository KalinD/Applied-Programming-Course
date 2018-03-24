using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fold_and_sum {
    class Program {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] first_row = new int[arr.Length / 2];
            int[] second_row = new int[arr.Length / 2];
            int k = arr.Length / 4;
            for(int i = 0; i < k; i++){
                first_row[i] = arr[k - i - 1];
            }
            int j = 0;
            for(int i = k; i < k * 2; i++){
                first_row[i] = arr[k * 4 - j - 1];
                j++;
            }
            for(int i = 0; i < k * 2; i++){
                second_row[i] = arr[k + i];
            }
            int[] sum = new int[first_row.Length];
            for(int i = 0; i < first_row.Length; i++){
                sum[i] = first_row[i] + second_row[i];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
