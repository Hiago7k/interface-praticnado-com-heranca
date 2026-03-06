namespace interface_praticnado_com_heranca;

internal class Funcionario
{
    public Funcionario(string nome, string departamento)
    {
        Nome = nome;
        Departamento = departamento;
    }

    public string Nome { get;  }
    public string Departamento { get;  }
}
