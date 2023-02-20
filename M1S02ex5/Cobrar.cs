using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S02ex5
{
    public class Cobrar
    {
        private decimal Valor;
        private decimal Multa;
        public decimal Soma; 
       public void Calcular()
        {
            
        }
        private void CalcularMulta(decimal valor, decimal multa, decimal soma)
        {
            Valor= valor;
            Multa= multa;
            Soma= soma;
        }
       
    }
    
}
