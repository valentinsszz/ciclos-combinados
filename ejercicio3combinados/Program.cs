using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para recibir listas de números positivos que están 
            //separadas entre sí por un cero. 
            //El fin de la carga se notifica con un número negativo. 
            //Luego mostrar cuántos números tiene cada lista.

           int n = 0, con, numGrupo = 0;
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                con = 0;
                numGrupo++;
                    while (n != 0){
                    con++;
                    n = int.Parse(Console.ReadLine());
                    } // fin del while
                    Console.WriteLine("la cantidad del grupo" + numGrupo +  "es " + con);
                
                n = int.Parse(Console.ReadLine());
            } // fin del while mayor



        }
    }
}
