using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lottary_ticket {
    class Program {
        static void Main(string[] args) {
            List<int> rowsAndCols = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];
            int[,] ticket = new int[rows, cols];
            int evenTopBottom = 0;
            int oddLeftRight = 0;
            for(int i = 0; i < rows; i++){
                List<int> row = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                for(int j = 0; j < cols; j++){
                    ticket[i, j] = row[j];
                    if((i == 0 || i == rows - 1) && ticket[i, j] % 2 == 0){
                        evenTopBottom += ticket[i, j];
                    }
                    if((j == 0 || j == cols - 1) && ticket[i, j] % 2 != 0){
                        oddLeftRight += ticket[i, j];
                    }
                }
            }
            int evenDiagonal = 0;
            int diagonal1 = 0;
            for (int i = 0, j = 0; i < rows && j < cols; i++, j++){
                diagonal1 += ticket[i, j];
                if(ticket[i, j] % 2 == 0){
                    evenDiagonal += ticket[i, j];
                }
            }
            int diagonal2 = 0;
            for (int i = 0, j = cols - 1; i < rows && j >= 0; i++, j--) {
                diagonal2 += ticket[i, j];
            }
            int overDiagonal = 0;
            for(int i = 0; i < rows - 1; i++){
                for(int j = i + 1; j < cols; j++){
                    overDiagonal += ticket[i, j];
                }
            }
            int underDiagonal = 0;
            for(int i = 1; i < rows; i++){
                for(int j = 0; j < i; j++){
                    underDiagonal += ticket[i, j];
                }
            }
            if(diagonal1 == diagonal2 && overDiagonal % 2 == 0 && underDiagonal % 2 != 0){
                Console.WriteLine("YES");
                double result = (underDiagonal + evenDiagonal + evenTopBottom + oddLeftRight) / 4.0;
                Console.WriteLine($"The amount of money won is: {result:f2}");
            }
            else{
                Console.WriteLine("NO");
            }
        }
    }
}
