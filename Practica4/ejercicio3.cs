using System;
using System.Collections.Generic;
using System.Text;

namespace Practica4
{
    class ejercicio3
    {
        static void Main(string[] args)
        {
            string nombre, nombre2;
            int contador=0;
            Console.WriteLine("Contador de vocales");
            Console.WriteLine("Ingrese su nombre:" );
            nombre = Console.ReadLine();
            nombre2 = nombre.ToLower();
            for (int i = 0; i < nombre2.Length; i++)
            {
                if (nombre2[i] == 'a' || nombre2[i] == 'á' || nombre2[i] == 'e' || nombre2[i] == 'é' || nombre2[i] == 'i' || nombre2[i] == 'í' || nombre2[i] == 'o' || nombre2[i] == 'ó' || nombre2[i] == 'u' || nombre2[i] == 'ú')
                {
                    contador++;
                    
                }
            }
            Console.WriteLine("El total de vocales es: " + contador);
            Console.ReadKey();
        }
    }
}
