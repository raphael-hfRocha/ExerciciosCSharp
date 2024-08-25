namespace ConversorMoeda;

class Program
{
    static void Main(string[] args)
    {
        /*
            Exercício 5 - Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado 
            por uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda
            que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda
            para ser responsável pelos cálculos.
        */

        double cotacao, precoDolar;

        Console.Write("Digite o valor da cotação em dolar: ");
        cotacao = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor do dolar que deseja comprar: ");
        precoDolar = double.Parse(Console.ReadLine());

        Console.WriteLine($"\nCotação do dolar: {cotacao:F2}");
        Console.WriteLine($"Valor do dolar que deseja comprar: {precoDolar:F2}");
        Console.WriteLine($"Valor a ser pago em reais: {ConversorDeMoeda.CalculoCompraDolar(cotacao, precoDolar):F2}");


    }
}
