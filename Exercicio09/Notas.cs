using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    internal class Notas
    {
        public double nota1, peso1, nota2, peso2;

        public double CalcularMediaHarmonica()
        {
            double x = 1.0 / nota1;
            double y = 1.0 / nota2;
            return 2.0 / (x + y);
        }
    }
}
