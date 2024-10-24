using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionariosEmpresa.Entities;
public class FuncionarioTerceirizado : Funcionario
{
    private double _despesaAdicional;

    public double DespesaAdicional { get => getDespesaAdicional(); set => setDespesaAdicional(value); }

    public FuncionarioTerceirizado()
    {
    }
    public FuncionarioTerceirizado(string nome, int horas, double valorPorHora, double despesaAdicional) : base(nome, horas, valorPorHora)
    {
        this.DespesaAdicional = despesaAdicional;
    }

    public override double CalculoPagamento()
    {
        return base.CalculoPagamento() + 1.1 * DespesaAdicional;
    }

    private double getDespesaAdicional()
    {
        return _despesaAdicional;
    }
    private void setDespesaAdicional(double valor)
    {
        this._despesaAdicional = valor;
    }
}
