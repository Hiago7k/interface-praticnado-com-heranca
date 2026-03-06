namespace interface_praticnado_com_heranca;

internal class Manutencao : IServico
{
    public Funcionario colaborador { get;}
    public string TipoDeServico { get; }
    public string TituloDaTarefa { get; }



    public void ExecutarServico()
    {
        Console.WriteLine($"Executando servico de Manutencao: {TituloDaTarefa} {TipoDeServico}");
        Console.WriteLine($"Responsavel: {colaborador.Nome} {colaborador.Departamento}");
    }
}
