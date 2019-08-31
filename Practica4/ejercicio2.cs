using System;
using System.Collections.Generic;
using System.Text;

namespace Practica4
{
    class ejercicio2
    {
        static void Main(string[] args)
        {
            bool condicion;
            int alumnos, repeticiones;
            double nota, asistencia;
            Console.WriteLine("Programación estructurada");
            
            do
            {
                Console.Clear();
                Console.WriteLine("¿Cuantos alumnos son?");
                condicion = int.TryParse(Console.ReadLine(), out repeticiones);
            } while (condicion == false || repeticiones < 0);
            
            for (alumnos = 1; alumnos <= repeticiones; alumnos++)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese la nota del alumno " + alumnos);
                    condicion = double.TryParse(Console.ReadLine(), out nota);
                } while (condicion == false || nota < 0);
                do
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese el promedio de asistencia del alumno " + alumnos);
                    condicion = double.TryParse(Console.ReadLine(), out asistencia);
                } while (condicion == false || asistencia < 0);                      
                if (nota >= 7.0 && asistencia >= 75) Console.WriteLine("El alumno " + alumnos + " ha aprobado");
                else  Console.WriteLine("El alumno " + alumnos + " ha repobrado"); 
            }            
            Console.ReadKey();

        }
    }
}
