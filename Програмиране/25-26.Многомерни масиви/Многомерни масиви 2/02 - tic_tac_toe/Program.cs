using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe {
    class Program {
        static void Main(string[] args) {
            char[,] table = new char[3, 3];
            for (int i = 0; i < 3; i++) {
                char[] row = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                for (int j = 0; j < 3; j++) {
                    table[i, j] = row[j];
                }
            }
            for (int row = 0; row < 3; row++) {
                int countX = 0;
                for (int col = 0; col < 2; col++) {
                    if (table[row, col] == table[row, col + 1]) {
                        countX++;
                    }
                    if (countX == 2) {
                        Console.WriteLine("The winner is:{0}", table[row, col]);
                        return;
                    }
                }
            }
            for (int col = 0; col < 3; col++) {
                int countY = 0;
                for (int row = 0; row < 2; row++) {
                    if (table[row, col] == table[row + 1, col]) {
                        countY++;
                    }
                    if (countY == 2) {
                        Console.WriteLine("The winner is:{0}", table[row, col]);
                        return;
                    }
                }
            }
            int countDiangonal = 0;
            for (int i = 0, j = 0; i < 2 && j < 2; i++, j++) {
                if (table[i, j] == table[i + 1, j + 1]) {
                    countDiangonal++;
                }
                if (countDiangonal == 2) {
                    Console.WriteLine("The winner is:{0}", table[1, 1]);
                    return;
                }
            }
            for (int i = 0, j = 2; i < 2 && j > 0; i++, j--) {
                if (table[i, j] == table[i + 1, j - 1]) {
                    countDiangonal++;
                }
                if (countDiangonal == 2) {
                    Console.WriteLine("The winner is:{0}", table[1, 1]);
                    return;
                }
            }
            Console.WriteLine("There is no winner");

        }
    }
}
