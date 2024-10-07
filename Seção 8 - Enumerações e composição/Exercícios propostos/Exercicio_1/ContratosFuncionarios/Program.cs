using ContratosFuncionarios.Entities.Enums;
using ContratosFuncionarios.Entities.Models;

namespace ContratosFuncionarios;

public class Program
{
    static void Main(string[] args)
    {
        /*
            Ler os dados de um trabalhador com N contratos (N fornecido pelo usuário). Depois, solicitar
            do usuário um mês e mostrar qual foi o salário do funcionário nesse mês, conforme exemplo
            (próxima página). 
        
            Exemplo:
        
            Enter department's name: Design
            Enter worker data:
            Name: Alex
            Level (Junior/MidLevel/Senior): MidLevel
            Base salary: 1200.00
            How many contracts to this worker? 3
            Enter #1 contract data:
            Date (DD/MM/YYYY): 20/08/2018
            Value per hour: 50.00
            Duration (hours): 20
            Enter #2 contract data:
            Date (DD/MM/YYYY): 13/06/2018
            Value per hour: 30.00
            Duration (hours): 18
            Enter #3 contract data:
            Date (DD/MM/YYYY): 25/08/2018
            Value per hour: 80.00
            Duration (hours): 10
            Enter month and year to calculate income (MM/YYYY): 08/2018
            Name: Alex
            Department: Design
            Income for 08/2018: 3000.00         
        */

        Funcionario funcionario;
        Departamento department = new Departamento();
        NivelFuncionario nivelFuncionario = new NivelFuncionario();
        HorasContrato contrato;

        Console.Write("Digite a função do funcionário: ");
        department.Nome = Console.ReadLine();
        Console.Write("Digite o nome do funcionário: ");
        string nome = Console.ReadLine();
        Console.Write("Digite o nível do funcionário(Junior/MidLevel/Senior): ");
        string nivel = Console.ReadLine();
        nivelFuncionario = (NivelFuncionario)Enum.Parse(typeof(NivelFuncionario), nivel);
        Console.Write("Digite o salario do funcionário: ");
        double salario = double.Parse(Console.ReadLine());
        funcionario = new Funcionario(nome, nivelFuncionario, salario, department);
        Console.Write("\nQuantos contratos este funcionário teve: ");
        int qtde = int.Parse(Console.ReadLine());

        for(int i = 1; i <= qtde; i++)
        {
            Console.Write($"\nInsira o dia do {i}º contrato: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write($"Insira o mês do {i}º contrato: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write($"Insira o ano do {i}º contrato: ");
            int ano = int.Parse(Console.ReadLine());
            DateTime dataContrato = new DateTime(ano, mes, dia);
            Console.Write($"Insira qual era o valor por hora do {i}º contrato: ");
            double valorHora = double.Parse(Console.ReadLine());
            Console.Write($"Insira o tempo(horas) a ser calculado do {i}º contrato: ");
            int hora = int.Parse(Console.ReadLine());
            contrato = new HorasContrato(dataContrato, valorHora, hora);
            funcionario.AdicionarContrato(contrato);
        }

        Console.WriteLine("\n\nCalculo de renda: \n");
        Console.Write("Digite o mês para o calculo de renda: ");
        int mesContrato = int.Parse(Console.ReadLine());
        Console.Write("Digite o ano para o calculo de renda: ");
        int anoContrato = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDados após calculo: \n");
        Console.WriteLine($"Nome do funcionário: {nome}");
        Console.WriteLine($"Departamento: {department.Nome}");
        Console.WriteLine($"Calculo do(s) contrato(os) de {mesContrato}/{anoContrato}: R${funcionario.CalcularRenda(mesContrato, anoContrato):F2}");


    }
}
