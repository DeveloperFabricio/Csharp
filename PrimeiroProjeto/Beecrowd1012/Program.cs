using System;
using System.Globalization;

namespace uri1012
{
    class Course
    {
        static void Main(string[] args)
        {
            double A, B, C, pi, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] vet;
                
            vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);         
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);            
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            pi = 3.14159;
            triangulo = A * C / 2.0;
            circulo = C * C * pi;
            trapezio = (A + B) / 2.0 * C;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}