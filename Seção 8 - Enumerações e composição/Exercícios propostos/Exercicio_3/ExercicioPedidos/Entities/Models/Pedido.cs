using ExercicioPedidos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPedidos.Entities.Models;
public class Pedido
{
    private DateTime Atual = DateTime.Now;
    private StatusPedido _status;
    private List<ItemPedido> listaItemPedido = new List<ItemPedido>();
    public StatusPedido Status { get => getStatus(); set => setStatus(value); }

    public Pedido(StatusPedido status)
    {
        this.Status = status;
    }

    public void AddItem(ItemPedido item)
    {
        listaItemPedido.Add(item);
    }
    public void RemoveItem(ItemPedido item)
    {
        listaItemPedido.Remove(item);
    }
    public void listItem()
    {
        int i = 0;

        foreach(ItemPedido item in listaItemPedido)
        {
            Console.WriteLine($"\nPedido #{i += 1}");
            Console.WriteLine($"\nNome do produto: {item.Nome}");
            Console.WriteLine($"Quantidade do produto: {item.Quantidade}");
            Console.WriteLine($"Preco do produto: R${item.Preco:F2}");
        }
    }
    private double Total()
    {
        double total = 0;

        foreach(ItemPedido item in listaItemPedido)
        {
            total += item.SubTotal();
        }

        return total;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"\nData/Horario da realização do pedido: {Atual.ToString("dd/MM/yyyy HH:mm:ss")}");
        sb.AppendLine($"\nStatus do pedido: {Status}");
        sb.AppendLine($"\nValor total do pedido: R${Total():F2}");
        return sb.ToString();
    }

    private StatusPedido getStatus()
    {
        return _status;
    }
    private void setStatus(StatusPedido valor)
    {
        this._status = valor;
    }
}
