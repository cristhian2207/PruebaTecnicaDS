using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2.Clases
{
    public class Serpiente:Animal
    {
        public void TenerVeneno()
        {
            Console.WriteLine("Hola, soy una serpiente y solo yo tengo veneno");
        }

        public override void Comer()
        {
            Console.WriteLine("Yo como ratones");
        }
    }
}
