using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emprty_receipt {
    class Program {
        static void Main(string[] args) {
            PrintReceipt();
        }
        static void PrintReceipt(){
            Header();
            Body();
            Footer();
        }
        static void Header(){
            Console.WriteLine("CASH RECEIPT\n------------------------------");
        }
        static void Body(){
            Console.WriteLine("Charged to____________________\nReceived by___________________");
        }
        static void Footer() {
            Console.WriteLine("------------------------------\n\u00A9 SoftUni"); //©
        }
    }
}
