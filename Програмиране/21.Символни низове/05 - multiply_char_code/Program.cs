using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiply_char_code {
    class Program {
        static void Main(string[] args) {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            //input[0] - word 1; input[1] - word 2
            int sum = 0;
            int i;
            for (i = 0; i < Math.Min(input[0].Length, input[1].Length); i++){
                sum += input[0][i] * input[1][i];
            }
            while(i < input[0].Length){
                sum += input[0][i];
                i++;
            }
            while (i < input[1].Length) {
                sum += input[1][i];
                i++;
            }
            Console.WriteLine(sum);
        }
    }
}
