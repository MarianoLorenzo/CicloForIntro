using System;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double edad, contadorEdad = 0, acumuladorEdad = 0;
            double promedioEdad;

            Console.WriteLine("Ingrese diez edades");

            for (int i = 0; i < 10; i++)
            {
                edad = int.Parse(Console.ReadLine());

                if (edad >= 18)
                {
                    contadorEdad ++;
                    acumuladorEdad += edad;
                }                
            }

            promedioEdad = acumuladorEdad / contadorEdad;

            Console.WriteLine("El promedio de edad de las personas mayores de 18 años es: " + promedioEdad.ToString("0.00") + " años");
        }
    }
}
