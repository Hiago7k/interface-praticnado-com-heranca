using interface_praticnado_com_heranca;

Funcionario tecnico = new Funcionario("Joao", "TI");
IServico s1 = new Manutencao("Atualizacao de servidor", tecnico);

Funcionario analista = new Funcionario("Marina", "Consultoria");
IServico s2 = new Consultoria("Planejamento Estrategico", analista);

s1.ExecutarServico();
Console.WriteLine();
s2.ExecutarServico();