using ExercicioPedidos.Entities.Enums;
using ExercicioPedidos.Entities.Models;
using System.Diagnostics.Tracing;

namespace ExercicioPedidos;

internal class Program
{
    static void Main(string[] args)
    {
        /*
            Ler os dados de um pedido com N itens (N fornecido pelo usuário). Depois, mostrar um
            sumário do pedido conforme exemplo abaixo. Nota: o instante do pedido deve ser
            o instante do sistema: DateTime.Now

            Exemplo:

            Enter cliente data:
            Name: Alex Green
            Email: alex@gmail.com
            Birth date (DD/MM/YYYY): 15/03/1985
            Enter order data:
            Status: Processing
            How many items to this order? 2
            Enter #1 item data:
            Product name: TV
            Product price: 1000.00
            Quantity: 1
            Enter #2 item data:
            Product name: Mouse
            Product price: 40.00
            Quantity: 2
            ORDER SUMMARY:
            Order moment: 20/04/2018 11:25:09
            Order status: Processing
            Client: Alex Green (15/03/1985) - alex@gmail.com
            Order items:
            TV, $1000.00, Quantity: 1, Subtotal: $1000.00
            Mouse, $40.00, Quantity: 2, Subtotal: $80.00
            Total price: $1080.00
        */


        StatusPedido statusPedido;
        ItemPedido item;
        Pedido pedido;
        string nomeCliente, email, status, nomeProduto;
        int diaNasc, mesNasc, anoNasc, qtdeProduto, n;
        double preco;

        Console.WriteLine("Dados do cliente: \n");
        Console.Write("Digite o nome do cliente: ");
        nomeCliente = Console.ReadLine();
        Console.Write("Digite o email do cliente: ");
        email = Console.ReadLine();
        Console.Write("Digite o dia de nascimento(DD): ");
        diaNasc = int.Parse(Console.ReadLine());
        Console.Write("Digite o mês de nascimento(MM): ");
        mesNasc = int.Parse(Console.ReadLine());
        Console.Write("Digite o ano de nascimento(YYYY): ");
        anoNasc = int.Parse(Console.ReadLine());

        DateTime dataNascimento = new DateTime(anoNasc, mesNasc, diaNasc);
        Cliente c = new Cliente(nomeCliente, email, dataNascimento);

        Console.WriteLine("\n\nDados do pedido: \n");
        Console.Write("Qual status do pedido(PagamentoPendente/Processando/Enviado/Entregue): ");
        status = Console.ReadLine();
        statusPedido = Enum.Parse<StatusPedido>(status);
        pedido = new Pedido(statusPedido);
        Console.Write("Digite a quantidade de itens do pedido: ");
        n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= n; i++)
        {
            Console.Write($"\nDigite o nome do {i}º produto: ");
            nomeProduto = Console.ReadLine();
            Console.Write($"Digite a quantidade do {i}º produto: ");
            qtdeProduto = int.Parse(Console.ReadLine());
            Console.Write($"Digite o preço do {i}º produto: ");
            preco = double.Parse(Console.ReadLine());
            item = new ItemPedido(nomeProduto, qtdeProduto, preco);
            pedido.AddItem(item);
        }

        Console.WriteLine("\n\nDados do cliente: \n");
        Console.WriteLine(c);
        Console.WriteLine("\nDados do pedido: ");
        pedido.listItem();
        Console.WriteLine(pedido);
    }
}
