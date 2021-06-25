using System;

namespace dio_DesafioGFT
{
    class Program
    {
        static void Main(string[] args)
        {
            Media1();
            //SomaSimples();
            //DividindoXPorY();
        }

        protected static void Media1()
        {
            //Desafio
            //Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas de um aluno. A seguir, calcule a média do
            //aluno, sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5(A soma dos pesos portanto é 11).Assuma que cada nota pode ir 
            //de 0 até 10.0, sempre com uma casa decimal.

            //Entrada
            //O arquivo de entrada contém 2 valores com uma casa decimal cada um.

            //Saída
            //Calcule e imprima a variável MEDIA conforme exemplo abaixo, com 5 dígitos após o ponto decimal e com um espaço em branco antes 
            //e depois da igualdade. Utilize variáveis de dupla precisão(double) e como todos os problemas, não esqueça de imprimir o fim de
            //linha após o resultado, caso contrário, você receberá "Presentation Error".

            double a, b, mediaP;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());

            //complete com as variaveis
            mediaP = ((a * 3.5) + (b *7.5)) / (3.5 + 7.5);

            Console.WriteLine("MEDIA = {0}", mediaP.ToString("0.00000"));
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
