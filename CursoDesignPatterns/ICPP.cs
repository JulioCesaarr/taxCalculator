using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class ICPP : TemplateDeImpostoCondicional
    {
       
        public override bool DeveUsarMaximaTaxação(Orçamento orçamento)
        {
            return orçamento.valor >= 500;
        }
        public override double MaximaTaxação(Orçamento orçamento)
        {
            return orçamento.valor * 0.07;  
        }
        public override double MinimaTaxação(Orçamento orçamento)
        {
            return orçamento.valor * 0.05;
        }
    }
}
