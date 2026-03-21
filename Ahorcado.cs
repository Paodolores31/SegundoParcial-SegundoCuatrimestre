using System;
using System.Linq;

namespace AHORCADO;

public static class Program
{
    public static void Main()
    {
        string palabra = "HOLA";


        char[] adivinado = new char[palabra.Length];
        for (int i = 0; i < palabra.Length; i++)
        {
            adivinado[i] = '_';
        }

        int vidas = 5;


        while (vidas > 0)
        {
            Console.WriteLine("\nPalabra: " + new string(adivinado));
            Console.WriteLine("Vidas: " + vidas);
            Console.Write("Dime una letra: ");


            char letra = Console.ReadLine().ToUpper()[0];

            bool acerto = false;


            for (int i = 0; i < palabra.Length; i++)
            {
                if (palabra[i] == letra)
                {
                    adivinado[i] = letra;
                    acerto = true;
                }
            }


            if (acerto == false)
            {
                vidas = vidas - 1;
                Console.WriteLine("¡Fallaste!");
            }


            if (new string(adivinado) == palabra)
            {
                Console.WriteLine("\n¡GANASTE! La palabra era: " + palabra);
                break;
            }
        }

        if (vidas == 0)
        {
            Console.WriteLine("\nPERDISTE. La palabra era: " + palabra);
        }
    }
}


