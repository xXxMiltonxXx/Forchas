using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aporte1
{
    public class Sala:Cliente
    {
        private string sala { get; set; }
        public int sala1 = 4;
        public int sala2 = 7;
        public int sala3 = 5;
        public int sala4 = 12;
        public override void NumSala()
        {
            if (Acientos <= sala1)
            {
                Console.WriteLine("Ingrese a la sala 1");
                Console.WriteLine("Aperitivos");
            }
            else if (Acientos <= sala2 && Acientos > sala1)
            {
                Console.WriteLine("Ingrese a sala 2");
                Console.WriteLine("Accesorios");
            }
            else if (Acientos <= sala3 && Acientos <= sala1)
            {
                Console.WriteLine("Ingrese a la sala 3 o 1");
                Console.WriteLine("Aperitivos");
            }
            else if (Acientos <= sala4)
            {
                Console.WriteLine("Ingrese a la sala 4");
                Console.WriteLine("Accesorios");
            }
           
        }
    }
}
