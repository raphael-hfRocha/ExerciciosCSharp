using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoEstoque;
public class Produto
{
    public string Nome;
    public double Preco;
    public int QtdEstoque;

    public double ValorTotalEmEstoque()
    {
        return Preco * QtdEstoque;
    }

    public void AddProdutoEstoque(int addProduto)
    {
        QtdEstoque += addProduto;
    }

    public void DelProdutoEstoque(int delProduto)
    {
        QtdEstoque -= delProduto;
    }
    /*
        public int AddProdutoEstoque(int addProduto)
        {
            return QtdEstoque += addProduto;
        }

        public int DelProdutoEstoque(int delProduto)
        {
            return QtdEstoque -= delProduto;
        }
    */
    public override string ToString()
    {
        return $"\n\nNome: {Nome} \nPreço: R${ValorTotalEmEstoque():F2} \nQuantidade em estoque: {QtdEstoque}";
    }
}
