// Trabalhando com variaveis char e byte
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

        double parte3de5 = 3 / 5;
        float fparte3de5 = 3.0f / 5.0f;

        Console.WriteLine("\n\n"); 
        Console.WriteLine("Double: " + parte3de5);
        Console.WriteLine("Float: " + fparte3de5);

        char letra = 'a'; // quando definido CHAR o sistema aceita somente uma letra
        Console.WriteLine("Char: "+ letra);

        byte verde = 157; // para numeros entre 0 e 255
        Console.WriteLine("Byte: "+ verde);

        Console.ReadKey();
    }
}