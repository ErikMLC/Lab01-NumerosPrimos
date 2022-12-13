using System;
using System.Diagnostics;
namespace Programa
{

    class NumeroPrimo
    {
        static void Main(string[] args)
        {
            Stopwatch time= new Stopwatch();
            Console.WriteLine("Impresión de los primeros números primos que anteceden a un número ingresado. ");
            int n=0;
            Console.WriteLine("Ingrese un numero");
            n=Convert.ToInt32(Console.ReadLine());
            time.Start();

            for(int i=2; i < n; i++)
            {
                int creciente=2;
                int esPrimo=1;

                while(esPrimo==1 && creciente <i)
                {
                    if(i % creciente ==0)
                    {
                        esPrimo=0;

                    }
                    else
                    {
                        creciente++;
                    }

                }

                if(esPrimo==1)
                {
                    Console.WriteLine("El numero " + i + " es un numero primo"
                    );

                }


            }
            Console.ReadKey();
            Console.WriteLine("El tiempo necesario fue: " + time.Elapsed.ToString());
            time.Stop();
        
        }
    }
}