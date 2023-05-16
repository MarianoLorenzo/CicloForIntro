using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, contadorDivisible = 0;

            Console.WriteLine("Ingrese un número");
            n = int.Parse(Console.ReadLine());

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    contadorDivisible ++;
            }

            if (contadorDivisible > 0)
                Console.WriteLine("El número " + n + " no es primo");
            else 
                Console.WriteLine("El número " + n + " es primo");   
        }
    }
}
