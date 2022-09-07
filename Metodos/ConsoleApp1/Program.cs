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
            

            string input = Console.ReadLine();
            Console.WriteLine(input);


            Console.WriteLine("dame el primer numero ");
            string numero1 = Console.ReadLine();
            Console.WriteLine("dame el segundo numero ");
            string numero2 = Console.ReadLine();

            Console.WriteLine(Calcular(Convert.ToDouble(numero1), Convert.ToDouble(numero2)));

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

        public static double Calcular(double numero1, double numero2)
        {
            return numero1 + numero2;
        }

    }
}
