using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLojaProdutos.Entities;
public class ProdutoImportado : Produto
{
    private double _taxaAlfandegaria;

    public double TaxaAlfandegaria { get => getTaxaAlfandegaria(); set => setTaxaAlfandegaria(value); }

    public ProdutoImportado()
    {
    }

    public ProdutoImportado(string nome, double preco, double taxaAlfandegaria) :base(nome, preco)
    {
        TaxaAlfandegaria = taxaAlfandegaria;
    }

    public override string EtiquetaPreco()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append(base.EtiquetaPreco());
        sb.Append($"   (Taxa alfandegária: R${TaxaAlfandegaria:F2})");
        return sb.ToString();
    }

    private double getTaxaAlfandegaria()
    {
        return _taxaAlfandegaria;
    }
    private void setTaxaAlfandegaria(double valor)
    {
        this._taxaAlfandegaria = valor;
    }
}
