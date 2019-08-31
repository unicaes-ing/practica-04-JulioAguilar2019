using System;
using System.Collections.Generic;
using System.Text;

namespace Practica4
{
    class ejercicio6
    {
        static void Main(string[] args)
        {
            double promedio, promedioglobal=0, total=0,totalglobal=0, ventas, sumaVentas=0;
            int sucursales, cantVentas=0, terminar;
            Console.WriteLine("Promedio de ventas por sucursal");
            bool condicion;
            do
            {
                Console.Clear();
                Console.WriteLine("¿Cuantas sucursales son?");
                condicion = int.TryParse(Console.ReadLine(), out sucursales);
            } while (condicion == false || sucursales < 1);
            for (int repeticionesSucursales = 1; repeticionesSucursales <= sucursales; repeticionesSucursales++)
            {
                sumaVentas = 0;
                cantVentas = 0;
                promedio = 0;
                do
                {
                    do
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese el total de ventas para la sucursal " + repeticionesSucursales);
                        condicion = double.TryParse(Console.ReadLine(), out ventas);
                        if (ventas < 0)
                    {
                        Console.WriteLine("Ingrese un valor valido");
                    }                    
                } while (condicion == false || ventas <= -1);
                sumaVentas = sumaVentas + ventas;
                    if (ventas > 0)
                    {
                        cantVentas++;
                    }                
                Console.Clear();
                Console.WriteLine("¿Desea seguir ingresando ventas? ");
                Console.WriteLine("1 ---- SI");
                Console.WriteLine("0 ---- NO ");                    
                condicion = int.TryParse(Console.ReadLine(), out terminar);
            } while (condicion == false || terminar != 0);
                promedio = sumaVentas / cantVentas;
                Console.WriteLine("El promedio de ventas para la sucursal " + repeticionesSucursales +" es: " + promedio.ToString("c2"));
                total = sumaVentas;
                Console.WriteLine("El total de ventas es: " + total.ToString("c2"));
                promedioglobal = promedioglobal + promedio;
                totalglobal = totalglobal + total;
            }
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("El promedio global de ventas es: " + promedioglobal.ToString("c2"));
            Console.WriteLine("El total global de ventas es: " + totalglobal.ToString("c2"));
          
            Console.ReadKey();
        }
    }
}
