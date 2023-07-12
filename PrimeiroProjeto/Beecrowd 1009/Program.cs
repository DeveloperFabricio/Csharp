using System;
using System.Globalization;

namespace uri1009
{
    class Course
    {
        static void Main(string[] args)
        {
            string vendedor;
            double salario, horas, media;

            vendedor = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            horas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = horas * 0.15 + salario;

            Console.WriteLine("TOTAL = R$ " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
