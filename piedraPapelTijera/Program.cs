using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piedraPapelTijera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INTENTO NUMERO DOS PROGRAMA DE MIERDA TE ODIO");
            Console.WriteLine("piedraPapelTijera");
            Console.ReadKey();
        }
        static void generarMenu()
        {

        }
        static void vsMaquina()
        {

        }

        static void vsJugador()
        {
            
        }

        static string getPalabra(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    return "piedra";
                case 2:
                    return "papel";
                case 3:
                    return "tijeras";
            }
            return "";
        }
    }
}
