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

            ////Deklarere en variable av hver  av de nevte datatypene

            //bool b;
            //int i;
            //float f;
            //double d;
            //string s;

            ////tilordning

            //b = true;
            //i = 5;
            //f = 3.2f;
            //d = 1.2;
            //s = "text haha kek";

            //// Kan også Deklarere og tilornde samtidig

            //bool b2 = false;
            //int i2 = 3;
            //float f2 = 1.3f;
            //double d2 = 7.7;
            //string s2 = "THK";

            //var b3 = false;
            //var i3 = 9;
            //var f3 = 5.5f;
            //var d3 = 9.9;
            //var s3 = "text";















            if (args.Length == 0)
            {
                Console.WriteLine("Fuck Mannen ingen Parameteres her nå as.");
            }
            else
            {
                Console.WriteLine("FUCK YOLO MANN: ");
            }
            
            foreach (var covid in args)
            {
                Console.WriteLine("Parameter " + covid);
            }
        }
    }
}
