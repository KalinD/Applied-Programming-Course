using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparing_char_arrays {
    class Program {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            bool areSame = true;
            for(int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++){
                if(arr1[i] > arr2[i]){
                    Console.WriteLine(string.Join("", arr2));
                    Console.WriteLine(string.Join("", arr1));
                    areSame = false;
                    break;
                }
                else if (arr1[i] < arr2[i]){
                    Console.WriteLine(string.Join("", arr1));
                    Console.WriteLine(string.Join("", arr2));
                    areSame = false;
                    break;
                }
            }
            if(areSame){
                if(arr1.Length > arr2.Length){
                    Console.WriteLine(string.Join("", arr2));
                    Console.WriteLine(string.Join("", arr1));
                }
                else{
                    Console.WriteLine(string.Join("", arr1));
                    Console.WriteLine(string.Join("", arr2));
                }
            }
        }
    }
}
