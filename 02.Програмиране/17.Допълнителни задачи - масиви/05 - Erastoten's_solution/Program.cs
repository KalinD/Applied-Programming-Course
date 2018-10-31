using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erastoten_s_solution {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            bool[] primeNums = new bool[n + 1];
            for(int i = 0; i < primeNums.Length; i++){
                primeNums[i] = true;
            }
            for(int i = 2; i < primeNums.Length; i++){
                if(primeNums[i]){
                    Console.Write(i + " ");
                    for(int j = i * 2; j <= n; j += i){
                        primeNums[j] = false;
                    }
                }
            }
        }
    }
}
