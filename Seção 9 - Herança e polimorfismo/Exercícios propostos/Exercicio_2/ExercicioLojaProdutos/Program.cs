using ExercicioLojaProdutos.Entities;
using System.Runtime.Serialization.Formatters;

namespace ExercicioLojaProdutos;

public class Program
{
    static void Main(string[] args)
    {
        /*
            Fazer um programa para ler os dados de N
            produtos (N fornecido pelo usuário). Ao final,
            mostrar a etiqueta de preço de cada produto na
            mesma ordem em que foram digitados.
            Todo produto possui nome e preço. Produtos
            importados possuem uma taxa de alfândega, e
            produtos usados possuem data de fabricação.
            Estes dados específicos devem ser
            acrescentados na etiqueta de preço conforme
            exemplo (próxima página). Para produtos
            importados, a taxa e alfândega deve ser
            acrescentada ao preço final do produto.
        

            Exemplo: 

            Enter the number of products: 3
            Product #1 data:
            Common, used or imported (c/u/i)? i
            Name: Tablet
            Price: 260.00
            Customs fee: 20.00
            Product #2 data:
            Common, used or imported (c/u/i)? c
            Name: Notebook
            Price: 1100.00
            Product #3 data:
            Common, used or imported (c/u/i)? u
            Name: Iphone
            Price: 400.00
            Manufacture date (DD/MM/YYYY): 15/03/2017
            PRICE TAGS:
            Tablet $ 280.00 (Customs fee: $ 20.00)
            Notebook $ 1100.00
            Iphone (used) $ 400.00 (Manufacture date: 15/03/2017)
        */

        string nome;
        double preco, taxaAlfandegaria;
        DateTime dataFabricacao;
        int qtde, op, j = 0;

        List<Produto> listProdutos = new List<Produto>();

        Console.Write("Digite a quantidade de produtos: ");
        qtde = int.Parse(Console.ReadLine());

        Console.WriteLine("\n");
        for(int i = 1; i <= qtde; i++)
        {
            Console.WriteLine("\n[1] - Produto comum \n[2] - Produto usado \n[3] - Produto importado");
            Console.Write("\nDigite uma das opções acima: ");
            op = int.Parse(Console.ReadLine());
            
            if(op == 1)
            {
                Console.Write($"\nDigite o nome do {i}º produto: ");
                nome = Console.ReadLine();
                Console.Write($"Digite o preco do {i}º produto: ");
                preco = double.Parse(Console.ReadLine());

                listProdutos.Add(new Produto(nome, preco));
            }
            else if(op == 2)
            {
                Console.Write($"\nDigite o nome do {i}º produto: ");
                nome = Console.ReadLine();
                Console.Write($"Digite o preco do {i}º produto: ");
                preco = double.Parse(Console.ReadLine());
                Console.Write("Digite o dia da fabricação: ");
                int dia = int.Parse(Console.ReadLine());
                Console.Write("Digite o mês da fabricação: ");
                int mes = int.Parse(Console.ReadLine());
                Console.Write("Digite o ano da fabricação: ");
                int ano = int.Parse(Console.ReadLine());
                dataFabricacao = new DateTime(ano, mes, dia);

                listProdutos.Add(new ProdutoUsado(nome, preco, dataFabricacao));
            }
            else if(op == 3)
            {
                Console.Write($"\nDigite o nome do {i}º produto: ");
                nome = Console.ReadLine();
                Console.Write($"Digite o preco do {i}º produto: ");
                preco = double.Parse(Console.ReadLine());
                Console.Write("Digite a taxa da alfândega: ");
                taxaAlfandegaria = double.Parse(Console.ReadLine());

                listProdutos.Add(new ProdutoImportado(nome, preco, taxaAlfandegaria));
            }
        }

        Console.WriteLine("\n");
        foreach (var item in listProdutos)
        {
            if(item is Produto)
            {
                Console.WriteLine(item.EtiquetaPreco());
            }
            else if (item is ProdutoUsado)
            {
                Console.WriteLine(item.EtiquetaPreco());
            }
            else if (item is ProdutoImportado)
            {
                Console.WriteLine(item.EtiquetaPreco());
            }
        }
    }
}
