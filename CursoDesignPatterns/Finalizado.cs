using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class Finalizado : EstadoDeUmOrçamento
    {
        public void AplicaDescontoExtra(Orçamento orçamento)
        {
            throw new Exception("Um orçamento finalizado NÃO pode receber um desconto extra!");
        }
        public void Aprova(Orçamento orçamento)
        {
            throw new Exception("Orçamento já está finalizado");
        }
        public void Reprova(Orçamento orçamento)
        {
            throw new Exception("Orçamento já está finalizado");
        }
        public void Finaliza(Orçamento orçamento)
        {
            throw new Exception("Orçamento já está finalizado");
        }
    }
}
