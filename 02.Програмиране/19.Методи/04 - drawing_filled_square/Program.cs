using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawing_filled_square {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            PrintSquare(n);
        }
        static void PrintSquare(int size){
            PrintHeader(size);
            for(int i = 0; i < size - 2; i++){
                PrintMiddleRow(size);
            }
            PrintHeader(size);
        }
        static void PrintHeader(int lenght){
            Console.WriteLine(new string('-', lenght * 2));
        }
        static void PrintMiddleRow(int lenght){
            Console.Write("-");
            for(int i = 1; i < lenght; i++){
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
    }
}
