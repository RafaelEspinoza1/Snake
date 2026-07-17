using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class MovimientoSnake
    {
        public static Posicion posicionPunto = new Posicion(11, 8);
        public static Posicion posicionAnterior = new Posicion(posicionPunto.X, posicionPunto.Y);
        public static char? DireccionGuardada;
        public static void Movimiento()
        {
            if (Console.KeyAvailable)
            {
                MoverPunto();
            }
            else
            {
                MantenerMovimiento();
            }
            ActualizarPosicionAnterior();
            Renderizador.DibujarPunto(posicionPunto.X, posicionPunto.Y);
        }
        public static void MoverPunto()
        {
            var Direccion = Console.ReadKey(true);
            DireccionGuardada = Direccion.KeyChar;
            AplicarDirecion(Direccion.KeyChar);
        }
        public static void MantenerMovimiento()
        {
            AplicarDirecion(DireccionGuardada);
        }
        public static void ActualizarPosicionAnterior()
        {
            Console.SetCursorPosition(posicionAnterior.X, posicionAnterior.Y);
            Console.Write(" ");
            posicionAnterior.X = posicionPunto.X;
            posicionAnterior.Y = posicionPunto.Y;
        }
        public static void AplicarDirecion(char? Direccion)
        {
            switch (Direccion)
            {
                case null: // Cuando se inicia el juego se mueve a la derecha como predeterminado
                    posicionPunto.X++;
                    break;
                case 'w':
                    posicionPunto.Y--;
                    break;
                case 's':
                    posicionPunto.Y++;
                    break;
                case 'a':
                    posicionPunto.X--;
                    break;
                case 'd':
                    posicionPunto.X++;
                    break;
            }
        }
    }
}
