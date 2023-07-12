using System;
using System.Globalization;

namespace uri1013
{
    class Course
    {
        static void Main(string[] args)
        {
            int A, B, C, maior, maiorXY;

            string[] vet;

            vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);  

            maiorXY = (A + B + Math.Abs(A - B)) / 2;

            maior = (maiorXY + C + Math.Abs(maiorXY - C)) / 2;

            Console.WriteLine(maior + " eh o maior");

        }
    }
}