using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class clsImpression
    {
        public void PrintClient(clsAbsClients client)
        {
            Console.WriteLine(client.Pin + " " + client.Name);
            Console.WriteLine(client.RegimentType);
            Console.WriteLine(client.RFC);
            Console.ReadKey();
        }
    }
}
