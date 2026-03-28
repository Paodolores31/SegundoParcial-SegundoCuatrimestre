using System;
using System.Linq;
using System.Collections.Generic;


namespace Colores;

public static class Program
{
    public static void Main()
    {


        Random rd = new Random();
        List<string> lista1 = new List<string>();
        List<string> lista2 = new List<string>();
        List<string> lista3 = new List<string>();

        //  Generar cantidades que sumen 100 //
        int n1 = rd.Next(1, 80);
        int n2 = rd.Next(1, 100 - n1);
        int n3 = 100 - (n1 + n2);

        // 2. Llenar las listas con EMOJIS usando FOR
        for (int i = 0; i < n1; i++) { lista1.Add("🔴"); }
        for (int i = 0; i < n2; i++) { lista2.Add("🟢"); }
        for (int i = 0; i < n3; i++) { lista3.Add("🔵"); }

        // Totales //
        Console.WriteLine("Cantidades: Rojo=" + n1 + " Verde=" + n2 + " Azul=" + n3);
        Console.WriteLine("Total: " + (n1 + n2 + n3) + "\n");

        // IMPRESIÓN HORIZONTAL //
        Console.WriteLine("--- VISTA HORIZONTAL ---");
        for (int i = 0; i < lista1.Count; i++) { Console.Write(lista1[i]); }
        for (int i = 0; i < lista2.Count; i++) { Console.Write(lista2[i]); }
        for (int i = 0; i < lista3.Count; i++) { Console.Write(lista3[i]); }

        Console.WriteLine("\n\n--- VISTA VERTICAL ---");

        //  IMPRESIÓN VERTICAL //
        for (int i = 0; i < lista1.Count; i++) { Console.WriteLine(lista1[i]); }
        for (int i = 0; i < lista2.Count; i++) { Console.WriteLine(lista2[i]); }
        for (int i = 0; i < lista3.Count; i++) { Console.WriteLine(lista3[i]); }

        Console.ReadKey();
    }
}




