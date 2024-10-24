using ExercicioStringBuilder.Entities.Models;

namespace ExercicioStringBuilder;

internal class Program
{
    static void Main(string[] args)
    {
        Post p;
        Comment c = new Comment();
        string title, content, comment;
        int like, qtde;

        Console.Write("Digite um título para a publicação: ");
        title = Console.ReadLine();
        Console.Write("Coloque o conteúdo da publicação: ");
        content = Console.ReadLine();
        Console.Write("Coloque a quantidade de likes: ");
        like = int.Parse(Console.ReadLine());
        p = new Post(title, content, like);
        Console.Write("Digite a quantidade de comentários: ");
        qtde = int.Parse(Console.ReadLine());

        Console.WriteLine("\n");
        for(int i = 1; i <= qtde; i++)
        {
            Console.Write($"\nDigite o {i}º comentario: ");
            c.Text = Console.ReadLine();
            p.AddComment(c);
        }

        Console.WriteLine("\n");

        Console.WriteLine(p);

    }
}
