using System;
namespace LinQ_complejo
{
    public class Contacto
    {
        public string Nombre{get;set;}
        public int Edad{get;set;}

        public Contacto(string nombre,int edad)
        {
            this.Nombre=nombre;
            this.Edad=edad;
        }

       
    }
}