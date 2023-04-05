using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    internal class Temperatura
    {
        public double celsius, fahrenheit;

        public double CalcularConversao()
        {
            return fahrenheit = (celsius * 9 / 5) + 32;
        }

    }
}
