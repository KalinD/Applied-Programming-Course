using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome {
    class Program {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int was = 0;
            for(int i = 0; i < input.Length / 2; i++){
                if(input[i] != input[input.Length - i - 1]){
                    Console.WriteLine("False");
                    was = 1;
                    break;
                }
            }
            if(was == 0){
                Console.WriteLine("True");
            }
        }
    }
}
