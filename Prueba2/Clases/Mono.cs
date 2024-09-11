using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2.Clases
{
    public class Mono : Animal
    {
        public void ComerBananas()
        {
            Console.WriteLine("Hola, soy un mono y me gustan las bananas");
        }

        public override void Comer()
        {
            Console.WriteLine("Yo como bananas");
        }
    }
}
