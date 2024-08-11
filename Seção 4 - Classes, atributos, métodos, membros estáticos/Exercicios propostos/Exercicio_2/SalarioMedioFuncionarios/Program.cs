namespace SalarioMedioFuncionarios;

internal class Program
{
    static void Main(string[] args)
    {
        /*
            EXERCÍCIO 02 - Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários. 
                    
            Exemplo:

            Dados do primeiro funcionário:
            Nome: Carlos Silva
            Salário: 6300.00
            Dados do segundo funcionário:
            Nome: Ana Marques
            Salário: 6700.00
            Salário médio = 6500.00

         */

        string Nome, Salario;

        Funcionario f1 = new Funcionario();
        Funcionario f2 = new Funcionario();

        Console.Write("Digite o nome do primeiro funcionário: ");
        f1.Nome = Console.ReadLine();
        Console.Write("Digite o salário do primeiro funcionário: ");
        f1.Salario = double.Parse(Console.ReadLine());
        Console.Write("\nDigite o nome do segundo funcionário: ");
        f2.Nome = Console.ReadLine();
        Console.Write("Digite o salário do segundo funcionário: ");
        f2.Salario = double.Parse(Console.ReadLine());


        double mediaSalario = (f1.Salario + f2.Salario) / 2;


        Console.WriteLine("\nDados do primeiro funcionário:");
        Console.WriteLine(f1);
        Console.WriteLine("\nDados do segundo funcionário:");
        Console.WriteLine(f2);
        Console.WriteLine($"\nSalario médio: {mediaSalario:F2}");

    }
}
