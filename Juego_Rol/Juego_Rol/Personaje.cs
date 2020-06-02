using System;
using System.Collections.Generic;
using System.Text;

namespace Juego_Rol
{
    class Personaje
    {
		enum TRAZA { Orco = 1, Humano = 2, Loli = 3 };
		string[] nombres = { "Destructor", "Demoledor" };

		
		//datos
		
		int velocidad;
		int destreza;
		int fuerza;
		int nivel;
		int armadura;
		
		//caracteristicas
		
		TRAZA raza;
		string nombre;
		DateTime fechanacimiento;
		int edad;
		int salud;

        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }
        private TRAZA Raza { get => raza; set => raza = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime Fechanacimiento { get => fechanacimiento; set => fechanacimiento = value; }
        public int Edad { get => this.edad; set => this.edad = value; }
        public int Salud { get => salud; set => salud = value; }

        public int edad(DateTime fechanacimiento)
        {

        }
	}
}
