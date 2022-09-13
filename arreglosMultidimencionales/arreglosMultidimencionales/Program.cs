using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglosMultidimencionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array 2d
            string[,] matriz2d;

            //Array 3d
            string[,,] matriz3d;

            string[,] array2d = new string[,]
            {
                {"A","B","C" },
                {"D","E","F"},
                {"G","H","I"}
            };

            Console.WriteLine("El valor central es {0}", array2d[2,0]);
            Console.WriteLine("La dimension del arreglo es {0}", array2d.Rank);
            Console.Read();
        }
    }
}
