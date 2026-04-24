using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binarios
{
    class Program
    {
        static Program pg = new Program();
        static void Main(string[] args)
        {
            string nombre = pg.PedirDatos("Nombre");
            Console.WriteLine($"Tu primer caracter es {nombre[0]}");
            int ascii = (int)nombre[0];
            Console.WriteLine($"{nombre[0]}:{ascii}");
            Console.WriteLine(pg.numeroBinario(ascii));
             
        }
        public string numeroBinario(int ascii) {

            string binario = "";

            while (binario.Length < 8) {

                int residuo = ascii % 2;
                binario = residuo + binario;
                ascii = ascii / 2;

            }
            return binario;
        
        }

        public string PedirDatos(string valor) {
            Console.WriteLine($"Por favor ingresa tu {valor}:");
            string dato = Console.ReadLine();
            return dato;
        }
    }
}
