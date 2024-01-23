// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");

#region Conversões

int notaAluno = 10;

// Conversão Implicita
double notaAlunoDouble = notaAluno;

// Conversão Explicita
int numeroDoubleComoInt = (int)notaAlunoDouble;

// Conversão utilizando Convert
string notaString = "10A";

int notaConvert = Convert.ToInt32(notaString);

// Conversão utilizando Parse
int notaParse = int.Parse(notaString);

if (int.TryParse(notaString, out int notaTryParse)) ;
{
    else
    {
        Console.WriteLine("Número em formato inválido.");
    }
}



#endregion

#region Operadores Aritméticos

// Unários ++, --, + e -
int numeroOperador = 4;

Console.WriteLine(numeroOperador++);
Console.WriteLine(numeroOperador--);

Console.WriteLine(++numeroOperador);
Console.WriteLine(--numeroOperador);


Console.WriteLine(numeroOperador);
Console.WriteLine(-numeroOperador);
Console.WriteLine(-(-numeroOperador));



// Binários * / + - 
var soma = 4 + 5;
var subtracao = 4 - 5;
var multiplicacao = 4 * 5;
var divisao = 20 / 3;
var divisaoDouble = (double)20 / 3;
var multiplos = (4 * 5) + 10;



#endregion

#region Operadores de Comparação > >= < <=
Console.WriteLine(4 > 5);
Console.WriteLine(5 > 5);
Console.WriteLine(5 >= 5);

Console.WriteLine(5 < 4);
Console.WriteLine(5 <= 5);
Console.WriteLine(5 < 6);


#endregion