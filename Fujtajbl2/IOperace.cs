using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fujtajbl2
{
    /// <summary>
    /// Rozhraní pro definici výpočetní operace
    /// </summary>
    interface IOperace
    {
        /// <summary>
        /// Definice metody pro výpočet operace
        /// </summary>
        /// <param name="a">Vstup prvního čísla datového typu double</param>
        /// <param name="b">Vstup druhého čísla datového typu double</param>
        /// <returns></returns>
        void VypocetOperace(double a, double b);
    }
}
