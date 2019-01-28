// Trabalhando input de dados pelo usuario
using System;
class programa
{
    static void Main()
    {
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine(); //Input de texto
        Console.WriteLine("Seu nome é " + nome);

        Console.ReadKey();
    }
}