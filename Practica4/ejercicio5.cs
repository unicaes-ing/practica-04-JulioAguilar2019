using System;
using System.Collections.Generic;
using System.Text;

namespace Practica4
{
    class ejercicio5
    {
        static void Main(string[] args)
        {
            const string pass = "1234";
            string password;
            int intentos=1, mostrar=0;
            Console.WriteLine("Prueba de contraseña");
            do
            {                  
                    Console.WriteLine("Ingrese la contraseña, intento " + intentos + " de 3" );
                    password = Console.ReadLine();
                Console.WriteLine("---------------------------------------------------------");
                if (password != pass)
                {
                    Console.WriteLine("Contraseña incorrecta, intente de nuevo. \n");
                    intentos++;
                    mostrar++;
                    Console.WriteLine("Pista sobre la contraseña: \n" + pass.Substring(0,mostrar));
                }
                else Console.WriteLine("Contraseña correcta");                 
            } while (password != pass && intentos <= 3);
            Console.ReadKey();
        }
    }
}
