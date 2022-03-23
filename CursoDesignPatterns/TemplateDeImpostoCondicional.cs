using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        public override double CalculaImposto(Orçamento orçamento)
        { 
            if(DeveUsarMaximaTaxação(orçamento))
            {
                return MaximaTaxação(orçamento);
            }

            return MinimaTaxação(orçamento);
        }

        public abstract double MinimaTaxação(Orçamento orçamento);
        public abstract double MaximaTaxação(Orçamento orçamento);
        public abstract bool DeveUsarMaximaTaxação(Orçamento orçamento);

    }
}
