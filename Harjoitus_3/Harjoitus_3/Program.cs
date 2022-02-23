using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String luku1, luku2;
            int jako;
            Console.Write("Anna 1. luku: ");
            luku1 = Console.ReadLine();
            Console.Write("Anna 2. luku: ");
            luku2 = Console.ReadLine();
            jako = Int32.Parse(luku1) * Int32.Parse(luku2);
            Console.Write(jako);
            Console.ReadLine();
        }
    }
}
