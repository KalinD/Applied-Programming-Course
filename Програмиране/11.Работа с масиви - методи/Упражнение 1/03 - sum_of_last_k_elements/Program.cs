using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_last_k_elements {
    class Program {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            arr[0] = 1;
            arr[1] = 1;
            for(int i = 2; i < n; i++){
                int count = k;
                int sum = 0;
                for (int j = i; j >= 0 && count >= 0; j--){
                    sum += arr[j];
                    count--;
                }
                arr[i] = sum;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
