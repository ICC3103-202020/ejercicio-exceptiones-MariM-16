using System;
using System.Collections.Generic;
using System.Text;
namespace Exepcion
{
    public class CARRERA
    {
        private List<AUTO> autos;
        private double distancia;
        private List<double> lugar;


        public CARRERA(double distancia)
        {
            this.autos = new List<AUTO>();
            this.distancia = distancia;

        }

        public void IniciarCarrera()
        {
            bool ganador = false;
            Console.WriteLine("Iniciar Carrera");
            foreach (AUTO autos in this.autos)
            {
                autos.Encendido = true;
            }
            int tiempo = 0;
            AUTO ganadors = new AUTO();
            while (ganador == false)
            {
                int contador = 0;
                foreach (AUTO auto in this.autos)
                {
                    this.lugar[contador] = auto.Velocidad * tiempo;
                    contador++;
                }
                MostrarAutos();
                contador = 0;
                foreach (AUTO auto in this.autos)
                {
                    if (this.lugar[contador] >= this.distancia) { ganador = true; ganadors = auto; }
                    contador++;
                }
                tiempo++;
            }
        }

        public void GenerarAutos(int cantidad)
        {
            AUTO auto = new AUTO();
            Random random = new Random();
            int contador = 0;
            while (contador < cantidad)
            {
                string color = auto.colores[random.Next(auto.colores.Count)];
                int velocidad = random.Next(151);
                AUTO autoo = new AUTO(color, velocidad, false);
                this.autos.Add(auto);
            }

            contador++;

            foreach (AUTO autos in this.autos)
            {
                this.lugar.Add(0);
            }
        }
        public void MostrarAutos()
        {
            int contador = 0;
            foreach (AUTO auto in this.autos)
            {
                Console.WriteLine($" Color: {auto.Color}. Velocidad: {auto.Velocidad}. Lugar: {this.lugar[contador]}");
                contador++;
            }


        }
    }
}
