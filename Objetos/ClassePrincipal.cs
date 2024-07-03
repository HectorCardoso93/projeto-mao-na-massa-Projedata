namespace Dev.Objetos;

using System.Collections.Generic;
using System.Globalization;


// 3 – Deve conter uma classe Principal para executar as seguintes ações:
public class ClassePrincipal : Pessoa {
// 3.1 – Inserir todos os funcionários, na mesma ordem e informações da tabela acima.
    List<Funcionario> funcionarios = new List<Funcionario>();
    // 3.5 – Agrupar os funcionários por função em um MAP, sendo a chave a “função” e o valor a “lista de funcionários”.
    Dictionary<string,List<Funcionario>> listaFuncionarios = new Dictionary<string,List<Funcionario>>();
    
    public void Adicionar (List<Funcionario> variosFuncionarios){
        foreach(var funcionario in variosFuncionarios){
            funcionarios.Add(funcionario);
        }
    }

    // 3.2 – Remover o funcionário “João” da lista.
    public void Remover (Funcionario funcionario){
        if(funcionario.Nome == "João"){
            funcionarios.Remove(funcionario);
        }
    }
    // 3.3 – Imprimir todos os funcionários com todas suas informações, sendo que:
    // • informação de data deve ser exibido no formato dd/mm/aaaa;
    // • informação de valor numérico deve ser exibida no formatado com separador de milhar como ponto e decimal como vírgula.
    public void ExibirFuncionarios(){
        CultureInfo formatoDecimal = new CultureInfo("pt-BR");
        foreach(var funcionario in funcionarios){
            System.Console.WriteLine(funcionario.Nome);

            string dataFormatada = funcionario.DataNascimento.ToString("dd/MM/yyyy");
            System.Console.WriteLine(dataFormatada);

            string salarioFormatado = funcionario.Salario.ToString("N", formatoDecimal);
            System.Console.WriteLine(salarioFormatado);

            System.Console.WriteLine(funcionario.Funcao);
        }
    }
    // 3.4 – Os funcionários receberam 10% de aumento de salário, atualizar a lista de funcionários com novo valor.
    public void AtualizacaoSalario(){
        foreach(var funcionario in funcionarios){
            double novoSalario = (funcionario.Salario * 0.10);
        }
    }
    // 3.6 – Imprimir os funcionários, agrupados por função.
    public void ExibirFuncionariosFuncao(string funcao){
        if(listaFuncionarios.ContainsKey(funcao)){
        CultureInfo formatoDecimal = new CultureInfo("pt-BR");
            foreach(var funcionario in funcionarios){
                System.Console.WriteLine(funcionario.Nome);

                string dataFormatada = funcionario.DataNascimento.ToString("dd/MM/yyyy");
                System.Console.WriteLine(dataFormatada);

                string salarioFormatado = funcionario.Salario.ToString("N", formatoDecimal);
                System.Console.WriteLine(salarioFormatado);
            }
        }
    }
    // 3.8 – Imprimir os funcionários que fazem aniversário no mês 10 e 12.
    public void ExibirFuncionariosAniversario(DateTime aniversario){
        if(aniversario.Month >= 10 && aniversario.Month <= 12 ){
            foreach(var funcionario in funcionarios){
            System.Console.WriteLine(funcionario.Nome);
            }
        } else {
            System.Console.WriteLine("Não faz aniversário entre Outubro e Dezembro.");
        }
    }
    // 3.9 – Imprimir o funcionário com a maior idade, exibir os atributos: nome e idade.
    public void ExibirFuncionariosIdade(){
        DateTime dataAtual = DateTime.Now;
        int anoAtual = dataAtual.Year;
        foreach(var funcionario in funcionarios){
            int anoNascimento = funcionario.DataNascimento.Year;
            int idade = anoAtual - anoNascimento;
            if(idade >= 18){
                System.Console.WriteLine(funcionario.Nome);
                System.Console.WriteLine(idade);
            } else{
                System.Console.WriteLine("Você não é maior de idade.");
            }
        }
    }
    // 3.10 – Imprimir a lista de funcionários por ordem alfabética.
    public void ExibirFuncionariosOrdemAlfabetica(){
        var nomesOrdenados = funcionarios.OrderBy(f => f.Nome);
        foreach(var nome in nomesOrdenados){
            System.Console.WriteLine(nome.Nome);
        }
    }
    // 3.11 – Imprimir o total dos salários dos funcionários.
    public void ExibirTotalSalario(){
        double salarioTotal = funcionarios.Sum(f => f.Salario);
    }
    // 3.12 – Imprimir quantos salários mínimos ganha cada funcionário, considerando que o salário mínimo é R$1212.00.
    public void ExibirSalariosMinimos(){
        int salarioMinimo = 0;
        foreach(var funcionario in funcionarios){
            double salarioTotal = funcionario.Salario;
            if(salarioTotal > 1212.00){
                for(int i = 0; salarioTotal > 1212.00; i++){
                    salarioTotal -= 1212.00;
                    salarioMinimo++;
                }
            }
        }
    }
}