using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Renderizador
    {
        public static int Alto = 20;
        public static int Ancho = 60;
        public static void DibujarTablero()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Puntaje = 0");
            Console.SetCursorPosition(0, 3);
            for (int i = 0; i < Alto; i++)
            {
                for (int j = 0; j < Ancho; j++)
                {
                    if (i == 0 || i == (Alto - 1) || j == 0 || j == Ancho - 1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public static void DibujarPunto(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("@");
        }
    }
}
