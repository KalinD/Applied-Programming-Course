using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Phoenix_Grid
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                string originalInput = Console.ReadLine();
                if (originalInput == "ReadMe")
                {
                    break;
                }
                List<string> input = originalInput.Split(".").ToList();
                if(input.All(x => x == string.Empty)) {
                    Console.WriteLine("YES");
                    continue;
                }
                if (originalInput.Contains("_") || originalInput.Contains(" ") || originalInput != string.Join("", originalInput.Reverse().ToList()) || input.Where(x => x.Length != 3).ToList().Count > 0)
                {
                    Console.WriteLine("NO");
                    continue;
                }
                Console.WriteLine("YES");
            }
        }
    }
}
