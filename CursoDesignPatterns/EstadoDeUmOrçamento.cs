using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    interface EstadoDeUmOrçamento
    {
        void AplicaDescontoExtra(Orçamento orçamento);

        void Aprova(Orçamento orçamento);
        void Reprova(Orçamento orçamento);
        void Finaliza(Orçamento orçamento);
        
    }
}
