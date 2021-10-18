using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ_complejo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contacto> lista1= new List<Contacto>();
            Contacto contacto1= new Contacto("Negan",40);
            Contacto contacto2= new Contacto("Rick",42);
            Contacto contacto3= new Contacto("Rosita",30);
            Contacto contacto4= new Contacto("Maggie",34);
            lista1.Add(contacto1);
            lista1.Add(contacto2);
            lista1.Add(contacto3);
            lista1.Add(contacto4);
            
            IEnumerable<Contacto> listaFiltrada = 
            lista1.Where(con=>con == contacto4);

            Console.WriteLine("LinQ Contactos con mas de 30 años");
            foreach(Contacto conItem in listaFiltrada)
            {
                Console.WriteLine(conItem.Nombre + " que tiene " + conItem.Edad.ToString());
            }

            List<FormasDePago> lista2 = new List<FormasDePago>();
            FormasDePago pago1 = new FormasDePago("Leo",10);
            FormasDePago pago2 = new FormasDePago("Nahuel",20);
            FormasDePago pago3 = new FormasDePago("Franco",30);
            FormasDePago pago4 = new FormasDePago("Luis",30);
            lista2.Add(pago1);
            lista2.Add(pago2);
            lista2.Add(pago3);
            lista2.Add(pago4);
            
            IEnumerable<FormasDePago> listaPagoFiltrada = 
            lista2.Where(form=>form == pago1);

            Console.WriteLine("LinQ Formas de Pago con el 30% de interes");
            foreach(FormasDePago conItem in listaPagoFiltrada)
            {
                Console.WriteLine(conItem.Nombre + " es el que tiene " + conItem.Interes.ToString() + "% de interes");
            }
            
        }
    }
}
