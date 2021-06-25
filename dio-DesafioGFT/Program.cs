using System;

namespace dio_DesafioGFT
{
    class Program
    {
        static void Main(string[] args)
        {
            SomaSimples();
            //DividindoXPorY();
        }

        protected static void SomaSimples()
        {
            //Desafio
            //Leia dois valores inteiros identificados como variáveis A e B.Calcule a soma entre elas e chame essa variável de 
            //SOMA.
            //A seguir escreva o valor desta variável.

            //Entrada
            //O arquivo de entrada contém 2 valores inteiros.

            //Saída
            //Imprima a variável SOMA com todas as letras maiúsculas, inserindo um espaço em branco antes e depois do símbolo de
            //igualdade, seguido pelo valor correspondente à soma de A e B.

            //Declare Variables
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());

            //Insira as variaveis de acordo com o solicitado
            int SOMA = A + B;

            //Print
            Console.WriteLine("SOMA = {0}", SOMA);
        }

        protected static void DividindoXPorY()
        {
            //Desafio
            //Você terá o desafio de escrever um algoritmo que leia 2 números e imprima o resultado da divisão do primeiro pelo segundo.
            //Caso não for possível, mostre a mensagem “divisao impossivel” para os valores em questão.

            //Entrada
            //A entrada contém um número inteiro N.Este N será a quantidade de pares de valores inteiros(X e Y) que serão lidos em seguida.

            //Saída
            //Para cada caso mostre o resultado da divisão com um dígito após o ponto decimal, ou “divisao impossivel” caso não seja
            //possível efetuar o cálculo.

            int limit = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < limit; i++)
            {
                string[] line = Console.ReadLine().Split(" ");
                double X = double.Parse(line[0]);
                double Y = line.Length > 1 ? double.Parse(line[1]) : 0;
                if (Y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double divisao = X / Y; // Digite aqui o calculo da divisao
                    Console.WriteLine(divisao.ToString("N1"));
                }
            }
        }
    }
}
