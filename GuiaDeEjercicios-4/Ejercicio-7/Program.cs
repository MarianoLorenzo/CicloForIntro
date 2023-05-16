using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double mayor, n;
            int posicion = 1;

            Console.WriteLine("Ingrese cinco números");
            mayor = double.Parse(Console.ReadLine());

            for (int i = 2; i <= 5; i++)
            {
                n = double.Parse(Console.ReadLine());

                if (n > mayor)
                {
                    mayor = n;  
                    posicion = i;     
                }                  
            }

            Console.WriteLine("El número mayor es: " + mayor);
            Console.WriteLine("Fue ingresado en la posición: " + posicion);
        }
    }
}
