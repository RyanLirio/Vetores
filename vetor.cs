using System;

class Program
{
    static void Main()
    {
        
        int[] numerosPares = new int[100];
        int[] numerosImpares = new int[100];

        int contadorPar = 0;
        int contadorImpar = 0;

        
        for (int i = 0; i < 200; i++)
        {
            if (i % 2 == 0) 
            {
                numerosPares[contadorPar] = i;
                contadorPar++;
            }
            else 
            {
                numerosImpares[contadorImpar] = i;
                contadorImpar++;
            }
        }

        
        Console.WriteLine("Lista de Números Pares:");
        foreach (var par in numerosPares)
        {
            Console.Write(par + " ");
        }

        Console.WriteLine("\n");

        
        Console.WriteLine("Lista de Números Ímpares:");
        foreach (var impar in numerosImpares)
        {
            Console.Write(impar + " ");
        }

        Console.WriteLine();
    }
}
