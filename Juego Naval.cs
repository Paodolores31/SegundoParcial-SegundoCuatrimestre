# Dolores Cruz Paola
# Leal Cañada Fatima Jaqueline 
# https://youtube.com/shorts/cZk0RPLyA5c?si=5ufTtsxaCwwcEpi0
using System;
using System.Linq;

namespace Juego_naval;

public static class Program
{

    // DECLARACIÓN DE LAS VARIABLES //

    int[,] tablero = new int[5, 5];
    int filaBarco, columnaBarco;
    int filaJugador, columnaJugador;
    bool juegoTerminado = false;


    // COLOCAR EL BARCO //

    Random random = new Random();
    filaBarco = random.Next(0, 5);
            columnaBarco = random.Next(0, 5);
            tablero[filaBarco, columnaBarco] = 1;

           
            // BIENVENIDA AL JUEGO//
           
            Console.WriteLine("🎯 JUEGO DE BATALLA NAVAL 🎯");
            Console.WriteLine("- Tablero 5x5 (filas y columnas del 0 al 4)");
            Console.WriteLine("- 0 = agua, 1 = barco\n");

            
            // BUCLE PRINCIPAL//
        
            while (!juegoTerminado)
            {
                Console.WriteLine("👉 TURNO DEL JUGADOR");

                Console.Write("Introduce fila (0-4): ");
                filaJugador = int.Parse(Console.ReadLine());

    Console.Write("Introduce columna (0-4): ");
                columnaJugador = int.Parse(Console.ReadLine());

                
                // VALIDAR RANGO //
               
                if (filaJugador< 0 || filaJugador> 4 || columnaJugador< 0 || columnaJugador> 4)
                {
                    Console.WriteLine("\n❌ Número inválido. Usa solo del 0 al 4.\n");
                    continue; // Volver a pedir numero//
                }

               
                // COMPROBAR DISPARO//
             
                if (filaJugador == filaBarco && columnaJugador == columnaBarco)
                {
                    Console.WriteLine("\n💥 ¡HAS HUNDIDO EL BARCO! ¡GANASTE!");
                    juegoTerminado = true;
                    break; 
                }
                else

    Console.WriteLine("\n💦 ¡AGUA! Inténtalo de nuevo.\n");

            }

           
            // FIN DEL JUEGO//
           
            Console.WriteLine("\n✅ Juego terminado. Gracias por jugar!");
        
    
    }
}





