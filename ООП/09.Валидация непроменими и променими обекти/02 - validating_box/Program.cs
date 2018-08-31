using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace validating_box {
    class Program {
        static void Main(string[] args) {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());
            try{
                Box box = new Box(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                Console.WriteLine($"Surface Area – {box.Surface():f2}");
                Console.WriteLine($"Lateral Surface Area – {box.LateralSurface():f2}");
                Console.WriteLine($"Volume - {box.Volume():f2}");
            }
            catch(ArgumentException e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
