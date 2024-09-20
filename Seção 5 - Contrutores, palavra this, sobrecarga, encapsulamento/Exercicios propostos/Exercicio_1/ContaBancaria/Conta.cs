using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria;
public class Conta
{
    private int _numeroConta;
    private string _titular;
    private double _saldoInicial;
        
    public int NumeroConta { get => getNumeroConta(); set => setNumeroConta(value); }
    public string Titular { get => getTitular(); set => setTitular(value); }
    public double SaldoInicial { get => getSaldoInicial(); set => setSaldoInicial(value); }

    public Conta(int numeroConta, string titular, double saldoInicial)
    {
        this.NumeroConta = numeroConta;
        this.Titular = titular;
        this.SaldoInicial = saldoInicial;
    }

    public Conta(int numeroConta, string titular)
    {
        this.NumeroConta = numeroConta;
        this.Titular = titular;
    }

    public void Deposito(double quantia)
    {
        SaldoInicial += quantia;
    }
    public void Saque(double quantia)
    {
        SaldoInicial -= quantia;
    }
    public override string ToString()
    {
        return $"Conta: {NumeroConta} \nTitular: {Titular} \nSaldo: R${SaldoInicial:F2}";
    }

    private int getNumeroConta()
    {
        return _numeroConta;
    }
    private void setNumeroConta(int numeroConta)
    {
        this._numeroConta = numeroConta;
    }
    private string getTitular()
    {
        return _titular;
    }
    private void setTitular(string titular)
    {
        this._titular = titular;
    }
    private double getSaldoInicial()
    {
        return _saldoInicial;
    }
    private void setSaldoInicial(double saldoInicial)
    {
        this._saldoInicial = saldoInicial;
    }
}
