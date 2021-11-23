using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aporte1
{
    public abstract class Comestibles
    {
        private int TipoAlimento { get; set; }
        public int Hotdog=1;
        public int Palomitas = 2;
        public int Bebida = 3;
        public void Seleccion()
        {
            if (TipoAlimento.Equals(Hotdog))
            {
                Console.WriteLine("Alimento: Hotdog");
            }else if (TipoAlimento.Equals(Palomitas))
            {
                Console.WriteLine("Alimento: Palomitas");
            }
            else if (TipoAlimento.Equals(Hotdog+Palomitas))
            {
                Console.WriteLine("Alimento: Hotdog + Palomitas");
            }else if (TipoAlimento.Equals(Hotdog + Bebida))
            {
                Console.WriteLine("Alimento:Hotdog+Bebida");
            }
        }
    }
}
