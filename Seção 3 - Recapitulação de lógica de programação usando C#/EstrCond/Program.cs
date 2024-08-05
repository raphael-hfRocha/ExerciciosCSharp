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
            
        
            string HorarioInicial, HorarioFinal;

            Console.Write("Digite a hora inicial (Digite no formato de 24 horas como hh:mm): ");
            HorarioInicial = Console.ReadLine();
            Console.Write("Digite a hora final(Digite no formato de 24 horas como hh:mm): ");
            HorarioFinal = Console.ReadLine();


            TimeSpan HorarioInicialConvert = TimeSpan.Parse(HorarioInicial);
            TimeSpan HorarioFinalConvert = TimeSpan.Parse(HorarioFinal);
            TimeSpan DuracaoHora;

            if(HorarioFinalConvert > HorarioInicialConvert)
            {
                DuracaoHora = HorarioFinalConvert - HorarioInicialConvert;
                Console.WriteLine($"\n\nO jogo teve duração de: {DuracaoHora.ToString("hh:mm")}");
            }
            else
            {
                DuracaoHora = (TimeSpan.FromHours(24) - HorarioInicialConvert) + HorarioFinalConvert;
                Console.WriteLine($"\n\nO jogo teve duração de: {DuracaoHora}");
            }
        */

        /*
            DuracaoHora = HoraInicial - HoraFinal;

        if (DuracaoHora != 0)
        {
            if (DuracaoHora < 0)
            {
                DuracaoHora = DuracaoHora * -1;
                Console.WriteLine($"O jogo durou {DuracaoHora} hora(s)");
            }
            else
            {
                Console.WriteLine($"O jogo durou {DuracaoHora} hora(s)");
            }
        }
        else
        {
            Console.WriteLine("O jogo durou 24 hora(s).");
        }
        */



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

        /*
            Exercicio 06 - Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
            seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
            nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”. 
        */

        /*
            double num;

            Console.Write("Digite um numero: ");
            num = double.Parse(Console.ReadLine());

            if(num >= 0 && num <= 25)
            {
                Console.WriteLine("\nIntervalo [0, 25]");
            }
            else if(num >= 25 && num <= 50)
            {
                Console.WriteLine("\nIntervalo [25, 50]");
            }
            else if (num >= 50 && num <= 75)
            {
                Console.WriteLine("\nIntervalo [50, 75]");
            }
            else if (num >= 75 && num <= 100)
            {
                Console.WriteLine("\nIntervalo [75, 100]");
            }
            else
            {
                Console.WriteLine("\nFora de intervalo");
            }             
        */

        /*
            Exercício 7 - Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
            de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
            ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
            Se o ponto estiver na origem, escreva a mensagem “Origem”.
            Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
            situação. 
        */

        /* 
             double x, y;

             Console.Write("Digite o valor de X: ");
             x = double.Parse(Console.ReadLine());
             Console.Write("Digite o valor de Y: ");
             y = double.Parse(Console.ReadLine());


             if (x == 0 && y == 0)
             {
                 Console.WriteLine("\nOrigem");
             }
             else if (x > 0 && y > 0)
             {
                 Console.WriteLine("\nQ1");
             }
             else if (x > 0 && y < 0)
             {
                 Console.WriteLine("\nQ4");
             }
             else if (x < 0 && y < 0)
             {
                 Console.WriteLine("\nQ3");
             }
             else if (x < 0 && y > 0)
             {
                 Console.WriteLine("\nQ2");
             }
        */


        /*
            Exercício 8 - Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
            que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
            qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.

            Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
            mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
            


            Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de
            salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é
            de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com
            duas casas decimais.
        */


        /*
            double Salario, Imposto, ValorDescontadoImposto;

            Console.Write("Digite um salario de um funcionario em Lisarb: ");
            Salario = double.Parse(Console.ReadLine());

            if (Salario >= 0.00 && Salario <= 2000.00)
            {
                Console.WriteLine("\nO funcionário isento.");
            }
            else if (Salario >= 2000.01 && Salario <= 3000.00)
            {
                Imposto = (Salario - 2000) * 0.08;

                Console.WriteLine("\nImposto 8%");
                Console.WriteLine($"\nO valor de imposto a ser cobrado é: R${Imposto:F2}");
            }
            else if (Salario >= 3000.01 && Salario <= 4500.00)
            {
                double ImpostoPrimeiraParte, ImpostoSegundaParte, Diferenca, SomaTotalImpostos;


                ImpostoPrimeiraParte = 1000 * 0.08;
                Diferenca = Salario - 3000;
                ImpostoSegundaParte = Diferenca * 0.18;
                SomaTotalImpostos = ImpostoPrimeiraParte + ImpostoSegundaParte;
                Console.WriteLine("\nImposto 18%");
                Console.WriteLine($"\nO valor de imposto a ser cobrado é: R${SomaTotalImpostos:F2}");

            }
            else if (Salario > 4500.00)
            {
                double ImpostoPrimeiraParte, ImpostoSegundaParte, ImpostoTerceiraParte, Diferenca, SomaTotalImpostos;

                ImpostoPrimeiraParte = 1500 * 0.18;
                Diferenca = Salario - 4500;
                ImpostoSegundaParte = Diferenca * 0.28;
                ImpostoTerceiraParte = 1000 * 0.08;
                SomaTotalImpostos = ImpostoPrimeiraParte + ImpostoSegundaParte + ImpostoTerceiraParte;
                Console.WriteLine("\nImposto 18%");
                Console.WriteLine($"\nO valor de imposto a ser cobrado é: R${SomaTotalImpostos:F2}");

            }
        */
    }
}
