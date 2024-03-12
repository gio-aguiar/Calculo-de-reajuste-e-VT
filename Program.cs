using System.Security.Cryptography;
using Aula02RH.models;
using Aula02RH.models.Enuns;

class Program
{
    static void Main(string[] args)
    {
        Funcionario func = new Funcionario();

        Console.WriteLine("Digite o ID do funcionário:");
        func.Id = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o nome do funcionário:");
        func.Nome = Console.ReadLine();

        Console.WriteLine("Digite o CPF:");
        func.Cpf = Console.ReadLine();

        Console.WriteLine("Digite a data de admissão:");
        func.DataAdmissao = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Digite o salário");
        func.Salario = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Digite 1 para Aprendiz e 2 para CLT");
        int opcao = int.Parse(Console.ReadLine());

        func.TipoFuncionario = (opcao == 1)? TipoFuncionarioEnum.CLT : TipoFuncionarioEnum.Aprendiz;

        func.ReajustarSalario();
        decimal valorDescontoVT = func.CalcularDescontoVt(6);

        Console.WriteLine("=========================");
        Console.WriteLine($"O salário reajuste do funcionário é {func.Salario}.\n");
        Console.WriteLine($"O desconto do VT é {valorDescontoVT}.\n");
        Console.WriteLine("======================");

    }
}