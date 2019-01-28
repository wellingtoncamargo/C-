// Trabalhando com loops
using System;
class programa
{
    static void Main()
    {
        //Primeira parte do video
     string[] nomes = {"ana", "fernanda", "cristina"};

     for(int i = 0; i < nomes.Length; i++)
     {
         Console.WriteLine("Nome: {0} = {1}", i,nomes[i] );
     }   
    
    Console.WriteLine("=======================================================================");
    Console.WriteLine("\n");
    /* Realizar um for em uma lista de nomes com 150 posições, neste caso 
    na linha onde esta escrito nulo preenche todas com a palavra NULO */
    
     int numeroDePessoas = 150;
     string[] pessoas = new string[numeroDePessoas];

     for(int i = 0; i <numeroDePessoas; i++);
        pessoas[i] = "nulo";
    
     Console.WriteLine(pessoas[0]);

    Console.WriteLine("=======================================================================");
    Console.WriteLine("\n");

    /*realiza um for com contagem numerica, onde se inicia em 0 e 
    termina em  999.*/
     for(int i = 0; i < 1000; i++) Console.WriteLine(i);


        Console.ReadKey();
    }
}