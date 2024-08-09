using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1;
internal class Pessoa
{
    public string Nome;
    public int Idade;

    
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }


    public override string ToString()
    {
        return $"\nNome: {Nome} \nIdade: {Idade}";
    }

}
