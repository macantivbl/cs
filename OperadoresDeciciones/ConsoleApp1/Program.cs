using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroComoString = "128vvdd";
            int valorParseado;

            bool exito = int.TryParse(numeroComoString, out valorParseado);

            if (exito) { Console.WriteLine("Parsing exitoso - el numero es: {0}", valorParseado); }
            else { Console.WriteLine("Parsing fallido"); }

            Console.ReadLine(); 
        }
    }
}
