using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLojaProdutos.Entities;
public class ProdutoUsado : Produto
{
    private DateTime _dataFabricacao;

    public DateTime DataFabricacao { get => getDataFabricacao(); set => setDataFabricacao(value); }

    public ProdutoUsado()
    {
    }
    public ProdutoUsado(string nome, double preco, DateTime dataFabricacao) :base(nome, preco)
    {
        DataFabricacao = dataFabricacao;
    }

    public override string EtiquetaPreco()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append(base.EtiquetaPreco());
        sb.Append($"   (Data fabricação: {DataFabricacao.ToString("d")})");
        return sb.ToString();
    }

    private DateTime getDataFabricacao()
    {
        return _dataFabricacao;
    }
    private void setDataFabricacao(DateTime valor)
    {
        this._dataFabricacao = valor;
    }
}