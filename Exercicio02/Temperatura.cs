using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class Temperatura
    {
        public int celsius, fahrenheit;
        public double ConverterTemperatura() 
        {
            return celsius = (fahrenheit - 32) * 5 / 9;
        }
    }
}
