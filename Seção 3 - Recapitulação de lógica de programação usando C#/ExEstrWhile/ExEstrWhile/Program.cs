using System;

namespace ExEstrWhile;

internal class Program
{
    static void Main(string[] args)
    {

        /*
            Exercicio 1 - Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
            incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
            impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.
        */

        /*
            int SenhaInserir, SenhaOficial = 2002;

            Console.Write("Insira a senha: ");
            SenhaInserir = int.Parse(Console.ReadLine());

            while(SenhaInserir != SenhaOficial)
            {
                Console.WriteLine("Senha inválida.");

                Console.Write("\nInsira a senha: ");
                SenhaInserir = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido.");
        */

        /*
            Exercício 2 - Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
            cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
            menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
        */

        /*
            int x, y;

            Console.Write("Digite a coordenada de X: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite a coordenada de Y: ");
            y = int.Parse(Console.ReadLine());

            while(x != 0 ||  y != 0)
            {
                if(x > 0 && y > 0)
                {
                    Console.WriteLine("\nPrimeiro quadrante");
                }
                else if(x < 0 && y > 0)
                {
                    Console.WriteLine("\nSegundo quadrante");
                }
                else if(x < 0 && y < 0)
                {
                    Console.WriteLine("\nTerceiro quadrante");
                }
                else if(x > 0 && y < 0)
                {
                    Console.WriteLine("\nQuarto quadrante");
                }
                else
                {
                    Environment.Exit(0);
                }

                Console.Write("\n\nDigite a coordenada de X: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Digite a coordenada de Y: ");
                y = int.Parse(Console.ReadLine());
        */

        /*
            Exercício 3 - Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
            que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
            mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
            exemplo. 
        */

        /*
            int op;
            int Alcool = 0;
            int Gasolina = 0;
            int Diesel = 0;


            Console.WriteLine("[1] - Álcool \n[2] - Gasolina \n[3] - Diesel \n[4] - Fim");
            Console.Write("\nDigite uma das opções acima: ");
            op = int.Parse(Console.ReadLine());

            while (op != 4)
            {
                switch (op)
                {
                    case 1:
                        Alcool += 1;
                        break;
                    case 2:
                        Gasolina += 1;
                        break;
                    case 3:
                        Diesel += 1;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\nCódigo inválido");
                        break;
                }
                Console.WriteLine("\n\n[1] - Álcool \n[2] - Gasolina \n[3] - Diesel \n[4] - Fim");
                Console.Write("\nDigite uma das opções acima: ");
                op = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nFim.");
			
            Console.WriteLine("\n\nÁlcool: " + Alcool);
            Console.WriteLine("\n\nGasolina: " + Gasolina);
            Console.WriteLine("\n\nDiesel: " + Diesel);
        */

    }
}
