using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2.Clases
{
    public class Vaca:Animal
    {
        public void GenerarLeche()
        {
            Console.WriteLine("Hola, soy una vaca y solo yo puedo dar leche");
        }

        public override void Comer()
        {
            Console.WriteLine("Yo como hierbas");
        }
    }
}
