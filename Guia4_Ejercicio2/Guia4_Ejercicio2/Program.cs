using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escriba la primer cadena: ");
        string cadena1 = Console.ReadLine();

        Console.WriteLine("Escriba la segunda cadena: ");
        string cadena2 = Console.ReadLine();

        int comparacion = cadena1.CompareTo(cadena2);

        if (comparacion == 0)
        {
            Console.WriteLine("Las cadenas son iguales según CompareTo().");
        }
        else
        {
            Console.WriteLine("Las cadenas no son iguales según CompareTo().");
        }

        bool iguales = cadena1.Equals(cadena2);

        if (iguales)
        {
            Console.WriteLine("Las cadenas son iguales según Equals().");
        }
        else
        {
            Console.WriteLine("Las cadenas no son iguales según Equals().");
        }
    }
}