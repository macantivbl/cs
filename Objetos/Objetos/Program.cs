using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instancia de Humano
            Humano juan = new Humano("Juan", "Rodrigez", "verde", 23);
            Humano pedro = new Humano("Pedro", "Zalomon", "negro", 78);
            Humano humano = new Humano();

            juan.presentarme();
            pedro.presentarme();


            //Propiedades
            Caja caja = new Caja(5,-4,4);

            caja.Muestrainfo();


            Console.ReadLine();


          
           
        }
    }
}
