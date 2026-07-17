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
        static bool juegando = false;
        // Declaracion del objeto Serpiente
        static MovimientoSnake Serpiente;
        static Renderizador renderizador = new Renderizador();
        public static void IniciarJuego()
        {
            while (juegando == false)
            {
                Serpiente = new MovimientoSnake();
                EjecucionJuego();
            }
        }
        static void EjecucionJuego()
        {
            juegando = true;
            renderizador.DibujarTablero();
            renderizador.DibujarCabezaSnake(Serpiente.posicionCabeza.X, Serpiente.posicionCabeza.Y);
            while (juegando)
            {
                Thread.Sleep(150);
                Serpiente.Movimiento();
                renderizador.BorrarPosicionAnterior(Serpiente.posicionAnteriorCabeza);
                Serpiente.ActualizarPosicionAnterior();
                renderizador.DibujarCabezaSnake(Serpiente.posicionCabeza.X, Serpiente.posicionCabeza.Y);
                GameOver();
            }
        }
        
        static void GameOver()
        {
            if (Serpiente.posicionCabeza.X == 0 || Serpiente.posicionCabeza.X == (renderizador.Ancho -1) || Serpiente.posicionCabeza.Y == 3 ||   Serpiente.posicionCabeza.Y == (renderizador.Alto + 2))
            {
                Console.Clear();
                Console.WriteLine("Game over");
                VolverJugar();
            }
        }
        static void VolverJugar()
        {
            Console.WriteLine("Intentar De nuevo? (s/n)");
            var Continuar = Console.ReadKey(true);
            if (Continuar.KeyChar == 's' || Continuar.KeyChar == 'S')
            {
                juegando = false;
                Console.Clear();
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