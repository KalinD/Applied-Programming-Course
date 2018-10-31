using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringBuilder {
    class Program {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder(100);
            sb.Append(text);
            string[] command = Console.ReadLine().Split(' ');
            switch (command[0])
            {
                case "Remove":
                    sb.Remove(Convert.ToInt32(command[1]), Convert.ToInt32(command[2]));
                    break;
                case "Insert":
                    sb.Insert(Convert.ToInt32(command[1]), command[2]);
                    break;
                case "Append":
                    sb.Append(command[0]);
                    break;
                case "Replace":
                    sb.Replace(command[1], command[2]);
                    break;
            }
            text = sb.ToString();
            Console.WriteLine(text);
        }
    }
}
