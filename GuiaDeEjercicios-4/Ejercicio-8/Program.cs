using System;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double menor, n;
            int posicion = 1;

            Console.WriteLine("Ingrese cinco números");
            menor = double.Parse(Console.ReadLine());

            for (int i = 2; i <= 5; i++)
            {
                n = double.Parse(Console.ReadLine());

                if (n < menor)
                {
                    menor = n;
                    posicion = i;
                }
            }

            Console.WriteLine("El número menor es " + menor);
            Console.WriteLine("Fue ingresado en la posición " + posicion);
        }
    }
}
