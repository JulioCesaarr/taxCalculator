using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Orçamento
    {
        internal EstadoDeUmOrçamento EstadoAtual { get; set; }

        public double valor { get; set; }
        public IList<Item> Itens { get; private set; }
        public Orçamento(double valor)
        {
            this.valor = valor;
            Itens = new List<Item>();
            EstadoAtual = new EmAprovação();
        }

        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void AdicionaItens(Item item)
        {
            Itens.Add(item);
        }
        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }
        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }
        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}
