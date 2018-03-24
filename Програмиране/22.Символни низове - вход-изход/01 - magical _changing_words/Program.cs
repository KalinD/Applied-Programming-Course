using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magical__changing_words {
    class Program {
        static void Main(string[] args) {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            bool isMagical = true;
            int i;
            for (i = 0; i < Math.Min(input[0].Length, input[1].Length); i++){
                char letter0 = input[0][i];
                char letter1 = input[1][i];
                int index = input[0].IndexOf(letter0);
                if(index != i){
                    if(letter1 != input[1][index] || letter0 != input[0][index]){
                        Console.WriteLine("false");
                        isMagical = false;
                        break;
                    }
                }
            }
            while(i < input[0].Length){
                int index = input[0].IndexOf(input[0][i]);
                if(index == -1 || index >= input[1].Length){
                    Console.WriteLine("false");
                    isMagical = false;
                    break;
                }
                i++;
            }
            while(i < input[1].Length) {
                int index = input[1].IndexOf(input[1][i]);
                if (index == -1 || index >= input[0].Length) {
                    Console.WriteLine("false");
                    isMagical = false;
                    break;
                }
                i++;
            }
            if (isMagical){
                Console.WriteLine("true");
            }
        }
    }
}
