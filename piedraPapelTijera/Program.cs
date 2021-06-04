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
            Console.WriteLine("Bienvenido al juego Piedra, Papel o Tijera\nIngrese un Nº segun lo que quiera hacer\n ");
            Console.WriteLine("1- Nuevo Juego \n2- Salir\n\n");//Solo hay 2 opciones: jugar 1 vs 1 o salir
            int menu = int.Parse(Console.ReadLine());         // Transformo el string en Int 

            generarMenu(menu);

            Console.WriteLine("FINAL DEL PROGRAMA ALCANZADO");
            Console.ReadKey();
        }
        static void generarMenu(int menu)
        {
            if( menu == 1 ){
                Console.WriteLine("¿En que modo quiere jugar?\n3- Vs CPU\n4- Vs Otra Persona\n");
                    menu = int.Parse(Console.ReadLine());
            switch (menu)
                {
                    case 3:
                        vsMaquina();
                        break;
                    case 4:
                        vsJugador();
                        break;
                    default:
                        break;
                }
            }else
            {
                Console.WriteLine("Adios\n");
            }
        }
        static void vsMaquina()
        {
            Console.WriteLine("ESTO LO VOY A HACER SI ANDA");
        }

        static void vsJugador()
        {
            int jugador1, jugador2, puntaje1 = 0, puntaje2 = 0;
            string p1, p2;
            string opciones = "1.Piedra\n2.Papel\n3.Tijeras";
            while(puntaje1 != 3 && puntaje2 != 3)
            {
                Console.WriteLine("Puntaje actual: \nJugador 1: {0}\nJugador 2: {1}", puntaje1, puntaje2);

                Console.WriteLine("Jugador 1. Ingrese una de las siguientes opciones: \n" + opciones);
                ConsoleKeyInfo input = Console.ReadKey();
                jugador1 = int.Parse(input.KeyChar.ToString());

                Console.WriteLine("Jugador 2. Ingrese una de las siguientes opciones: \n" + opciones);
                input = Console.ReadKey();
                jugador2 = int.Parse(input.KeyChar.ToString());
                Console.Clear();

                p1 = getPalabra(jugador1);
                p2 = getPalabra(jugador2);

                Console.WriteLine("Jugador 1: {0}\nJugador 2: {1}", p1, p2);

                switch(getGanador(jugador1, jugador2))
                {
                    case 0:
                        Console.WriteLine("AMBOS ELIGIERON LO MISMO. EMPATE");
                        break;
                    case 1:
                        Console.WriteLine("JUGADOR 1 GANADOR!");
                        puntaje1++;
                        break;
                    case 2:
                        Console.WriteLine("JUGADOR 2 GANADOR!");
                        puntaje2++;
                        break;
                    default:
                        Console.WriteLine("OPCION INGRESADA INCORRECTA, NO CONTEST");
                        break;
                }
            }
            Console.WriteLine("Puntaje Final: \nJugador 1: {0}\nJugador 2: {1}", puntaje1, puntaje2);
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
        
        static int getGanador(int player1, int player2)
        {
            if(player1 == player2)
            {
                return 0;
            }
            else
            {
                switch (player1)
                {
                    case 1:
                        if (player2 == 2)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    case 2:
                        if(player2 == 1)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    case 3:
                        if(player2 == 1)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    default:
                        return -1;
                }
            }
        }
    }
}
