using System;
using System.Collections.Generic;
using CentralTelefonica.Entidades;
namespace CentralTelefonica
{
    class Program
    {
        static void Main(string[] args)
        {     //creo un objeto de tipo LlamadaDepartamental
            LlamadaDepartamental llamadaDepto = new LlamadaDepartamental();
            llamadaDepto.NumeroDestino = "123";
            llamadaDepto.NumeroOrigen = "456";
            llamadaDepto.Franja = 0;
            llamadaDepto.Duracion = 10;
            llamadaDepto.PrecioUno = 1.5;
             //creo un objeto de tipo LlamadaLocal
            LlamadaLocal llamadaLocal = new LlamadaLocal();
            llamadaLocal.NumeroDestino = "789";
            llamadaLocal.NumeroOrigen = "135";
            llamadaLocal.Duracion = 5;
            llamadaLocal.Precio = 0.96;
            //creo otro objeto de tipo LlamadaLocal
            LlamadaLocal otraLocal = new LlamadaLocal();
            otraLocal.NumeroDestino = "111";
            otraLocal.NumeroOrigen = "222";
            otraLocal.Duracion = 25;
            otraLocal.Precio = 0.96;

            List<Llamada> llamadasRealizadas = new List<Llamada>();
            llamadasRealizadas.Add(llamadaDepto);
            llamadasRealizadas.Add(llamadaLocal);
            llamadasRealizadas.Add(otraLocal);

            foreach(Llamada item in llamadasRealizadas)
            {
                if (item is LlamadaLocal)
                {
                    Console.WriteLine($"Llamada Local ({item}) Precio: {item.CalcularPrecio()}");
                }
                else if (item is LlamadaDepartamental)
                {
                    Console.WriteLine($"Llamada Depto ({item}) Precio: {item.CalcularPrecio()}");
                }
                
                
                
            }
                Console.ReadKey();
            
        }
    }
}
