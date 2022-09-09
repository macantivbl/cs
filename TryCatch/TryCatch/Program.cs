using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero ");
            string valorIngresado = Console.ReadLine();

            try
            {
                int valorComoInt = int.Parse(valorIngresado);
            }
            catch(FormatException)
            {
                Console.WriteLine("Valor ingresado es incorrecto");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Valor ingresado es demaciado largo");
            }
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
}
