using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    internal class Humano
    {
        // Miembro variable
        private string primerNombre="";
        private string apellido = "";
        private string colorOjo = "";
        private int edad = 0;

        //Constructor NoParametrizado
        public Humano()
        {
            Console.WriteLine("Humano");
        }
        
        // Constructores Parametrizado
        public Humano(string primerNombre, string apellido, string colorOjo, int edad)
        {
            this.primerNombre = primerNombre;
            this.apellido = apellido;
            this.colorOjo = colorOjo;
            this.edad = edad;
        }

        //Metodo

        public void presentarme()
        {
            Console.WriteLine("Hola soy {0} {1} tengo los ojos {2} y mi edad es {3}", primerNombre,apellido, colorOjo, edad);
        }
    }
}
