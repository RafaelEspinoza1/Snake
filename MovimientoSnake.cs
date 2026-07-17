using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class MovimientoSnake
    {
        public enum Direccion
        {
            Arriba,
            Abajo,
            Derecha,
            Izquierda

        }
        Posicion posicionInicial = new Posicion(11, 8);
        public Posicion posicionCabeza;
        public Posicion posicionAnteriorCabeza;
        public Direccion direccionActual = Direccion.Derecha;
        public MovimientoSnake()
        {
            posicionCabeza = new Posicion(posicionInicial.X, posicionInicial.Y);
            posicionAnteriorCabeza = new Posicion(posicionCabeza.X, posicionCabeza.Y);
        }
        public void Movimiento()
        {
            if (Console.KeyAvailable)
            {
                MoverSnake();
            }
            else
            {
                MantenerMovimiento();
            }
        }
        void MoverSnake()
        {
            var tecla = Console.ReadKey(true);
            char direccion = char.ToLower(tecla.KeyChar);
            switch (direccion)
            {
                case 'w':
                        direccionActual = Direccion.Arriba;
                        break;
                case 's':
                        direccionActual = Direccion.Abajo;
                        break;
                case 'a':
                        direccionActual = Direccion.Izquierda;
                        break;
                case 'd':
                        direccionActual = Direccion.Derecha;
                        break;
            }
            while (Console.KeyAvailable)
            {
                Console.ReadKey(true);
            }
            AplicarDireccion();
        }
        void MantenerMovimiento()
        {
            AplicarDireccion();
        }
        public void ActualizarPosicionAnterior()
        {
            posicionAnteriorCabeza.X = posicionCabeza.X;
            posicionAnteriorCabeza.Y = posicionCabeza.Y;
        }
        void AplicarDireccion()
        {
            switch (direccionActual)
            {
                case Direccion.Arriba:
                    posicionCabeza.Y--;
                    break;
                case Direccion.Abajo:
                    posicionCabeza.Y++;
                    break;
                case Direccion.Izquierda:
                    posicionCabeza.X--;
                    break;
                case Direccion.Derecha:   
                    posicionCabeza.X++;
                    break;
            }
        }
    }
}
