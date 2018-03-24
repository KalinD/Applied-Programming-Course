using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longest_common_end {
    class Program {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split(' ').ToArray();
            string[] input2 = Console.ReadLine().Split(' ').ToArray();
            int front = 0;
            int back = 0;
            for(int i = 0; i < Math.Min(input1.Length, input2.Length); i++){
                if(input1[i] == input2[i]){
                    front++;
                }
                else{
                    break;
                }
            }
            int j = input2.Length - 1;
            for(int i = input1.Length - 1; i >= 0 && j >= 0; i--){
                if(input1[i] == input2[j]){
                    back++;
                    j--;
                }
                else{
                    break;
                }
            }
            Console.WriteLine(Math.Max(front, back));
        }
    }
}
