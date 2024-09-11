using Prueba2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2.Clases
{
    public class Animal : IAnimal
    {
        //La clase animal hereda de la interfaz de Animal, por tanto se sobreescriben los métodos
        public virtual void Comer()
        {
            Console.WriteLine("Soy un animal, y necesito ingerir alimentos");
        }

        public virtual void Moverse()
        {
            Console.WriteLine("Soy un animal, y puedo moverme");
        }

        public virtual void Respirar()
        {
            Console.WriteLine("Soy un animal, y necesito respirar");
        }
    }
}
