using System;
using System.Collections.Generic;
using System.Text;

namespace Practica4
{
    class ejercicio4
    {
        static void Main(string[] args)
        {
            int terminar=0;
            double ventas=0, bonificacion, contadorVentas=0;
            bool condicion;
            Console.WriteLine("Detalle de ventas");      
           
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese el monto de la venta:");
                condicion = double.TryParse(Console.ReadLine(), out ventas);
                if (ventas < 0)
                    {
                        Console.WriteLine("Ingrese un valor valido");                        
                    }
                } while (condicion == false || ventas < 0);
                contadorVentas = contadorVentas + ventas;
            do
            {
                Console.Clear();
                Console.WriteLine("¿Desea seguir ingresando ventas? ");
                Console.WriteLine("1 ---- SI");
                Console.WriteLine("0 ---- NO ");
                condicion = int.TryParse(Console.ReadLine(), out terminar);
            } while (condicion == false || terminar != 0);      
            bonificacion = contadorVentas * 0.05;
            Console.WriteLine(string.Format("El subtotal de ventas es: {0:c2}", contadorVentas));
            Console.WriteLine(string.Format("La bonificacion es: {0:c2}", bonificacion));
            contadorVentas = contadorVentas + bonificacion;
            Console.WriteLine(string.Format("El total es: {0:c2}", contadorVentas));
            Console.ReadKey();
        }
    }
}
