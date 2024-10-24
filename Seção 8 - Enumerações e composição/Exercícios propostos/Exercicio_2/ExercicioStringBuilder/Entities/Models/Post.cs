using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioStringBuilder.Entities.Models;
public class Post
{
    private DateTime Moment = DateTime.Now;
    private string _title;
    private string _content;
    private int _like;
    public List<Comment> Comments = new List<Comment>();

    public string Title { get => getTitle(); set => setTitle(value); }
    public string Content { get => getContent(); set => setContent(value); }
    public int Like { get => getLike(); set => setLike(value); }

    public Post(string title, string content, int like)
    {
        this.Title = title;
        this.Content = content;
        this.Like = like;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine(Title);
        sb.Append(Like);
        sb.Append(" - ");
        sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
        sb.AppendLine(Content);
        sb.AppendLine("\nComments: \n");
        foreach(Comment c in Comments)
        {
            sb.AppendLine(c.Text);
        }

        return sb.ToString();
    }

    private string getTitle()
    {
        return _title;
    }
    private void setTitle(string valor)
    {
        this._title = valor;
    }
    private string getContent()
    {
        return _content;
    }
    private void setContent(string valor)
    {
        this._content = valor;
    }
    private int getLike()
    {
        return _like;
    }
    private void setLike(int valor)
    {
        this._like = valor;
    }
}
