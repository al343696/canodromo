using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canódromo
{
    class Galgo
    {
        private PictureBox miPictureBox = null;             // El objeto para representar al galgo
        private int posicion = 0;                           // Posición de miPictureBox en la calle
        private int posicionInicial;                        // Posicion inicial del miPictureBox
        private int longitudCalle;                          // Longitud de la calle
        private Random aleatorio;                           // Una instancia de random

        public Galgo(int posicion, int posicionInicial, int longitudCalle, Random aleatorio)        // El constructor
        {
            this.posicion = posicion;
            this.posicionInicial = posicionInicial;
            this.longitudCalle = longitudCalle;
            this.aleatorio = aleatorio;

        }

        public bool Run()                                                               
        {
            bool ganado = false;
            
            int distancia =                         // Desplazarse 1, 2, 3 o 4 espacios al azar
            posicion += distancia;                  // Actualizar la posición de miPictureBox en la forma
            
            Point p = miPictureBox.Location;        // Recoge la posición actual en la forma
            p.X += distancia;                       // Añade los espacios a avanzar
            miPictureBox.Location = p;              // Actualiza la posición en la forma
                
            if (posicion == longitudCalle)          
            {
                ganado = true;                      // Devuelve true si he ganado la carrera
            }
            return ganado;
        }

        public void ASusPuestos() 
        {
            posicion = posicionInicial;

        }

// Inicializar mi posición a la línea de salida
    }
}
