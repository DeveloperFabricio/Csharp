using System;
using System.Globalization;

namespace Vetores2
{
    class Course
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];
            double[] alturas = new double[N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);
                alturas[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            double soma = 0.0;
            for (int i = 0;i < N; i++)
            {
                soma = soma + alturas[i];
            }
            double media = soma / N;
            Console.WriteLine("Altura média: " + media.ToString("F2", CultureInfo.InvariantCulture));


            int cont = 0;
            for (int i = 0;i<N; i++)
            {
                if (idades[i] < 16) {
                    cont++;
                }
            }
            double porcentagem = (double)cont / N * 100.0;
            Console.WriteLine("Pessoas co menos de 16 anos: " + porcentagem.ToString("F1", CultureInfo.InvariantCulture) + "%");
            Console.ReadLine();

        }
    }
}
