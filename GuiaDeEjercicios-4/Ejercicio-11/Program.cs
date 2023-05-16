using System;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, contadorDivisor = 0, contadorPrimo = 0, mayor = 0;  

            Console.WriteLine("Ingrese diez números");

            for (int i = 0; i < 10; i++)
            {
                n = int.Parse(Console.ReadLine());

                for (int x = 2; x < n; x++)
                {
                    if (n % x == 0)
                        contadorDivisor ++;                   
                }

                if (contadorDivisor == 0)
                {
                    contadorPrimo ++;

                    if (contadorPrimo == 1)
                        mayor = n;
                    else if (n > mayor)
                        mayor = n;
                }

                contadorDivisor = 0;                    
            }

            if (contadorPrimo == 0)
                Console.WriteLine("No se ha ingresado ningún número primo");
            else 
                Console.WriteLine("El mayor número primo ingresado es: " + mayor);    
        }
    }
}
