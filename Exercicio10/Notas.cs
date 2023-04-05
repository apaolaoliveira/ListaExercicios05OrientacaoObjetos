using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    internal class Notas
    {
        public float nota1, peso1, nota2, peso2;

        public float CalcularMedia()
        {
            return (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);
        }
    }
}
