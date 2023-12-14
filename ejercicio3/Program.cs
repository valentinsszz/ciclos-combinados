using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 edades 
            //y luego calcule el promedio de edad 
            //de aquellas personas mayores a 18 años.

            int edades, promedio, acu = 0, con = 0;
            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese una edad: ");
                edades = int.Parse(Console.ReadLine());
                if(edades >= 18){
                    acu += edades;
                    con++;
                }
                
            } 
            promedio = acu / con;
            Console.WriteLine("El promedio es " + promedio);
        }
    }
}
