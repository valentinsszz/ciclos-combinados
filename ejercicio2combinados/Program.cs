using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. 
            //Se pide determinar e informar:

                // El número de grupo con mayor porcentaje de números impares respecto 
                //al total de números que forman el grupo.
                //Informar cuántos grupos están formados 
                //por todos números ordenados de mayor a menor.
                
            int n, conNumeros, conImpares, grupoImparesMaximo = 0, min, conOrdenados = 0;
            double porcentajeImpares, porcentajeMaximo=-1;
            bool banderaOrdenados;

            for (int x = 0; x < 5; x++)
            {
                conNumeros = 0;
                conImpares = 0;
                banderaOrdenados = true;
            n = int.Parse(Console.ReadLine());
                min = n;
                while (n != 0)
                {
                    conNumeros++;
                    if (n % 2 != 0)
                    
                        conImpares++;
                    
                    // punto B
                    if (n <= min)
                    {
                        min = n;
                    } else
                    {
                        banderaOrdenados = false;
                    }
                    
                    n = int.Parse(Console.ReadLine());
                }//Fin del While

                porcentajeImpares = conImpares * 100 / conNumeros;
                if (porcentajeImpares > porcentajeMaximo){
                    porcentajeMaximo = porcentajeImpares;
                    grupoImparesMaximo = x + 1;
                }

                // punto B
                if (banderaOrdenados)
                conOrdenados++;
                
                

            }//Fin del For
            Console.WriteLine("El Grupo con mayor porcentaje de impares es el numero " + grupoImparesMaximo);
            Console.WriteLine("La cantidad de grupos con nros ordenados es " + conOrdenados);

                
                    




        }
    }
}
