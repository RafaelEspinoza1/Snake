using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{
    public class Controlador
    {
        public static void IniciarJuego()
        {
            Renderizador.DibujarTablero();
            Renderizador.DibujarPunto(MovimientoSnake.posicionPunto.X, MovimientoSnake.posicionPunto.Y);
            while (true)
            {
                Thread.Sleep(250);
                MovimientoSnake.Movimiento();
                GameOver();
            }
        }
        
        public static void GameOver()
        {
            if (MovimientoSnake.posicionPunto.X == 0 || MovimientoSnake.posicionPunto.X == 60 || MovimientoSnake.posicionPunto.Y == 3 || MovimientoSnake.posicionPunto.Y == 23)
            {
                Console.Clear();
                Console.WriteLine("Game over");
                Console.WriteLine("Intentar De nuevo? (s/n)");
                var Continuar = Console.ReadKey(true);
                if (Continuar.KeyChar == 's')
                {
                    Console.Clear();
                    MovimientoSnake.posicionPunto.X = 11;
                    MovimientoSnake.posicionPunto.Y = 8;
                    MovimientoSnake.posicionAnterior.X = MovimientoSnake.posicionPunto.X;
                    MovimientoSnake.posicionAnterior.Y = MovimientoSnake.posicionPunto.Y;
                    MovimientoSnake.DireccionGuardada = null;
                    IniciarJuego();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Gracias por jugar!");
                    Environment.Exit(0);
                }
            }
        }
    }
}