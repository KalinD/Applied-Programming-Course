using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_statistic {
    class Program {
        static void Main(string[] args){
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            double average = 0;
            int min = arr[0];
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++){
                sum += arr[i];
                if (min > arr[i]){
                    min = arr[i];
                }
                if (max < arr[i]){
                    max = arr[i];
                }
            }
            average = (float)sum / arr.Length;
            Console.WriteLine($"Min = {min}\nMax = {max}\nSum = {sum}\nAverage = {average}");
        }
    }
}
