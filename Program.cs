using interface_praticnado_com_heranca;

Funcionario tecnico = new Funcionario("Joao", "TI");
IServico s1 = new Manutencao("Atualizacao de servidor", tecnico);

s1.ExecutarServico();