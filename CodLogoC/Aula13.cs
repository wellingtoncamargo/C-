// Trabalhando com loops foreach
using System;
class programa
{
    static void Main()
    {
        int numero = 15;
        int[] numeros = new int[numero];

        for(int i = 0; i < numero; i++) numeros[i] = i;
        
        // foreach Utilizado para percorrer uma collection
        foreach (int num in numeros)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("=======================================================================");
        Console.WriteLine("\n");

        string[] lista = {"ana", "fernanda", "cristina"};

        foreach (string palavra in lista)
            Console.WriteLine(palavra);

        Console.ReadKey();
    }
}