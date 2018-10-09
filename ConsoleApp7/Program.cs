using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            clsBaseClients client = new clsBaseClients(0, "Cesar Tapia", "0012", "TAMC880934", 1, "Scott Yoon");
            Console.WriteLine(client.Pin + " " + client.Name);
            Console.WriteLine(client.RegimentType);
            Console.WriteLine(client.RFC);
            Console.ReadKey();
        }
    }
}
