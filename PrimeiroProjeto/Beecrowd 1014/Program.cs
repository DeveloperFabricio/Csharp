using System;
using System.Globalization;

namespace uri1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            decimal Y, resultado;

            X = int.Parse(Console.ReadLine());  
            Y = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resultado = X / Y;

            Console.WriteLine(resultado.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
