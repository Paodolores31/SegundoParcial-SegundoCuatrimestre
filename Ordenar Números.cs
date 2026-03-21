using System;
using System.Linq;

namespace ORDEN_DE_NÚMERO;

public static class Program
{
    public static void Main()
    {
        int[] numeros = new int[3];

        Console.WriteLine(" Ordena 3 números de Mayor a Menor ");

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Ingresa el número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numeros.Length - 1; i++)
        {
            for (int j = 0; j < numeros.Length - 1 - i; j++)
            {
                if (numeros[j] < numeros[j + 1])
                {
                    int aux = numeros[j];
                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = aux;
                }

                Console.WriteLine("\nNúmeros ordenados de MAYOR a MENOR:");
                Console.WriteLine(numeros[0]);

                Console.WriteLine(numeros[1]);
                Console.WriteLine(numeros[2]);










            }

        }
    }
}
