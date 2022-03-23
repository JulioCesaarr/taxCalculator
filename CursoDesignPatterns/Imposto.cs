using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }

        protected Imposto(Imposto outroImposto)
        {
            OutroImposto = outroImposto;
        }
        public Imposto()
        {
            OutroImposto = null;
        }

        public abstract double CalculaImposto(Orçamento orçamento);

        protected double CalculaOutroImposto(Orçamento orçamento)
        {
            if(OutroImposto == null) return 0;
            return OutroImposto.CalculaImposto(orçamento);
        }
    }
}
