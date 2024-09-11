using Prueba2.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Encontrar palabras en común entre 2 strings
            //Define los strings
            string cadena1 = "Hola, cómo estás en este hermoso día";
            string cadena2 = "Espero que tengas un hermoso día";

            //Separa las palabras, omitiendo espacios o comas
            string[] palabra1 = cadena1.Split(' ', ',');
            string[] palabra2 = cadena2.Split(' ', ',');
            Console.WriteLine("Palabras en comun:");

            //Se procede a iterar los 2 strings
            foreach (string palabras in palabra1)
            {
                foreach (string palabra in palabra2)
                {
                    //Se valida si el 1er string no viene vacío, si tiene palabras iguales
                    //al segundo y que ignore las mayúsculas y minúsculas
                    if (!string.IsNullOrEmpty(palabras) && palabras.Equals(palabra, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(palabras);
                        break;
                    }
                }
            }
            #endregion

            //Instancia de la clase Animal
            Animal animal = new Animal();
            animal.Comer();
            animal.Respirar();
            

            //Instancia de las clases hijas mediante polimorfismo
            Animal mono = new Mono();
            mono.Comer();
            
            Animal vaca = new Vaca();
            vaca.Comer();

            Animal serpiente = new Serpiente();
            serpiente.Comer();

            //Instancia y uso de clases y métodos de las hijas

            Mono mono1 = new Mono();
            mono1.ComerBananas();

            Vaca vaca1 = new Vaca();
            vaca1.GenerarLeche();

            Serpiente serpiente1 = new Serpiente();
            serpiente1.TenerVeneno();
            Console.ReadKey();

        }

       
    }
}
