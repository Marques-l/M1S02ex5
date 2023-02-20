using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S02ex5
{
    internal class Cobrar
    {
        private decimal valor;
        private decimal multa;
        public decimal soma; 
       public void Calcular(decimal Valor, decimal Multa)
        {
            Valor = valor;
            Multa = multa; 
        }
        private void CalcularMulta()
        {
            soma = valor + multa;
            return; 
        }
        public void Calcular()
        {
            CalcularMulta(); 
        }
    }
    
}
