using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            if (args.Length == 0)
            {
                Console.WriteLine("ingen Parameteres her nå as.");
            }
            else
            {
                Console.WriteLine("Tror parameter skal komme under her");
            }
            
            foreach (var covid in args)
            {
                Console.WriteLine("Parameter " + covid);
            }
        }
    }
}
