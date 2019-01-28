// Trabalhando para obter o tamanho do tipo de uma variavel usando bytes
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

        Console.WriteLine("\n"); 
        Console.WriteLine("Double: " + parte3de5);
        Console.WriteLine("Float: " + fparte3de5);

        Console.WriteLine("\n");
        char letra = 'a'; 
        Console.WriteLine("Char: "+ letra);

        Console.WriteLine("\n");
        byte verde = 157; 
        Console.WriteLine("Byte: "+ verde);

        Console.WriteLine("\n");
        Console.WriteLine("Tamanho do tipo double: " + sizeof(double) + " bytes.");
        Console.WriteLine("Tamanho do tipo int: " + sizeof(int) + " bytes.");
        Console.WriteLine("Tamanho do tipo float: " + sizeof(float) + " bytes.");
        Console.WriteLine("Tamanho do tipo char: " + sizeof(char) + " bytes.");


        Console.ReadKey();
    }
}