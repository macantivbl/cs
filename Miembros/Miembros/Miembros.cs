using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miembros
{
    internal class Miembros
    {
        //Miembros - Campos Privados
        private string nombrePersona;
        private string tituloTrabajo;
        private int salario;

        // Miembros Campo Publico
        public int edad;

        //Miembros - Propiedades 
        public string TituloTrabajo
        {
            get
            {
                return tituloTrabajo;
            }
            set
            {
                tituloTrabajo = value;
            }
        }

        //Miembros - Metodo privado
        private void CompartirInfoPrivada()
        {
            Console.WriteLine("Mi salario es: {0}", salario);
        }

        //miembros - metodos publicos
        public void Amigo(bool esAmigo)
        {
            if (esAmigo)
            {
                CompartirInfoPrivada();
            }
            Console.WriteLine("no tiene permisos para ver esto");
        }

        //Miembros - Constructor

        public Miembros()
        {
            edad = 30;
            nombrePersona = "Ana";
            salario = 50000;
            tituloTrabajo = "Desarrollador";
            Console.WriteLine("objeto Creado");
        }

        //Destructor
        ~Miembros()
        {
            //Limpia declaraciones
            Console.WriteLine("Destruccion del objeto miembro");
            Console.ReadLine();
        }
    }
}
