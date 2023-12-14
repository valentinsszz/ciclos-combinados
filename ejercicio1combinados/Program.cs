using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer un programa para ingresar 10 números. 
            //El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.

            int num, con, conPrimos = 0;
                
                for (int x = 0; x < 10; x++)
                {
                    Console.WriteLine("Ingrese un nro: ");
                    num = int.Parse(Console.ReadLine());
                    
                    con = 0;

                    for (int y = 1; y <= num; y++)
                    {
                        if (num % y == 0){
                        con++;
                        }
                    }
                    if (con == 2)
                    conPrimos++;
                } 
                    Console.WriteLine("la cantidad de primos es " + conPrimos);
                
              
                    

        }
    }
}
