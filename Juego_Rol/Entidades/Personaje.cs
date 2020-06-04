using System;

namespace Entidades
{
    public enum RAZA { Orco = 1, Humano = 2, Elfo = 3 ,Loli = 4};
    public enum MAXIMOS { MaxSpeed = 10, MaxDex = 5, MaxStr = 10, MaxLvl = 10, MaxArmor = 10 };
    public class Personaje
    {
        //-->CARACTERISTICAS
        int velocidad;
        int destreza;
        int fuerza;
        int nivel;
        int armadura;

        //-->DATOS
        RAZA raza;
        string nombre;
        string apodo;
        int fechanacimiento;
        int edad; //hasta 300
        int salud;

        //Constructores
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }
        public RAZA Raza { get => raza; set => raza = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public int Fechanacimiento { get => fechanacimiento; set => fechanacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Salud { get => salud; set => salud = value; }


        //Metodos
        public void CargaDatos(int _velocidad, int _destreza, int _fuerza, int _nivel, int _armadura)
        {
            
            velocidad = _velocidad;
            destreza = _destreza;
            fuerza = _fuerza;
            nivel = _nivel;
            armadura = _armadura;
        }
        public void CargaCaracteriscas(int _fechanc, int _salud)
        {
            string[] nombres = {"Jhon Salchichon", "Josefo", "Lady Sonsa"};
            string[] apodos = {"Degolador", "El Destructor", "El Elegido"};
            fechanacimiento = _fechanc;
            int salud = _salud;
        }
    }
}
