using System;

class Program
{
    static void Main()
    {
        string frase = "MI MAMA ME MIMA, AMO A MI MAMA";

        Console.WriteLine("Frase original: ");
        Console.WriteLine(frase);

        string fraseMinusculas = frase.ToLower();

        Console.WriteLine("\nFrase en minúsculas: ");
        Console.WriteLine(fraseMinusculas);

        string[] palabras = fraseMinusculas.Split(' ');

        Console.WriteLine("\nPalabras separadas: ");

        foreach (string palabra in palabras)
        {
            if (palabra.Length < 3)
            {
                Console.Write(palabra + "% ");
            }
            else
            {
                Console.Write(palabra + " ");
            }
        }
    }
}
