using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        
        public override bool DeveUsarMaximaTaxação(Orçamento orçamento)
        {
            return orçamento.valor > 500 && ItemValor100(orçamento);
        }

        public override double MaximaTaxação(Orçamento orçamento)
        {
            return orçamento.valor * 0.10;
        }
        
        public override double MinimaTaxação(Orçamento orçamento)
        {
            return orçamento.valor * 0.06;
        }
        
        private bool ItemValor100 (Orçamento orçamento)
        {
            foreach (Item item in orçamento.Itens)
            {
                if (item.Valor > 100) return true;
            }
            return false;   
        }
    }
}
