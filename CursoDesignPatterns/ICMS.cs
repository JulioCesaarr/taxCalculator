using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class ICMS : Imposto
    {
        public ICMS(Imposto outroImposto) : base(outroImposto)
        {

        }
        public ICMS() : base() { }

        public override double CalculaImposto(Orçamento orçamento)
        {
            return orçamento.valor * 0.1 + CalculaOutroImposto(orçamento);
        }
    }
}
