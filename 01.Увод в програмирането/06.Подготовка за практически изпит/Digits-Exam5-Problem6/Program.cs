using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits_Exam5_Problem6 {
    class Program {
        static void Main(string[] args) {
            int num = int.Parse(Console.ReadLine());
            int first = num / 100;
            int second = (num / 10) % 10;
            int third = num % 10;
            int rows = first + second;
            int cols = first + third;
            for(int i = 1; i <= rows * cols; i++){
                if(num % 5 == 0){
                    num -= first;
                }
                else if(num % 3 == 0){
                    num -= second;
                }
                else{
                    num += third;
                }
                Console.Write(num + " ");
                if(i % cols == 0){
                    Console.WriteLine();
                }
            }
        }
    }
}
