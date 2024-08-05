using System.Xml.Linq;
using System.Globalization;

namespace ExEstrFor;

internal class Program
{
    static void Main(string[] args)
    {
        /*
            Exercicios 1 - Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
            X, se for o caso.
            
                
                int x;
                Console.Write("Insira o valor de X: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("\n");
        
                for(int i = 0; i <= x; i++)
                {
                    if(!(i % 2 == 0))
                    {
                        Console.WriteLine(i);
                    }
                }


        */



        /*
            Exercício 2 - Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
            essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).    
                
        
        
                int x, n, count_in = 0, count_out = 0;

                Console.Write("Digite o limite máximo de repetições: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("\n");

                for(int i = 1; i <= x; i++)
                {
                    Console.Write("Digite um numero: ");
                    n = int.Parse(Console.ReadLine());

                    if(n >= 10 && n <= 20)
                    {
                        count_in++;
                    }
                    else
                    {
                        count_out++;
                    }
                }

                Console.WriteLine(\ncount_in + " in");
                Console.WriteLine(count_out + " out");
            }    
        */




        /*
            Exercício 3 - Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
            de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
            conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
            peso 5.



                int numCaso;
                double media;

                Console.Write("Digite o numero de casos: ");
                numCaso = int.Parse(Console.ReadLine());
                Console.WriteLine("\n---------------------------------");

                for (int i = 0; i < numCaso; i++)
                {
                    Console.Write("\n\nDigite o primeiro valor: ");
                    double v1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Digite o segundo valor: ");
                    double v2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Digite o terceiro valor: ");
                    double v3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    media = (v1 * 2.0 + v2 * 3.0 + v3 * 5.0) / 10.0;

                    if(v1 == 0 || v2 == 0 || v3 == 0)
                    {
                        media = 0.0;
                        Console.WriteLine("\nMedia: " + media.ToString("F1", CultureInfo.InvariantCulture));
                        Console.WriteLine("\n---------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("\nMedia: " + media.ToString("F1", CultureInfo.InvariantCulture));
                        Console.WriteLine("\n---------------------------------");
                    }

                } 
        */



        /*
            Exercício 4 - Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
            segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel". 





            int n;
            double numerador, denominador, divisao;

            Console.Write("Digite a quantidade de vezes: ");
            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("\n---------------------------------");
                Console.Write("\nDigite o numerador: ");
                numerador = double.Parse(Console.ReadLine());
                Console.Write("Digite o denominador: ");
                denominador = double.Parse(Console.ReadLine());

                divisao = numerador / denominador;

                if(denominador == 0)
                {
                    Console.WriteLine("Divisão impossível");
                }
                else
                {
                    Console.WriteLine($"\nO resultado da {i}ª divisão é: {divisao:F1}");
                }

            }

            Console.WriteLine("\n---------------------------------");

        */



        /*
            Exercício 5 - Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
            Lembrando que, por definição, fatorial de 0 é 1. 
            
        
        
        
            int n, i, fatorial;

            Console.Write("Digite um numero: ");
            n = int.Parse(Console.ReadLine());

            fatorial = 1;

            for (i = 1; i <= n; i++)
            {
                fatorial = fatorial * i;
            }

            Console.WriteLine($"\n\nValor de saída: {fatorial}");
        */


        /*
             Exercicio 6 - Ler um número inteiro N e calcular todos os seus divisores.
            


            int n;

            Console.Write("Digite o valor de n: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n\nDivisores de {n}: ");

            for (int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
       
        */

        /*
            Exercicio 07 - Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
            começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
            exemplo. 
            
        
        
            int n;


            Console.Write("Digite o valor de n: ");
            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                double quadrado = Math.Pow(i, 2);
                double cubo = Math.Pow(i, 3);
                Console.WriteLine($"{i}   {quadrado}   {cubo}");
            }
        */


    }
}
