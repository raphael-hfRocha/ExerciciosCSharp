using System.Collections.Generic;

namespace EstrCond;

internal class Program
{
    static void Main(string[] args)
    {
        /*
            Exercício 01 - Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
        */
        /*
            int num;

            Console.Write("Digite um numero: ");
            num = int.Parse(Console.ReadLine());

            if(num >= 0)
            {
                Console.WriteLine("\nO número digitado é positivo.");
            }
            else
            {
                Console.WriteLine("\nO numero digitado é negativo.");
            }
        */

        /*
            Exercicio 2 - Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar. 
        */

        /*
            int numero;

            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            if(numero % 2 == 0)
            {
                Console.WriteLine("\nÉ um número par.");
            }
            else
            {
                Console.WriteLine("\nÉ um número impar.");
            } 
        */

        /*
            Exercício 3 - Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
            Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
            ordem crescente ou decrescente. 
        */

        /*
            int a, b;

            Console.Write("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());

            if(b % a == 0 || a % b == 0)
            {
                Console.WriteLine("\nOs numeros informados são multiplos");
            }
            else
            {
                Console.WriteLine("\nOs numeros informados não são multiplos");
            }
        */

        /*
            Exercício 04 - Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
            começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas. 
        */


        /**/



        /*
            Exercício 05 - Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
            seguir, calcule e mostre o valor da conta a pagar.
        */

        /*
            int Codigo, Quantidade;
            double Total;
            string valor;

            Dictionary<int, string> Menu = new Dictionary<int, string>()
                {
                    { 1, "Cachorro Quente" },
                    { 2, "X-Salada" },
                    { 3, "X-Bacon" },
                    { 4, "Torrada Simples" },
                    { 5, "Refrigerante" },
                };


            Console.Write("Digite o código do item: ");
            Codigo = int.Parse(Console.ReadLine());


            if (Menu.ContainsKey(Codigo))
            {
                Console.Write("Digite a quantidade do item escolhido: ");
                Quantidade = int.Parse(Console.ReadLine());

                if (Codigo == 1)
                {
                    valor = Menu[Codigo];
                    Console.WriteLine($"\nItem escolhido: {valor}");
                    Total = Quantidade * 4.0;
                    Console.WriteLine($"O valor total é: R${Total:F2}");
                }
                else if (Codigo == 2)
                {
                    valor = Menu[Codigo];
                    Console.WriteLine($"\nItem escolhido: {valor}");
                    Total = Quantidade * 4.5;
                    Console.WriteLine($"O valor total é: R${Total:F2}");
                }
                else if (Codigo == 3)
                {
                    valor = Menu[Codigo];
                    Console.WriteLine($"\nItem escolhido: {valor}");
                    Total = Quantidade * 5.0;
                    Console.WriteLine($"O valor total é: R${Total:F2}");
                }
                else if (Codigo == 4)
                {
                    valor = Menu[Codigo];
                    Console.WriteLine($"\nItem escolhido: {valor}");
                    Total = Quantidade * 2.0;
                    Console.WriteLine($"O valor total é: R${Total:F2}");
                }
                else if (Codigo == 5)
                {
                    valor = Menu[Codigo];
                    Console.WriteLine($"\nItem escolhido: {valor}");
                    Total = Quantidade * 1.5;
                    Console.WriteLine($"O valor total é: {Total:F2}");
                }
            }
            else
            {
                Console.WriteLine("\nCódigo inválido.");
            }
        */
    }
}
