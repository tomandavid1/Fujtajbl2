using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fujtajbl2
{
    /// <summary>
    /// Operace dělení
    /// </summary>
    class DeleniOperace : IOperace
    {
        /// <summary>
        /// Metoda pro výpočet dělení dvou čísel
        /// </summary>
        /// <param name="a">Vstup prvního čísla datového typu double</param>
        /// <param name="b">Vstup druhého čísla datového typu double</param>
        /// <returns>Výsledek datového typu double po dělení</returns>
        /// <exception cref="ArithmeticException">Zachycení neočekávané vyjímky</exception>
        public void VypocetOperace(double a, double b)
        {
            try
            {
                if (b != 0)
                    Console.WriteLine($"Výsledek: {a/b}");
                else
                    Console.WriteLine("Nelze dělit nulou!");
            }
            catch(Exception e)
            {
                throw new ArithmeticException("Nastala neočekávaná vyjímka", e);
            }
        }
    }
}
