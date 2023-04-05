using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class Salario
    {
        public double salarioBase, totalVendas, comissao;

        public double CalcularSalarioTotal()
        {
            return salarioBase + (totalVendas * (comissao * salarioBase / 100));
        }
    }
}
