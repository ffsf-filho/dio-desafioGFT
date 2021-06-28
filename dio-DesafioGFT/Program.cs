using System;

namespace dio_DesafioGFT
{
    class Program
    {
        static void Main(string[] args)
        {
            FormulaDeBaskara();
            //TiposDeTriangulos();
            //NotasEMoedas();
            //Media1();
            //SomaSimples();
            //DividindoXPorY();
        }

        protected static void FormulaDeBaskara()
        {
            //Desafio
            //Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. Se não for possível 
            //calcular as raízes, mostre a mensagem correspondente “Impossivel calcular”, caso haja uma divisão por 0 ou raiz de 
            //numero negativo.

            //Entrada
            //Leia três valores de ponto flutuante(double) A, B e C.

            //Saída
            //Se não houver possibilidade de calcular as raízes, apresente a mensagem "Impossivel calcular".Caso contrário, 
            //imprima o resultado das raízes com 5 dígitos após o ponto, com uma mensagem correspondente conforme exemplo abaixo.
            //Imprima sempre o final de linha após cada mensagem.

            double a, b, c, delta, r1, r2;
            string[] valor = Console.ReadLine().Split();

            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);

            delta = (Math.Pow(b, 2) - (4 * a * c));
            r1 = (-b + Math.Sqrt(delta)) / (2 * a);
            r2 = (-b - Math.Sqrt(delta)) / (2 * a);

            if (a != 0 && delta > 0)
            {
                Console.WriteLine($"R1 = {r1.ToString("F5")}");
                Console.WriteLine($"R2 = {r2.ToString("F5")}");
            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }
        }

        protected static void TiposDeTriangulos()
        {
            //Desafio
            //Leia 3 valores de ponto flutuante A, B e C e ordene - os em ordem decrescente, de modo que o lado A representa o maior dos 3 
            //lados.A seguir, determine o tipo de triângulo que estes três lados formam, com base nos seguintes casos, sempre escrevendo uma 
            //mensagem adequada:

            //se A ≥ B + C, apresente a mensagem: NAO FORMA TRIANGULO
            //se A^2 = B^2 + C^2, apresente a mensagem: TRIANGULO RETANGULO
            //se A^2 > B^2 + C^2, apresente a mensagem: TRIANGULO OBTUSANGULO
            //se A^2 < B^2 + C^2, apresente a mensagem: TRIANGULO ACUTANGULO
            //se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO
            //se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES

            //Entrada
            //A entrada contem três valores de ponto flutuante de dupla precisão A(0 < A) , B(0 < B) e C(0 < C).

            //Saída
            //Imprima todas as classificações do triângulo especificado na entrada.

            string[] s = Console.ReadLine().Split(' ');
            Array.Sort(s);
            Array.Reverse(s);

            double a = double.Parse(s[0]);
            double b = double.Parse(s[1]);
            double c = double.Parse(s[2]);

            //continue a solucao
            if (a >= ( b + c))
                Console.WriteLine("NAO FORMA TRIANGULO");
            else if (Math.Pow(a,2) == (Math.Pow(b,2) + Math.Pow(c,2)))
                Console.WriteLine("TRIANGULO RETANGULO");
            else if (Math.Pow(a, 2) > (Math.Pow(b, 2) + Math.Pow(c, 2)))
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            else if (Math.Pow(a, 2) < (Math.Pow(b, 2) + Math.Pow(c, 2)))
                Console.WriteLine("TRIANGULO ACUTANGULO");
            if ((a == b) && (b ==c))
                Console.WriteLine("TRIANGULO EQUILATERO");
            if (((a == b) || (b == c)) && (a != c))
                Console.WriteLine("TRIANGULO ISOSCELES");

            Console.ReadLine();
        }

        protected static void NotasEMoedas()
        {
            //Desafio
            //Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. A seguir, calcule 
            //o menor número de notas e moedas possíveis no qual o valor pode ser decomposto.As notas consideradas são de 100, 50, 
            //20, 10, 5, 2.As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01.A seguir mostre a relação de notas necessárias.

            //Entrada
            //O arquivo de entrada contém um valor de ponto flutuante N(0 ≤ N ≤ 1000000.00).

            //Saída
            //Imprima a quantidade mínima de notas e moedas necessárias para trocar o valor inicial, conforme exemplo fornecido.

            //Obs: Utilize ponto(.) para separar a parte decimal.

            double valor;
            int inteiro, auxNotas, auxMoedas;

            valor = Convert.ToDouble(Console.ReadLine());

            inteiro = (int)valor;
            valor *= 100;
            auxMoedas = (int)valor;

            Console.WriteLine("NOTAS:");
            Console.WriteLine("{0} nota(s) de R$ 100.00", inteiro / 100);
            auxNotas = (inteiro % 100);
            Console.WriteLine("{0} nota(s) de R$ 50.00", auxNotas / 50);
            auxNotas %= 50;
            Console.WriteLine("{0} nota(s) de R$ 20.00", auxNotas / 20);
            auxNotas %= 20;
            Console.WriteLine("{0} nota(s) de R$ 10.00", auxNotas / 10);
            auxNotas %= 10;
            Console.WriteLine("{0} nota(s) de R$ 5.00", auxNotas / 5);
            auxNotas %= 5;
            Console.WriteLine("{0} nota(s) de R$ 2.00", auxNotas / 2);
            auxNotas %= 2;

            Console.WriteLine("MOEDAS:");
            Console.WriteLine("{0} moeda(s) de R$ 1.00", auxNotas / 1);
            auxMoedas %= 100;
            Console.WriteLine("{0} moeda(s) de R$ 0.50", auxMoedas / 50);
            auxMoedas %= 50;
            Console.WriteLine("{0} moeda(s) de R$ 0.25", auxMoedas / 25);
            auxMoedas %= 25;
            Console.WriteLine("{0} moeda(s) de R$ 0.10", auxMoedas / 10);
            auxMoedas %= 10;
            Console.WriteLine("{0} moeda(s) de R$ 0.05", auxMoedas / 5);
            auxMoedas %= 5;
            Console.WriteLine("{0} moeda(s) de R$ 0.01", auxMoedas / 1);
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
            mediaP = ((a * 3.5) + (b * 7.5)) / (3.5 + 7.5);

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
