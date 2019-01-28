// Trabalhando com variaveis double e float
using System;
class programa
{
    static void Main()
    {
        string nome = "Paulo";
        int canetas = 3;
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Tenho:"+canetas+" canetas.");

        double alturaAna = 1.58, alturaJoao = 1.80, alturaMaria = 1.56;
        Console.WriteLine("Altura da Ana: "+ alturaAna);
        Console.WriteLine("Altura do João: "+ alturaJoao);
        Console.WriteLine("Altura da Maria: "+ alturaMaria);

        double parte3de5 = 3 / 5; // utilizado para realizar decisoes
        float fparte3de5 = 3.0f / 5.0f; 

        Console.WriteLine("\n\n"); // pulando linha
        Console.WriteLine("Double: " + parte3de5);
        Console.WriteLine("Float: " + fparte3de5);

        Console.ReadKey();
    }
}