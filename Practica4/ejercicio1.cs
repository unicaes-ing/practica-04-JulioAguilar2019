using System;
//Julio Israel Aguilar Melgar
namespace Practica4
{
    class ejercicio1
        {
        static void Main(string[] args)
        {
            bool condicion;            
            int numEmpleados;
            double promedio = 0, sueldo = 0, total = 0;
            Console.WriteLine("Promedio de sueldos");
            for (numEmpleados = 1; numEmpleados <= 5; numEmpleados++)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese el sueldo del empleado #" + numEmpleados);
                    condicion = double.TryParse(Console.ReadLine(), out sueldo);
                    total = total + sueldo;                    
                } while (condicion == false || sueldo < 0);                
            }
            promedio = total / (numEmpleados-1);
            Console.WriteLine("El total es: " + total );
            Console.WriteLine("El promedio es: " + promedio );
            Console.ReadKey();
        }
    }
}
