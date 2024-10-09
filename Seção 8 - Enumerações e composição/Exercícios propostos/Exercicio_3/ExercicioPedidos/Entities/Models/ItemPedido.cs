using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPedidos.Entities.Models;
public class ItemPedido
{
    private string _nome;
    private int _quantidade;
    private double _preco;

    public string Nome { get => getNome(); set => setNome(value); }
    public int Quantidade { get => getQuantidade(); set => setQuantidade(value); }
    public double Preco { get => getPreco(); set => setPreco(value); }

    public ItemPedido()
    {
    }
    public ItemPedido(string nome, int quantidade, double preco)
    {
        this.Nome = nome;
        this.Quantidade = quantidade;
        this.Preco = preco;
    }

    public double SubTotal()
    {
        return _preco * _quantidade;
    }

    private string getNome()
    {
        return _nome;
    }
    private void setNome(string valor)
    {
        this._nome = valor;
    }
    private int getQuantidade()
    {
        return _quantidade;
    }
    private void setQuantidade(int valor)
    {
        this._quantidade = valor;
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