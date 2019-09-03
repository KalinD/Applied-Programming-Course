using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.CODE__Phoenix_Oscar_Romeo_November
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> creatureToSquad = new Dictionary<string, List<string>>();
            while (true)
            {
                List<string> input = Console.ReadLine().Split(" -> ").ToList();
                if (input[0] == "Blaze it!")
                {
                    break;
                }
                if (!creatureToSquad.ContainsKey(input[0]))
                {
                    creatureToSquad.Add(input[0], new List<string> { input[1] });
                    continue;
                }
                if (!creatureToSquad[input[0]].Contains(input[1]))
                {
                    creatureToSquad[input[0]].Add(input[1]);
                }
            }
            List<int> printOrder = new List<int>();
            foreach (var pair in creatureToSquad)
            {
                int substract = 0;
                foreach (string member in pair.Value)
                {
                    if (creatureToSquad.ContainsKey(member) && creatureToSquad[member].Contains(pair.Key))
                    {
                        substract++;

                    }
                }
                printOrder.Add(pair.Value.Count - substract);
            }
            while(printOrder.Any(x => x != -1)) {
                int index = printOrder.IndexOf(printOrder.Max());
                Console.WriteLine($"{creatureToSquad.ElementAt(index).Key} : {printOrder.Max()}");
                printOrder[index] = -1;
            }
        }
    }
}
