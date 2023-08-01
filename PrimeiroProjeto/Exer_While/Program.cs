using System;
using System.Globalization;

namespace exer_while
{
    class Course
    {
        static void Main(string[] args)
        {
            double x, soma, media;
            int resultado;

            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            soma = 0.0;
            resultado = 0;

            while ( x >= 0 )
            {
                soma = soma + x;
                resultado = resultado + 1;
                x = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);        
            }
            if (resultado == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                media = soma / resultado;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }
                Console.ReadLine ();
        }
    }
}
