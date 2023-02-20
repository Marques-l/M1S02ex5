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
        public decimal Valor { get; set; }
        public decimal Multa { get; set; }
        public  Cobrar(decimal valor, decimal multa)
        {
            Valor = valor;
            Multa = multa;
           
        }
        private void CalcularMulta()
        {
            var soma = Multa + Valor;
            Console.WriteLine(soma);
        }
       public void CalculoReal()
        {
            CalcularMulta();
          
        }
    }
    
}
