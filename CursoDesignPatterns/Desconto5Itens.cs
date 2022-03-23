using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Desconto5Itens : Desconto
    {
        public Desconto Proximo { get; set; }
        public double Desconta(Orçamento orçamento)
        {
            if (orçamento.Itens.Count > 5)
            {
                return orçamento.valor * 0.01;
            }
            
            return Proximo.Desconta(orçamento);
        }
    }
}
