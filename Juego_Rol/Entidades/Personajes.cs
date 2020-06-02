using System;

namespace Entidades
{
    public class Personajes
    {
        public enum TRAZA { Orco = 1, Humano = 2, Loli = 3 };
        public enum MAXIMOS { MaxSpeed = 10, MaxDex = 5, MaxStr = 10, MaxLvl = 10, MaxArbol = 10 };
        public class Personaje
        {

            public string[] nombres = { "Mario", "Tyrael", "Josefo" };
            //caracteristicas
            int velocidad;
            int destreza;
            int fuerza;
            int nivel;
            int armadura;

            //datos
            TRAZA raza;
            string nombre;
            DateTime fechanacimiento;
            TimeSpan edad;
            int salud;

            public int Velocidad { get => velocidad; set => velocidad = value; }
            public int Destreza { get => destreza; set => destreza = value; }
            public int Fuerza { get => fuerza; set => fuerza = value; }
            public int Nivel { get => nivel; set => nivel = value; }
            public int Armadura { get => armadura; set => armadura = value; }
            public TRAZA Raza { get => raza; set => raza = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public DateTime Fechanacimiento { get => fechanacimiento; set => fechanacimiento = value; }
            public TimeSpan Edad { get => edad; set => edad = value; }
            public int Salud { get => salud; set => salud = value; }

            public TimeSpan EDAD(DateTime fechanacimiento)
            {
                return DateTime.Now - fechanacimiento;
            }
        }
    }

}
}
