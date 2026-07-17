using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Posicion
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Posicion(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
