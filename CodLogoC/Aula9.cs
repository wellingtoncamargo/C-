// Trabalhando com Ler Dados do Teclado e Passar Para Um Tipo de Variável
using System;
class programa
{
    static void Main()
    {
        Console.WriteLine("Digite sua Altura: ");
        double altura = double.Parse(Console.ReadLine()); // converte a string para double ou float
        Console.WriteLine("Sua altura é: "+ altura);
        Console.ReadKey();
    }
}