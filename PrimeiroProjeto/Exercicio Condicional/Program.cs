using System;
using System.Globalization;

namespace Exercicio
{
    class Course
    {
        static void Main(string[] args)
        {
            double nota1, nota2, resultado;

            Console.WriteLine("Digite sua primeira nota: ");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite sua segunda nota: ");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resultado = nota1 + nota2;

            if (resultado > 60.00) {
                Console.WriteLine("NOTA FINAL: " + resultado.ToString("F1", CultureInfo.InvariantCulture));
                
            }
            else
            {
                Console.WriteLine("NOTA FINAL = " + resultado.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
            }


        }
    }
}
