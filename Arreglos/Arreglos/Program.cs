using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] calificaciones = new double[5];

            calificaciones[0] = 10;
            calificaciones[1] = 7.5;
            calificaciones[2] = 8.2;
            calificaciones[3] = 6.8;
            calificaciones[4] = 5.5;

            // otra manera de crear arrays
            int[] edades = { 17, 15, 16, 15, 17 };

            // otra manera de crear arrays
            int[] faltasAlColegio = new int[] { 3, 5, 7, 0, 4 };

            for (int y = 0; y < calificaciones.Length; y++)
            {
                Console.WriteLine("Ingrese la calificacion: ");
                string ingreso = Console.ReadLine();
                calificaciones[y] = Double.Parse(ingreso);
            }

            foreach (double i in calificaciones)
            {
                Console.WriteLine(i);
            }

            Console.Read();

        }
    }
}
