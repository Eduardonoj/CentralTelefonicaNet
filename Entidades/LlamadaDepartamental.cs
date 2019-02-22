namespace CentralTelefonica.Entidades
{
    public class LlamadaDepartamental : Llamada
    {
        private double precioUno;
        private double precioDos;
        private double precioTres;

        private int franja;
        public double PrecioUno
        {
            get{return precioUno;}
            set{precioUno = value;}
        }

        public double PrecioDos
        {
            get{return precioDos;}
            set{precioDos = value;}
        }

        public double PrecioTres
        {
            get{return precioTres;}
            set{precioTres = value;}
        }

        public int Franja
        {
            get{return franja;}
            set{franja = value;}
        }

        public override double CalcularPrecio()
        {
            double resultado = 0;
            if(this.Franja == 0){
                resultado = this.PrecioUno * this.Duracion;
            }
            else if(this.Franja == 1){
                resultado = this.PrecioDos * this.Duracion;
            }
            else if(this.Franja == 2){
                resultado = this.PrecioTres * this.Duracion;
            }
            return resultado;
        }

    }
}