using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;
            int contadorPositivo = 0;

            Console.WriteLine("Ingrese cinco números");

            for (int i = 0; i < 5; i++)
            {
                n = double.Parse(Console.ReadLine());

                if (n > 0)
                    contadorPositivo ++;
            }

            if (contadorPositivo == 0)
                Console.WriteLine("No hay números positivos");
            else if (contadorPositivo == 1)
                Console.WriteLine("Hay " + contadorPositivo + " número positivo");
            else 
                Console.WriteLine("Hay " + contadorPositivo + " números positivos");

        }
    }
}
