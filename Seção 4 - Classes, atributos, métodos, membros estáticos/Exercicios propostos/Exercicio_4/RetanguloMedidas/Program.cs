namespace RetanguloMedidas;

internal class Program
{
    static void Main(string[] args)
    {
        Retangulo r = new Retangulo();

        Console.Write("Digite a largura do retângulo: ");
        r.Largura = double.Parse(Console.ReadLine());
        Console.Write("Digite a altura do retângulo: ");
        r.Altura = double.Parse(Console.ReadLine());

        Console.WriteLine("\nDados: \n");
        Console.WriteLine(r);
    }
}
