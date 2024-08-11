namespace ProdutoEstoque;

public class Program
{
    static void Main(string[] args)
    {
        /*
            Exercício 3 - Fazer um programa para ler os dados de um produto em estoque (nome, preço e
            quantidade no estoque). Em seguida:

            • Mostrar os dados do produto (nome, preço, quantidade no estoque, valor total no
            estoque)
            • Realizar uma entrada no estoque e mostrar novamente os dados do produto
            • Realizar uma saída no estoque e mostrar novamente os dados do produto 
        */

        Produto produto = new Produto();
        int addProduto, delProduto;

        Console.Write("Digite o nome do produto: ");
        produto.Nome = Console.ReadLine();
        Console.Write("Digite o preco do produto: ");
        produto.Preco = double.Parse(Console.ReadLine());
        Console.Write("Digite a quantidade do produto no estoque: ");
        produto.QtdEstoque = int.Parse(Console.ReadLine());

        Console.WriteLine($"\n\nNome do produto: {produto.Nome}");
        Console.WriteLine($"Preço do produto: {produto.Preco}");
        Console.WriteLine($"Quantidade no estoque: {produto.QtdEstoque}");

        Console.Write("\n\nDigite a quantidade de produtos a serem adicionados ao estoque: ");
        addProduto = int.Parse(Console.ReadLine());
        produto.AddProdutoEstoque(addProduto);
        
        Console.WriteLine($"\nTotal de produtos após adicionar: {produto.QtdEstoque}");

        Console.Write("\n\nDigite a quantidade de produtos a serem removidos ao estoque: ");
        delProduto = int.Parse(Console.ReadLine());
        produto.DelProdutoEstoque(delProduto);

        Console.WriteLine($"\nTotal de produtos após remover: {produto.QtdEstoque}");
    }
}
