using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canódromo
{
    class Jugador
    {
        private string nombre;                          // El nombre del jugador
        private Apuesta miApuesta;                      // La apuesta del jugador
        private int cartera;                            // Dinero disponible para apostar
        private RadioButton miRadioButton;              // Mi RadioButton en la forma
        private Label miLabel;                          // Label en la forma que muestra el nombre del jugador

        public Jugador(string nombre, Apuesta miApuesta, int cartera, RadioButton miRadioButton, Label miLabel) // El constructor

        {
            this.nombre = nombre;
            this.miApuesta = miApuesta;
            this.cartera = cartera;
            this.miRadioButton = miRadioButton;
            this.miLabel = miLabel;

        }
        public void ActualizaLabels()
        {
            miLabel = miApuesta;
            miRadioButton = cartera;


        // Actualiza miLabel a la descripción de mi apuesta

        // Y la etiqueta de miRadioButton para mostrar mi cartera

        // por ejemplo, Pepe tiene 100 euros.

        }

        public bool Apostar(int cantidad, int perro) {

        // Coloca una nueva apuesta y almacénala en el atributo apuesta

        // Devuelve true si el jugador tiene suficiente dinero para apostar

        }

        public void EliminaApuesta() {

        // Borra mi miApuesta

        }

        public void Recoger(int ganador) {

        // Hacer que miApuesta recoja beneficios o pérdidas

        }
            }
        }
