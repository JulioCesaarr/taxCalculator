using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class ICCC : Imposto
    {
        
        public override double CalculaImposto(Orçamento orçamento)
        {
            if (orçamento.valor < 1000)
            {
                return 0.05 * orçamento.valor;
            }
            else if(orçamento.valor >= 1000 && orçamento.valor <= 3000)
            {
                return 0.07 * orçamento.valor;
            }
            else 
            {
                return 0.08 * orçamento.valor;
            }
        }
    }
}
