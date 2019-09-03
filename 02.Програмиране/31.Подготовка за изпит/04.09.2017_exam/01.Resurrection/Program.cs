using System;

namespace _01.Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int length = int.Parse(Console.ReadLine());
                decimal width = decimal.Parse(Console.ReadLine());
                int wingLength = int.Parse(Console.ReadLine());

                decimal totalYears = length * length * (width + 2 * wingLength);
                Console.WriteLine(totalYears);
            }
        }
    }
}
