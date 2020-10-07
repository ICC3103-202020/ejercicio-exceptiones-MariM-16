using System;
using System.Collections.Generic;

namespace Exepcion
{
    public class JUEGO
    {
        public void Bienvenida()
        {
            Console.WriteLine("Hola! Bienvenido al mejor programa de carreas del mundo!");
        }

        public double ObtenerLongitudPista()
        {
            Console.WriteLine("Ingrese la longitud de la pista: ");
            double longitud = Convert.ToDouble(Console.ReadLine());
            return longitud;
        }

        public int CantidadAutos()
        {
            Console.WriteLine("Ingrese la cantidad de autos: ");
            int longitud = Convert.ToInt32(Console.ReadLine());
            return longitud;
        }

        public int MostrarMenu(List<string> opciones)
        {

            int cnt = 1;
            Console.WriteLine("Seleccione una opcion: ");
            foreach (string opcion in opciones)
            {
                Console.WriteLine($"{cnt}. {opcion}");
                cnt++;
            }
            int respuesta;
            try
            {
                respuesta = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                respuesta = -1;
            }
            while (respuesta > opciones.Count || respuesta < 1)
            {
                cnt = 1;
                Console.Clear();
                Console.WriteLine("[!] ERROR: Opcion no valida");
                foreach (string opcion in opciones)
                {
                    Console.WriteLine($"{cnt}. {opcion}");
                    cnt++;
                }
                try
                {
                    respuesta = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    respuesta = -1;
                }
            }
            return respuesta;

        }
    }
}
