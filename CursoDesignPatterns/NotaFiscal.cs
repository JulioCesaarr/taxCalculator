using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class NotaFiscal
    {
        public NotaFiscal(string razãoSocial, string cNPJ, DateTime dataDeEmissão, double valorBruto, double valorDosImpostos, 
            IList<ItemDaNota> itens, string observações)
        {
            RazãoSocial = razãoSocial;
            CNPJ = cNPJ;
            DataDeEmissão = dataDeEmissão;
            ValorBruto = valorBruto;
            ValorDosImpostos = valorDosImpostos;
            Itens = itens;
            Observações = observações;
        }

        public string RazãoSocial { get; set; }
        public string CNPJ { get; set; }
        public DateTime DataDeEmissão { get; set; }
        public double ValorBruto { get; set; }  
        public double ValorDosImpostos { get; set; }
        public IList<ItemDaNota> Itens { get; set; } 
        public string Observações { get; set; }
    }
}
