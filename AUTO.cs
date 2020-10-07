using System;
using System.Collections.Generic;
using System.Text;
namespace Exepcion
{
    public class AUTO
    {
        private int velocidad;
        private string color;
        private bool encendido;
        public List<string> colores = new List<string>() { "Rojo", "Azul", "Rosado" };

        public int Velocidad
        {
            get => velocidad; set
            {
                if (value > 0 && value <= 150)
                {
                    velocidad = value;
                }
            }
         }

        public string Color { get => color; set => color = value; }
        public bool Encendido { get => encendido; set => encendido = value; }

        public AUTO(string color, int velocidad, bool encendido)
        {
            Color = color;
            Encendido = encendido;
            Velocidad = velocidad; 
        }
        public AUTO() { }
    }
}
