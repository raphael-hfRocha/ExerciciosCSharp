namespace Exercicio_1;

internal class Program
{
    static void Main(string[] args)
    {
        /*
            EXERCÍCIO 01: Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.
        
            Exemplo:
            
            Dados da primeira pessoa:
            Nome: Maria
            Idade: 17
            Dados da segunda pessoa:
            Nome: Joao
            Idade: 16
            Pessoa mais velha: Maria 
        */


        string nome;
        int idade;

        Console.Write("Digite o nome da primeira pessoa: ");
        nome = Console.ReadLine();
        Console.Write("Digite a idade da primeira pessoa: ");
        idade = int.Parse(Console.ReadLine());

        Pessoa PrimeiraPessoa = new Pessoa(nome, idade);

        Console.Write("\n\nDigite o nome da segunda pessoa: ");
        nome = Console.ReadLine();
        Console.Write("Digite a idade da segunda pessoa: ");
        idade = int.Parse(Console.ReadLine());

        Pessoa SegundaPessoa = new Pessoa(nome, idade);

        Console.WriteLine("\n\nDados da primeira pessoa: ");
        Console.WriteLine($"{PrimeiraPessoa}");
        Console.WriteLine("\nDados da segunda pessoa: ");
        Console.WriteLine($"{SegundaPessoa}");

        
        if(PrimeiraPessoa.Idade > SegundaPessoa.Idade)
        {
            Console.WriteLine($"\nPessoa mais velha: {PrimeiraPessoa.Nome}");
        }
        else
        {
            Console.WriteLine($"\nPessoa mais velha: {SegundaPessoa.Nome}");
        }
    }
}
