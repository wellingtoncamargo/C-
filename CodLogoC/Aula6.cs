// Trabalhando com variavel Decimal
using System;
class programa //Objeto
{
    static void Main()
    {
        decimal PI = 3.14159265358979323846m; // para não identificar como float
                                            // Inserir o 'm'
        Console.WriteLine(PI);
        Console.WriteLine("Decimal len: " + sizeof(decimal));
    
        Console.ReadKey();
    }
}