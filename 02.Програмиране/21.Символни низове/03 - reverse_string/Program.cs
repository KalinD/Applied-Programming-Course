using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_string {
    class Program {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] output = new char[input.Length];
            for(int i = input.Length - 1; i >= 0; i--){
                //Console.Write(input[i]);
                output[input.Length - i - 1] = input[i];
            }
            Console.WriteLine(output);
        }
    }
}
