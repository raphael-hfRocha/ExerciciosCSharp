namespace ListagemFuncionarios;

public class Program
{
    static void Main(string[] args)
    {
        /*
            Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
            N funcionários. Não deve haver repetição de id.
            Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
            Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
            mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
            conforme exemplos.
            Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
            ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
            aumento por porcentagem dada.

            Exemplo:

            How many employees will be registered? 3

            Emplyoee #1:
            Id: 333
            Name: Maria Brown
            Salary: 4000.00
            
            Emplyoee #2:
            Id: 536
            Name: Alex Grey
            Salary: 3000.00
            
            Emplyoee #3:
            Id: 772
            Name: Bob Green
            Salary: 5000.00

            Enter the employee id that will have salary increase : 536
            
            Enter the percentage: 10.0
            
            Updated list of employees:

            333, Maria Brown, 4000.00
            536, Alex Grey, 3300.00
            772, Bob Green, 5000.00
         */

        Funcionario f;
        int qtd, id;
        string nome;
        double salario;

        List<Funcionario> listaFuncionarios = new List<Funcionario>();

        Console.Write("Digite a quantidade de funcionarios: ");
        qtd = int.Parse(Console.ReadLine());

        Console.WriteLine();
        for(int i = 1; i <= qtd; i++)
        {
            Console.Write($"\nDigite o id do {i}º funcionário: ");
            id = int.Parse(Console.ReadLine());
            Console.Write($"Digite o nome do {i}º funcionário: ");
            nome = Console.ReadLine();
            Console.Write($"Digite o salário do {i}º funcionário: ");
            salario = double.Parse(Console.ReadLine());
            f = new Funcionario(id, nome, salario);

            listaFuncionarios.Add(f);
            Console.WriteLine("\n");
        }
        foreach (var funcionario in listaFuncionarios)
        {
            Console.WriteLine($"\nId: {funcionario.Id}");
            Console.WriteLine($"Nome: {funcionario.Nome}");
            Console.WriteLine($"Salario: R${funcionario.Salario:F2}");
        }




        Console.Write("\nEntre com o numero de id do funcionário que receberá aumento de salário: ");
        id = int.Parse(Console.ReadLine());

        Funcionario funcionarioSelected = listaFuncionarios.Find(x => x.Id == id);
        
        if(funcionarioSelected != null)
        {
            Console.Write("\nDigite o valor da porcentagem de aumento: ");
            double porcentagem = double.Parse(Console.ReadLine());

            funcionarioSelected.AumentoSalario(porcentagem);


            Console.WriteLine("\n");
            Console.WriteLine("Listagem após atualização do salário: \n");
            foreach(var funcionario in listaFuncionarios)
            {
                Console.WriteLine($"\nId: {funcionario.Id}");
                Console.WriteLine($"Nome: {funcionario.Nome}");
                Console.WriteLine($"Salario: R${funcionario.Salario:F2}");
            }
        }
        else
        {
            Console.WriteLine("\nO id digitado não existe.");
            Console.WriteLine("\nFim da operação.");
        }






    }
}
