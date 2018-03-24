using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace most_often_number {
    class Program {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] counter = new int[65535];
            foreach(int num in arr){
                counter[num]++;
            }
            int max = counter.Max();
            for(int i = 0; i < arr.Length; i++){
                if(counter[arr[i]] == max){
                    Console.WriteLine(arr[i]);
                    break;
                }
            }
        }
    }
}
