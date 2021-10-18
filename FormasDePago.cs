namespace LinQ_complejo
{
    public class FormasDePago
    {
        public string Nombre{get;set;}
        public float Interes{get;set;}

        public FormasDePago(string nombre,int interes)
        {
            this.Nombre=nombre;
            this.Interes=interes;
        }
    }
}