using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class EmAprovação : EstadoDeUmOrçamento
    {
        public void AplicaDescontoExtra(Orçamento orçamento)
        {
            orçamento.valor = orçamento.valor - (orçamento.valor * 0.05);
        }

        public void Aprova(Orçamento orçamento)
        {
            orçamento.EstadoAtual = new Aprovado();
        }

        public void Finaliza(Orçamento orçamento)
        {
            throw new Exception("orçamento em finalização não pode ser aprovado direto!");
        }

        public void Reprova(Orçamento orçamento)
        {
            orçamento.EstadoAtual = new Reprovado();
        }
    }
}
