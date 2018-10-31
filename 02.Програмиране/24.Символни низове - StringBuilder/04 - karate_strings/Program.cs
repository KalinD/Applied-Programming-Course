using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karate_strings {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            StringBuilder output = new StringBuilder(input.Length);
            output.Append(input);
            int power = 0;
            while(output.ToString().Contains('>')) {
                int index = output.ToString().IndexOf('>');
                output[index] = '~';
                index++;
                power += output[index] - '0';
                while(power > 0 && output[index] != '>'){
                    output.Remove(index, 1);
                    power--;
                }
            }
            output.Replace('~', '>');
            Console.WriteLine(output.ToString());
        }
    }
}
