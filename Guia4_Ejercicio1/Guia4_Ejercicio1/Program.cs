using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escriba una cadena de caracteres:");
        string cadena = Console.ReadLine();

        if (cadena.Length < 25)
        {
            Console.WriteLine("La cadena es menor que 25 caracteres.");

            Console.WriteLine("¿Cómo desea rellenarla?");
            Console.WriteLine("1. Rellenar por la derecha");
            Console.WriteLine("2. Rellenar por la izquierda");

            char relleno = '$';
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                while (cadena.Length < 25)
                {
                    cadena += relleno;
                }
            }
            else if (opcion == 2)
            {
                while (cadena.Length < 25)
                {
                    cadena = relleno + cadena;
                }
            }
            else
            {
                Console.WriteLine("Opción inválida.");
                return;
            }

            Console.WriteLine("La cadena rellenada es:");
            Console.WriteLine(cadena);
        }
        else
        {
            Console.WriteLine("La cadena tiene 25 caracteres o más, no se requiere relleno.");
        }
    }
}