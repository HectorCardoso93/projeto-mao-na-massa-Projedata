using System;
using Dev.Objetos;

// 3.1 – Inserir todos os funcionários, na mesma ordem e informações da tabela acima.

List<Funcionario> funcionarios = new List<Funcionario>();

funcionarios.Add(new Funcionarios {
    Nome = "Maria",
    DataNascimento = new DateTime(2000,10,18),
    Salario = 2009.44,
    Funcao = "Operador"
});
funcionarios.Add(new Funcionarios {
    Nome = "João",
    DataNascimento = new DateTime(1990,05,12),
    Salario = 2284.38m,
    Funcao = "Operador"
});
funcionarios.Add(new Funcionarios {
    Nome = "Caio",
    DataNascimento = new DateTime(1961,05,02),
    Salario = 9836.14m,
    Funcao = "Coordenador"
});
funcionarios.Add(new Funcionarios {
    Nome = "Miguel",
    DataNascimento = new DateTime(1988,10,14),
    Salario = 19119.88m,
    Funcao = "Diretor"
});
funcionarios.Add(new Funcionarios {
    Nome = "Alice",
    DataNascimento = new DateTime(1995,01,05),
    Salario = 2234.68m,
    Funcao = "Recepcionista"
});
funcionarios.Add(new Funcionarios {
    Nome = "Heitor",
    DataNascimento = new DateTime(199,11,19),
    Salario = 1582.72m,
    Funcao = "Operador"
});
funcionarios.Add(new Funcionarios {
    Nome = "Arthur",
    DataNascimento = new DateTime(1993,03,31),
    Salario = 4071.84m,
    Funcao = "Contador"
});
funcionarios.Add(new Funcionarios {
    Nome = "Laura",
    DataNascimento = new DateTime(1994,07,08),
    Salario = 3017.45m,
    Funcao = "Gerente"
});
funcionarios.Add(new Funcionarios {
    Nome = "Heloísa",
    DataNascimento = new DateTime(2003,05,24),
    Salario = 1606.85m,
    Funcao = "Eletricista"
});
funcionarios.Add(new Funcionarios {
    Nome = "Helena",
    DataNascimento = new DateTime(1996,09,02),
    Salario = 2799.93m,
    Funcao = "Gerente"
});

