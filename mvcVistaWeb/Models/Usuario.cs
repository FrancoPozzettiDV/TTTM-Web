using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcVistaWeb.Models
{
    public class Usuario
    {

        public int id { get; set; }
        public string nombre { get; set; }
        public string contraseña { get; set; }
        public int puntaje { get; set; }
        public int partidasGanadas { get; set; }
        public int partidasJugadas { get; set; }

        //Constructor normal
        public Usuario(int id, string nombre, string contraseña, int puntaje, int partidasGanadas, int partidasJugadas)
        {
            this.id = id;
            this.nombre = nombre;
            this.contraseña = contraseña;
            this.puntaje = puntaje;
            this.partidasGanadas = partidasGanadas;
            this.partidasJugadas = partidasJugadas;
        }
        //Constructor Base de Datos (sin id)
        public Usuario(string nombre, string contraseña, int puntaje, int partidasGanadas, int partidasJugadas)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
            this.puntaje = puntaje;
            this.partidasGanadas = partidasGanadas;
            this.partidasJugadas = partidasJugadas;
        }
        //Constructor Juego (sin contraseña)
        public Usuario(int id, string nombre, int puntaje, int partidasGanadas, int partidasJugadas)
        {
            this.id = id;
            this.nombre = nombre;
            this.puntaje = puntaje;
            this.partidasGanadas = partidasGanadas;
            this.partidasJugadas = partidasJugadas;
        }
        //Constructor Deserializador
        public Usuario()
        {
        }


    }
}
