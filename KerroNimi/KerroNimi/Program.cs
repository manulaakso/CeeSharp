using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerroNimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kerro etunimesi:");
            string nimi = Console.ReadLine();
            Console.Write("Hei " + nimi + "!");
            Console.Read();
        }
    }
}
