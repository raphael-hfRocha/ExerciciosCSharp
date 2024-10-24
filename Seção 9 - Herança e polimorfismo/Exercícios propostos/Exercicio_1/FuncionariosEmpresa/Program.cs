using FuncionariosEmpresa.Entities;
using System.Text;

namespace FuncionariosEmpresa;

internal class Program
{
    static void Main(string[] args)
    {

        /*
            Uma empresa possui funcionários próprios e terceirizados.
            Para cada funcionário, deseja-se registrar nome, horas
            trabalhadas e valor por hora. Funcionários terceirizados
            possuem ainda uma despesa adicional.
            O pagamento dos funcionários corresponde ao valor da hora
            multiplicado pelas horas trabalhadas, sendo que os
            funcionários terceirizados ainda recebem um bônus
            correspondente a 110% de sua despesa adicional.
            Fazer um programa para ler os dados de N funcionários (N
            fornecido pelo usuário) e armazená-los em uma lista. Depois
            de ler todos os dados, mostrar nome e pagamento de cada
            funcionário na mesma ordem em que foram digitados. 

            Exemplo:

            Enter the number of employees: 3
            Employee #1 data:
            Outsourced (y/n)? n
            Name: Alex
            Hours: 50
            Value per hour: 20.00

            Employee #2 data:
            Outsourced (y/n)? y
            Name: Bob
            Hours: 100
            Value per hour: 15.00
            Additional charge: 200.00

            Employee #3 data:
            Outsourced (y/n)? n
            Name: Maria
            Hours: 60
            Value per hour: 20.00

            PAYMENTS:
            Alex - $ 1000.00
            Bob - $ 1720.00
            Maria - $ 1200.00
        */


        string nome;
        int horas, n, tipoFuncionario, j = 0;
        double valorPorHora, despesaAdicional;

        StringBuilder sb = new StringBuilder();
        List<Funcionario> listaFuncionarios = new List<Funcionario>();

        Console.Write("Digite a quantidade de funcionarios: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("\n[1] - Funcionario da empresa");
            Console.WriteLine("[2] - Funcionario terceirizado");

            Console.Write("\nDigite uma das opções acima: ");
            tipoFuncionario = int.Parse(Console.ReadLine());

            if (tipoFuncionario == 1)
            {
                Console.Write("\nDigite o nome do funcionario: ");
                nome = Console.ReadLine();
                Console.Write("Digite a quantidade de horas: ");
                horas = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor por hora: ");
                valorPorHora = double.Parse(Console.ReadLine());
                listaFuncionarios.Add(new Funcionario(nome, horas, valorPorHora));
            }
            else if (tipoFuncionario == 2)
            {
                Console.Write("\nDigite o nome do funcionario: ");
                nome = Console.ReadLine();
                Console.Write("Digite a quantidade de horas: ");
                horas = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor por hora: ");
                valorPorHora = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor da despesa adicional: ");
                despesaAdicional = double.Parse(Console.ReadLine());
                listaFuncionarios.Add(new FuncionarioTerceirizado(nome, horas, valorPorHora, despesaAdicional));
            }
        }

        Console.WriteLine("\n\nDados da lista: ");
        foreach (var item in listaFuncionarios)
        {
            j += 1;

            if (item is FuncionarioTerceirizado funcionarioTerceirizado)
            {
                sb.AppendLine($"\n{j}#Funcionario terceirizado : \n");
                sb.AppendLine($"Nome: {funcionarioTerceirizado.Nome}");
                sb.AppendLine($"Horas: {funcionarioTerceirizado.Horas}");
                sb.AppendLine($"Valor por hora: {funcionarioTerceirizado.ValorPorHora}");
                sb.AppendLine($"Pagamento: {funcionarioTerceirizado.CalculoPagamento():F2}");
            }
            else if (item is Funcionario funcionario)
            {
                sb.AppendLine($"\n{j}#Funcionario da empresa: \n");
                sb.AppendLine($"Nome: {funcionario.Nome}");
                sb.AppendLine($"Horas: {funcionario.Horas}");
                sb.AppendLine($"Valor por hora: {funcionario.ValorPorHora}");
                sb.AppendLine($"Pagamento: {funcionario.CalculoPagamento():F2}");
            }
        }
        Console.WriteLine(sb.ToString());
    }
}
