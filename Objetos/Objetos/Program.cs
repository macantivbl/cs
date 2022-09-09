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


            juan.presentarme();
            pedro.presentarme();

            Console.ReadLine();


          
           
        }
    }
}
