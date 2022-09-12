using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miembros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Miembros nuevoMiembros = new Miembros();
            nuevoMiembros.Amigo(true);

            Console.ReadLine();
        }
    }
}
