using CursoDesignPatterns;

class program
{ 
    static void Main(string[]args)
    {
        NotaFiscalBuilder criador = new NotaFiscalBuilder();
        criador
            .ParaEmpresa("Caelum Ensino e Inovação")
            .ComCnpj("23.421.534/0001-12")
            .comItens(new ItemDaNota("Monitor", 100))
            .comItens(new ItemDaNota("Fone de ouvido", 250))
            .ComObservações("Uma OBS qualquer")
            .NaDataAtual();
        criador.AdicionaAcao(new EnviadorDeEmail());
        criador.AdicionaAcao(new EnviadorDeSMS());
        criador.AdicionaAcao(new NotaFiscalDAO());

        NotaFiscal FN = criador.Constroi();

        Console.WriteLine(FN.ValorBruto);
        Console.WriteLine(FN.ValorDosImpostos);
        
        Console.ReadKey();
    }
}
