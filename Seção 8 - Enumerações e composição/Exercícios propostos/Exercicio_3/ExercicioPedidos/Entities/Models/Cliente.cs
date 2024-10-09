using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPedidos.Entities.Models;
public class Cliente
{
    private string _nome;
    private string _email;
    private DateTime _dataNascimento;

    public string Nome { get => getNome(); set => setNome(value); }
    public string Email { get => getEmail(); set => setEmail(value); }
    public DateTime DataNascimento { get => getDataNascimento(); set => setDataNascimento(value); }
    
    public Cliente(string nome, string email, DateTime dataNascimento)
    {
        this.Nome = nome;
        this.Email = email;
        this.DataNascimento = dataNascimento;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"Nome do cliente: {Nome}");
        sb.AppendLine($"\nData de nascimento: {DataNascimento:d}");
        sb.AppendLine($"\nE-mail: {Email}");

        return sb.ToString();
    }

    private string getNome()
    {
        return _nome;
    }
    private void setNome(string valor)
    {
        this._nome = valor;
    }
    private string getEmail()
    {
        return _email;
    }
    private void setEmail(string valor)
    {
        this._email = valor;
    }
    private DateTime getDataNascimento()
    {
        return _dataNascimento;
    }
    private void setDataNascimento(DateTime valor)
    {
        this._dataNascimento = valor;
    }
}
