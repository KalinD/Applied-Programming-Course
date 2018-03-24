using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1000_Days {
    class Program {
        static void Main(string[] args){
            CultureInfo provider = CultureInfo.InvariantCulture;
            string entered_date = Console.ReadLine();
            var new_date = DateTime.ParseExact(entered_date, "dd-MM-yyyy", provider);
            Console.WriteLine("{0:dd-MM-yyyy}", new_date.AddDays(999));
        }
    }
}
