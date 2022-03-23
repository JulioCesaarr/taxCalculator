using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class CalculadorDeDesconto
    {
        public double CalculaDesconto(Orçamento orçamento)
        {
            Desconto D1 = new Desconto5Itens();
            Desconto D2 = new Desconto500R_();
            Desconto D3 = new SemDesconto();


            D1.Proximo = D2;
            D2.Proximo = D3;

            return D1.Desconta(orçamento);
        }
    }
}
