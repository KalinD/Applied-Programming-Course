using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualCouples {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++) {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                arr[i] = num1 + num2;
            }
            if (arr.Max() == arr.Min()) {
                Console.WriteLine("Yes, value={0}", arr[0]);
            }
            else {
                int max = 0;
                if (Array.IndexOf(arr, arr.Max()) < n - 2 && Array.IndexOf(arr, arr.Max()) > 0) {
                    max = Math.Max(arr[Array.IndexOf(arr, arr.Max()) - 1], arr[Array.IndexOf(arr, arr.Max()) + 1]);
                }
                else if (Array.IndexOf(arr, arr.Max()) == n - 1) {
                    max = arr.Max() - arr[Array.IndexOf(arr, arr.Max()) - 1];
                }
                else if (Array.IndexOf(arr, arr.Max()) == 0) {
                    max = arr.Max() - arr[Array.IndexOf(arr, arr.Max()) + 1];
                }
                Console.WriteLine("No, maxdiff={0}", max);
            }
        }
    }
}
