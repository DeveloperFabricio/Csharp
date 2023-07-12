using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        private static string X;

        static void Main(string[] args){

            double n, raio, area;

            n = 3.14159;
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = n * (raio * raio);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
