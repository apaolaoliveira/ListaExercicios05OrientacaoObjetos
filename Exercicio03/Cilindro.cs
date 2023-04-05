using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Cilindro
    {
        public double raio, altura;
        
        public double CalcularVolume()
        {
            return Math.PI * Math.Pow(raio, 2) * altura;
        }
    }
}
