using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemFuncionarios;
public class Funcionario
{
    private int _id;
    private string _nome;
    private double _salario;

    public int Id { get => getId(); private set => setId(value); }
    public string Nome { get => getNome(); private set => setNome(value); }
    public double Salario { get => getSalario(); private set => setSalario(value); }

    public Funcionario(int id, string nome, double salario)
    {
        Id = id;
        Nome = nome;
        Salario = salario;
    }

    public void AumentoSalario(double porcentagem)
    {
        Salario += (Salario * (porcentagem / 100));
    }

    private int getId()
    {
        return _id;
    }
    private void setId(int id)
    {
        this._id = id;
    }
    private string getNome()
    {
        return _nome;
    }
    private void setNome(string nome)
    {
        this._nome = nome;
    }
    private double getSalario()
    {
        return _salario;
    }
    private void setSalario(double salario)
    {
        this._salario = salario;
    }
}
