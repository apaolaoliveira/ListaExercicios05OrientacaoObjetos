using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    internal class Oleo
    {
        public int raio, altura;

        public double CalcularVolume()
        {
            return Math.PI * Math.Pow(raio, 2) * altura;
        }
    }
}
