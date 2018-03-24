using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace centuries_to_minutes {
    class Program {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            long minutes = hours * 60;
            Console.WriteLine($"{centuries} centurie(s) = {years} year(s) = {days} day(s) = {hours} hour(s) = {minutes} minute(s)");
        }
    }
}
