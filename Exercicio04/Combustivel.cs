using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class Combustivel
    {
        public int kmFinal, kmInicial, consumoCombustivel;

        public double CalcularConsumo()
        {
            return (kmFinal - kmInicial) / consumoCombustivel;
        }
    }
}
