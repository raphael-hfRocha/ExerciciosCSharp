using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratosFuncionarios.Entities.Models;
public class HorasContrato
{
    private DateTime _data;
    private double _valorPorHora;
    private int _horas;

    public DateTime Data { get => getData(); set => setData(value); }
    public double ValorPorHora { get => getValorPorHora(); set => setValorPorHora(value); }
    public int Horas { get => getHoras(); set => setHoras(value); }

    public HorasContrato(DateTime data, double valorPorHora, int horas)
    {
        this.Data = data;
        this.ValorPorHora = valorPorHora;
        this.Horas = horas;
    }

    public double ValorTotalHoras()
    {
        return Horas * ValorPorHora;
    }

    private DateTime getData()
    {
        return _data;
    }
    private void setData(DateTime valor)
    {
        _data = valor;
    }
    private double getValorPorHora()
    {
        return _valorPorHora;
    }
    private void setValorPorHora(double valor)
    {
        _valorPorHora = valor;
    }
    private int getHoras()
    {
        return _horas;
    }
    private void setHoras(int valor)
    {
        _horas = valor;
    }
}
