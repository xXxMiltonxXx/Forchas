using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aporte1
{
    public abstract class Cliente : Pelicula
    {
        //Caracteristicas
        private string Tipo { get; set; }
        public int NumerodeAcientos { get; set; }
        public int Acientos;
        public override void AsignaciondeSala()
        {
            if (Tipo.Equals("John Wick 3"))
            {
                Acientos = NumerodeAcientos;

            }
            if (Tipo.Equals("Aladdin"))
            {
                Acientos = NumerodeAcientos;
            }
            if (Tipo.Equals("Avengers"))
            {
                Acientos = NumerodeAcientos;
            }
            if (Tipo.Equals("Pikachu"))
            {
                Acientos = NumerodeAcientos;
            }

        }
        public abstract void NumSala();
    }
}
