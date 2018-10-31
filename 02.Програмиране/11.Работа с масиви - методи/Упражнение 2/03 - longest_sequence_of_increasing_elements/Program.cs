using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longest_sequence_of_increasing_elements {
    class Program {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int index;
            int count = 0;
            int max = 1;
            for (int i = 0; i < arr.Length - 1; i++){
                if (arr[i] == arr[i + 1] - 1){
                    count++;
                }
                else{
                    count = 0;
                }
                max = Math.Max(max, count);
            }
            count = 0;
            for (int i = 0; i < arr.Length - 1; i++){
                if (arr[i] == arr[i + 1] - 1){
                    count++;
                    if(count == max){
                        index = i + 1 - max;
                        int j = 0;
                        while(j <= max){
                            Console.Write(arr[index] + " ");
                            index++;
                            j++;
                        }
                        break;
                    }
                }
                else{
                    count = 0;
                }
            }
        }
    }
}
