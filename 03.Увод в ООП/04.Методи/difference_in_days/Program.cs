using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace difference_in_days {
    class Program {
        static void Main(string[] args) {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();
            DateModifier difference = new DateModifier();
            Console.WriteLine(difference.DaysBetweenTwoDates(date1, date2));
        }
    }
}
