namespace interface_praticnado_com_heranca;

internal class Consultoria : IServico
{
    public Funcionario colaborador;

    public Consultoria(string tituloDaTarefa, Funcionario colaborador)
    {
        TituloDaTarefa = tituloDaTarefa;
        this.colaborador = colaborador;

    }

    public string TipoDeServico { get; }
    public string TituloDaTarefa { get; }


    public void ExecutarServico() 
    {
        Console.WriteLine($"Executando servico de consultoria: {TituloDaTarefa} {TipoDeServico}");
        Console.WriteLine($"Responsavel: {colaborador.Nome} {colaborador.Departamento}");
    }

}
