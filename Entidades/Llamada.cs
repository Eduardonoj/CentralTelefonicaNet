namespace CentralTelefonica.Entidades
{
    public abstract class Llamada
    {
        private string numeroOrigen;
        private string numeroDestino;
        private double duracion;
        public string NumeroOrigen
        { 
            get{return numeroOrigen;}
            set{numeroOrigen = value;}
        }

        public string NumeroDestino
        {   
            get{return numeroDestino;}
            set{numeroDestino = value;}
        }


        public double Duracion
        {
            get{return duracion;}
            set{duracion = value;}
        }

        public abstract double CalcularPrecio();

        public override string ToString()
        {
            return $" #Origen: {this.numeroOrigen} - #Destino: {this.numeroDestino} - Duracion: {this.duracion}";
        }

    }
}