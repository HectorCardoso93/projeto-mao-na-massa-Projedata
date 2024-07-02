namespace Dev.Objetos;
// 1– Classe Pessoa com os atributos: nome (String) e data nascimento (LocalDate).
public class Funcionario : Pessoa{
    public decimal Salario { get; set; }
    public string Funcao { get; set; }
}