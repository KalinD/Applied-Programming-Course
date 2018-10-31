using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combining_two_sorted_arrays {
    class Program {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] combined = new int[arr1.Length + arr2.Length];
            int i1 = arr1.Length - 1, i2 = arr2.Length - 1, i = combined.Length - 1;
            for (; i1 >= 0 && i2 >= 0; i--){
                if(arr1[i1] > arr2[i2]){
                    combined[i] = arr1[i1];
                    i1--;
                }
                else{
                    combined[i] = arr2[i2];
                    i2--;
                }
            }
            while(i1 >= 0){
                combined[i] = arr1[i1];
                i1--;
                i--;
            }
            while (i2 >= 0){
                combined[i] = arr2[i2];
                i2--;
                i--;
            }
            Console.WriteLine(string.Join(" ", combined));
        }
    }
}
