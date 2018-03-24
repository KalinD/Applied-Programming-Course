using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace speed_converter {
    class Program {
        static void Main(string[] args)
        {
            float speed = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            seconds += minutes * 60 + hours * 3600;
            float mInSec = speed / seconds;
            Console.WriteLine(mInSec);
            seconds -= minutes * 60 + hours * 3600;
            hours += minutes / 60f + seconds / 3600f;
            float kmInHour = (speed / 1000f) / hours;
            Console.WriteLine(kmInHour);
            float milInHour = (float)Math.Round((speed / 1609) / hours, 7);
            Console.WriteLine(milInHour);
        }
    }
}
