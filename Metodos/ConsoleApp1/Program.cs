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
            EscribeAlgo();
            EscriveAlgoEspecifico("soy un argumento");

            Console.WriteLine(Sumar(5, 3));
            Console.ReadLine();


        }

        public static void EscribeAlgo()
        {
            Console.WriteLine("Yo naci en un metodo");
            
        }

        public static void EscriveAlgoEspecifico(string miTexto)
        {
            Console.WriteLine(miTexto);
        }

        public static int Sumar(int parametro1, int parametro2)
        {
            return parametro1 + parametro2;
        }
    }
}
