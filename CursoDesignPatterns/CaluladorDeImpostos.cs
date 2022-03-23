using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class CaluladorDeImpostos
    { 
      public void RealizaCalculo(Orçamento orçamento, Imposto imposto)
      {
            double icms = imposto.CalculaImposto(orçamento);
        Console.WriteLine($"icms: {icms}");
      }
    }
}
