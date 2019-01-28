// Trabalhando com Tipos de Unsigned - unit
using System;
class programa
{
    static void Main()
    {
        int gb = -2000000000; // int aceita valores positivos e negativos, sendo <= 2bilhoes ou 2³²
        uint ugb = 4000000000; // uint aceita somente valores positivos <= a 4bilhoes
        Console.WriteLine(gb);
        Console.WriteLine(ugb);

        Console.ReadKey();
    }
}