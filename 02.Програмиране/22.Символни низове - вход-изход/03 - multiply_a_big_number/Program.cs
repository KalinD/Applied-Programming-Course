using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiply_a_nig_number {
    class Program {
        static void Main(string[] args) {
            string num1 = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());
            List<int> result = new List<int>();
            int i = num1.Length - 1;
            int toAdd = 0;
            while (i >= 0) {
                int num = (((int)num1[i] - '0') * num2) + toAdd;
                result.Add(num % 10);
                toAdd = 0;
                if (num >= 10) {
                    num /= 10;
                    toAdd = num;
                }
                i--;
            }
            if(toAdd > 0){
                result.Add(toAdd);
            }
            result.Reverse();
            Console.WriteLine(string.Join("", result));
        }
    }
}
