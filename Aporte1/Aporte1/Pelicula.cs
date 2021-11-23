using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aporte1
{
    public abstract class Pelicula : Comestibles
    {
        //Propiedades (caracteristicas)
        public string Titulo { get; set; }

        //Mostrar en pantalla los titulos de las peliculas 
        public void Mostrar()
        {
            Console.WriteLine("Titulo: {0}", Titulo);
        }
        public abstract void AsignaciondeSala();
    }
}
