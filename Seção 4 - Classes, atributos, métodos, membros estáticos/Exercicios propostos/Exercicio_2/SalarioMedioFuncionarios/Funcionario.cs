using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioMedioFuncionarios;
public class Funcionario
{
    public string Nome;
    public double Salario;

    public override string ToString()
    {
        return $"\nNome: {Nome} \nSalario: {Salario:F2}";
    }


    /*
        private string _nome;
        private double _salario;
   

        public string Nome { get => getNome(); set => setNome(value); }
        public double Salario { get => getSalario(); set => setSalario(value); }

        public Funcionario()
        {
        }

        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public string getNome()
        {
            return _nome;
        }
        public void setNome(string value)
        {
            this._nome = value;
        }
        public double getSalario()
        {
            return _salario;
        }
        public void setSalario(double value)
        {
            this._salario = value;
        }
    */
}