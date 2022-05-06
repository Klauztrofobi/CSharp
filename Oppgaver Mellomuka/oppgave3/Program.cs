using System;

namespace oppgave3
{
    internal class Program
    {
        static int tall1 = 5987;
        static int tall2 = 75984;
        static void Main(string[] args)
        {
            var toTall = TallSum(tall1, tall2);
            Console.WriteLine(toTall);


        }

        static int TallSum(int tall1, int tall2)
        {
            return tall1 + tall2;
        }
        static void Ingenting()
        {
            return;;
        }
    }
}
