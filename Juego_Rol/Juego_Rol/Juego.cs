using Entidades;
using System;

namespace Juego_Rol
{
    class Juego
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Jhon Salchichon", "Josefo", "Lady Sonsa" };
            string[] apodos = { "Degolador", "El Destructor", "El Elegido" };

            Personaje Mipersonaje = new Personaje(); //Instanciacion del objeto pj
            Random aleatorio = new Random();

            Mipersonaje.Nombre = aleatorio.Next();
            Mipersonaje.Armadura = 10;
        }
    }
}
