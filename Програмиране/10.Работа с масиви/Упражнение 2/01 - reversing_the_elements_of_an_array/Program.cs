using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversing_the_elements_of_an_array {
    class Program {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++){
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(arr);
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
