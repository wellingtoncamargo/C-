// Trabalhando com loops While
using System;
class programa
{
    static void Main()
    {
        string[] nomes = {"ana", "fernanda", "cristina"};
        int i = 0;
        while(i < nomes.Length)
        {
            Console.WriteLine("Index: {0} => {1}", i, nomes[i]);
            i++;
        }

        Console.ReadKey();
    }
}