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

    public void AddProdutoEstoque(int addProduto)
    {
        QtdEstoque = QtdEstoque + addProduto;
    }

    public void DelProdutoEstoque(int delProduto)
    {
        QtdEstoque = QtdEstoque - delProduto;
    }
}
