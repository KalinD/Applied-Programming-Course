using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace middle_nums {
    class Program {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if(arr.Length == 1){
                Console.WriteLine("{{ {0} }}", arr[0]);
            }
            else{
                if(arr.Length % 2 == 0){
                    Console.WriteLine("{{ {0}, {1} }}", arr[arr.Length / 2 - 1], arr[arr.Length / 2]);
                }
                else{
                    Console.WriteLine("{{ {0}, {1}, {2} }}", arr[arr.Length / 2 - 1], arr[arr.Length / 2], arr[arr.Length / 2 + 1]);
                }
            }
        }
    }
}
