using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int position = int.Parse(Console.ReadLine());
            int damage = 1;
            while (true)
            {
                List<string> command = Console.ReadLine().Split(" ").ToList();
                if (command[0] == "Supernova")
                {
                    break;
                }
                int steps = int.Parse(command[1]);
                if (command[0] == "left")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        position--;
                        if(position < 0) {
                            damage++;
                            position = sequence.Count - 1;
                        }
                        sequence[position] -= damage;
                    }
                }
                else if (command[0] == "right")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        position++;
                        if (position >= sequence.Count)
                        {
                            damage++;
                            position = 0;
                        }
                        sequence[position] -=  damage;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
