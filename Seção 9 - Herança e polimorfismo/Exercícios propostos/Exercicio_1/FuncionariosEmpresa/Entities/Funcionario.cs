using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionariosEmpresa.Entities;
public class Funcionario
{
    private string _nome;
    private int _horas;
    private double _valorPorHora;

    public string Nome { get => getNome(); set => setNome(value); }
    public int Horas { get => getHoras(); set => setHoras(value); }
    public double ValorPorHora { get => getValorPorHora(); set => setValorPorHora(value); }

    public Funcionario()
    {
    }
    public Funcionario(string nome, int horas, double valorPorHora)
    {
        this.Nome = nome;
        this.Horas = horas;
        this.ValorPorHora = valorPorHora;
    }

    public virtual double CalculoPagamento()
    {
        return _valorPorHora * _horas;
    }
    private string getNome()
    {
        return _nome;
    }
    private void setNome(string valor)
    {
        this._nome = valor;
    }
    private int getHoras()
    {
        return _horas;
    }
    private void setHoras(int valor)
    {
        this._horas = valor;
    }
    private double getValorPorHora()
    {
        return _valorPorHora;
    }
    private void setValorPorHora(double valor)
    {
        this._valorPorHora = valor;
    }
}
