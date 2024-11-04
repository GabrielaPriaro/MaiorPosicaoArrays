//Utilizand Arrays:
//Problema "maior_posicao"
//Faça um programa que leia N números reais e armazene-os em um vetor. Em seguida, mostrar na tela
//o maior número do vetor (supor não haver empates). Mostrar também a posição do maior elemento,
//considerando a primeira posição como 0 (zero). 

using System.Globalization;

namespace MaiorPosiçaoArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, posicaoMaiorValor;
            double maiorValor;

            posicaoMaiorValor = 0;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quanto numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            maiorValor = vet[0];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            for (int i = 0; i < n; i++)
            {
                if (vet[i] > maiorValor)
                {
                    maiorValor = vet[i];
                    posicaoMaiorValor = i;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"MAIOR VALOR = {maiorValor.ToString("F1", CI)}");
            Console.WriteLine($"POSICAO DO MAIOR VALOR = {posicaoMaiorValor}");
        }
    }
}
