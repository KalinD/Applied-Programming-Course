using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longest_sequence_of_identical_elements {
    class Program {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int max = 1;
            int count = 1;
            for (int i = 0; i < arr.Length - 1; i++){
                if(arr[i] == arr[i + 1]){
                    count++;
                }
                else{
                    count = 1;
                }
                max = Math.Max(max, count);
            }
            count = 1;
            for(int i = 0; i < arr.Length - 1; i++){
                if(arr[i] == arr[i + 1]){
                    count++;
                    if(count == max){
                        while(max > 0){
                            Console.Write(arr[i] + " ");
                            max--;
                        }
                        break;
                    }
                }
                else{
                    count = 1;
                }
            }
        }
    }
}
