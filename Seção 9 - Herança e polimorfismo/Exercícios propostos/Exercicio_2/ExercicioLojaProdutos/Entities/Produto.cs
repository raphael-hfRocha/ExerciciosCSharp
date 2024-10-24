using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLojaProdutos.Entities;
public class Produto
{
    private string _nome;
    private double _preco;

    public string Nome { get => getNome(); set => setNome(value); }
    public double Preco { get => getPreco(); set => setPreco(value); }

    public Produto()
    {
    }
    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public virtual string EtiquetaPreco()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append($"\n{Nome}");
        sb.Append($"  R${Preco:F2}");

        return sb.ToString();
    }
    private string getNome()
    {
        return _nome;
    }
    private void setNome(string valor)
    {
        this._nome = valor;
    }
    private double getPreco()
    {
        return _preco;
    }
    private void setPreco(double valor)
    {
        this._preco = valor;
    }
}
