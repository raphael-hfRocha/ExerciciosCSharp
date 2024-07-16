namespace ExEstrSeq;

public class Program
{
    static void Main(string[] args)
    {
        /*
            Exercícios sobre Estrutura Sequencial (entrada, processamento, saída)
         */


        /*
            Exercício 01 - Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
            mensagem explicativa, conforme exemplos.    
        */
        /*
            int num1, num2, soma;

            Console.Write($"Digite o primeiro número a ser somado: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write($"Digite o segundo número a ser somado: ");
            num2 = int.Parse(Console.ReadLine());


            soma = num1 + num2;


            Console.WriteLine($"A soma dos números é igual a: {soma}");

        */



        /*
            Exercício 02 - Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
            casas decimais conforme exemplos.

            Fórmula da área: area = π . raio2
            Considere o valor de π = 3.14159
        */

        /*
            double area, raio;

            double pi = 3.14159;


            Console.Write("Digite o numero do raio: ");
            raio = double.Parse(Console.ReadLine());

            area = pi * (Math.Pow(raio, 2));

            Console.WriteLine($"A area do círculo é: {area:F4}");
        */

        /*
            Exercício 03 - Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
            de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
        */

        /*
            int A, B, C, D, diferenca;


            Console.Write("Digite o numero de A: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o numero de B: ");
            B = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o numero de C: ");
            C = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o numero de D: ");
            D = int.Parse(Console.ReadLine());


            diferenca = (A * B) - (C * D);


            Console.WriteLine($"\n\nA diferença do produto de A e B pelo produto de C e D segundo a fórmula é: {diferenca}");
         */


        /*
            Exercício 04 - Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
            hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
            decimais.
        */

        /*
            int NumFuncionario;
            double HorasTrabalhadas, ValorHora, Salario;


            Console.Write("Digite o número do funcionario: ");
            NumFuncionario = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a quantidade de horas trabalhadas pelo funcionário: ");
            HorasTrabalhadas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor por hora: "); 
            ValorHora = Convert.ToDouble(Console.ReadLine());


            Salario = ValorHora * HorasTrabalhadas;

            Console.WriteLine($"\nNumero do funcionário: {NumFuncionario}");
            Console.WriteLine($"Salario do funcionário: R${Salario:F2}");
        */



        /*
            Exercicio 05 - Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
            código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
         */
        /*

                int CodigoPeca, NumeroPecas, QuantidadePecas;
                double ValorUnitario, ValorTotal;


                Console.Write("Digite a quantidade de produto a cadastrar: ");
                QuantidadePecas = int.Parse(Console.ReadLine());

                for(int i = 1; i <= QuantidadePecas; i++)
                {
                    Console.Write($"\n\nDigite o código da {i}ª peça: ");
                    CodigoPeca = int.Parse(Console.ReadLine());
                    Console.Write($"Digite o numero de peças da {i}ª peça: ");
                    NumeroPecas = int.Parse(Console.ReadLine());
                    Console.Write($"Digite o valor unitário de cada peça da {i}ª peça: ");
                    ValorUnitario = double.Parse(Console.ReadLine());

                    ValorTotal = ValorUnitario * NumeroPecas;
                    Console.WriteLine($"\nValor total da {i} peça: R${ValorTotal:F2}\n\n");
                }


                int CodigoPeca1, CodigoPeca2, NumeroPecas1, NumeroPecas2;
                double ValorUnitario1, ValorUnitario2, ValorTotalPecas1, ValorTotalPecas2, ValorTotal;

                Console.Write($"Digite o código da 1ª peça: ");
                CodigoPeca1 = int.Parse(Console.ReadLine());
                Console.Write($"Digite o numero de peças da 1ª peça: ");
                NumeroPecas1 = int.Parse(Console.ReadLine());
                Console.Write($"Digite o valor unitário de cada peça da 1ª peça: ");
                ValorUnitario1 = double.Parse(Console.ReadLine());

                ValorTotalPecas1 = ValorUnitario1 * NumeroPecas1;

                Console.Write($"\n\nDigite o código da 2ª peça: ");
                CodigoPeca2 = int.Parse(Console.ReadLine());
                Console.Write($"Digite o numero de peças da 2ª peça: ");
                NumeroPecas2 = int.Parse(Console.ReadLine());
                Console.Write($"Digite o valor unitário de cada peça da 2ª peça: ");
                ValorUnitario2 = double.Parse(Console.ReadLine());

                ValorTotalPecas2 = ValorUnitario2 * NumeroPecas2;


                ValorTotal = ValorTotalPecas1 + ValorTotalPecas2;
                Console.WriteLine($"\nValor total: R${ValorTotal:F2}\n\n");
        */


        /*
            Exercício 06 - Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
            mostre:
            a) a área do triângulo retângulo que tem A por base e C por altura.
            b) a área do círculo de raio C. (pi = 3.14159)
            c) a área do trapézio que tem A e B por bases e C por altura.
            d) a área do quadrado que tem lado B.
            e) a área do retângulo que tem lados A e B.
         */

        /*
            double a, b, c, AreaTriangulo, AreaCirculo, AreaTrapezio, AreaQuadrado, AreaRetangulo;
            double pi = 3.14159;

            Console.Write("Digite o valor de A: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            b = double.Parse(Console.ReadLine()); 
            Console.Write("Digite o valor de C: ");
            c = double.Parse(Console.ReadLine());

            AreaTriangulo = (a * c) / 2;
            AreaCirculo = pi * (Math.Pow(c, 2));
            AreaTrapezio = (a + b) * c / 2;
            AreaQuadrado = b * 4;
            AreaRetangulo = a * b;


            Console.WriteLine($"\n\nÁrea do triângulo retângulo: {AreaTriangulo:F3}");
            Console.WriteLine($"Área do circulo: {AreaCirculo:F3}");
            Console.WriteLine($"Área do trapézio: {AreaTrapezio:F3}");
            Console.WriteLine($"Área do quadrado: {AreaQuadrado:F3}");
            Console.WriteLine($"Área do retângulo: {AreaRetangulo:F3}");
         */


    }
}
