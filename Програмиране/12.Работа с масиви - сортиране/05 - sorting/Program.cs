using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting {
    class Program {
        static void Main(string[] args){
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int min;
            for(int i = 0; i < arr.Length; i++){
                min = arr[i];
                for(int j = i + 1; j < arr.Length; j++){
                    if(min > arr[j]){
                        min = arr[j];
                    }
                }
                int temp = arr[i];
                arr[Array.IndexOf(arr, min)] = temp;
                arr[i] = min;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
