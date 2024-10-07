using ContratosFuncionarios.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratosFuncionarios.Entities.Models;
public class Funcionario
{
    private string _nome;
    private NivelFuncionario _nivel;
    private double _salario;
    private Departamento _departamento;
    public List<HorasContrato> Contratos = new List<HorasContrato>();

    public string Nome { get => getNome(); set => setNome(value); }
    public NivelFuncionario Nivel { get => getNivel(); set => setNivel(value); }
    public double Salario { get => getSalario(); set => setSalario(value); }
    public Departamento Departamento { get => getDepartamento(); set => setDepartamento(value); }

    public Funcionario()
    {
    }
    public Funcionario(string nome, NivelFuncionario nivel, double salario, Departamento departamento)
    {
        this.Nome = nome;
        this.Nivel = nivel;
        this.Salario = salario;
        this.Departamento = departamento;
    }

    public void AdicionarContrato(HorasContrato contrato)
    {
        Contratos.Add(contrato);
    }
    public void RemoverContrato(HorasContrato contrato)
    {
        Contratos.Remove(contrato);
    }
    public double CalcularRenda(int mes, int ano)
    {
        List<HorasContrato> buscarContrato = Contratos.FindAll(x => x.Data.Month == mes && x.Data.Year == ano);

        foreach (HorasContrato contrato in buscarContrato)
        {
            Salario += contrato.ValorTotalHoras();
        }
        return Salario;
    }

    private string getNome()
    {
        return _nome;
    }
    private void setNome(string valor)
    {
        this._nome = valor;
    }
    private NivelFuncionario getNivel()
    {
        return _nivel;
    }
    private void setNivel(NivelFuncionario valor)
    {
        this._nivel = valor;
    }
    private double getSalario()
    {
        return _salario;
    }
    private void setSalario(double valor)
    {
        this._salario = valor;
    }
    private Departamento getDepartamento()
    {
        return _departamento;
    }
    private void setDepartamento(Departamento valor)
    {
        this._departamento = valor;
    }
}
