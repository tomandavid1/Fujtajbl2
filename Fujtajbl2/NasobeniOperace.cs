using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fujtajbl2
{
    /// <summary>
    /// Operace násobení
    /// </summary>
    class NasobeniOperace : IOperace
    {
        /// <summary>
        /// Metoda pro výpočet násobení dvou čísel
        /// </summary>
        /// <param name="a">Vstup prvního čísla datového typu double</param>
        /// <param name="b">Vstup druhého čísla datového typu double</param>
        /// <returns>Výsledek datového typu double po násobení</returns>
        /// <exception cref="ArithmeticException">Zachycení neočekávané vyjímky</exception>
        public void VypocetOperace(double a, double b)
        {
            try
            {
                Console.WriteLine($"Výsledek: {a * b}");
            }
            catch(Exception e)
            {
                throw new ArithmeticException("Nastala neočekávaná vyjímka", e);
            }
        }
    }
}
