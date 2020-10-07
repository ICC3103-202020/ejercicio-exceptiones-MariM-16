using System;
using System.Collections.Generic;
using System.Text;

namespace Exepcion
{
    class Program
    {
        static void Main(string[] args)
        {
            JUEGO juego = new JUEGO();
            juego.Bienvenida();
            List<string> opciones = new List<string>() { "Carrera de autos", "Carrera de autos 2p" }; 
            double longitudpista = juego.ObtenerLongitudPista();
            int cantidadAutos = juego.CantidadAutos();
            CARRERA carrera = new CARRERA(longitudpista);
            carrera.GenerarAutos(cantidadAutos);
           
           }
           /* carrera.MostrarAutos(); 
            CARRERA.IniciarCarrera();
           NO FUNCIONO LA IDEA, NO ME AGARRA LA CLASE AUTO Y SU METOD*/ 
        }
    }

