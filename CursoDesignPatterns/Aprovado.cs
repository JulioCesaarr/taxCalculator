using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class Aprovado : EstadoDeUmOrçamento
    {
        public void AplicaDescontoExtra(Orçamento orçamento)
        {
            orçamento.valor -= orçamento.valor * 0.02;
        }

        public void Aprova(Orçamento orçamento)
        {
            throw new Exception("Orçamento já foi aprovado");
        }
        public void Reprova(Orçamento orçamento)
        {
            throw new Exception("orçamento aprovado, não pode ser reprovado agora!");
        }
        public void Finaliza(Orçamento orçamento)
        {
            orçamento.EstadoAtual = new Finalizado();
        }
        






    }
}
