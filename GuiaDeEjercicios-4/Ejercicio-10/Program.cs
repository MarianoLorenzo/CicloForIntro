using System;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, mayor = 0, menor = 0;
            bool banPar = false, banImpar = false;

            Console.WriteLine("Ingrese 10 números");

            for (int i = 0; i < 10; i++)
            {
                n = double.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {                   
                    if (banPar == false)
                    {
                        mayor = n;
                        banPar = true;
                    }                        
                    else if (n > mayor)
                        mayor = n;
                }                  
                else
                {                   
                    if (banImpar == false)
                    {
                        menor = n;
                        banImpar = true;
                    }                                              
                    else if (n < menor) 
                        menor = n;  
                }                                                                                             
            }

            Console.WriteLine("El mayor de los números pares es: " + mayor);
            Console.WriteLine("El menor de los números impares es: " + menor);         
        }
    }
}
