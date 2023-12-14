using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
           // Hacer un programa que solicite 20 números y luego emitir por pantalla 
           //el máximo de los números pares y el mínimo de los números impares.

            int n, mp = 0, mi = 0;
            int conPares = 0, conImpares = 0;

           for (int x = 0; x < 20; x++)
           {
            Console.WriteLine("Ingrese un nro");
            n = int.Parse(Console.ReadLine());

                if (n % 2 == 0 )
                { conPares++;
                    if (conPares == 1)
                         mp = n;
                    else if (n > mp)
                        mp = n;
                }else
                { //impares
                    conImpares++;
                    if (conImpares == 1)
                        mi = n;
                    else if (n < mi)
                            mi = n;
                    } 
           }
                    Console.WriteLine("El maximo par es " + mp);
                Console.WriteLine("El minimo impar es " + mi);
        }
    }
}
