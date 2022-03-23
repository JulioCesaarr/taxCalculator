using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class NotaFiscalBuilder
    {
        public string CNPJ { get; private set; }
        public string RazãoSocial { get; private set; }
        private double ValorTotal;
        private double Impostos;
        private IList<ItemDaNota> TodosOsItens = new List<ItemDaNota>();
        public string Observações { get; private set; }
        public DateTime DataAtual { get; private set; }

        private IList<AcaoAposGerarNota> todasAcoesASeremExecutadas = new List<AcaoAposGerarNota>();
        public NotaFiscal Constroi() 
        {
           NotaFiscal nf = new NotaFiscal(RazãoSocial, CNPJ, DataAtual, ValorTotal, Impostos, TodosOsItens, Observações);

            foreach (AcaoAposGerarNota acao in todasAcoesASeremExecutadas)
            {
                acao.Executa(nf);
            }

            return nf;
        }
        
        public void AdicionaAcao(AcaoAposGerarNota novaAcao)
        {
            todasAcoesASeremExecutadas.Add(novaAcao);
        }
        
        public NotaFiscalBuilder ParaEmpresa(String razãosocial)
        {
            RazãoSocial = razãosocial;
            return this;
        }
        public NotaFiscalBuilder ComObservações(string observações)
        {
            Observações = observações;
            return this;
        }
        public NotaFiscalBuilder NaDataAtual()
        {
            DataAtual = DateTime.Now;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            CNPJ = cnpj;
            return this;
        }
        public NotaFiscalBuilder comItens(ItemDaNota item)
        {
            TodosOsItens.Add(item);
            ValorTotal += item.Valor;
            Impostos += item.Valor * 0.05;
            return this;
        }

    }
}
