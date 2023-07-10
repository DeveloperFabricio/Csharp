using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com o seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem sua casa? ");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço do produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura: ");
            string[] vet = Console.ReadLine().Split(' ');
            string sobrenome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.ReadLine(nome);
            Console.ReadLine(quartos);
            Console.ReadLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine(sobrenome);
            Console.ReadLine(idade);
            Console.ReadLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}