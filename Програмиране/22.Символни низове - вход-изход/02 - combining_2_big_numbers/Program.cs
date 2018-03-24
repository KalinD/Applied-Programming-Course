using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combining_2_big_numbers {
    class Program {
        static void Main(string[] args) {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            List<int> result = new List<int>();
            int i = num1.Length - 1;
            int j = num2.Length - 1;
            int toAdd = 0;
            while(i >= 0 && j >= 0){
                int num = (int)num1[i] - '0' + (int)num2[j] - '0' + toAdd;
                result.Add(num % 10);
                toAdd = 0;
                if (num >= 10){
                    toAdd = 1; 
                }
                i--;
                j--;
            }
            while(i >= 0){
                result.Add((int)num1[i] - '0' + toAdd);
                toAdd = 0;
                i--;
            }
            while (j >= 0) {
                result.Add((int)num2[j] - '0' + toAdd);
                toAdd = 0;
                j--;
            }
            result.Reverse();
            Console.WriteLine(string.Join("", result));
        }
    }
}
