using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    internal class Caja
    {
        private int largo;
        private int alto;
        private int ancho;
        private int volumen;


        //Propiedad Auto Implementada
        public int Ancho
        {
            get { return ancho; }
            set { 
                if (value < 0) value = -value;
                ancho = value;
            }
        }
        public int Alto
        {
            get { return alto; }
            set
            {
                if (value < 0) value = -value;
                alto = value;
            }
        }

        public int Largo
        {
            get { return largo; }
            set
            {
                if (value < 0) { value = -value; }
                largo = value;
            }
        }

        public int Volumen
        {
            get { return alto * ancho * largo; }
            set { volumen = value; }
        }


        public Caja(int largo, int alto, int ancho)
        {
            this.largo = largo;
            this.alto = alto;
            this.ancho = ancho;
        }




        //Miembro metodo
        public void Muestrainfo()
        {
            Console.WriteLine("El largo es {0} la altura es {1} el ancho es {2} el volumen es {3}", largo, alto, ancho, volumen);
        }

    }
}
