using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    internal class Desconto500R_ : Desconto
    {
        public Desconto Proximo { get; set; }
        public double Desconta (Orçamento orçamento)
        {
            if (orçamento.valor > 500.00)
            {
                return orçamento.valor * 0.07;
            }
            return Proximo.Desconta(orçamento);
        }
    }
}
