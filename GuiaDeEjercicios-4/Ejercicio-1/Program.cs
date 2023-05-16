using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double mayor, n;

            Console.WriteLine("Ingrese cinco números");
            mayor = double.Parse(Console.ReadLine());

            for (int i = 0; i < 4; i++)
            {
                n = double.Parse(Console.ReadLine());

                if (n > mayor)
                    mayor = n;                  
            }

            Console.WriteLine("El mayor número ingresado es: " + mayor);
        }
    }
}
